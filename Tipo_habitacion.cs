using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SRRH
{
    public partial class Tipo_habitacion : Form
    {
        Tipo_hab tip_h;
        ErrorProvider error;
        public Tipo_habitacion()
        {
            InitializeComponent();
            tip_h = new Tipo_hab();
            error = new ErrorProvider();
            Startup();
        }


        private void Startup()
        {
            Tabla.Rows.Clear();
            aregar_btn.Enabled = true;
            editar_btn.Enabled = false;

            Total_hab.Text = "##";
            tipo.Text = "";
            precio.Text = "";
            capa.Text = "";
            Eliminados.Text = "Eliminados";
            Eliminar.Text = "Eliminar";
            Eliminar.Enabled = false;
            tip_h.rellenar("1");
            Rellenar();
        }

        private void Rellenar()
        {
            this.Tabla.Rows.Clear();
            string auxiliar = "";
            foreach (DataRow actual in tip_h.dt_tip.Rows)//recorrerá cada fila del data table
            {
                Tabla.Rows.Add(
                actual.Field<string>(0),
                actual.Field<string>(1),
                actual.Field<decimal>(2),
                actual.Field<Int32>(3),
                auxiliar);//Se añade la nueva columna

            }
            tip_h.dt_tip.Clear(); //limpiar la datatable para evitar problemas futuros
        }

        //Esto es un evento que se activa siempre que se escribe al textbox de precio
        //Su objetivo sera no permitir que se escriban contenidos diferentes a numeros
        private void Solo_Numeros_Allowed(object sender, KeyPressEventArgs e)
        {
            //Creo un arreglo con todas las teclas que estan permitidas.
            var validos = new[] { Keys.Delete, Keys.Decimal, Keys.Back, Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9 };
            //la propiedad handled indica si permite que entre el caracter (false) o no (true)
            //se verifica que lo presionado sea un numero o borrar, de ser asi tira true, se convierte a false y el caracter entra
            e.Handled = !validos.Contains((Keys)e.KeyChar);
        }
        private void Solo_Numeros_Allowed_ND(object sender, KeyPressEventArgs e)
        {
            //Creo un arreglo con todas las teclas que estan permitidas.
            var validos = new[] { Keys.Delete, Keys.Back, Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9 };
            //la propiedad handled indica si permite que entre el caracter (false) o no (true)
            //se verifica que lo presionado sea un numero o borrar, de ser asi tira true, se convierte a false y el caracter entra
            e.Handled = !validos.Contains((Keys)e.KeyChar);
        }




        private void Tabla_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow auxiliar = this.Tabla.SelectedRows[0];
            Total_hab.Text = auxiliar.Cells[0].Value.ToString();
            tipo.Text = auxiliar.Cells[1].Value.ToString();
            Eliminar.Enabled = true;
            precio.Text = auxiliar.Cells[2].Value.ToString();
            capa.Text = auxiliar.Cells[3].Value.ToString();
            aregar_btn.Enabled = false;
            editar_btn.Enabled = true;

        }

        private void Startup(object sender, EventArgs e)
        {
            this.Startup();
        }


        private bool Comprobar()
        {
            bool aux = true;
            if (this.precio.Text == "")
            {
                error.SetError(precio, "no se puede dejar vacio");
                aux = false;
            }
            else
            {
                error.SetError(precio, "");
            }
            if (this.tipo.Text == "")
            {
                error.SetError(tipo, "no se puede dejar vacio");
                aux = false;
            }
            else
            {
                error.SetError(tipo, "");
            }
            if (this.precio.Text == "")
            {
                error.SetError(precio, "no se puede dejar vacio");
                aux = false;
            }
            else
            {
                error.SetError(precio, "");
            }
            return aux;
        }

        private void aregar_btn_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {

                BoxMessage muuu = new BoxMessage();
                muuu.Aviso_arriba.Text = "Confirmacion de operacion";
                muuu.Cuerpo_men.Text = "¿Desea agregar estos datos?";
                muuu.ShowDialog();
                if (!muuu.Condicion) return;
                tip_h.Nombre = tipo.Text;
                tip_h.Precio = Convert.ToSingle(precio.Text);
                tip_h.Num_Per = Convert.ToInt16(capa.Text);
                tip_h.Insertar();
                muuu.Aviso_arriba.Text = "Operacion completada";
                muuu.Cuerpo_men.Text = "Se ha agregado el tipo de habitacion satisfactoriamente";
                muuu.si.Visible = false;
                muuu.no.Text = "Ok";
                muuu.ShowDialog();
                this.Startup();
            }
        }

        private void editar_btn_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                BoxMessage muuu = new BoxMessage();
                muuu.Aviso_arriba.Text = "Confirmacion de operacion";
                muuu.Cuerpo_men.Text = "¿Desea editar estos datos?";
                muuu.ShowDialog();
                if (!muuu.Condicion) return;
                tip_h.ID = Total_hab.Text;
                tip_h.Nombre = tipo.Text;
                tip_h.Precio = Convert.ToSingle(precio.Text);
                tip_h.Num_Per = Convert.ToInt16(capa.Text);
                tip_h.Actualizar();
                muuu.Aviso_arriba.Text = "Operacion completada";
                muuu.Cuerpo_men.Text = "Se ha editado el tipo de habitacion satisfactoriamente";
                muuu.si.Visible = false;
                muuu.no.Text = "Ok";
                muuu.ShowDialog();
                this.Startup();
            }
        }

        private void Eliminados_Click(object sender, EventArgs e)
        {
            if (Eliminados.Text == "Eliminados")
            {
                tip_h.rellenar("0");
                this.Rellenar();
                Eliminar.Text = "Recuperar";
                this.Eliminados.Text = "Activos";
                this.Eliminar.IconChar = FontAwesome.Sharp.IconChar.Circle;
            }
            else this.Startup();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (this.Eliminar.Text == "Recuperar")
            {
                tip_h.ID = Total_hab.Text;
                tip_h.Eliminar("1");
                this.Startup();
            }
            else
            {
                tip_h.ID = Total_hab.Text;
                tip_h.Eliminar("0");
                this.Startup();
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
