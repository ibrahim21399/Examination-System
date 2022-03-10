namespace Examination_System.Exam
{
    partial class exam
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
            this.btnprev = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnprev
            // 
            this.btnprev.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnprev.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.btnprev.ForeColor = System.Drawing.SystemColors.Info;
            this.btnprev.Location = new System.Drawing.Point(237, 682);
            this.btnprev.Margin = new System.Windows.Forms.Padding(4);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(225, 57);
            this.btnprev.TabIndex = 11;
            this.btnprev.Text = "<Prev";
            this.btnprev.UseVisualStyleBackColor = false;
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnnext.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.btnnext.ForeColor = System.Drawing.SystemColors.Info;
            this.btnnext.Location = new System.Drawing.Point(1442, 682);
            this.btnnext.Margin = new System.Windows.Forms.Padding(4);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(225, 57);
            this.btnnext.TabIndex = 12;
            this.btnnext.Text = "Next>";
            this.btnnext.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Maroon;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSubmit.Location = new System.Drawing.Point(904, 682);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(225, 57);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Examination_System.Properties.Resources.style_2_5;
            this.ClientSize = new System.Drawing.Size(1810, 811);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "exam";
            this.Text = "exam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnSubmit;
    }
}