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
    public partial class ReporteEstadisticaObrasXBarrio : Form
    {
        public ReporteEstadisticaObrasXBarrio()
        {
            InitializeComponent();
        }

        private void ReporteEstadisticaObrasXBarrio_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Obras.ObtenerEstadisticasObrasXbarrio();
            ReportDataSource ds = new ReportDataSource("DatosEstadisticas", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }
    }
}
