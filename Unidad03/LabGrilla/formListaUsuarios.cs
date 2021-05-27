using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabGrilla
{
    public partial class formListaUsuarios : Form
    {
        public formListaUsuarios()
        {
            InitializeComponent();
            this.oUsuarios = new Negocio.Usuarios();
            this.dgvUsuarios.DataSource = this.oUsuarios.GetAll();

        }

        private Negocio.Usuarios _usuarios;
        public Negocio.Usuarios oUsuarios
        {
            get { return _usuarios; }
            set { _usuarios = value; }
        }

        private void RecargarGrilla()
        {
            this.dgvUsuarios.DataSource = this.oUsuarios.GetAll();
        }

        private void GuardarCambios()
        {
            this.oUsuarios.GuardarCambios((DataTable)this.dgvUsuarios.DataSource);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
            this.RecargarGrilla();

        }
    }
}
