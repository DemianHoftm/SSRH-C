using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRRH
{
    public partial class Modulo_Pago : Form
    {
        Pago_Clase pagos;
        usuario Usuario_Actual;
        public Modulo_Pago(usuario ingreso)
        {
            InitializeComponent();
            this.stratup();
            Usuario_Actual = ingreso;
            pagos = new Pago_Clase();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void id_reser_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Creo un arreglo con todas las teclas que estan permitidas.
            var validos = new[] { Keys.Delete, Keys.Back, Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.A, Keys.B, Keys.C, Keys.D, Keys.E, Keys.F };
            //la propiedad handled indica si permite que entre el caracter (false) o no (true)
            //se verifica que lo presionado sea un numero o borrar, de ser asi tira true, se convierte a false y el caracter entra
            e.Handled = !validos.Contains((Keys)e.KeyChar);
        }

        private void ID_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Creo un arreglo con todas las teclas que estan permitidas.
            var validos = new[] { Keys.Delete, Keys.Back, Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9 };
            //la propiedad handled indica si permite que entre el caracter (false) o no (true)
            //se verifica que lo presionado sea un numero o borrar, de ser asi tira true, se convierte a false y el caracter entra
            e.Handled = !validos.Contains((Keys)e.KeyChar);
        }
        public void stratup()
        {
            f_reser_min.Value = DateTime.Now;
            f_reser_max.Value = f_reser_min.Value.AddDays(1);
            f_reser_max.MinDate = f_reser_min.Value.AddDays(1);
            id_reser.Text = "";
            ID_cliente.Text = "";
            ID1.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            Eliminar.Text = "DESACTIVAR";
            Eliminar.Enabled = false;
            editar_btn.Enabled = false;
            textBox1.Text = "";
            nombreycodigoclient.Text = "#### ____";
            pagoid.Text = "####";
            reserva_codi.Text = "####";

        }
        private void f_reser_min_Leave(object sender, EventArgs e)
        {
            f_reser_max.MinDate = f_reser_min.Value.AddDays(1);
            f_reser_max.Value = f_reser_min.Value.AddDays(1);
        }

        public void rellenar()
        {
            string tipo;
            Tabla.Rows.Clear();
            foreach (DataRow actual in pagos.pagoDT.Rows)//recorrerá cada fila del data table
            {
                if (actual.Field<string>(2) == "EE")
                {
                    tipo = "Efectivo";
                    goto Salt;
                }
                if (actual.Field<string>(2) == "TT")
                {
                    tipo = "Tarjeta";
                    goto Salt;
                }
                else tipo = actual.Field<string>(2);
                Salt:
                Tabla.Rows.Add(actual.Field<string>(4),
                actual.Field<string>(0), //Codigo de reservacion
                actual.Field<decimal>(1).ToString(), //Importe
                tipo,//tipo de pago o referencia
                actual.Field<DateTime>(3).ToShortDateString()); // Fecha

                //Se añade la nueva columna
            }
            pagos.pagoDT.Rows.Clear();

        }

        private void Consultar_btt_Click(object sender, EventArgs e)
        {
            string identificador_reserva;
            string anfitrion;
            string metodo = null;
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    {
                        metodo = "EE";
                        break;
                    }
                case 2:
                    {
                        metodo = "TT";
                        break;
                    }


            }
            if (id_reser.Text.Length > 0) identificador_reserva = id_reser.Text; else identificador_reserva = null;
            if (ID_cliente.Text.Length > 1) anfitrion = ID1.SelectedItem.ToString() + ID_cliente.Text; else anfitrion = null;

            if (comboBox1.SelectedIndex == 3)
            {
                pagos.rellenar_trans(identificador_reserva, anfitrion, f_reser_min.Value.ToString("yyyy-MM-dd"), f_reser_max.Value.ToString("yyyy-MM-dd"));

            }
            else pagos.rellenar(identificador_reserva, anfitrion, f_reser_min.Value.ToString("yyyy-MM-dd"), f_reser_max.Value.ToString("yyyy-MM-dd"), metodo);

            this.rellenar();

        }

        private void Tabla_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow aux = this.Tabla.SelectedRows[0];
            Pago_Clase pezRaya3 = new Pago_Clase();
            pezRaya3.recuperar(aux.Cells[0].Value.ToString());
            DataRow auxiliar = pezRaya3.pagoDT.Rows[0];
            Eliminar.Enabled = true;
            editar_btn.Enabled = true;
            textBox1.Text = auxiliar.Field<decimal>(1).ToString();
            nombreycodigoclient.Text = auxiliar.Field<string>(3) + ", " + auxiliar.Field<string>(4);
            pagoid.Text = auxiliar.Field<string>(0);
            reserva_codi.Text = auxiliar.Field<string>(2);
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            string operador = Usuario_Actual.Nombre;
            if (Usuario_Actual.Rol == 0)
            {
                Confirmar_adm solicitud = new Confirmar_adm();
                solicitud.ShowDialog();
                if (!solicitud.acceso)
                {
                    return;
                }
                else operador = solicitud.usuario;
            }
            pagos.eliminar(pagoid.Text);
            Bitacora bit = new Bitacora();
            bit.Accion = "Eliminar";
            bit.Codigo = pagoid.Text;
            bit.Modulo = "Pago";
            bit.Usuario = operador;
            bit.Insertar();
            Tabla.Rows.Clear();
            this.stratup();
        }

        private void editar_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) return;
            string operador = Usuario_Actual.Nombre;
            if (Usuario_Actual.Rol == 0)
            {
                Confirmar_adm solicitud = new Confirmar_adm();
                solicitud.ShowDialog();
                if (!solicitud.acceso)
                {
                    return;
                }
                else operador = solicitud.usuario;
            }
            pagos.actualizar(pagoid.Text, textBox1.Text);
            Bitacora bit = new Bitacora();
            bit.Accion = "Editar";
            bit.Codigo = pagoid.Text;
            bit.Modulo = "Pago";
            bit.Usuario = operador;
            bit.Insertar();
            Tabla.Rows.Clear();
            this.stratup();
        }
    }
}
