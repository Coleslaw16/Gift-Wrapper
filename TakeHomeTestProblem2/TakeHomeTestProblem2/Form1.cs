using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Collections;

namespace TakeHomeTestProblem2
{
    public partial class Form1 : Form
    {
        string filename = "";
        private points[] pointLocation;
        private ArrayList tempForConvex;
        private Bitmap aBitMap;
        private float scale;
        private float dotSize;
        private float lineSize;
        private Color Color = Color.Black;
        private bool drawingLines = false;
        private string output ="";
        public Form1()
        {
            InitializeComponent();
            ResizeRedraw = true;
            scale = float.Parse(textBox.Text);
            dotSize = float.Parse(textBox1.Text);
            lineSize = float.Parse(lineBox.Text);
        }

        private void getFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filename = dlg.FileName;
                readFile();
            }
        }
        private void readFile()
        {
            try
            {
                StreamReader st = new StreamReader(filename);
                int arraySize = int.Parse(st.ReadLine());
                Console.WriteLine(arraySize);
                pointLocation = new points[arraySize];
                for (int i = 0; i < arraySize; i++)
                {
                    string[] temp = st.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                    int x = int.Parse(temp[0]);
                    int y = int.Parse(temp[1]);
                    pointLocation[i] = (new points(x, y, dotSize, Color));
                }
                st.Close();
                tempForConvex = new ArrayList();
                foreach(points x in pointLocation)
                {
                    tempForConvex.Add(x);
                }
                drawPoints();
            }
            catch (Exception e)
            {
                MessageBox.Show("You messed up somewhere");
            }
        }

        private void resetFrameBuffer()
        {
            Graphics g = CreateGraphics();
            if (aBitMap != null)
                aBitMap.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            aBitMap = new Bitmap(picBox.Width, picBox.Height, g);
        }
        private void drawPoints()
        {
            resetFrameBuffer();
            Graphics g = Graphics.FromImage(aBitMap);
            System.Drawing.SolidBrush aBrsh = new System.Drawing.SolidBrush(Color.Black);
            if (drawingLines == true)
            {
                Pen drawingPen = new Pen(Brushes.Crimson, lineSize);
                for (int i = 0; i < pointLocation.Length - 1; i++)
                {
                    g.DrawLine(drawingPen, pointLocation[i].X * scale, pointLocation[i].Y * scale, pointLocation[i + 1].X * scale, pointLocation[i + 1].Y * scale);
                }
                drawingPen.Dispose();
            }
            for (int i = 0; i < pointLocation.GetLength(0); i++)
            {
                g.FillEllipse(aBrsh, (float)(pointLocation[i].X * scale) - dotSize / 2.0F, (float)(pointLocation[i].Y * scale) - dotSize / 2.0F, dotSize, dotSize);
            }
            picBox.Image = aBitMap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scale = float.Parse(textBox.Text);
            drawPoints();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dotSize = float.Parse(textBox1.Text);
            drawPoints();
        }

        private void drawLine_Click(object sender, EventArgs e)
        {
            lineSize = float.Parse(lineBox.Text);
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFile.FilterIndex = 1;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter w = new StreamWriter(saveFile.OpenFile());
                w.Write(output);
                w.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
 //           resetFrameBuffer();
            if(pointLocation.Length<3)
            {
                throw new ArgumentException("You need at least 3 points");
            }
            while (tempForConvex.Count >= 3)
            {
                points min = (points)tempForConvex[0];
                foreach (points x in tempForConvex)
                {
                    if (x.X < min.X)
                    {
                        min = x;
                    }
                }

                List<points> hull = new List<points>();
                points vEndpoint;
                points vpointOnHull = min;
                do
                {
                    hull.Add(vpointOnHull);
                    vEndpoint = (points)tempForConvex[0];

                    for (int j = 1; j < tempForConvex.Count; j++)
                    {
                        if (vpointOnHull == vEndpoint || Orientation(vpointOnHull, vEndpoint, (points)tempForConvex[j]) == -1)
                        {
                            vEndpoint = (points)tempForConvex[j];
                        }
                    }
                    vpointOnHull = vEndpoint;
                } while (vEndpoint != hull[0]);

                Pen drawingPen = new Pen(Brushes.Crimson, lineSize);
                points[] tempCH = new points[hull.Count];
                int count = 0;
                foreach (points x in hull)
                {
                    tempCH[count] = x;
                    count++;
                    output += x.X + " " + x.Y + "\r\n";
                }
                foreach(points x in hull)
                {
                    tempForConvex.Remove(x);
                }
                Graphics g = Graphics.FromImage(aBitMap);
                System.Drawing.SolidBrush aBrsh = new System.Drawing.SolidBrush(Color.Black);
                for (int i = 0; i < tempCH.Length - 1; i++)
                {
                    g.DrawLine(drawingPen, tempCH[i].X * scale, tempCH[i].Y * scale, tempCH[i + 1].X * scale, tempCH[i + 1].Y * scale);
                }
                g.DrawLine(drawingPen, tempCH[tempCH.Length - 1].X * scale, tempCH[tempCH.Length - 1].Y * scale, tempCH[0].X * scale, tempCH[0].Y * scale);
                drawingPen.Dispose();
                for (int i = 0; i < pointLocation.GetLength(0); i++)
                {
                    g.FillEllipse(aBrsh, (float)(pointLocation[i].X * scale) - dotSize / 2.0F, (float)(pointLocation[i].Y * scale) - dotSize / 2.0F, dotSize, dotSize);
                }
                output += "\r\n";
            }
            picBox.Image = aBitMap;
        }

        private int Orientation(points p1, points p2, points p)
        {
            int orin = (int)((p2.X - p1.X) * (p.Y - p1.Y) - (p.X - p1.X) * (p2.Y - p1.Y));

            if (orin > 0)
                return -1;
            if (orin < 0)
                return 1;

            return 0;
        }
    }
}
