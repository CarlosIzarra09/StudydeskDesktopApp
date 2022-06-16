
namespace StudydeskDesktopApp
{
    partial class SdApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_CoursesForm = new System.Windows.Forms.Button();
            this.button_TutorsForm = new System.Windows.Forms.Button();
            this.button_Dashboard = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button_CoursesForm);
            this.panel1.Controls.Add(this.button_TutorsForm);
            this.panel1.Controls.Add(this.button_Dashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 716);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1322, 37);
            this.panel2.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(245, 37);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1077, 716);
            this.MainPanel.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::StudydeskDesktopApp.Properties.Resources.studydesk_title_logo1;
            this.pictureBox2.InitialImage = global::StudydeskDesktopApp.Properties.Resources.studydesk_title_logo;
            this.pictureBox2.Location = new System.Drawing.Point(13, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudydeskDesktopApp.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(43, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_CoursesForm
            // 
            this.button_CoursesForm.BackColor = System.Drawing.Color.SkyBlue;
            this.button_CoursesForm.FlatAppearance.BorderSize = 0;
            this.button_CoursesForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CoursesForm.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CoursesForm.ForeColor = System.Drawing.SystemColors.Window;
            this.button_CoursesForm.Image = global::StudydeskDesktopApp.Properties.Resources.books_stack_of_three;
            this.button_CoursesForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_CoursesForm.Location = new System.Drawing.Point(3, 382);
            this.button_CoursesForm.Name = "button_CoursesForm";
            this.button_CoursesForm.Size = new System.Drawing.Size(242, 33);
            this.button_CoursesForm.TabIndex = 2;
            this.button_CoursesForm.Text = "COURSES";
            this.button_CoursesForm.UseVisualStyleBackColor = false;
            this.button_CoursesForm.Click += new System.EventHandler(this.button_CoursesForm_Click);
            // 
            // button_TutorsForm
            // 
            this.button_TutorsForm.BackColor = System.Drawing.Color.SkyBlue;
            this.button_TutorsForm.FlatAppearance.BorderSize = 0;
            this.button_TutorsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TutorsForm.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TutorsForm.ForeColor = System.Drawing.SystemColors.Window;
            this.button_TutorsForm.Image = global::StudydeskDesktopApp.Properties.Resources.teacher;
            this.button_TutorsForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_TutorsForm.Location = new System.Drawing.Point(3, 330);
            this.button_TutorsForm.Name = "button_TutorsForm";
            this.button_TutorsForm.Size = new System.Drawing.Size(242, 33);
            this.button_TutorsForm.TabIndex = 1;
            this.button_TutorsForm.Text = "TUTORS";
            this.button_TutorsForm.UseVisualStyleBackColor = false;
            this.button_TutorsForm.Click += new System.EventHandler(this.button_TutorsForm_Click);
            // 
            // button_Dashboard
            // 
            this.button_Dashboard.BackColor = System.Drawing.Color.SkyBlue;
            this.button_Dashboard.FlatAppearance.BorderSize = 0;
            this.button_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Dashboard.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Dashboard.ForeColor = System.Drawing.SystemColors.Window;
            this.button_Dashboard.Image = global::StudydeskDesktopApp.Properties.Resources.monitor1;
            this.button_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Dashboard.Location = new System.Drawing.Point(3, 276);
            this.button_Dashboard.Name = "button_Dashboard";
            this.button_Dashboard.Size = new System.Drawing.Size(242, 33);
            this.button_Dashboard.TabIndex = 0;
            this.button_Dashboard.Text = "DASHBORAD";
            this.button_Dashboard.UseVisualStyleBackColor = false;
            this.button_Dashboard.Click += new System.EventHandler(this.button_Dashboard_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Image = global::StudydeskDesktopApp.Properties.Resources.power_off;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1121, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "CERRAR SESIÓN";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SdApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 753);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SdApp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studydesk Application";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button button_Dashboard;
        private System.Windows.Forms.Button button_CoursesForm;
        private System.Windows.Forms.Button button_TutorsForm;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}