using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SRRH
{
    public partial class Consultar_reser : Form
    {
        Reservacion_Clase reserva;
        decimal plato; //aqui se guarda el precio por dia de habitacion
        int dias;
        usuario Usuario_Actual;
        public Consultar_reser(usuario actual)
        {
            InitializeComponent();
            reserva = new Reservacion_Clase();
            Usuario_Actual = actual;
            this.Consulta_Startup();
            this.func_startup();
        }

        //boton de consulta
        private void button1_Click(object sender, EventArgs e)
        {

            if (Fecha_re_Con.Checked == fe_est_con.Checked)
            {
                BoxMessage chismoso = new BoxMessage();
                chismoso.Aviso_arriba.Text = "Procedimiento invalido";
                chismoso.si.Visible = false;
                chismoso.Cuerpo_men.Text = "Elija un tipo de rango de busqueda";
                chismoso.Show();
                return;
            }
            string auxiliar_cliente = "";
            string estado = "";
            if (Condicion_deleted.Checked) estado = "1"; else estado = "0";

            if (ID_consul.SelectedIndex == -1)
            {
                auxiliar_cliente = "" + id2_consul.Text;
            }
            if ((auxiliar_cliente == "") && (id_reser.Text == ""))
            {
                if (Fecha_re_Con.Checked == true)
                {
                    //consulta vacia con rango de reservacion
                    reserva.Consulta_reserva(f_reser_min.Value.ToString("yyyy-MM-dd"), f_reser_max.Value.ToString("yyyy-MM-dd"), estado);
                    //MODIFICAR AQUI
                    goto DeadEnd;
                }
                else
                {
                    //consulta vacia con rango de estadia
                    reserva.Consulta_estadia(f_est_min.Value.ToString("yyyy-MM-dd"), f_est_max.Value.ToString("yyyy-MM-dd"), estado);
                    //MODIFICAR AQUI
                    goto DeadEnd;
                }
            }
            else
            {
                if (Fecha_re_Con.Checked == true)
                {
                    //consulta con rango de reservacion
                    string reservacion_Urano = "--"; //
                    if (auxiliar_cliente == "") auxiliar_cliente = "--"; //Se coloca un invalido para que no se tome en cuenta
                    if (id_reser.Text != "") reservacion_Urano = id_reser.Text;
                    reserva.Consulta_reserva(f_reser_min.Value.ToString("yyyy-MM-dd"), f_reser_max.Value.ToString("yyyy-MM-dd"), reservacion_Urano, auxiliar_cliente, estado);
                    //MODIFICAR AQUI
                    goto DeadEnd;
                }
                else
                {
                    //consulta con rango de estadia
                    string reservacion_Urano = "--"; //
                    if (auxiliar_cliente == "") auxiliar_cliente = "--"; //Se coloca un invalido para que no se tome en cuenta
                    if (id_reser.Text != "") reservacion_Urano = id_reser.Text;
                    reserva.Consulta_estadia(f_est_min.Value.ToString("yyyy-MM-dd"), f_est_max.Value.ToString("yyyy-MM-dd"), auxiliar_cliente, reservacion_Urano, estado);
                    //modificar aqui
                    goto DeadEnd;
                }


            }

        DeadEnd:
            this.rellenar();
            this.Consulta_Startup();

        }

        //Limpiador de la consulta
        public void Consulta_Startup()
        {
            DateTime minimo = new DateTime(2020, 01, 01);
            f_reser_min.MinDate = minimo;
            f_est_min.MinDate = minimo;
            f_reser_max.MinDate = minimo.AddDays(1);
            f_est_max.MinDate = minimo.AddDays(1);
            id_reser.Text = "";
            ID_consul.SelectedIndex = -1;
            ID_consul.SelectedItem = "";
            id2_consul.Text = "";
            DateTime hoy = DateTime.Now;
            f_reser_min.Value = hoy;
            f_est_min.Value = hoy;
            f_reser_max.Value = hoy.AddDays(1);
            f_est_max.Value = hoy.AddDays(1);
            Fecha_re_Con.Checked = false;
            fe_est_con.Checked = false;

        }

        public void rellenar()
        {
            Reservacion_Clase urano = new Reservacion_Clase();
            Tabla.Rows.Clear();
            string auxiliar = "";
            string atlas;
            foreach (DataRow actual in reserva.re.Rows)//recorrerá cada fila del data table
            {
                if (urano.Balance(actual.Field<string>(0))) atlas = "Pagado"; else atlas = "Por Pagar";
                auxiliar = urano.Habitacion_Ocupadas(actual.Field<string>(0));
                Tabla.Rows.Add(
                actual.Field<string>(0), //numero de reservacion
                actual.Field<string>(1), //cliente id
                auxiliar, //habitaciones ocupadas
                actual.Field<DateTime>(2).ToShortDateString(),//Fecha de entrada
                actual.Field<DateTime>(3).ToShortDateString(), //Fecha de salida
                atlas); //balance

                //Se añade la nueva columna
            }
            this.reserva.re.Clear();

        }
        //evento para el ingreso de reservacion
        private void id_reser_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Creo un arreglo con todas las teclas que estan permitidas.
            var validos = new[] { Keys.Delete, Keys.Back, Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.A, Keys.B, Keys.C, Keys.D, Keys.E, Keys.F };
            //la propiedad handled indica si permite que entre el caracter (false) o no (true)
            //se verifica que lo presionado sea un numero o borrar, de ser asi tira true, se convierte a false y el caracter entra
            e.Handled = !validos.Contains((Keys)e.KeyChar);
        }

        private void f_reser_min_Leave(object sender, EventArgs e)
        {
            f_reser_max.Value = f_reser_min.Value.AddDays(1);
            f_reser_max.MinDate = f_reser_min.Value.AddDays(1);
        }

        private void f_est_min_Leave(object sender, EventArgs e)
        {
            f_est_max.Value = f_reser_min.Value.AddDays(1);
            f_est_max.MinDate = f_reser_min.Value.AddDays(1);
        }



        //fin de lo relacionado a consultas

        //Funciones de Eliminar y actualizar
        public void func_startup()
        {
            ID_ciente_actu.Text = "#### ____";
            Descuento.Text = "";
            Cantidad_total.Text = "##";
            Eliminar_btn.Text = "DESACTIVAR";
            Eliminar_btn.Enabled = false;
            editar_btn.Enabled = false;
            id_resv.Text = "####";
            button2.Enabled = false;
            PAGO_BTN.Enabled = false;
        }

        private void Descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Creo un arreglo con todas las teclas que estan permitidas.
            var validos = new[] { Keys.Delete, Keys.Decimal, Keys.Back, Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9 };
            //la propiedad handled indica si permite que entre el caracter (false) o no (true)
            //se verifica que lo presionado sea un numero o borrar, de ser asi tira true, se convierte a false y el caracter entra
            e.Handled = !validos.Contains((Keys)e.KeyChar);
        }



        private void Tabla_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow auxiliar = this.Tabla.SelectedRows[0];
            plato = reserva.Get_Bruto(auxiliar.Cells[0].Value.ToString());
            Reservacion_Clase pezRaya4 = new Reservacion_Clase();
            pezRaya4.Recupera(auxiliar.Cells[0].Value.ToString());
            id_resv.Text = auxiliar.Cells[0].Value.ToString();
            ID_ciente_actu.Text = pezRaya4.re.Rows[0].Field<String>(0) + ", " + pezRaya4.re.Rows[0].Field<String>(1);
            Descuento.Text = pezRaya4.re.Rows[0].Field<decimal>(2).ToString();
            Cantidad_total.Text = pezRaya4.re.Rows[0].Field<decimal>(3).ToString();
            TimeSpan dia = pezRaya4.re.Rows[0].Field<DateTime>(5) - pezRaya4.re.Rows[0].Field<DateTime>(4);
            dias = dia.Days;
            if (pezRaya4.re.Rows[0].Field<string>(6) == "1")
            {
                Eliminar_btn.Text = "DESACTIVAR";
            }
            else
            {
                Eliminar_btn.Text = "ACTIVAR";

            }
            Eliminar_btn.Enabled = true;
            editar_btn.Enabled = true;
            button2.Enabled = true;
            if (auxiliar.Cells[5].Value.ToString().Length > 6) PAGO_BTN.Enabled = true; else PAGO_BTN.Enabled = false;


        }

        public void Calculo()
        {
            decimal plata = plato * dias;
            plata = (plata - (plata * (Convert.ToDecimal(Descuento.Text) / 100.0M)));
            string oro = Math.Round(plata, 2).ToString("0.00");

            Cantidad_total.Text = oro;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Calculo();
        }

        private void Eliminar_btn_Click(object sender, EventArgs e)
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

            if (Eliminar_btn.Text.Length == 10) reserva.Cambio_Estado(id_resv.Text, "0"); else reserva.Cambio_Estado(id_resv.Text, "1");
            Bitacora bit = new Bitacora();
            bit.Accion = "Editar";
            bit.Codigo = id_resv.Text;
            bit.Modulo = "Reservacion";
            bit.Usuario = operador;
            bit.Insertar();
            Tabla.Rows.Clear();
            this.func_startup();
            this.Consulta_Startup();
        }

        private void editar_btn_Click(object sender, EventArgs e)
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
            if (Descuento.Text.Length < 1)
            {
                return;
            }
            reserva.actualizar(id_resv.Text, Convert.ToDecimal(Descuento.Text), Convert.ToDecimal(Cantidad_total.Text));

            Bitacora bit = new Bitacora();
            bit.Accion = "Editar";
            bit.Codigo = id_resv.Text;
            bit.Modulo = "Reservacion";
            bit.Usuario = operador;
            bit.Insertar();
            BoxMessage LaVaca = new BoxMessage();
            LaVaca.Aviso_arriba.Text = "Tarea ejecutada";
            LaVaca.Cuerpo_men.Text = "Se han guardado los cambios";
            LaVaca.si.Visible = false;
            LaVaca.no.Text = "ok";
            LaVaca.ShowDialog();
            this.func_startup();
            this.Consulta_Startup();
            Tabla.Rows.Clear();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PAGO_BTN_Click(object sender, EventArgs e)
        {
            Nuevo_pago auxiliar = new Nuevo_pago(id_resv.Text, Usuario_Actual.Nombre);
            auxiliar.ShowDialog();
            this.func_startup();
        }



        //Fin de funciones


    }
}
