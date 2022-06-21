
namespace StudydeskDesktopApp.Menu
{
    partial class ProfileForm
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
            this.txtName = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(248, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 27);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Nombre Nombre2";
            // 
            // txtLastname
            // 
            this.txtLastname.AutoSize = true;
            this.txtLastname.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(248, 92);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(255, 32);
            this.txtLastname.TabIndex = 2;
            this.txtLastname.Text = "Apellido Apellido2";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDescription.Location = new System.Drawing.Point(249, 146);
            this.txtDescription.MaximumSize = new System.Drawing.Size(520, 0);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(517, 88);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor i" +
    "ncididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostru" +
    "d exercitation ullamco laboris\"";
            this.txtDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logo
            // 
            this.logo.Image = global::StudydeskDesktopApp.Properties.Resources.default_placeholder;
            this.logo.Location = new System.Drawing.Point(33, 29);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(193, 194);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(808, 582);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtLastname;
        private System.Windows.Forms.Label txtDescription;
    }
}