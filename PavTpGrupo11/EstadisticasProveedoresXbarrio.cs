using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using PavTpGrupo11.AccesoADatos;

namespace PavTpGrupo11
{
    public partial class EstadisticasProveedoresXbarrio : Form
    {
        public EstadisticasProveedoresXbarrio()
        {
            InitializeComponent();
        }

        private void EstadisticasProveedoresXbarrio_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

            DataTable tabla = new DataTable();
            tabla = ConexionSQL.ObtenerProveedoresXbarrio();

            ReportDataSource ds = new ReportDataSource("DatosEProveedores", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
