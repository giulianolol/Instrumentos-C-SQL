using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace DepositoInsturmentosMusicales
{
    public partial class wfrmAppDeposito : Form
    {
        private List<Insturmento> listaInstrumento;
        public wfrmAppDeposito()
        {
            InitializeComponent();
        }

        private void wfrmAppDeposito_Load(object sender, EventArgs e)
        {
            InstrumentoNegocio negocio = new InstrumentoNegocio();
            listaInstrumento = negocio.Listar();
            dgvElementos.DataSource = negocio.Listar();
            pbxGuitarra.Load(listaInstrumento[0].UrlImagenEjemplo);
            dgvElementos.Columns["UrlImagenEjemplo"].Visible = false;
        }

        private void pbxGuitarra_Click(object sender, EventArgs e)
        {

        }

        private void dgvElementos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvElementos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Insturmento seleccionado = (Insturmento)dgvElementos.CurrentRow.DataBoundItem;
                pbxGuitarra.Load(seleccionado.UrlImagenEjemplo);

            }
            catch (Exception ex)
            {
                throw ex;

            }
            
        }
    }
}
