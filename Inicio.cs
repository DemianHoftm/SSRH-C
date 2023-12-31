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
//Añadir el combobox de tipo de identificacion a la identificacion del cliente y reintegrarlo al sistema
namespace SRRH
{
    public partial class Inicio : Form
    {
        private usuario Usuario_Actual;
        public bool open = true;
        public bool open2 = true;
        private Tipo_hab tipo_habitacion;
        Habitacion_clase okupa;
        public Inicio(usuario entrada)
        {
            InitializeComponent();
            this.usuario_boton.Click += new EventHandler(Usuario_Func);
            this.Cerrar.Click += new EventHandler(Cerrar_Func);
            this.Log_out.Click += new EventHandler(Log_out_Func);
            this.bitacora_boton.Click += new EventHandler(BitaVision);
            okupa = new Habitacion_clase();
            Usuario_Actual = entrada;
            tipo_habitacion = new Tipo_hab();

            if (Usuario_Actual.Rol == 0)
            {
                hab_menu.Location = new Point(273, -35);
                man_menu.Visible = false;
                man_menu.Enabled = false;
            }
            tipo_habitacion.rellenar("1");

            foreach (DataRow actual in tipo_habitacion.dt_tip.Rows)//recorrerá cada fila del data table
            {
                comboBox1.Items.Add(actual.Field<string>(1)); //agrega los nombres de los tipos de habitacion
            }
            tipo_habitacion.dt_tip.Clear();
            Lista_Reservar.Items.Clear();
            //Modificadores para nueva reservacion
            string formato = "yyyy-MM-d";
            f_entrada.CustomFormat = formato;
            f_salida.CustomFormat = formato;
            DateTime hoy = DateTime.Today;
            f_entrada.MinDate = hoy;
            f_entrada.Value = hoy;
            f_salida.MinDate = hoy.AddDays(1);
            f_salida.Value = hoy.AddDays(1);
            //Cierro nueva modificacion

        }


        //Esto reinicia todo el inicio
        public void restart_New()
        {
            Descuento.Text = "0";
            Nombre_Cliente.Text = "_______________________";
            label2.Text = "##";
            ID1.SelectedIndex = -1;
            ID1.Enabled = true;
            ID_cliente.Text = "";
            ID_cliente.Enabled = true;
            habitaciones.Items.Clear();
            Lista_Reservar.Items.Clear();
            DateTime hoy = DateTime.Today;
            f_entrada.MinDate = hoy;
            f_salida.MinDate = hoy.AddDays(1);
            f_entrada.Value = hoy;
            f_salida.Value = hoy.AddDays(1);
            comboBox1.SelectedIndex = -1;
            Cantidad_total.Text = "##";
        }

        //Inicio de eventos del menu
        private void button1_Click(object sender, EventArgs e)
        {
            Modulo_Pago aux = new Modulo_Pago(Usuario_Actual);
            aux.ShowDialog();
        }
        private void inicio_btn_Click(object sender, EventArgs e)
        {
            Consultar_reser res = new Consultar_reser(Usuario_Actual);
            res.ShowDialog();
        }
        public void BitaVision(object sender, EventArgs e)
        {
            Modulo_Bitacora bit = new Modulo_Bitacora();
            bit.ShowDialog();
        }
        public void Log_out_Func(object sender, EventArgs e)
        {
            Application.Restart();
        }

        public void Usuario_Func(object sender, EventArgs e)
        {
            Modulo_usuario aux = new Modulo_usuario(Usuario_Actual.Nombre);
            aux.ShowDialog();

        }

        public void Cerrar_Func(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cliente_btn_Click(object sender, EventArgs e)
        {
            Modulo_cliente aux = new Modulo_cliente();
            aux.ShowDialog();
        }

        private void tipo_btn_Click(object sender, EventArgs e)
        {
            Tipo_habitacion aux = new Tipo_habitacion();
            aux.ShowDialog();
        }

        private void habitacio_btn_Click(object sender, EventArgs e)
        {
            Modulo_habitacion Hab = new Modulo_habitacion();
            Hab.ShowDialog();
        }


        private void hab_menu_Click(object sender, EventArgs e)
        {
            if (open == true)
            {
                tipo_btn.Location = new Point(273, 35);
                open = false;
            }
            else
            {
                tipo_btn.Location = new Point(273, 0);
                open = true;
            }
        }

        private void HM_leave(object sender, EventArgs e)
        {
            tipo_btn.Location = new Point(273, 0);
            open = true;
        }

        private void man_menu_Click(object sender, EventArgs e)
        {
            if (open2 == true)
            {
                usuario_boton.Location = new Point(513, 35);
                reporte_boton.Location = new Point(513, 67);
                bitacora_boton.Location = new Point(513, 99);
                open2 = false;
            }
            else
            {
                usuario_boton.Location = new Point(513, 0);
                reporte_boton.Location = new Point(513, 0);
                bitacora_boton.Location = new Point(513, 0);
                open2 = true;
            }
        }

        private void MM_leave(object sender, EventArgs e)
        {
            usuario_boton.Location = new Point(513, 0);
            reporte_boton.Location = new Point(513, 0);
            bitacora_boton.Location = new Point(513, 0);
            open2 = true;

        }

        private void reporte_boton_Click(object sender, EventArgs e)
        {
            Reporte botox = new Reporte();
            botox.ShowDialog();
        }
        //Fin del menu


        //De aqui en adelante es todo relacionado a la creacion de nuevas reservaciones

        //este evento evita que se añada letras al textbox de cliente
        private void ID_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Creo un arreglo con todas las teclas que estan permitidas.
            var validos = new[] { Keys.Delete, Keys.Back, Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9 };
            //la propiedad handled indica si permite que entre el caracter (false) o no (true)
            //se verifica que lo presionado sea un numero o borrar, de ser asi tira true, se convierte a false y el caracter entra
            e.Handled = !validos.Contains((Keys)e.KeyChar);
        }
        //este evento es para buscar al cliente por el ID ingresado apenas se retire el cursor del control
        private void ID_cliente_Leave(object sender, EventArgs e)
        {
        FRANCHESCOOOO:
            Cliente_Clase NOSE = new Cliente_Clase();
            //Si no se encuentra al cliente se abre una nueva ventana para agregarlo
            BoxMessage mensaje = new BoxMessage();
            mensaje.Aviso_arriba.Text = "cliente invalido";
            mensaje.Cuerpo_men.Text = "Cliente no encontrado, ¿desea agregarlo ?";
            if (ID1.SelectedIndex == -1) return;
            if (!NOSE.Buscar(ID1.SelectedItem.ToString() + ID_cliente.Text))
            {

                mensaje.ShowDialog();
                bool result = mensaje.Condicion;
                if (result)
                {
                    Agregar_Cliente auxiliar = new Agregar_Cliente();

                    auxiliar.ShowDialog();
                    ID1.SelectedIndex = auxiliar.INDIE;
                    ID_cliente.Text = auxiliar.line;
                    this.ID1.Enabled = false;
                    this.ID_cliente.Enabled = false;
                    NOSE.Buscar(ID1.SelectedItem.ToString() + ID_cliente.Text);
                    goto FRANCHESCOOOO;
                }
                else
                {
                    this.ID1.Enabled = true;
                    this.ID_cliente.Enabled = true;

                }
            }
            else
            {
                this.ID1.Enabled = false;
                this.ID_cliente.Enabled = false;
                Nombre_Cliente.Text = NOSE.dt_client.Rows[0].Field<string>(1);
            }
        }

        //Cuando se vaya la atencion de la fecha de entrada se produce esta comprobacion
        private void f_entrada_Leave(object sender, EventArgs e)
        {
            f_salida.MinDate = f_entrada.Value.AddDays(1);
            f_salida.Value = f_entrada.Value.AddDays(1);
            if (comboBox1.SelectedIndex != -1) this.Rellenar_habitaciones();
            this.Calculo_Total();
        }

        public void Rellenar_habitaciones()
        {
            okupa.Rellenar_Bas_nost("", "1", comboBox1.SelectedItem.ToString());
            habitaciones.Items.Clear();
            Reservacion_Clase Platano = new Reservacion_Clase();
            string[] conservaDe = Platano.Habitacion_Ocupadas(this.f_entrada.Value.ToString("yyyy-MM-dd"), f_salida.Value.ToString("yyyy-MM-dd"));
            //busco las habitaciones reservadas en ese rango de fecha
            foreach (DataRow actual in okupa.dt_hab.Rows)//recorrerá cada fila del data table
            {
                if ((Array.IndexOf(conservaDe, actual.Field<string>(0))) == -1) //comprueba que la habitacion no esté entre las reservadas
                {
                    habitaciones.Items.Add(actual.Field<string>(0));//agrega a la caja de habitacion
                }

            }
            okupa.dt_hab.Clear();
            label2.Text = habitaciones.Items.Count.ToString();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Rellenar_habitaciones();
        }
        //aqui mando todas las habitacione seleccionadas a la lista de habitaciones a reservar
        private void Agregar_habitacion_a_reservar_Click(object sender, EventArgs e)
        {
            foreach (string actual in habitaciones.SelectedItems)
            {
                if (!Lista_Reservar.Items.Contains(actual)) Lista_Reservar.Items.Add(actual);
            }
        }
        //para eliminar lo seleccionado
        private void button4_Click(object sender, EventArgs e)
        {
            foreach (int numero in Lista_Reservar.SelectedIndices)
            {
                Lista_Reservar.Items.RemoveAt(numero);
            }
        }

        private void f_salida_Leave(object sender, EventArgs e)
        {
            this.Calculo_Total();
            if (comboBox1.SelectedIndex != -1) this.Rellenar_habitaciones();
        }
        public void Calculo_Total()
        {
            int amount = Lista_Reservar.Items.Count;
            if (amount > 0)
            {
                TimeSpan dias = f_salida.Value - f_entrada.Value;
                string[] jefe = new string[amount];
                for (int i = 0; i < amount; i++)
                {
                    jefe[i] = Lista_Reservar.Items[i].ToString();
                }
                decimal cantidad = okupa.Get_Total_Raw(jefe);
                cantidad = cantidad * dias.Days; //Precio total sin descuento
                decimal Descuento_var;
                if (!(Descuento.Text == ""))
                {
                    Descuento_var = Convert.ToDecimal(Descuento.Text);
                    decimal ulysses = (cantidad - (cantidad * (Descuento_var / 100.0M)));
                    //A la cantidad le resto el calculado del descuento
                    Cantidad_total.Text = Math.Round(ulysses, 2).ToString("0.00");
                    //redondeo para 2 decimales y evitar errores
                }
                else
                {
                    Cantidad_total.Text = Math.Round(cantidad, 2).ToString("0.00");
                }
            }
        }

        private void Descuento_Leave(object sender, EventArgs e)
        {
            this.Calculo_Total();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Calculo_Total();
        }

        private void guardar_res_Click(object sender, EventArgs e)
        {
            if ((ID1.Enabled == false) && (Cantidad_total.Text != ""))
            {
                if (Cantidad_total.Text == "##") return;
                Reservacion_Clase reser = new Reservacion_Clase();
                reser.Numero_Cliente = ID1.SelectedItem.ToString() + ID_cliente.Text;
                reser.Salida = f_salida.Value;
                reser.Entrada = f_entrada.Value;
                reser.Usuario = Usuario_Actual.Nombre;
                reser.Total = Convert.ToDecimal(Cantidad_total.Text);
                string arroz;
                if (Descuento.Text == "") arroz = "0"; else arroz = Descuento.Text;
                reser.Descuento = Convert.ToDecimal(arroz);
                string[] array = new string[Lista_Reservar.Items.Count];
                Lista_Reservar.Items.CopyTo(array, 0);
                string pollo_Lavenganza = reser.Insertar(array);
                Bitacora bit = new Bitacora();
                bit.Accion = "Insertar";
                bit.Codigo = pollo_Lavenganza;
                bit.Modulo = "Reservacion";
                bit.Usuario = Usuario_Actual.Nombre;
                BoxMessage muuu = new BoxMessage();
                muuu.Aviso_arriba.Text = "Registro completado";
                muuu.Cuerpo_men.Text = "¿Desea imprimir el comprobante?";
                muuu.ShowDialog();
                if (muuu.Condicion)
                {
                    Ticket_p p = new Ticket_p(reser.Numero_Cliente, pollo_Lavenganza,
                    DateTime.Now.ToShortDateString(), f_entrada.Value.ToShortDateString(), f_salida.Value.ToShortDateString(), reser.Descuento.ToString(), reser.Total.ToString());
                }
                bit.Insertar();
                this.restart_New();
            }
            else MessageBox.Show("No debe dejar ningun campo vacio", "Procedimiento invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.restart_New();
        }

        private void Descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Creo un arreglo con todas las teclas que estan permitidas.
            var validos = new[] { Keys.Delete, Keys.Decimal, Keys.Back, Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9 };
            //la propiedad handled indica si permite que entre el caracter (false) o no (true)
            //se verifica que lo presionado sea un numero o borrar, de ser asi tira true, se convierte a false y el caracter entra
            e.Handled = !validos.Contains((Keys)e.KeyChar);
        }








        //Termina lo relacionado a nuevas reservaciones


    }
}
