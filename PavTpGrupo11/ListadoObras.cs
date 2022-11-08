using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using PavTpGrupo11.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PavTpGrupo11
{
    public partial class ReporteListadoObras : Form
    {
        public ReporteListadoObras()
        {
            InitializeComponent();
        }

        private void ReporteListadoObras_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Obras.ConsultarObrasDG();
            ReportDataSource ds = new  ReportDataSource("ListadoDeObras", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!rdbBarrio.Checked && !rdbCodObra.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Obras.ConsultarObrasDG();
                ReportDataSource ds = new ReportDataSource("ListadoDeObras", tabla);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }
            if(rdbCodObra.Checked && !txtCodObra.Text.Equals(""))
            {
                try
                {
                    int cod = int.Parse(txtCodObra.Text);
                    DataTable tabla = new DataTable();
                    tabla = AD_Obras.ObtenerObraxCod(cod);
                    ReportDataSource ds = new ReportDataSource("ListadoDeObras", tabla);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.RefreshReport();
                    rdbCodObra.Checked = false;
                    txtCodObra.Enabled=false;
                }
                catch (Exception)
                {
                    MessageBox.Show("El valor ingresado no es numerico o es muy grande");
                }
            }
            if(rdbBarrio.Checked && !txtIdBarrio.Text.Equals(""))
            {
                try
                {
                    int id = int.Parse(txtIdBarrio.Text);
                    DataTable tabla = new DataTable();
                    tabla = AD_Obras.ObtenerObraxIdBarrio(id);
                    ReportDataSource ds = new ReportDataSource("ListadoDeObras", tabla);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.RefreshReport();
                    rdbBarrio.Checked = false;
                    txtIdBarrio.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("El valor ingresado no es numerico o es muy grande");
                }
            }
        }


        private void rdbCodObra_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCodObra.Checked)
            {
                txtCodObra.Enabled = true;
            }
            else
            {
                txtCodObra.Text = "";
                txtCodObra.Enabled=false;
            }
        }

        private void rdbBarrio_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBarrio.Checked)
            {
                txtIdBarrio.Enabled = true;

            }
            else
            {
                txtIdBarrio.Enabled = false;
                txtIdBarrio.Text = "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            rdbBarrio.Checked = false;
            txtIdBarrio.Enabled = false;

            rdbCodObra.Checked = false;
            txtCodObra.Enabled = false;
        }

        
    }
}
