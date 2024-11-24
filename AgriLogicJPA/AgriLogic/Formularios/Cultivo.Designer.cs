namespace AgriLogic.Formularios
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtpCosecha = new System.Windows.Forms.DateTimePicker();
            this.dtpSiembra = new System.Windows.Forms.DateTimePicker();
            this.txtRequisito = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMin = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnMax = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(24, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 270);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRegistros);
            this.groupBox1.Location = new System.Drawing.Point(24, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registros De Cultivos";
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(0, 21);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.RowHeadersWidth = 51;
            this.dgvRegistros.RowTemplate.Height = 24;
            this.dgvRegistros.Size = new System.Drawing.Size(833, 204);
            this.dgvRegistros.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(23, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 217);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.dtpCosecha);
            this.groupBox2.Controls.Add(this.dtpSiembra);
            this.groupBox2.Controls.Add(this.txtRequisito);
            this.groupBox2.Controls.Add(this.txtTipo);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 173);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion De Cultivo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(480, 117);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 32);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtpCosecha
            // 
            this.dtpCosecha.Location = new System.Drawing.Point(480, 68);
            this.dtpCosecha.Name = "dtpCosecha";
            this.dtpCosecha.Size = new System.Drawing.Size(200, 22);
            this.dtpCosecha.TabIndex = 9;
            // 
            // dtpSiembra
            // 
            this.dtpSiembra.Location = new System.Drawing.Point(480, 31);
            this.dtpSiembra.Name = "dtpSiembra";
            this.dtpSiembra.Size = new System.Drawing.Size(200, 22);
            this.dtpSiembra.TabIndex = 8;
            // 
            // txtRequisito
            // 
            this.txtRequisito.Location = new System.Drawing.Point(133, 101);
            this.txtRequisito.Name = "txtRequisito";
            this.txtRequisito.Size = new System.Drawing.Size(100, 22);
            this.txtRequisito.TabIndex = 7;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(133, 62);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 22);
            this.txtTipo.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(133, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Cosecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha De Siembra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Requisitos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo De Cultivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cultivo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(301, 345);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 52);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar En Archivo";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(562, 345);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(110, 52);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar Archivo";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Silver;
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnMax);
            this.panelTop.Controls.Add(this.btnCerrar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(939, 54);
            this.panelTop.TabIndex = 6;
            // 
            // btnMin
            // 
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.ImageRotate = 0F;
            this.btnMin.Location = new System.Drawing.Point(756, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMin.Size = new System.Drawing.Size(32, 32);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMin.TabIndex = 8;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click_1);
            // 
            // btnMax
            // 
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.ImageRotate = 0F;
            this.btnMax.Location = new System.Drawing.Point(823, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMax.Size = new System.Drawing.Size(32, 32);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMax.TabIndex = 7;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageRotate = 0F;
            this.btnCerrar.Location = new System.Drawing.Point(882, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(939, 645);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker dtpCosecha;
        private System.Windows.Forms.DateTimePicker dtpSiembra;
        private System.Windows.Forms.TextBox txtRequisito;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnMin;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnMax;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnCerrar;
    }
}