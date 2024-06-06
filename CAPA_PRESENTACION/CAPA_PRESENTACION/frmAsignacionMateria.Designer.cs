namespace CAPA_PRESENTACION
{
    partial class frmAsignacionMateria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbMañana = new System.Windows.Forms.RadioButton();
            this.rdbMedioDia = new System.Windows.Forms.RadioButton();
            this.rdbTarde = new System.Windows.Forms.RadioButton();
            this.rdbNoche = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDocente = new System.Windows.Forms.ComboBox();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.comboBoxModulo = new System.Windows.Forms.ComboBox();
            this.comboBoxLaboratorio = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBoxLaboratorio);
            this.groupBox1.Controls.Add(this.comboBoxModulo);
            this.groupBox1.Controls.Add(this.comboBoxMateria);
            this.groupBox1.Controls.Add(this.comboBoxDocente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 317);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignacion de Materia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Docente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Materia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modulo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbNoche);
            this.groupBox2.Controls.Add(this.rdbTarde);
            this.groupBox2.Controls.Add(this.rdbMedioDia);
            this.groupBox2.Controls.Add(this.rdbMañana);
            this.groupBox2.Location = new System.Drawing.Point(6, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 137);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turno";
            // 
            // rdbMañana
            // 
            this.rdbMañana.AutoSize = true;
            this.rdbMañana.Location = new System.Drawing.Point(4, 33);
            this.rdbMañana.Name = "rdbMañana";
            this.rdbMañana.Size = new System.Drawing.Size(64, 17);
            this.rdbMañana.TabIndex = 0;
            this.rdbMañana.TabStop = true;
            this.rdbMañana.Text = "Mañana";
            this.rdbMañana.UseVisualStyleBackColor = true;
            // 
            // rdbMedioDia
            // 
            this.rdbMedioDia.AutoSize = true;
            this.rdbMedioDia.Location = new System.Drawing.Point(3, 57);
            this.rdbMedioDia.Name = "rdbMedioDia";
            this.rdbMedioDia.Size = new System.Drawing.Size(73, 17);
            this.rdbMedioDia.TabIndex = 1;
            this.rdbMedioDia.TabStop = true;
            this.rdbMedioDia.Text = "Medio Dia";
            this.rdbMedioDia.UseVisualStyleBackColor = true;
            // 
            // rdbTarde
            // 
            this.rdbTarde.AutoSize = true;
            this.rdbTarde.Location = new System.Drawing.Point(3, 80);
            this.rdbTarde.Name = "rdbTarde";
            this.rdbTarde.Size = new System.Drawing.Size(53, 17);
            this.rdbTarde.TabIndex = 2;
            this.rdbTarde.TabStop = true;
            this.rdbTarde.Text = "Tarde";
            this.rdbTarde.UseVisualStyleBackColor = true;
            // 
            // rdbNoche
            // 
            this.rdbNoche.AutoSize = true;
            this.rdbNoche.Location = new System.Drawing.Point(4, 103);
            this.rdbNoche.Name = "rdbNoche";
            this.rdbNoche.Size = new System.Drawing.Size(57, 17);
            this.rdbNoche.TabIndex = 3;
            this.rdbNoche.TabStop = true;
            this.rdbNoche.Text = "Noche";
            this.rdbNoche.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Laboratorio";
            // 
            // comboBoxDocente
            // 
            this.comboBoxDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDocente.FormattingEnabled = true;
            this.comboBoxDocente.Location = new System.Drawing.Point(113, 29);
            this.comboBoxDocente.Name = "comboBoxDocente";
            this.comboBoxDocente.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDocente.TabIndex = 6;
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMateria.FormattingEnabled = true;
            this.comboBoxMateria.Location = new System.Drawing.Point(113, 61);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMateria.TabIndex = 7;
            // 
            // comboBoxModulo
            // 
            this.comboBoxModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModulo.FormattingEnabled = true;
            this.comboBoxModulo.Location = new System.Drawing.Point(113, 92);
            this.comboBoxModulo.Name = "comboBoxModulo";
            this.comboBoxModulo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModulo.TabIndex = 8;
            // 
            // comboBoxLaboratorio
            // 
            this.comboBoxLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLaboratorio.FormattingEnabled = true;
            this.comboBoxLaboratorio.Location = new System.Drawing.Point(113, 124);
            this.comboBoxLaboratorio.Name = "comboBoxLaboratorio";
            this.comboBoxLaboratorio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLaboratorio.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Asignar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CAPA_PRESENTACION.Properties.Resources.logotipo_upds_azul_1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // frmAsignacionMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmAsignacionMateria";
            this.Text = "frmAsignacionMateria";
            this.Load += new System.EventHandler(this.frmAsignacionMateria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxLaboratorio;
        private System.Windows.Forms.ComboBox comboBoxModulo;
        private System.Windows.Forms.ComboBox comboBoxMateria;
        private System.Windows.Forms.ComboBox comboBoxDocente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbNoche;
        private System.Windows.Forms.RadioButton rdbTarde;
        private System.Windows.Forms.RadioButton rdbMedioDia;
        private System.Windows.Forms.RadioButton rdbMañana;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}