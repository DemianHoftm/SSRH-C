using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRRH
{
    public partial class Nuevo_pago : Form
    {
        private string auxiliar_usu;
        public Nuevo_pago(string id, string usuario)
        {
            InitializeComponent();
            id_resv.Text = id;
            auxiliar_usu = usuario;
            ID_consul.SelectedIndex = 0;
            Banco_trans.SelectedIndex = 0;
            this.Switch();
        }

        private void Switch()
        {

            if (ID_consul.SelectedIndex == 3)
            {

                tabControl1.SelectedIndex = 1;

            }
            else { tabControl1.SelectedIndex = 0; }

        }


        private void Descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Creo un arreglo con todas las teclas que estan permitidas.
            var validos = new[] { Keys.Delete, Keys.Decimal, Keys.Back, Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9 };
            //la propiedad handled indica si permite que entre el caracter (false) o no (true)
            //se verifica que lo presionado sea un numero o borrar, de ser asi tira true, se convierte a false y el caracter entra
            e.Handled = !validos.Contains((Keys)e.KeyChar);
        }

        private void guaradar_trans_Click(object sender, EventArgs e)
        {
            if ((ID_consul.SelectedIndex != 0) && (Descuento.Text.Length > 0) && (Banco_trans.SelectedIndex != 0) && (referencia_num.Text.Length > 0))
            {
                BoxMessage LaVaca = new BoxMessage();
                LaVaca.Aviso_arriba.Text = "Aviso de confirmacion";
                LaVaca.Cuerpo_men.Text = "¿Desea guardar los datos registrados?";
                LaVaca.ShowDialog();
                if (!LaVaca.Condicion) return;
                Pago_Clase pato = new Pago_Clase();
                pato.ID_Reserv = id_resv.Text;
                pato.Importe = Convert.ToDecimal(Descuento.Text);
                pato.Usuario = auxiliar_usu;
                pato.Referencia_Pago = referencia_num.Text;
                string bachata = pato.insertar(Banco_trans.SelectedItem.ToString());
                Bitacora bit = new Bitacora();
                bit.Accion = "Insertar";
                bit.Modulo = "Pago";
                bit.Usuario = auxiliar_usu;
                bit.Codigo = bachata;
                bit.Insertar();
                LaVaca.Aviso_arriba.Text = "Transaccion completada";
                LaVaca.Cuerpo_men.Text = "Se ha guardado el pago satisfactoriamente";
                LaVaca.si.Visible = false;
                LaVaca.no.Text = "ok";
                LaVaca.ShowDialog();
                BoxMessage muuu = new BoxMessage();
                muuu.Aviso_arriba.Text = "Registro completado";
                muuu.Cuerpo_men.Text = "¿Desea imprimir la factura?";
                muuu.ShowDialog();
                pato.recuperar(bachata);
                if (muuu.Condicion)
                {
                    Ticket_Confirmacion p = new Ticket_Confirmacion(pato.pagoDT.Rows[0]);
                }
                this.Close();
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if ((ID_consul.SelectedIndex != 0) && (Descuento.Text.Length > 0))
            {
                BoxMessage LaVaca = new BoxMessage();
                LaVaca.Aviso_arriba.Text = "Aviso de confirmacion";
                LaVaca.Cuerpo_men.Text = "¿Desea guardar los datos registrados?";
                LaVaca.ShowDialog();
                if (!LaVaca.Condicion) return;
                Pago_Clase pato = new Pago_Clase();
                pato.ID_Reserv = id_resv.Text;
                pato.Importe = Convert.ToDecimal(Descuento.Text);
                pato.Usuario = auxiliar_usu;
                if (ID_consul.SelectedIndex == 1) pato.Referencia_Pago = "EE"; else pato.Referencia_Pago = "TT";
                string bachata = pato.insertar();
                Bitacora bit = new Bitacora();
                bit.Accion = "Insertar";
                bit.Modulo = "Pago";
                bit.Usuario = auxiliar_usu;
                bit.Codigo = bachata;
                bit.Insertar();
                LaVaca.Aviso_arriba.Text = "Transaccion completada";
                LaVaca.Cuerpo_men.Text = "Se ha guardado el pago satisfactoriamente";
                LaVaca.si.Visible = false;
                LaVaca.no.Text = "ok";
                LaVaca.ShowDialog();
                BoxMessage muuu = new BoxMessage();
                muuu.Aviso_arriba.Text = "Registro completado";
                muuu.Cuerpo_men.Text = "¿Desea imprimir la factura?";
                muuu.ShowDialog();
                pato.recuperar(bachata);
                if (muuu.Condicion)
                {
                    Ticket_Confirmacion p = new Ticket_Confirmacion(pato.pagoDT.Rows[0]);
                }
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ID_consul_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Switch();
        }
    }
}
