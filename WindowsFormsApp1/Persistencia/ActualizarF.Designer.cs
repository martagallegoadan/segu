namespace WindowsFormsApp1.Persistencia
{
    partial class ActualizarF
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtfest = new System.Windows.Forms.TextBox();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtlocal = new System.Windows.Forms.TextBox();
            this.IdFestejo = new System.Windows.Forms.Label();
            this.txtprov = new System.Windows.Forms.TextBox();
            this.Ffestejo = new System.Windows.Forms.Label();
            this.tipo_festejo = new System.Windows.Forms.Label();
            this.localidad = new System.Windows.Forms.Label();
            this.provincia = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(147, 53);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 9;
            // 
            // txtfest
            // 
            this.txtfest.Location = new System.Drawing.Point(382, 53);
            this.txtfest.Name = "txtfest";
            this.txtfest.Size = new System.Drawing.Size(100, 20);
            this.txtfest.TabIndex = 10;
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(665, 53);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(100, 20);
            this.txttipo.TabIndex = 11;
            // 
            // txtlocal
            // 
            this.txtlocal.Location = new System.Drawing.Point(262, 139);
            this.txtlocal.Name = "txtlocal";
            this.txtlocal.Size = new System.Drawing.Size(100, 20);
            this.txtlocal.TabIndex = 12;
            // 
            // IdFestejo
            // 
            this.IdFestejo.AutoSize = true;
            this.IdFestejo.Location = new System.Drawing.Point(62, 60);
            this.IdFestejo.Name = "IdFestejo";
            this.IdFestejo.Size = new System.Drawing.Size(16, 13);
            this.IdFestejo.TabIndex = 13;
            this.IdFestejo.Text = "Id";
            // 
            // txtprov
            // 
            this.txtprov.Location = new System.Drawing.Point(537, 139);
            this.txtprov.Name = "txtprov";
            this.txtprov.Size = new System.Drawing.Size(100, 20);
            this.txtprov.TabIndex = 14;
            // 
            // Ffestejo
            // 
            this.Ffestejo.AutoSize = true;
            this.Ffestejo.Location = new System.Drawing.Point(308, 60);
            this.Ffestejo.Name = "Ffestejo";
            this.Ffestejo.Size = new System.Drawing.Size(38, 13);
            this.Ffestejo.TabIndex = 15;
            this.Ffestejo.Text = "festejo";
            // 
            // tipo_festejo
            // 
            this.tipo_festejo.AutoSize = true;
            this.tipo_festejo.Location = new System.Drawing.Point(556, 60);
            this.tipo_festejo.Name = "tipo_festejo";
            this.tipo_festejo.Size = new System.Drawing.Size(58, 13);
            this.tipo_festejo.TabIndex = 17;
            this.tipo_festejo.Text = "tipo festejo";
            // 
            // localidad
            // 
            this.localidad.AutoSize = true;
            this.localidad.Location = new System.Drawing.Point(177, 146);
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(49, 13);
            this.localidad.TabIndex = 18;
            this.localidad.Text = "localidad";
            // 
            // provincia
            // 
            this.provincia.AutoSize = true;
            this.provincia.Location = new System.Drawing.Point(442, 146);
            this.provincia.Name = "provincia";
            this.provincia.Size = new System.Drawing.Size(50, 13);
            this.provincia.TabIndex = 19;
            this.provincia.Text = "provincia";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(106, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 186);
            this.dataGridView1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 43);
            this.button1.TabIndex = 21;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Festejos";
            // 
            // ActualizarF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.provincia);
            this.Controls.Add(this.localidad);
            this.Controls.Add(this.tipo_festejo);
            this.Controls.Add(this.Ffestejo);
            this.Controls.Add(this.txtprov);
            this.Controls.Add(this.IdFestejo);
            this.Controls.Add(this.txtlocal);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.txtfest);
            this.Controls.Add(this.txtId);
            this.Name = "ActualizarF";
            this.Text = "ActualizarF";
            this.Load += new System.EventHandler(this.ActualizarF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtfest;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.TextBox txtlocal;
        private System.Windows.Forms.Label IdFestejo;
        private System.Windows.Forms.TextBox txtprov;
        private System.Windows.Forms.Label Ffestejo;
        private System.Windows.Forms.Label tipo_festejo;
        private System.Windows.Forms.Label localidad;
        private System.Windows.Forms.Label provincia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}