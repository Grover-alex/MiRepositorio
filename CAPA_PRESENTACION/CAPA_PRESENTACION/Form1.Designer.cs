namespace CAPA_PRESENTACION
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
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnEstudiates = new System.Windows.Forms.Button();
            this.btnAuxiliares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDocentes
            // 
            this.btnDocentes.AutoSize = true;
            this.btnDocentes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocentes.Image = global::CAPA_PRESENTACION.Properties.Resources.aula;
            this.btnDocentes.Location = new System.Drawing.Point(547, 191);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(165, 165);
            this.btnDocentes.TabIndex = 2;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDocentes.UseVisualStyleBackColor = true;
            // 
            // btnEstudiates
            // 
            this.btnEstudiates.AutoSize = true;
            this.btnEstudiates.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiates.Image = global::CAPA_PRESENTACION.Properties.Resources.leyendo;
            this.btnEstudiates.Location = new System.Drawing.Point(336, 191);
            this.btnEstudiates.Name = "btnEstudiates";
            this.btnEstudiates.Size = new System.Drawing.Size(165, 165);
            this.btnEstudiates.TabIndex = 1;
            this.btnEstudiates.Text = "Estudiantes";
            this.btnEstudiates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstudiates.UseVisualStyleBackColor = true;
            this.btnEstudiates.Click += new System.EventHandler(this.btnEstudiates_Click);
            // 
            // btnAuxiliares
            // 
            this.btnAuxiliares.AutoSize = true;
            this.btnAuxiliares.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuxiliares.Image = global::CAPA_PRESENTACION.Properties.Resources.servicio_al_cliente;
            this.btnAuxiliares.Location = new System.Drawing.Point(122, 191);
            this.btnAuxiliares.Name = "btnAuxiliares";
            this.btnAuxiliares.Size = new System.Drawing.Size(165, 165);
            this.btnAuxiliares.TabIndex = 0;
            this.btnAuxiliares.Text = "Auxiliares";
            this.btnAuxiliares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAuxiliares.UseVisualStyleBackColor = true;
            this.btnAuxiliares.Click += new System.EventHandler(this.btnAuxiliares_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 532);
            this.Controls.Add(this.btnDocentes);
            this.Controls.Add(this.btnEstudiates);
            this.Controls.Add(this.btnAuxiliares);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuxiliares;
        private System.Windows.Forms.Button btnEstudiates;
        private System.Windows.Forms.Button btnDocentes;
    }
}

