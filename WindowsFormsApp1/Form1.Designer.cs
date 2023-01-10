namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txttEma = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.txtPa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgusuario = new System.Windows.Forms.DataGridView();
            this.Enter = new System.Windows.Forms.Button();
            this.linkuser = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgusuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txttEma
            // 
            this.txttEma.AutoSize = true;
            this.txttEma.Location = new System.Drawing.Point(77, 52);
            this.txttEma.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txttEma.Name = "txttEma";
            this.txttEma.Size = new System.Drawing.Size(0, 20);
            this.txttEma.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.AutoSize = true;
            this.txtPass.Location = new System.Drawing.Point(44, 101);
            this.txtPass.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(86, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "Password";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(157, 52);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(216, 26);
            this.textEmail.TabIndex = 5;
            this.textEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEmail_TextChanged);
            // 
            // txtPa
            // 
            this.txtPa.Location = new System.Drawing.Point(157, 98);
            this.txtPa.MaxLength = 14;
            this.txtPa.Name = "txtPa";
            this.txtPa.PasswordChar = '*';
            this.txtPa.Size = new System.Drawing.Size(216, 26);
            this.txtPa.TabIndex = 6;
            this.txtPa.UseSystemPasswordChar = true;
            this.txtPa.TextChanged += new System.EventHandler(this.txtPa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "INICIAR SESIÓN";
            // 
            // dgusuario
            // 
            this.dgusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgusuario.Location = new System.Drawing.Point(48, 285);
            this.dgusuario.Name = "dgusuario";
            this.dgusuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgusuario.Size = new System.Drawing.Size(237, 125);
            this.dgusuario.TabIndex = 12;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(62, 441);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 31);
            this.Enter.TabIndex = 13;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkuser
            // 
            this.linkuser.AutoSize = true;
            this.linkuser.Location = new System.Drawing.Point(48, 243);
            this.linkuser.Name = "linkuser";
            this.linkuser.Size = new System.Drawing.Size(112, 20);
            this.linkuser.TabIndex = 15;
            this.linkuser.TabStop = true;
            this.linkuser.Text = "Registrarse?";
            this.linkuser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkuser_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Email";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "Validar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "fest.JPG");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.fest;
            this.pictureBox1.Location = new System.Drawing.Point(634, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 241);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SuperAdmin",
            "Admin",
            "Usuario"});
            this.comboBox1.Location = new System.Drawing.Point(157, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 28);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Text = "Roles";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 39);
            this.label3.TabIndex = 23;
            this.label3.Text = "Festejos Taurinos";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(238, 243);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(197, 20);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Olvidó su contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1107, 692);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkuser);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.dgusuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPa);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txttEma);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "FESTEJOS";
            ((System.ComponentModel.ISupportInitialize)(this.dgusuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txttEma;
        private System.Windows.Forms.Label txtPass;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox txtPa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgusuario;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.LinkLabel linkuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

