namespace Lab2
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.a_label = new System.Windows.Forms.Label();
            this.b_label = new System.Windows.Forms.Label();
            this.a_value = new System.Windows.Forms.TextBox();
            this.b_value = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dx_value = new System.Windows.Forms.Label();
            this.Sx_value = new System.Windows.Forms.Label();
            this.Mx_value = new System.Windows.Forms.Label();
            this.BarChart_zedGraph = new ZedGraph.ZedGraphControl();
            this.right_button = new System.Windows.Forms.RadioButton();
            this.left_button = new System.Windows.Forms.RadioButton();
            this.AValue = new System.Windows.Forms.TextBox();
            this.MValue = new System.Windows.Forms.TextBox();
            this.R0Value = new System.Windows.Forms.TextBox();
            this.ALabel = new System.Windows.Forms.Label();
            this.MLabel = new System.Windows.Forms.Label();
            this.R0Label = new System.Windows.Forms.Label();
            this.mxTextbox = new System.Windows.Forms.TextBox();
            this.sxTextBox = new System.Windows.Forms.TextBox();
            this.lyTextBox = new System.Windows.Forms.TextBox();
            this.nuTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.functionListBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // a_label
            // 
            this.a_label.AutoSize = true;
            this.a_label.Location = new System.Drawing.Point(929, 15);
            this.a_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.a_label.Name = "a_label";
            this.a_label.Size = new System.Drawing.Size(18, 16);
            this.a_label.TabIndex = 0;
            this.a_label.Text = "a:";
            // 
            // b_label
            // 
            this.b_label.AutoSize = true;
            this.b_label.Location = new System.Drawing.Point(929, 52);
            this.b_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.b_label.Name = "b_label";
            this.b_label.Size = new System.Drawing.Size(18, 16);
            this.b_label.TabIndex = 0;
            this.b_label.Text = "b:";
            // 
            // a_value
            // 
            this.a_value.Location = new System.Drawing.Point(973, 12);
            this.a_value.Margin = new System.Windows.Forms.Padding(4);
            this.a_value.Name = "a_value";
            this.a_value.Size = new System.Drawing.Size(105, 22);
            this.a_value.TabIndex = 1;
            this.a_value.Text = "0";
            // 
            // b_value
            // 
            this.b_value.Location = new System.Drawing.Point(973, 49);
            this.b_value.Margin = new System.Windows.Forms.Padding(4);
            this.b_value.Name = "b_value";
            this.b_value.Size = new System.Drawing.Size(105, 22);
            this.b_value.TabIndex = 2;
            this.b_value.Text = "1";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(1301, 6);
            this.calcButton.Margin = new System.Windows.Forms.Padding(4);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(148, 99);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mx:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dx:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sx:";
            // 
            // Dx_value
            // 
            this.Dx_value.AutoSize = true;
            this.Dx_value.Location = new System.Drawing.Point(213, 49);
            this.Dx_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dx_value.Name = "Dx_value";
            this.Dx_value.Size = new System.Drawing.Size(0, 16);
            this.Dx_value.TabIndex = 4;
            // 
            // Sx_value
            // 
            this.Sx_value.AutoSize = true;
            this.Sx_value.Location = new System.Drawing.Point(213, 86);
            this.Sx_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sx_value.Name = "Sx_value";
            this.Sx_value.Size = new System.Drawing.Size(0, 16);
            this.Sx_value.TabIndex = 4;
            // 
            // Mx_value
            // 
            this.Mx_value.AutoSize = true;
            this.Mx_value.Location = new System.Drawing.Point(213, 12);
            this.Mx_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mx_value.Name = "Mx_value";
            this.Mx_value.Size = new System.Drawing.Size(0, 16);
            this.Mx_value.TabIndex = 4;
            // 
            // BarChart_zedGraph
            // 
            this.BarChart_zedGraph.IsShowPointValues = false;
            this.BarChart_zedGraph.Location = new System.Drawing.Point(13, 117);
            this.BarChart_zedGraph.Margin = new System.Windows.Forms.Padding(4);
            this.BarChart_zedGraph.Name = "BarChart_zedGraph";
            this.BarChart_zedGraph.PointValueFormat = "G";
            this.BarChart_zedGraph.Size = new System.Drawing.Size(1436, 437);
            this.BarChart_zedGraph.TabIndex = 5;
            // 
            // right_button
            // 
            this.right_button.AutoSize = true;
            this.right_button.Checked = true;
            this.right_button.Location = new System.Drawing.Point(373, 45);
            this.right_button.Margin = new System.Windows.Forms.Padding(4);
            this.right_button.Name = "right_button";
            this.right_button.Size = new System.Drawing.Size(207, 20);
            this.right_button.TabIndex = 6;
            this.right_button.TabStop = true;
            this.right_button.Text = "f = 2 * (x - a) / (b - a)^2 , x = [a,b]";
            this.right_button.UseVisualStyleBackColor = true;
            this.right_button.CheckedChanged += new System.EventHandler(this.right_button_CheckedChanged);
            // 
            // left_button
            // 
            this.left_button.AutoSize = true;
            this.left_button.Location = new System.Drawing.Point(373, 82);
            this.left_button.Margin = new System.Windows.Forms.Padding(4);
            this.left_button.Name = "left_button";
            this.left_button.Size = new System.Drawing.Size(207, 20);
            this.left_button.TabIndex = 6;
            this.left_button.Text = "f = 2 * (b - x) / (b - a)^2 , x = [a,b]";
            this.left_button.UseVisualStyleBackColor = true;
            this.left_button.CheckedChanged += new System.EventHandler(this.left_button_CheckedChanged);
            // 
            // AValue
            // 
            this.AValue.Location = new System.Drawing.Point(44, 9);
            this.AValue.Margin = new System.Windows.Forms.Padding(4);
            this.AValue.Name = "AValue";
            this.AValue.Size = new System.Drawing.Size(105, 22);
            this.AValue.TabIndex = 7;
            this.AValue.Text = "1473";
            // 
            // MValue
            // 
            this.MValue.Location = new System.Drawing.Point(44, 46);
            this.MValue.Margin = new System.Windows.Forms.Padding(4);
            this.MValue.Name = "MValue";
            this.MValue.Size = new System.Drawing.Size(105, 22);
            this.MValue.TabIndex = 7;
            this.MValue.Text = "2094991";
            // 
            // R0Value
            // 
            this.R0Value.Location = new System.Drawing.Point(45, 82);
            this.R0Value.Margin = new System.Windows.Forms.Padding(4);
            this.R0Value.Name = "R0Value";
            this.R0Value.Size = new System.Drawing.Size(105, 22);
            this.R0Value.TabIndex = 7;
            this.R0Value.Text = "17";
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(17, 12);
            this.ALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(19, 16);
            this.ALabel.TabIndex = 8;
            this.ALabel.Text = "A:";
            // 
            // MLabel
            // 
            this.MLabel.AutoSize = true;
            this.MLabel.Location = new System.Drawing.Point(17, 49);
            this.MLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MLabel.Name = "MLabel";
            this.MLabel.Size = new System.Drawing.Size(21, 16);
            this.MLabel.TabIndex = 8;
            this.MLabel.Text = "M:";
            // 
            // R0Label
            // 
            this.R0Label.AutoSize = true;
            this.R0Label.Location = new System.Drawing.Point(17, 86);
            this.R0Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.R0Label.Name = "R0Label";
            this.R0Label.Size = new System.Drawing.Size(27, 16);
            this.R0Label.TabIndex = 8;
            this.R0Label.Text = "R0:";
            // 
            // mxTextbox
            // 
            this.mxTextbox.Location = new System.Drawing.Point(973, 86);
            this.mxTextbox.MaxLength = 10;
            this.mxTextbox.Name = "mxTextbox";
            this.mxTextbox.Size = new System.Drawing.Size(105, 22);
            this.mxTextbox.TabIndex = 9;
            this.mxTextbox.Text = "0,5";
            // 
            // sxTextBox
            // 
            this.sxTextBox.Location = new System.Drawing.Point(1179, 9);
            this.sxTextBox.Name = "sxTextBox";
            this.sxTextBox.Size = new System.Drawing.Size(105, 22);
            this.sxTextBox.TabIndex = 10;
            this.sxTextBox.Text = "0,15";
            // 
            // lyTextBox
            // 
            this.lyTextBox.Location = new System.Drawing.Point(1179, 47);
            this.lyTextBox.Name = "lyTextBox";
            this.lyTextBox.Size = new System.Drawing.Size(105, 22);
            this.lyTextBox.TabIndex = 11;
            this.lyTextBox.Text = "100";
            // 
            // nuTextBox
            // 
            this.nuTextBox.Location = new System.Drawing.Point(1179, 86);
            this.nuTextBox.Name = "nuTextBox";
            this.nuTextBox.Size = new System.Drawing.Size(105, 22);
            this.nuTextBox.TabIndex = 12;
            this.nuTextBox.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(920, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mx:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1110, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sigma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1105, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lambda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1110, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nu:";
            // 
            // functionListBox
            // 
            this.functionListBox.FormattingEnabled = true;
            this.functionListBox.ItemHeight = 16;
            this.functionListBox.Items.AddRange(new object[] {
            "Uniform distribution (a, b)",
            "Gaussian distribution (Mx, Sigma)",
            "Exponential distrbution (Lambda)",
            "Gamma distribution (Nu, Lambda)",
            "Triangle distribution (a, b)",
            "Simpson distribution (a, b)"});
            this.functionListBox.Location = new System.Drawing.Point(615, 9);
            this.functionListBox.Name = "functionListBox";
            this.functionListBox.Size = new System.Drawing.Size(277, 100);
            this.functionListBox.TabIndex = 17;
            this.functionListBox.SelectedIndexChanged += new System.EventHandler(this.functionListBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Triangle distribution function:";
            // 
            // Form1
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 569);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.functionListBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nuTextBox);
            this.Controls.Add(this.lyTextBox);
            this.Controls.Add(this.sxTextBox);
            this.Controls.Add(this.mxTextbox);
            this.Controls.Add(this.R0Label);
            this.Controls.Add(this.MLabel);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.R0Value);
            this.Controls.Add(this.MValue);
            this.Controls.Add(this.AValue);
            this.Controls.Add(this.left_button);
            this.Controls.Add(this.right_button);
            this.Controls.Add(this.BarChart_zedGraph);
            this.Controls.Add(this.Sx_value);
            this.Controls.Add(this.Dx_value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mx_value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.b_value);
            this.Controls.Add(this.a_value);
            this.Controls.Add(this.b_label);
            this.Controls.Add(this.a_label);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(927, 605);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label a_label;
        private System.Windows.Forms.Label b_label;
        private System.Windows.Forms.TextBox a_value;
        private System.Windows.Forms.TextBox b_value;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Dx_value;
        private System.Windows.Forms.Label Sx_value;
        private System.Windows.Forms.Label Mx_value;
        private ZedGraph.ZedGraphControl BarChart_zedGraph;
        private System.Windows.Forms.RadioButton right_button;
        private System.Windows.Forms.RadioButton left_button;
        private System.Windows.Forms.TextBox AValue;
        private System.Windows.Forms.TextBox MValue;
        private System.Windows.Forms.TextBox R0Value;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Label MLabel;
        private System.Windows.Forms.Label R0Label;
        private System.Windows.Forms.TextBox mxTextbox;
        private System.Windows.Forms.TextBox sxTextBox;
        private System.Windows.Forms.TextBox lyTextBox;
        private System.Windows.Forms.TextBox nuTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox functionListBox;
        private System.Windows.Forms.Label label8;
    }
}

