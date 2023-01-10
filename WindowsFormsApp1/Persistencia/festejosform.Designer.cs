namespace WindowsFormsApp1
{
    partial class festejosform
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
            this.InsertarF = new System.Windows.Forms.Button();
            this.ActualizarF = new System.Windows.Forms.Button();
            this.EliminarF = new System.Windows.Forms.Button();
            this.IdFestejo = new System.Windows.Forms.Label();
            this.tipo_festejo = new System.Windows.Forms.Label();
            this.Ffestejo = new System.Windows.Forms.Label();
            this.localidad = new System.Windows.Forms.Label();
            this.provincia = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtfestejo = new System.Windows.Forms.TextBox();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtlocalidad = new System.Windows.Forms.TextBox();
            this.txtprovincia = new System.Windows.Forms.TextBox();
            this.dgFestejo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgUsuario = new System.Windows.Forms.DataGridView();
            this.InsertarUsu = new System.Windows.Forms.Button();
            this.EliminarUsu = new System.Windows.Forms.Button();
            this.ActualizarUsu = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.Label();
            this.textdni = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.textFiltroUsu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgFestejo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertarF
            // 
            this.InsertarF.Location = new System.Drawing.Point(522, 53);
            this.InsertarF.Name = "InsertarF";
            this.InsertarF.Size = new System.Drawing.Size(75, 23);
            this.InsertarF.TabIndex = 0;
            this.InsertarF.Text = "Insertar";
            this.InsertarF.UseVisualStyleBackColor = true;
            this.InsertarF.Click += new System.EventHandler(this.InsertarF_Click);
            // 
            // ActualizarF
            // 
            this.ActualizarF.Location = new System.Drawing.Point(523, 134);
            this.ActualizarF.Name = "ActualizarF";
            this.ActualizarF.Size = new System.Drawing.Size(75, 23);
            this.ActualizarF.TabIndex = 1;
            this.ActualizarF.Text = "Actualizar";
            this.ActualizarF.UseVisualStyleBackColor = true;
            this.ActualizarF.Click += new System.EventHandler(this.ActualizarF_Click);
            // 
            // EliminarF
            // 
            this.EliminarF.BackColor = System.Drawing.Color.IndianRed;
            this.EliminarF.Location = new System.Drawing.Point(523, 232);
            this.EliminarF.Name = "EliminarF";
            this.EliminarF.Size = new System.Drawing.Size(75, 23);
            this.EliminarF.TabIndex = 2;
            this.EliminarF.Text = "Eliminar";
            this.EliminarF.UseVisualStyleBackColor = false;
            this.EliminarF.Click += new System.EventHandler(this.EliminarF_Click);
            // 
            // IdFestejo
            // 
            this.IdFestejo.AutoSize = true;
            this.IdFestejo.Location = new System.Drawing.Point(164, 46);
            this.IdFestejo.Name = "IdFestejo";
            this.IdFestejo.Size = new System.Drawing.Size(16, 13);
            this.IdFestejo.TabIndex = 3;
            this.IdFestejo.Text = "Id";
            // 
            // tipo_festejo
            // 
            this.tipo_festejo.AutoSize = true;
            this.tipo_festejo.Location = new System.Drawing.Point(164, 139);
            this.tipo_festejo.Name = "tipo_festejo";
            this.tipo_festejo.Size = new System.Drawing.Size(58, 13);
            this.tipo_festejo.TabIndex = 4;
            this.tipo_festejo.Text = "tipo festejo";
            // 
            // Ffestejo
            // 
            this.Ffestejo.AutoSize = true;
            this.Ffestejo.Location = new System.Drawing.Point(164, 86);
            this.Ffestejo.Name = "Ffestejo";
            this.Ffestejo.Size = new System.Drawing.Size(38, 13);
            this.Ffestejo.TabIndex = 5;
            this.Ffestejo.Text = "festejo";
            // 
            // localidad
            // 
            this.localidad.AutoSize = true;
            this.localidad.Location = new System.Drawing.Point(164, 186);
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(49, 13);
            this.localidad.TabIndex = 6;
            this.localidad.Text = "localidad";
            // 
            // provincia
            // 
            this.provincia.AutoSize = true;
            this.provincia.Location = new System.Drawing.Point(164, 237);
            this.provincia.Name = "provincia";
            this.provincia.Size = new System.Drawing.Size(50, 13);
            this.provincia.TabIndex = 7;
            this.provincia.Text = "provincia";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(226, 47);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(162, 20);
            this.txtId.TabIndex = 8;
            // 
            // txtfestejo
            // 
            this.txtfestejo.Location = new System.Drawing.Point(226, 86);
            this.txtfestejo.Name = "txtfestejo";
            this.txtfestejo.Size = new System.Drawing.Size(162, 20);
            this.txtfestejo.TabIndex = 9;
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(226, 137);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(162, 20);
            this.txttipo.TabIndex = 10;
            // 
            // txtlocalidad
            // 
            this.txtlocalidad.Location = new System.Drawing.Point(226, 186);
            this.txtlocalidad.Name = "txtlocalidad";
            this.txtlocalidad.Size = new System.Drawing.Size(162, 20);
            this.txtlocalidad.TabIndex = 11;
            // 
            // txtprovincia
            // 
            this.txtprovincia.Location = new System.Drawing.Point(226, 237);
            this.txtprovincia.Name = "txtprovincia";
            this.txtprovincia.Size = new System.Drawing.Size(162, 20);
            this.txtprovincia.TabIndex = 12;
            // 
            // dgFestejo
            // 
            this.dgFestejo.AllowUserToAddRows = false;
            this.dgFestejo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFestejo.Location = new System.Drawing.Point(32, 282);
            this.dgFestejo.Name = "dgFestejo";
            this.dgFestejo.Size = new System.Drawing.Size(578, 150);
            this.dgFestejo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // dgUsuario
            // 
            this.dgUsuario.AllowUserToAddRows = false;
            this.dgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuario.Location = new System.Drawing.Point(654, 282);
            this.dgUsuario.Name = "dgUsuario";
            this.dgUsuario.Size = new System.Drawing.Size(571, 150);
            this.dgUsuario.TabIndex = 16;
            // 
            // InsertarUsu
            // 
            this.InsertarUsu.Location = new System.Drawing.Point(771, 53);
            this.InsertarUsu.Name = "InsertarUsu";
            this.InsertarUsu.Size = new System.Drawing.Size(75, 23);
            this.InsertarUsu.TabIndex = 17;
            this.InsertarUsu.Text = "Insertar";
            this.InsertarUsu.UseVisualStyleBackColor = true;
            this.InsertarUsu.Click += new System.EventHandler(this.InsertarUsu_Click);
            // 
            // EliminarUsu
            // 
            this.EliminarUsu.BackColor = System.Drawing.Color.IndianRed;
            this.EliminarUsu.Location = new System.Drawing.Point(1093, 53);
            this.EliminarUsu.Name = "EliminarUsu";
            this.EliminarUsu.Size = new System.Drawing.Size(75, 23);
            this.EliminarUsu.TabIndex = 18;
            this.EliminarUsu.Text = "Eliminar";
            this.EliminarUsu.UseVisualStyleBackColor = false;
            // 
            // ActualizarUsu
            // 
            this.ActualizarUsu.Location = new System.Drawing.Point(949, 53);
            this.ActualizarUsu.Name = "ActualizarUsu";
            this.ActualizarUsu.Size = new System.Drawing.Size(75, 23);
            this.ActualizarUsu.TabIndex = 19;
            this.ActualizarUsu.Text = "Actualizar";
            this.ActualizarUsu.UseVisualStyleBackColor = true;
            this.ActualizarUsu.Click += new System.EventHandler(this.ActualizarUsu_Click_1);
            // 
            // txtDni
            // 
            this.txtDni.AutoSize = true;
            this.txtDni.Location = new System.Drawing.Point(732, 119);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(26, 13);
            this.txtDni.TabIndex = 20;
            this.txtDni.Text = "DNI";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(732, 144);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(44, 13);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.Text = "Nombre";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(732, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(32, 13);
            this.txtEmail.TabIndex = 22;
            this.txtEmail.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(732, 207);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(53, 13);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.Text = "Password";
            // 
            // textdni
            // 
            this.textdni.Location = new System.Drawing.Point(811, 112);
            this.textdni.Name = "textdni";
            this.textdni.Size = new System.Drawing.Size(226, 20);
            this.textdni.TabIndex = 25;
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(811, 141);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(226, 20);
            this.textnombre.TabIndex = 26;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(811, 175);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(226, 20);
            this.textemail.TabIndex = 27;
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(811, 207);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(226, 20);
            this.textpassword.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Purple;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(946, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "USUARIOS";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(611, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 31;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(520, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Asigna un rol:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Purple;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(236, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "FESTEJOS";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(239, 462);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtFiltro.TabIndex = 34;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // textFiltroUsu
            // 
            this.textFiltroUsu.Location = new System.Drawing.Point(888, 471);
            this.textFiltroUsu.Name = "textFiltroUsu";
            this.textFiltroUsu.Size = new System.Drawing.Size(100, 20);
            this.textFiltroUsu.TabIndex = 35;
            this.textFiltroUsu.TextChanged += new System.EventHandler(this.textFiltroUsu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Filtrado Festejos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(732, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Filtrado Usuarios";
            // 
            // festejosform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1277, 544);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textFiltroUsu);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.textdni);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.ActualizarUsu);
            this.Controls.Add(this.EliminarUsu);
            this.Controls.Add(this.InsertarUsu);
            this.Controls.Add(this.dgUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgFestejo);
            this.Controls.Add(this.txtprovincia);
            this.Controls.Add(this.txtlocalidad);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.txtfestejo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.provincia);
            this.Controls.Add(this.localidad);
            this.Controls.Add(this.Ffestejo);
            this.Controls.Add(this.tipo_festejo);
            this.Controls.Add(this.IdFestejo);
            this.Controls.Add(this.EliminarF);
            this.Controls.Add(this.ActualizarF);
            this.Controls.Add(this.InsertarF);
            this.Name = "festejosform";
            this.Text = "festejosform";
            this.Load += new System.EventHandler(this.festejosform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFestejo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertarF;
        private System.Windows.Forms.Button ActualizarF;
        private System.Windows.Forms.Button EliminarF;
        private System.Windows.Forms.Label IdFestejo;
        private System.Windows.Forms.Label tipo_festejo;
        private System.Windows.Forms.Label Ffestejo;
        private System.Windows.Forms.Label localidad;
        private System.Windows.Forms.Label provincia;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtfestejo;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.TextBox txtlocalidad;
        private System.Windows.Forms.TextBox txtprovincia;
        private System.Windows.Forms.DataGridView dgFestejo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgUsuario;
        private System.Windows.Forms.Button InsertarUsu;
        private System.Windows.Forms.Button EliminarUsu;
        private System.Windows.Forms.Button ActualizarUsu;
        private System.Windows.Forms.Label txtDni;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.TextBox textdni;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.TextBox textFiltroUsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}