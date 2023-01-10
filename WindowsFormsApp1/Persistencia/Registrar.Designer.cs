namespace WindowsFormsApp1.Persistencia
{
    partial class Registrar
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtdn = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(156, 47);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(211, 20);
            this.txtemail.TabIndex = 2;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(156, 92);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(211, 20);
            this.txtpass.TabIndex = 3;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 147);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 20);
            this.txtNombre.TabIndex = 12;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_TextChanged);
            // 
            // txtdn
            // 
            this.txtdn.Location = new System.Drawing.Point(151, 198);
            this.txtdn.Name = "txtdn";
            this.txtdn.Size = new System.Drawing.Size(216, 20);
            this.txtdn.TabIndex = 13;
            this.txtdn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdn_TextChanged);
            // 
            // txtNom
            // 
            this.txtNom.AutoSize = true;
            this.txtNom.Location = new System.Drawing.Point(58, 154);
            this.txtNom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(44, 13);
            this.txtNom.TabIndex = 14;
            this.txtNom.Text = "Nombre";
            // 
            // txtDni
            // 
            this.txtDni.AutoSize = true;
            this.txtDni.Location = new System.Drawing.Point(59, 201);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(26, 13);
            this.txtDni.TabIndex = 15;
            this.txtDni.Text = "DNI";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(524, 47);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(5);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(110, 26);
            this.btnInsertar.TabIndex = 16;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Rol";
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(151, 237);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(216, 20);
            this.txtRol.TabIndex = 21;
            this.txtRol.TextChanged += new System.EventHandler(this.txtRol_TextChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(524, 144);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(110, 23);
            this.btnEnter.TabIndex = 22;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtdn);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registrar";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtdn;
        private System.Windows.Forms.Label txtNom;
        private System.Windows.Forms.Label txtDni;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Button btnEnter;
    }
}