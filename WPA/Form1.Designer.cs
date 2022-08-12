
namespace WPA
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
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubstraction = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtIslem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(10, 37);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(118, 76);
            this.btnAddition.TabIndex = 10;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubstraction
            // 
            this.btnSubstraction.Location = new System.Drawing.Point(134, 37);
            this.btnSubstraction.Name = "btnSubstraction";
            this.btnSubstraction.Size = new System.Drawing.Size(113, 76);
            this.btnSubstraction.TabIndex = 11;
            this.btnSubstraction.Text = "-";
            this.btnSubstraction.UseVisualStyleBackColor = true;
            this.btnSubstraction.Click += new System.EventHandler(this.btnSubstraction_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(10, 119);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(118, 77);
            this.btnMultiply.TabIndex = 12;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(134, 119);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(113, 77);
            this.btnDivision.TabIndex = 13;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(253, 37);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 76);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtIslem
            // 
            this.txtIslem.Location = new System.Drawing.Point(8, 11);
            this.txtIslem.Name = "txtIslem";
            this.txtIslem.Size = new System.Drawing.Size(362, 20);
            this.txtIslem.TabIndex = 15;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(419, 252);
            this.Controls.Add(this.txtIslem);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubstraction);
            this.Controls.Add(this.btnAddition);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubstraction;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtIslem;
    }
}

