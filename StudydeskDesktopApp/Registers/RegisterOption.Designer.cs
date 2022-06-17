namespace StudydeskDesktopApp
{
    partial class OptionRegister
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
            this.button_Tutor = new System.Windows.Forms.Button();
            this.button_student = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiero registrame como";
            // 
            // button_Tutor
            // 
            this.button_Tutor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_Tutor.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tutor.ForeColor = System.Drawing.Color.White;
            this.button_Tutor.Location = new System.Drawing.Point(69, 74);
            this.button_Tutor.Margin = new System.Windows.Forms.Padding(2);
            this.button_Tutor.Name = "button_Tutor";
            this.button_Tutor.Size = new System.Drawing.Size(153, 50);
            this.button_Tutor.TabIndex = 1;
            this.button_Tutor.Text = "Tutor";
            this.button_Tutor.UseVisualStyleBackColor = false;
            this.button_Tutor.Click += new System.EventHandler(this.button_Tutor_Click);
            // 
            // button_student
            // 
            this.button_student.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_student.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_student.ForeColor = System.Drawing.Color.White;
            this.button_student.Location = new System.Drawing.Point(69, 140);
            this.button_student.Margin = new System.Windows.Forms.Padding(2);
            this.button_student.Name = "button_student";
            this.button_student.Size = new System.Drawing.Size(153, 50);
            this.button_student.TabIndex = 2;
            this.button_student.Text = "Estudiante";
            this.button_student.UseVisualStyleBackColor = false;
            this.button_student.Click += new System.EventHandler(this.button_student_Click);
            // 
            // OptionRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(297, 215);
            this.Controls.Add(this.button_student);
            this.Controls.Add(this.button_Tutor);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OptionRegister";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Tutor;
        private System.Windows.Forms.Button button_student;
    }
}