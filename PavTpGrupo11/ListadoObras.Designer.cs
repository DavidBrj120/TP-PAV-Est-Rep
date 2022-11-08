namespace PavTpGrupo11
{
    partial class ReporteListadoObras
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCodObra = new System.Windows.Forms.RadioButton();
            this.rdbBarrio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodObra = new System.Windows.Forms.TextBox();
            this.txtIdBarrio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PavTpGrupo11.ListadoDeObras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 172);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 266);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdBarrio);
            this.groupBox1.Controls.Add(this.txtCodObra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbBarrio);
            this.groupBox1.Controls.Add(this.rdbCodObra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Obras";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbCodObra
            // 
            this.rdbCodObra.AutoSize = true;
            this.rdbCodObra.Location = new System.Drawing.Point(37, 53);
            this.rdbCodObra.Name = "rdbCodObra";
            this.rdbCodObra.Size = new System.Drawing.Size(171, 22);
            this.rdbCodObra.TabIndex = 0;
            this.rdbCodObra.TabStop = true;
            this.rdbCodObra.Text = "Filtro De Codigo Obra";
            this.rdbCodObra.UseVisualStyleBackColor = true;
            this.rdbCodObra.CheckedChanged += new System.EventHandler(this.rdbCodObra_CheckedChanged);
            // 
            // rdbBarrio
            // 
            this.rdbBarrio.AutoSize = true;
            this.rdbBarrio.Location = new System.Drawing.Point(37, 93);
            this.rdbBarrio.Name = "rdbBarrio";
            this.rdbBarrio.Size = new System.Drawing.Size(123, 22);
            this.rdbBarrio.TabIndex = 1;
            this.rdbBarrio.TabStop = true;
            this.rdbBarrio.Text = "Filtro de Barrio";
            this.rdbBarrio.UseVisualStyleBackColor = true;
            this.rdbBarrio.CheckedChanged += new System.EventHandler(this.rdbBarrio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aplicar Filtros";
            // 
            // txtCodObra
            // 
            this.txtCodObra.Location = new System.Drawing.Point(370, 54);
            this.txtCodObra.Name = "txtCodObra";
            this.txtCodObra.Size = new System.Drawing.Size(140, 24);
            this.txtCodObra.TabIndex = 3;
            // 
            // txtIdBarrio
            // 
            this.txtIdBarrio.Location = new System.Drawing.Point(370, 94);
            this.txtIdBarrio.Name = "txtIdBarrio";
            this.txtIdBarrio.Size = new System.Drawing.Size(140, 24);
            this.txtIdBarrio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cod. De Obra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id De Barrio:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(610, 42);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(132, 30);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Actualizar Listado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReporteListadoObras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteListadoObras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoObras";
            this.Load += new System.EventHandler(this.ReporteListadoObras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbBarrio;
        private System.Windows.Forms.RadioButton rdbCodObra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdBarrio;
        private System.Windows.Forms.TextBox txtCodObra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLimpiar;
    }
}