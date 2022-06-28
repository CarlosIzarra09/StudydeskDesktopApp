﻿
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
            this.btEditar = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.txt_mail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(329, 95);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 35);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Nombre Nombre2";
            // 
            // txtLastname
            // 
            this.txtLastname.AutoSize = true;
            this.txtLastname.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(328, 154);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(308, 40);
            this.txtLastname.TabIndex = 2;
            this.txtLastname.Text = "Apellido Apellido2";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDescription.Location = new System.Drawing.Point(330, 219);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDescription.MaximumSize = new System.Drawing.Size(693, 0);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(691, 108);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor i" +
    "ncididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostru" +
    "d exercitation ullamco laboris\"";
            this.txtDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.MediumBlue;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btEditar.Location = new System.Drawing.Point(44, 309);
            this.btEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(257, 44);
            this.btEditar.TabIndex = 6;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // logo
            // 
            this.logo.Image = global::StudydeskDesktopApp.Properties.Resources.default_placeholder;
            this.logo.Location = new System.Drawing.Point(44, 36);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(257, 239);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // txt_mail
            // 
            this.txt_mail.AutoSize = true;
            this.txt_mail.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mail.Location = new System.Drawing.Point(329, 36);
            this.txt_mail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(105, 35);
            this.txt_mail.TabIndex = 7;
            this.txt_mail.Text = "Correo";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1077, 716);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Label txt_mail;
    }
}