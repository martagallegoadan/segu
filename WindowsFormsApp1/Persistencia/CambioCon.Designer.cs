namespace WindowsFormsApp1
{
    partial class CambioCon
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
            this.ActualizarCon = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgCon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCon)).BeginInit();
            this.SuspendLayout();
            // 
            // ActualizarCon
            // 
            this.ActualizarCon.Location = new System.Drawing.Point(455, 124);
            this.ActualizarCon.Name = "ActualizarCon";
            this.ActualizarCon.Size = new System.Drawing.Size(75, 23);
            this.ActualizarCon.TabIndex = 0;
            this.ActualizarCon.Text = "Cambiar";
            this.ActualizarCon.UseVisualStyleBackColor = true;
            this.ActualizarCon.Click += new System.EventHandler(this.ActualizarCon_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Volver Inicio";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgCon
            // 
            this.dgCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCon.Location = new System.Drawing.Point(54, 89);
            this.dgCon.Name = "dgCon";
            this.dgCon.Size = new System.Drawing.Size(240, 150);
            this.dgCon.TabIndex = 4;
            // 
            // CambioCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgCon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ActualizarCon);
            this.Name = "CambioCon";
            this.Text = "CambioCon";
            ((System.ComponentModel.ISupportInitialize)(this.dgCon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ActualizarCon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgCon;
    }
}