namespace GorodKrovi_PuzzleSolver
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.GroupBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.cmbEndLocation = new System.Windows.Forms.ComboBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.cmbStartLocation = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.startLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(294, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(164, 13);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Gorod Krovi Airflow Puzzle Solver";
            // 
            // startLabel
            // 
            this.startLabel.Controls.Add(this.lblEnd);
            this.startLabel.Controls.Add(this.cmbEndLocation);
            this.startLabel.Controls.Add(this.lblStart);
            this.startLabel.Controls.Add(this.cmbStartLocation);
            this.startLabel.Location = new System.Drawing.Point(183, 38);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(366, 154);
            this.startLabel.TabIndex = 1;
            this.startLabel.TabStop = false;
            this.startLabel.Text = "groupBox1";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblEnd.Location = new System.Drawing.Point(17, 130);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(29, 13);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "End";
            // 
            // cmbEndLocation
            // 
            this.cmbEndLocation.FormattingEnabled = true;
            this.cmbEndLocation.Location = new System.Drawing.Point(52, 127);
            this.cmbEndLocation.Name = "cmbEndLocation";
            this.cmbEndLocation.Size = new System.Drawing.Size(121, 21);
            this.cmbEndLocation.TabIndex = 2;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.Green;
            this.lblStart.Location = new System.Drawing.Point(17, 46);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(34, 13);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start";
            // 
            // cmbStartLocation
            // 
            this.cmbStartLocation.FormattingEnabled = true;
            this.cmbStartLocation.Location = new System.Drawing.Point(52, 43);
            this.cmbStartLocation.Name = "cmbStartLocation";
            this.cmbStartLocation.Size = new System.Drawing.Size(121, 21);
            this.cmbStartLocation.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(311, 198);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(119, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate Path";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(311, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(13, 256);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(759, 293);
            this.txtOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.startLabel.ResumeLayout(false);
            this.startLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.GroupBox startLabel;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.ComboBox cmbEndLocation;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.ComboBox cmbStartLocation;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

