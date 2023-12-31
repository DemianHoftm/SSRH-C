using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRRH
{
    public partial class Agregar_Cliente : Form
    {
        private ErrorProvider error;
        public int INDIE;
        public string line;
        public Agregar_Cliente()
        {
            InitializeComponent();
            error = new ErrorProvider();
        }

        private void iD2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Creo un arreglo con todas las teclas que estan permitidas.
            var validos = new[] { Keys.Delete, Keys.Back, Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9 };
            //la propiedad handled indica si permite que entre el caracter (false) o no (true)
            //se verifica que lo presionado sea un numero o borrar, de ser asi tira true, se convierte a false y el caracter entra
            e.Handled = !validos.Contains((Keys)e.KeyChar);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aregar_btn_Click_1(object sender, EventArgs e)
        {
            bool auxiliar = true;
            Cliente_Clase clint = new Cliente_Clase();
            if (ID1.SelectedIndex == -1)
            {
                auxiliar = false;
                error.SetError(ID1, "Seleccione uno");
            }
            else error.SetError(ID1, "");

            if (iD2.Text == "")
            {
                auxiliar = false;
                error.SetError(iD2, "ingrese un valor");
            }
            else
            {
                if (clint.Buscar(this.ID1.SelectedItem.ToString() + this.iD2.Text))
                {
                    error.SetError(this.iD2, "Ya existe un usuario con este nombre");
                    auxiliar = false;
                    clint.dt_client.Clear();
                }
                else error.SetError(iD2, "");
            }
            if (telf.Text == "")
            {
                auxiliar = false;
                error.SetError(telf, "ingrese un valor");
            }
            else error.SetError(telf, "");
            if (NOMBRE.Text == "")
            {
                auxiliar = false;
                error.SetError(NOMBRE, "ingrese un valor");
            }
            else error.SetError(NOMBRE, "");
            if (corr.Text == "")
            {
                auxiliar = false;
                error.SetError(corr, "ingrese un valor");
            }
            else error.SetError(corr, "");

            if (auxiliar)
            {

                clint.ID = this.ID1.SelectedItem.ToString() + this.iD2.Text;
                clint.Nombre = this.NOMBRE.Text;
                clint.Telefono = this.telf.Text;
                clint.Correo = this.corr.Text;

                clint.Insertar();
                line = this.iD2.Text;
                INDIE = ID1.SelectedIndex;
                this.Close();
            }
        }
    }
}
