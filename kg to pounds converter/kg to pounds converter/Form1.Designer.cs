namespace kg_to_pounds_converter
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
            this.radKilogram1 = new System.Windows.Forms.RadioButton();
            this.txtConvert = new System.Windows.Forms.TextBox();
            this.radPounds2 = new System.Windows.Forms.RadioButton();
            this.txtConverted = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radKilogram1
            // 
            this.radKilogram1.AutoSize = true;
            this.radKilogram1.Location = new System.Drawing.Point(91, 85);
            this.radKilogram1.Name = "radKilogram1";
            this.radKilogram1.Size = new System.Drawing.Size(84, 21);
            this.radKilogram1.TabIndex = 0;
            this.radKilogram1.TabStop = true;
            this.radKilogram1.Text = "Kilogram";
            this.radKilogram1.UseVisualStyleBackColor = true;
            // 
            // txtConvert
            // 
            this.txtConvert.Location = new System.Drawing.Point(91, 124);
            this.txtConvert.Name = "txtConvert";
            this.txtConvert.Size = new System.Drawing.Size(204, 22);
            this.txtConvert.TabIndex = 2;
            // 
            // radPounds2
            // 
            this.radPounds2.AutoSize = true;
            this.radPounds2.Location = new System.Drawing.Point(216, 85);
            this.radPounds2.Name = "radPounds2";
            this.radPounds2.Size = new System.Drawing.Size(77, 21);
            this.radPounds2.TabIndex = 4;
            this.radPounds2.TabStop = true;
            this.radPounds2.Text = "Pounds";
            this.radPounds2.UseVisualStyleBackColor = true;
            // 
            // txtConverted
            // 
            this.txtConverted.Location = new System.Drawing.Point(89, 239);
            this.txtConverted.Name = "txtConverted";
            this.txtConverted.Size = new System.Drawing.Size(204, 22);
            this.txtConverted.TabIndex = 5;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(123, 210);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(130, 23);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(89, 308);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(216, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 354);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtConverted);
            this.Controls.Add(this.radPounds2);
            this.Controls.Add(this.txtConvert);
            this.Controls.Add(this.radKilogram1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radKilogram1;
        private System.Windows.Forms.TextBox txtConvert;
        private System.Windows.Forms.RadioButton radPounds2;
        private System.Windows.Forms.TextBox txtConverted;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

