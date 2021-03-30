
namespace BaseNumberConverter
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelResultBinary = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelResultDecimal = new System.Windows.Forms.Label();
            this.labelResultOctal = new System.Windows.Forms.Label();
            this.inputType = new System.Windows.Forms.ComboBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 85);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(214, 20);
            this.textBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBox, "Enter a number to convert here.");
            // 
            // labelResultBinary
            // 
            this.labelResultBinary.AutoSize = true;
            this.labelResultBinary.Location = new System.Drawing.Point(10, 42);
            this.labelResultBinary.Name = "labelResultBinary";
            this.labelResultBinary.Size = new System.Drawing.Size(0, 13);
            this.labelResultBinary.TabIndex = 8;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(13, 111);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 9;
            this.buttonSubmit.Text = "Convert";
            this.toolTip1.SetToolTip(this.buttonSubmit, "Convert entered value to selected base.");
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelResultDecimal
            // 
            this.labelResultDecimal.AutoSize = true;
            this.labelResultDecimal.Location = new System.Drawing.Point(10, 9);
            this.labelResultDecimal.Name = "labelResultDecimal";
            this.labelResultDecimal.Size = new System.Drawing.Size(0, 13);
            this.labelResultDecimal.TabIndex = 10;
            // 
            // labelResultOctal
            // 
            this.labelResultOctal.AutoSize = true;
            this.labelResultOctal.Location = new System.Drawing.Point(10, 69);
            this.labelResultOctal.Name = "labelResultOctal";
            this.labelResultOctal.Size = new System.Drawing.Size(0, 13);
            this.labelResultOctal.TabIndex = 11;
            // 
            // inputType
            // 
            this.inputType.FormattingEnabled = true;
            this.inputType.Items.AddRange(new object[] {
            "Decimal",
            "Binary",
            "Octal"});
            this.inputType.Location = new System.Drawing.Point(234, 83);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(121, 21);
            this.inputType.TabIndex = 12;
            this.inputType.Text = "Input Type";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(95, 120);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 13;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.inputType);
            this.Controls.Add(this.labelResultOctal);
            this.Controls.Add(this.labelResultDecimal);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelResultBinary);
            this.Controls.Add(this.textBox);
            this.Name = "Form";
            this.Text = "Base Number Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelResultBinary;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelResultDecimal;
        private System.Windows.Forms.Label labelResultOctal;
        private System.Windows.Forms.ComboBox inputType;
        private System.Windows.Forms.Label labelError;
    }
}

