namespace TooManyStudentsThomasA
{
    partial class frmTooManyStudents
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
            this.lblInputPrompt = new System.Windows.Forms.Label();
            this.txtNumStudents = new System.Windows.Forms.TextBox();
            this.btnCheckSize = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInputPrompt
            // 
            this.lblInputPrompt.AutoSize = true;
            this.lblInputPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputPrompt.Location = new System.Drawing.Point(23, 67);
            this.lblInputPrompt.Name = "lblInputPrompt";
            this.lblInputPrompt.Size = new System.Drawing.Size(286, 20);
            this.lblInputPrompt.TabIndex = 0;
            this.lblInputPrompt.Text = "Enter the number of students (max 24):";
            // 
            // txtNumStudents
            // 
            this.txtNumStudents.Location = new System.Drawing.Point(331, 67);
            this.txtNumStudents.Name = "txtNumStudents";
            this.txtNumStudents.Size = new System.Drawing.Size(100, 20);
            this.txtNumStudents.TabIndex = 1;
            // 
            // btnCheckSize
            // 
            this.btnCheckSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckSize.Location = new System.Drawing.Point(161, 125);
            this.btnCheckSize.Name = "btnCheckSize";
            this.btnCheckSize.Size = new System.Drawing.Size(101, 31);
            this.btnCheckSize.TabIndex = 2;
            this.btnCheckSize.Text = "Check Size";
            this.btnCheckSize.UseVisualStyleBackColor = true;
            this.btnCheckSize.Click += new System.EventHandler(this.btnCheckSize_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(24, 193);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 3;
            // 
            // frmTooManyStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 230);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheckSize);
            this.Controls.Add(this.txtNumStudents);
            this.Controls.Add(this.lblInputPrompt);
            this.Name = "frmTooManyStudents";
            this.Text = "Too Many Students By Thomas Aubin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputPrompt;
        private System.Windows.Forms.TextBox txtNumStudents;
        private System.Windows.Forms.Button btnCheckSize;
        private System.Windows.Forms.Label lblResult;
    }
}

