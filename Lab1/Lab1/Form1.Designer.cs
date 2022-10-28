namespace Lab1
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.a_label = new System.Windows.Forms.Label();
            this.a_textBox = new System.Windows.Forms.TextBox();
            this.m_textBox = new System.Windows.Forms.TextBox();
            this.R0_textBox = new System.Windows.Forms.TextBox();
            this.m_label = new System.Windows.Forms.Label();
            this.R0_label = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.Mx_label = new System.Windows.Forms.Label();
            this.Mx_value = new System.Windows.Forms.Label();
            this.Dx_label = new System.Windows.Forms.Label();
            this.Dx_value = new System.Windows.Forms.Label();
            this.Sx_label = new System.Windows.Forms.Label();
            this.Sx_value = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pi_4_value = new System.Windows.Forms.Label();
            this.BarChart_zedGraph = new ZedGraph.ZedGraphControl();
            this.Uniformity_value = new System.Windows.Forms.TextBox();
            this.Period = new System.Windows.Forms.TextBox();
            this.AperiodInterval = new System.Windows.Forms.TextBox();
            this.AperiodInterval_value = new System.Windows.Forms.TextBox();
            this.Period_value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // a_label
            // 
            this.a_label.AutoSize = true;
            this.a_label.Location = new System.Drawing.Point(10, 10);
            this.a_label.Name = "a_label";
            this.a_label.Size = new System.Drawing.Size(16, 13);
            this.a_label.TabIndex = 0;
            this.a_label.Text = "a:";
            // 
            // a_textBox
            // 
            this.a_textBox.Location = new System.Drawing.Point(30, 7);
            this.a_textBox.Name = "a_textBox";
            this.a_textBox.Size = new System.Drawing.Size(80, 20);
            this.a_textBox.TabIndex = 2;
            this.a_textBox.Text = "1473";
            // 
            // m_textBox
            // 
            this.m_textBox.Location = new System.Drawing.Point(30, 37);
            this.m_textBox.Name = "m_textBox";
            this.m_textBox.Size = new System.Drawing.Size(80, 20);
            this.m_textBox.TabIndex = 3;
            this.m_textBox.Text = "2094991";
            // 
            // R0_textBox
            // 
            this.R0_textBox.Location = new System.Drawing.Point(30, 67);
            this.R0_textBox.Name = "R0_textBox";
            this.R0_textBox.Size = new System.Drawing.Size(80, 20);
            this.R0_textBox.TabIndex = 4;
            this.R0_textBox.Text = "18";
            // 
            // m_label
            // 
            this.m_label.AutoSize = true;
            this.m_label.Location = new System.Drawing.Point(8, 40);
            this.m_label.Name = "m_label";
            this.m_label.Size = new System.Drawing.Size(18, 13);
            this.m_label.TabIndex = 0;
            this.m_label.Text = "m:";
            // 
            // R0_label
            // 
            this.R0_label.AutoSize = true;
            this.R0_label.Location = new System.Drawing.Point(2, 70);
            this.R0_label.Name = "R0_label";
            this.R0_label.Size = new System.Drawing.Size(24, 13);
            this.R0_label.TabIndex = 0;
            this.R0_label.Text = "R0:";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(417, 5);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 1;
            this.calcButton.TabStop = false;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mx_label
            // 
            this.Mx_label.AutoSize = true;
            this.Mx_label.Location = new System.Drawing.Point(130, 10);
            this.Mx_label.Name = "Mx_label";
            this.Mx_label.Size = new System.Drawing.Size(24, 13);
            this.Mx_label.TabIndex = 0;
            this.Mx_label.Text = "Mx:";
            // 
            // Mx_value
            // 
            this.Mx_value.AutoSize = true;
            this.Mx_value.Location = new System.Drawing.Point(155, 10);
            this.Mx_value.MaximumSize = new System.Drawing.Size(70, 13);
            this.Mx_value.Name = "Mx_value";
            this.Mx_value.Size = new System.Drawing.Size(0, 13);
            this.Mx_value.TabIndex = 0;
            // 
            // Dx_label
            // 
            this.Dx_label.AutoSize = true;
            this.Dx_label.Location = new System.Drawing.Point(131, 40);
            this.Dx_label.Name = "Dx_label";
            this.Dx_label.Size = new System.Drawing.Size(23, 13);
            this.Dx_label.TabIndex = 0;
            this.Dx_label.Text = "Dx:";
            // 
            // Dx_value
            // 
            this.Dx_value.AutoSize = true;
            this.Dx_value.Location = new System.Drawing.Point(155, 40);
            this.Dx_value.MaximumSize = new System.Drawing.Size(80, 13);
            this.Dx_value.Name = "Dx_value";
            this.Dx_value.Size = new System.Drawing.Size(0, 13);
            this.Dx_value.TabIndex = 0;
            // 
            // Sx_label
            // 
            this.Sx_label.AutoSize = true;
            this.Sx_label.Location = new System.Drawing.Point(132, 70);
            this.Sx_label.Name = "Sx_label";
            this.Sx_label.Size = new System.Drawing.Size(22, 13);
            this.Sx_label.TabIndex = 0;
            this.Sx_label.Text = "Sx:";
            // 
            // Sx_value
            // 
            this.Sx_value.AutoSize = true;
            this.Sx_value.Location = new System.Drawing.Point(155, 70);
            this.Sx_value.MaximumSize = new System.Drawing.Size(80, 13);
            this.Sx_value.Name = "Sx_value";
            this.Sx_value.Size = new System.Drawing.Size(0, 13);
            this.Sx_value.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "--->";
            // 
            // Pi_4_value
            // 
            this.Pi_4_value.AutoSize = true;
            this.Pi_4_value.Location = new System.Drawing.Point(133, 100);
            this.Pi_4_value.Name = "Pi_4_value";
            this.Pi_4_value.Size = new System.Drawing.Size(0, 13);
            this.Pi_4_value.TabIndex = 5;
            // 
            // BarChart_zedGraph
            // 
            this.BarChart_zedGraph.IsShowPointValues = false;
            this.BarChart_zedGraph.Location = new System.Drawing.Point(10, 130);
            this.BarChart_zedGraph.Name = "BarChart_zedGraph";
            this.BarChart_zedGraph.PointValueFormat = "G";
            this.BarChart_zedGraph.TabIndex = 6;
            // 
            // Uniformity_value
            // 
            this.Uniformity_value.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Uniformity_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Uniformity_value.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Uniformity_value.Location = new System.Drawing.Point(29, 100);
            this.Uniformity_value.Name = "Uniformity_value";
            this.Uniformity_value.Size = new System.Drawing.Size(81, 13);
            this.Uniformity_value.TabIndex = 0;
            this.Uniformity_value.TabStop = false;
            this.Uniformity_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AperiodInterval
            // 
            this.AperiodInterval.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AperiodInterval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AperiodInterval.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AperiodInterval.Location = new System.Drawing.Point(260, 100);
            this.AperiodInterval.Name = "AperiodInterval";
            this.AperiodInterval.Size = new System.Drawing.Size(90, 13);
            this.AperiodInterval.TabIndex = 7;
            this.AperiodInterval.TabStop = false;
            this.AperiodInterval.Text = "Aperiodic Interval:";
            this.AperiodInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Period
            // 
            this.Period.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Period.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Period.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Period.Location = new System.Drawing.Point(260, 70);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(90, 13);
            this.Period.TabIndex = 7;
            this.Period.TabStop = false;
            this.Period.Text = "Period:";
            this.Period.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AperiodInterval_value
            // 
            this.AperiodInterval_value.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AperiodInterval_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AperiodInterval_value.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AperiodInterval_value.Location = new System.Drawing.Point(355, 100);
            this.AperiodInterval_value.Name = "AperiodInterval_value";
            this.AperiodInterval_value.Size = new System.Drawing.Size(93, 13);
            this.AperiodInterval_value.TabIndex = 7;
            this.AperiodInterval_value.TabStop = false;
            // 
            // Period_value
            // 
            this.Period_value.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Period_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Period_value.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Period_value.Location = new System.Drawing.Point(355, 70);
            this.Period_value.Name = "Period_value";
            this.Period_value.Size = new System.Drawing.Size(93, 13);
            this.Period_value.TabIndex = 7;
            this.Period_value.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.AperiodInterval_value);
            this.Controls.Add(this.Period_value);
            this.Controls.Add(this.Period);
            this.Controls.Add(this.AperiodInterval);
            this.Controls.Add(this.Uniformity_value);
            this.Controls.Add(this.BarChart_zedGraph);
            this.Controls.Add(this.Pi_4_value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.R0_textBox);
            this.Controls.Add(this.m_textBox);
            this.Controls.Add(this.a_textBox);
            this.Controls.Add(this.R0_label);
            this.Controls.Add(this.m_label);
            this.Controls.Add(this.Dx_value);
            this.Controls.Add(this.Sx_value);
            this.Controls.Add(this.Sx_label);
            this.Controls.Add(this.Dx_label);
            this.Controls.Add(this.Mx_label);
            this.Controls.Add(this.Mx_value);
            this.Controls.Add(this.a_label);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       
        private System.Windows.Forms.Label a_label;
        private System.Windows.Forms.TextBox a_textBox;
        private System.Windows.Forms.TextBox m_textBox;
        private System.Windows.Forms.TextBox R0_textBox;
        private System.Windows.Forms.Label m_label;
        private System.Windows.Forms.Label R0_label;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label Mx_label;
        private System.Windows.Forms.Label Mx_value;
        private System.Windows.Forms.Label Dx_label;
        private System.Windows.Forms.Label Dx_value;
        private System.Windows.Forms.Label Sx_label;
        private System.Windows.Forms.Label Sx_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Pi_4_value;
        private ZedGraph.ZedGraphControl BarChart_zedGraph;
        private System.Windows.Forms.TextBox Uniformity_value;
        private System.Windows.Forms.TextBox Period;
        private System.Windows.Forms.TextBox AperiodInterval;
        private System.Windows.Forms.TextBox AperiodInterval_value;
        private System.Windows.Forms.TextBox Period_value;

    }
}

