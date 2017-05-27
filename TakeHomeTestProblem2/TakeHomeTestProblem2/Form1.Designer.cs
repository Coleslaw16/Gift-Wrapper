namespace TakeHomeTestProblem2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.getFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lineBox = new System.Windows.Forms.TextBox();
            this.drawLine = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getFileToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // getFileToolStripMenuItem
            // 
            this.getFileToolStripMenuItem.Name = "getFileToolStripMenuItem";
            this.getFileToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.getFileToolStripMenuItem.Text = "Get File";
            this.getFileToolStripMenuItem.Click += new System.EventHandler(this.getFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(138, 2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(54, 20);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "1";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Scale Factor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "2";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Dot Size";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lineBox
            // 
            this.lineBox.Location = new System.Drawing.Point(465, 4);
            this.lineBox.Name = "lineBox";
            this.lineBox.Size = new System.Drawing.Size(48, 20);
            this.lineBox.TabIndex = 5;
            this.lineBox.Text = "2";
            this.lineBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drawLine
            // 
            this.drawLine.Location = new System.Drawing.Point(519, 1);
            this.drawLine.Name = "drawLine";
            this.drawLine.Size = new System.Drawing.Size(75, 23);
            this.drawLine.TabIndex = 6;
            this.drawLine.Text = "Line Size";
            this.drawLine.UseVisualStyleBackColor = true;
            this.drawLine.Click += new System.EventHandler(this.drawLine_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(690, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Concentric Puzzle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.White;
            this.picBox.Location = new System.Drawing.Point(0, 28);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(872, 556);
            this.picBox.TabIndex = 9;
            this.picBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 581);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.drawLine);
            this.Controls.Add(this.lineBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem getFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox lineBox;
        private System.Windows.Forms.Button drawLine;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox picBox;
    }
}

