using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRRH
{
    public partial class Modulo_habitacion : Form
    {
        Tipo_hab tipos;
        Habitacion_clase hab;
        ErrorProvider error;
        public Modulo_habitacion()
        {
            InitializeComponent();
            tipos = new Tipo_hab();
            hab = new Habitacion_clase();
            error = new ErrorProvider();

            this.startup();
        }




        //Funcion para poner todo a la normalidad
        public void startup()
        {

            Tabla.Rows.Clear();
            No_Hosp.Text = "";
            No_Hosp.Enabled = true;
            tipos.dt_tip.Clear();
            ID1.Items.Clear();
            tipos.rellenar("1");
            foreach (DataRow actual in tipos.dt_tip.Rows)
            {
                ID1.Items.Add(actual.Field<string>(1));
            }
            this.editar_btn.Enabled = false;
            ID1.SelectedItem = null;
            ID1.SelectedIndex = -1;
            ID1.SelectedText = "";
            Eliminar.Enabled = false;
            Eliminar.Text = "DESACTIVAR";
            Consultar_btt.Enabled = true;
            aregar_btn.Enabled = true;
            error.Clear();
            hab.Rellenar_Bas("1");
            this.rellenar_tabla();
        }
        public void rellenar_tabla()
        {
            this.Tabla.Rows.Clear();
            string auxiliar = "";
            foreach (DataRow actual in hab.dt_hab.Rows)//recorrerá cada fila del data table
            {
                if (actual.Field<string>(2) == "1")
                {
                    auxiliar = "DISPONIBLE";
                }
                else auxiliar = "MANTENIMIENTO";

                Tabla.Rows.Add(
                actual.Field<string>(0), //numero de habitacion
                actual.Field<string>(1), //nombre del tipo
                auxiliar);//Se añade la nueva columna
            }
            hab.dt_hab.Clear();//esto es para contar las habitaciones
            if (ID1.SelectedIndex != -1)
            {
                int[] aux = hab.Get_Cantidad(ID1.SelectedItem.ToString());
                this.Cantidad_contador.Text = ID1.SelectedItem.ToString() + " total de " + Convert.ToString(aux[0] + aux[1]) + " , " + Convert.ToString(aux[1]) + " funcionales";
            }
            else
            {

                this.Cantidad_contador.Text = " total de Habitaciones funcionales: " + Convert.ToString(Tabla.Rows.Count);
            }
        }

        private void No_Hosp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Creo un arreglo con todas las teclas que estan permitidas.
            var validos = new[] { Keys.Delete, Keys.Back, Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9 };
            //la propiedad handled indica si permite que entre el caracter (false) o no (true)
            //se verifica que lo presionado sea un numero o borrar, de ser asi tira true, se convierte a false y el caracter entra
            e.Handled = !validos.Contains((Keys)e.KeyChar);
        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            this.startup();
        }

        private void aregar_btn_Click(object sender, EventArgs e)
        {
            bool aux = true;
            if (hab.comprobar_numero(No_Hosp.Text))
            {
                aux = false;
                error.SetError(No_Hosp, "este numero de habitacion ya existe");
            }
            else error.SetError(No_Hosp, "");
            if (ID1.SelectedIndex == -1)
            {
                aux = false;
                error.SetError(ID1, "seleccione uno");
            }
            else error.SetError(ID1, "");
            hab.dt_hab.Clear();
            if (aux)
            {
                BoxMessage muuu = new BoxMessage();
                muuu.Aviso_arriba.Text = "Confirmacion de operacion";
                muuu.Cuerpo_men.Text = "¿Desea agregar estos datos?";
                muuu.ShowDialog();
                if (!muuu.Condicion) return;
                hab.Numero = No_Hosp.Text;
                hab.ID = tipos.Buscar(ID1.SelectedItem.ToString());
                hab.insertar();

                muuu.Aviso_arriba.Text = "Operacion completada";
                muuu.Cuerpo_men.Text = "Se ha agregado la habitacion satisfactoriamente";
                muuu.si.Visible = false;
                muuu.no.Text = "Ok";
                muuu.ShowDialog();
                this.startup();
            }

        }

        private void Tabla_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow auxiliar = this.Tabla.SelectedRows[0];
            No_Hosp.Text = auxiliar.Cells[0].Value.ToString();
            No_Hosp.Enabled = false;
            int prueba = ID1.FindString(auxiliar.Cells[1].Value.ToString());
            ID1.SelectedIndex = prueba;
            aregar_btn.Enabled = false;
            Eliminar.Enabled = true;
            editar_btn.Enabled = true;
            Consultar_btt.Enabled = false;
            if (auxiliar.Cells[2].Value.ToString() == "DISPONIBLE")
            {
                Eliminar.Text = "DESACTIVAR";
                Eliminar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            }
            else
            {
                Eliminar.Text = "ACTIVAR";
                Eliminar.IconChar = FontAwesome.Sharp.IconChar.Circle;
            }
        }

        private void editar_btn_Click(object sender, EventArgs e)
        {
            bool aux = true;
            if (ID1.SelectedIndex == -1)
            {
                aux = false;
                error.SetError(ID1, "seleccione uno");
            }
            else error.SetError(ID1, "");
            BoxMessage muuu = new BoxMessage();
            muuu.Aviso_arriba.Text = "Confirmacion de operacion";
            muuu.Cuerpo_men.Text = "¿Desea editar estos datos?";
            muuu.ShowDialog();
            if (!muuu.Condicion) return;
            hab.Numero = No_Hosp.Text;
            hab.ID = tipos.Buscar(ID1.SelectedItem.ToString());
            hab.Actualizar(hab.ID);
            muuu.Aviso_arriba.Text = "Operacion completada";
            muuu.Cuerpo_men.Text = "Se ha actualizado la habitacion satisfactoriamente";
            muuu.si.Visible = false;
            muuu.no.Text = "Ok";
            muuu.ShowDialog();
            this.startup();
        }

        private void Consultar_btt_Click(object sender, EventArgs e)
        {
            string auxiliar_consulta;
            if (checkBox1.Checked == true) auxiliar_consulta = "1"; else auxiliar_consulta = "0";
            string auxiliar_tipo;
            if ((ID1.SelectedIndex == -1) && (No_Hosp.Text == ""))
            {
                hab.Rellenar_Bas(auxiliar_consulta);
            }
            else
            {
                auxiliar_tipo = ID1.SelectedItem.ToString();
                hab.Rellenar_Bas_nost(No_Hosp.Text, auxiliar_consulta, auxiliar_tipo);
            }

            this.rellenar_tabla();

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {


            string cambio, rec;
            if (this.Tabla.SelectedRows[0].Cells[2].Value.ToString() == "DISPONIBLE")
            {
                rec = "desactivado";
                cambio = "0";
            }
            else { cambio = "1"; rec = "activado"; }
            BoxMessage muuu = new BoxMessage();
            muuu.Aviso_arriba.Text = "Confirmacion de operacion";
            muuu.Cuerpo_men.Text = "¿Desea oriceder la operacion?";
            muuu.ShowDialog();
            if (!muuu.Condicion) return;
            hab.Cambio_Estado(No_Hosp.Text, cambio);
            muuu.Aviso_arriba.Text = "Operacion completada";
            muuu.Cuerpo_men.Text = "Se ha " + rec + " la habitacion satisfactoriamente";
            muuu.si.Visible = false;
            muuu.no.Text = "Ok";
            muuu.ShowDialog();
            this.startup();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
