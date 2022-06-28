namespace StudydeskDesktopApp
{
    partial class EditProfile
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
            this.btEditar = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.richTextBox_descripcion = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.MediumBlue;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btEditar.Location = new System.Drawing.Point(36, 296);
            this.btEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(257, 44);
            this.btEditar.TabIndex = 8;
            this.btEditar.Text = "ACTUALIZAR";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // logo
            // 
            this.logo.Image = global::StudydeskDesktopApp.Properties.Resources.default_placeholder;
            this.logo.Location = new System.Drawing.Point(36, 23);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(257, 239);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // textBox_mail
            // 
            this.textBox_mail.Font = new System.Drawing.Font("Arial", 18F);
            this.textBox_mail.Location = new System.Drawing.Point(325, 23);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(229, 42);
            this.textBox_mail.TabIndex = 9;
            this.textBox_mail.Text = "Correo";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Arial", 18F);
            this.textBox_name.Location = new System.Drawing.Point(325, 88);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(229, 42);
            this.textBox_name.TabIndex = 10;
            this.textBox_name.Text = "Nombre";
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Font = new System.Drawing.Font("Arial", 18F);
            this.textBox_lastname.Location = new System.Drawing.Point(325, 158);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(229, 42);
            this.textBox_lastname.TabIndex = 11;
            this.textBox_lastname.Text = "Apellido";
            // 
            // richTextBox_descripcion
            // 
            this.richTextBox_descripcion.Font = new System.Drawing.Font("Arial", 14F);
            this.richTextBox_descripcion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.richTextBox_descripcion.Location = new System.Drawing.Point(325, 217);
            this.richTextBox_descripcion.Name = "richTextBox_descripcion";
            this.richTextBox_descripcion.Size = new System.Drawing.Size(691, 108);
            this.richTextBox_descripcion.TabIndex = 12;
            this.richTextBox_descripcion.Text = "Descripción";
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 669);
            this.Controls.Add(this.richTextBox_descripcion);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.logo);
            this.Name = "EditProfile";
            this.Text = "Editar Perfil";
            this.Load += new System.EventHandler(this.EditProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.RichTextBox richTextBox_descripcion;
    }
}