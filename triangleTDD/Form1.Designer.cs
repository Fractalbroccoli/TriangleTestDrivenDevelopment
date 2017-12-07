namespace triangleTDD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Angle1Entry = new System.Windows.Forms.TextBox();
            this.Angle2Entry = new System.Windows.Forms.TextBox();
            this.Angle3Entry = new System.Windows.Forms.TextBox();
            this.SideAEntry = new System.Windows.Forms.TextBox();
            this.SideBEntry = new System.Windows.Forms.TextBox();
            this.SideCEntry = new System.Windows.Forms.TextBox();
            this.TriangleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angle 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Angle 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Side A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Side B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Side C";
            // 
            // Angle1Entry
            // 
            this.Angle1Entry.Location = new System.Drawing.Point(256, 211);
            this.Angle1Entry.Name = "Angle1Entry";
            this.Angle1Entry.Size = new System.Drawing.Size(100, 20);
            this.Angle1Entry.TabIndex = 6;
            // 
            // Angle2Entry
            // 
            this.Angle2Entry.Location = new System.Drawing.Point(257, 260);
            this.Angle2Entry.Name = "Angle2Entry";
            this.Angle2Entry.Size = new System.Drawing.Size(100, 20);
            this.Angle2Entry.TabIndex = 7;
            // 
            // Angle3Entry
            // 
            this.Angle3Entry.Location = new System.Drawing.Point(256, 308);
            this.Angle3Entry.Name = "Angle3Entry";
            this.Angle3Entry.Size = new System.Drawing.Size(100, 20);
            this.Angle3Entry.TabIndex = 8;
            // 
            // SideAEntry
            // 
            this.SideAEntry.Location = new System.Drawing.Point(532, 211);
            this.SideAEntry.Name = "SideAEntry";
            this.SideAEntry.Size = new System.Drawing.Size(100, 20);
            this.SideAEntry.TabIndex = 9;
            // 
            // SideBEntry
            // 
            this.SideBEntry.Location = new System.Drawing.Point(532, 260);
            this.SideBEntry.Name = "SideBEntry";
            this.SideBEntry.Size = new System.Drawing.Size(100, 20);
            this.SideBEntry.TabIndex = 10;
            // 
            // SideCEntry
            // 
            this.SideCEntry.Location = new System.Drawing.Point(532, 308);
            this.SideCEntry.Name = "SideCEntry";
            this.SideCEntry.Size = new System.Drawing.Size(100, 20);
            this.SideCEntry.TabIndex = 11;
            // 
            // TriangleButton
            // 
            this.TriangleButton.Location = new System.Drawing.Point(256, 386);
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(132, 33);
            this.TriangleButton.TabIndex = 12;
            this.TriangleButton.Text = "Calculate";
            this.TriangleButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 592);
            this.Controls.Add(this.TriangleButton);
            this.Controls.Add(this.SideCEntry);
            this.Controls.Add(this.SideBEntry);
            this.Controls.Add(this.SideAEntry);
            this.Controls.Add(this.Angle3Entry);
            this.Controls.Add(this.Angle2Entry);
            this.Controls.Add(this.Angle1Entry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Angle1Entry;
        private System.Windows.Forms.TextBox Angle2Entry;
        private System.Windows.Forms.TextBox Angle3Entry;
        private System.Windows.Forms.TextBox SideAEntry;
        private System.Windows.Forms.TextBox SideBEntry;
        private System.Windows.Forms.TextBox SideCEntry;
        private System.Windows.Forms.Button TriangleButton;
    }
}

