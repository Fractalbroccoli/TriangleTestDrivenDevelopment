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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SideAEntry = new System.Windows.Forms.TextBox();
            this.SideBEntry = new System.Windows.Forms.TextBox();
            this.SideCEntry = new System.Windows.Forms.TextBox();
            this.TriangleButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Angle2Entry = new System.Windows.Forms.TextBox();
            this.Angle3Entry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Angle1Entry = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Side A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Side B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Side C";
            // 
            // SideAEntry
            // 
            this.SideAEntry.Location = new System.Drawing.Point(100, 70);
            this.SideAEntry.Margin = new System.Windows.Forms.Padding(4);
            this.SideAEntry.Name = "SideAEntry";
            this.SideAEntry.Size = new System.Drawing.Size(132, 22);
            this.SideAEntry.TabIndex = 9;
            // 
            // SideBEntry
            // 
            this.SideBEntry.Location = new System.Drawing.Point(100, 130);
            this.SideBEntry.Margin = new System.Windows.Forms.Padding(4);
            this.SideBEntry.Name = "SideBEntry";
            this.SideBEntry.Size = new System.Drawing.Size(132, 22);
            this.SideBEntry.TabIndex = 10;
            // 
            // SideCEntry
            // 
            this.SideCEntry.Location = new System.Drawing.Point(100, 186);
            this.SideCEntry.Margin = new System.Windows.Forms.Padding(4);
            this.SideCEntry.Name = "SideCEntry";
            this.SideCEntry.Size = new System.Drawing.Size(132, 22);
            this.SideCEntry.TabIndex = 11;
            // 
            // TriangleButton
            // 
            this.TriangleButton.Location = new System.Drawing.Point(163, 460);
            this.TriangleButton.Margin = new System.Windows.Forms.Padding(4);
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(176, 57);
            this.TriangleButton.TabIndex = 12;
            this.TriangleButton.Text = "Calculate Triangle Attributes";
            this.TriangleButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Angle Measurement Entry (degrees)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(639, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Side Length Entry";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SideAEntry);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SideBEntry);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SideCEntry);
            this.groupBox1.Location = new System.Drawing.Point(562, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 293);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Angle1Entry);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Angle2Entry);
            this.groupBox2.Controls.Add(this.Angle3Entry);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(163, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 293);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // Angle2Entry
            // 
            this.Angle2Entry.Location = new System.Drawing.Point(100, 153);
            this.Angle2Entry.Margin = new System.Windows.Forms.Padding(4);
            this.Angle2Entry.Name = "Angle2Entry";
            this.Angle2Entry.Size = new System.Drawing.Size(132, 22);
            this.Angle2Entry.TabIndex = 7;
            // 
            // Angle3Entry
            // 
            this.Angle3Entry.Location = new System.Drawing.Point(98, 212);
            this.Angle3Entry.Margin = new System.Windows.Forms.Padding(4);
            this.Angle3Entry.Name = "Angle3Entry";
            this.Angle3Entry.Size = new System.Drawing.Size(132, 22);
            this.Angle3Entry.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Angle 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle 2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(36, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(209, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Is this a right-angle triangle?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angle 1";
            // 
            // Angle1Entry
            // 
            this.Angle1Entry.Location = new System.Drawing.Point(98, 93);
            this.Angle1Entry.Margin = new System.Windows.Forms.Padding(4);
            this.Angle1Entry.Name = "Angle1Entry";
            this.Angle1Entry.Size = new System.Drawing.Size(132, 22);
            this.Angle1Entry.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 729);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TriangleButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SideAEntry;
        private System.Windows.Forms.TextBox SideBEntry;
        private System.Windows.Forms.TextBox SideCEntry;
        private System.Windows.Forms.Button TriangleButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Angle1Entry;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Angle2Entry;
        private System.Windows.Forms.TextBox Angle3Entry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

