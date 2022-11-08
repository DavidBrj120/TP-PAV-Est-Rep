using Microsoft.Reporting.WinForms;
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
    public partial class ReporteListadoCamiones : Form
    {
        public ReporteListadoCamiones()
        {
            InitializeComponent();
        }

        private void ReporteListadoCamiones_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Camion.ObtenerCamiones();
            ReportDataSource ds = new ReportDataSource("DatosCamiones", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!rdbMarca.Checked && !rdbPatente.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = AD_Camion.ObtenerCamiones();
                ReportDataSource ds = new ReportDataSource("DatosCamiones", tabla);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }
    
            if (rdbPatente.Checked && !txtPatente.Text.Equals(""))
            {
                try
                {
                    string pat = txtMarca.Text;
                    DataTable tabla = new DataTable();
                    tabla = AD_Camion.ObtenerCamionesXPatente(pat);
                    ReportDataSource ds = new ReportDataSource("DatosCamiones", tabla);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.RefreshReport();
                    rdbPatente.Checked = false;
                    txtPatente.Enabled = false;

                }
                catch
                {
                    MessageBox.Show("El valor ingresado no es numerico o es muy grande");
                }
            }
            if (rdbMarca.Checked && !txtMarca.Text.Equals(""))
            {
                try
                {
                    string marca = txtMarca.Text;
                    DataTable tabla = new DataTable();
                    tabla = AD_Camion.ObtenerCamionesXMarca(marca);
                    ReportDataSource ds = new ReportDataSource("DatosCamiones", tabla);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.RefreshReport();
                    rdbMarca.Checked = false;
                    txtMarca.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("El valor ingresado no es numerico o es muy grande");
                }
            }  
        }

        private void rdbPatente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPatente.Checked)
            {
                txtPatente.Enabled = true;
            }
            else
            {
                txtPatente.Text = "";
                txtPatente.Enabled = false;
            }
        }

        private void rdbMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMarca.Checked)
            {
                txtMarca.Enabled = true;

            }
            else
            {
                txtMarca.Enabled = false;
                txtMarca.Text = "";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rdbMarca.Checked = false;
            txtMarca.Enabled = false;

            rdbPatente.Checked = false;
            txtPatente.Enabled = false;
        }
    }
}
