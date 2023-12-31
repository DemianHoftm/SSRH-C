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
    public partial class Modulo_cliente : Form
    {
        private ErrorProvider Errores;
        private Cliente_Clase clint;
        public Modulo_cliente()
        {
            InitializeComponent();
            clint = new Cliente_Clase();

            Errores = new ErrorProvider();
            this.Start_up();
        }


        public void Start_up()
        {
            clint.dt_client.Clear();
            Tabla.Rows.Clear();
            this.ID.Clear();
            this.nombre.Clear();
            this.correo.Clear();
            this.telef.Clear();
            this.editar_btn.Enabled = false;
            this.eliminar_btn.Enabled = false;
            this.aregar_btn.Enabled = true;
            eliminar_btn.Text = "ELIMINAR";
            clint.rellenar("", "1", ""); //paso 1 y string vacios para que se seleccione a todos los clientes
            this.Rellenar_tabla();
            this.ID1.SelectedIndex = 0;
            Errores.Clear();
        }

        public void Rellenar_tabla()
        {
            foreach (DataRow actual in clint.dt_client.Rows)
            {
                Tabla.Rows.Add(
                    actual.Field<string>(0),
                    actual.Field<string>(1),
                    actual.Field<string>(2),
                    actual.Field<string>(3)
                    );
            }
            clint.dt_client.Clear();//limpiar la tabla
        }

        //Esto es un evento que se activa siempre que se escribe al textbox de id
        //Su objetivo sera no permitir que se escriban contenidos diferentes a numeros
        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Creo un arreglo con todas las teclas que estan permitidas.
            var validos = new[] { Keys.Delete, Keys.Back, Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9 };
            //la propiedad handled indica si permite que entre el caracter (false) o no (true)
            //se verifica que lo presionado sea un numero o borrar, de ser asi tira true, se convierte a false y el caracter entra
            e.Handled = !validos.Contains((Keys)e.KeyChar);

        }

        private void Inicio_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            this.Start_up();
        }

        private void aregar_btn_Click(object sender, EventArgs e)
        {
            bool aux = true;
            //Verifica el id
            if ((this.ID.Text.Length >= 1) && (this.ID.Text.Length <= 14))
            {
                if (clint.Buscar(this.ID1.SelectedItem.ToString() + this.ID.Text))
                {
                    Errores.SetError(this.ID, "Ya existe un usuario con este nombre");
                    aux = false;
                    clint.dt_client.Clear();
                }
                else
                {
                    Errores.SetError(this.ID, "");
                }
            }
            else
            {
                Errores.SetError(this.ID, "Ingrese un valor de entre 1 y 14");
                aux = false;
            }
            //verifica el nombre
            if ((this.nombre.Text.Length >= 1) && (this.nombre.Text.Length <= 30))
            {
                Errores.SetError(this.nombre, "");
            }
            else
            {
                Errores.SetError(this.nombre, "Ingrese un valor de entre 1 y 30");
                aux = false;
            }
            //verifica el telefono
            if ((this.telef.Text.Length >= 1) && (this.telef.Text.Length <= 14))
            {
                Errores.SetError(this.telef, "");
            }
            else
            {
                Errores.SetError(this.telef, "Ingrese un valor de entre 1 y 14");
                aux = false;
            }
            //verifica el correo
            if ((this.correo.Text.Length >= 1) && (this.correo.Text.Length <= 45))
            {
                Errores.SetError(this.correo, "");
            }
            else
            {
                Errores.SetError(this.correo, "Ingrese un valor de entre 1 y 45");
                aux = false;
            }

            if (aux)
            {

                clint.ID = this.ID1.SelectedItem.ToString() + this.ID.Text;
                clint.Nombre = this.nombre.Text;
                clint.Telefono = this.telef.Text;
                clint.Correo = this.correo.Text;
                BoxMessage muuu = new BoxMessage();
                muuu.Aviso_arriba.Text = "Confirmacion de operacion";
                muuu.Cuerpo_men.Text = "¿Desea agregar estos datos?";
                muuu.ShowDialog();
                if (!muuu.Condicion) return;

                clint.Insertar();
                muuu.Aviso_arriba.Text = "Operacion completada";
                muuu.Cuerpo_men.Text = "Se ha agregado la habitacion satisfactoriamente";
                muuu.si.Visible = false;
                muuu.no.Text = "Ok";
                muuu.ShowDialog();
                this.Start_up();

            }


        }

        private void button1_Click(object sender, EventArgs e)//consulta
        {
            string Consulta_estado; //Auxiliar para estado
            if (checkBox1.Checked)
            {
                Consulta_estado = "1";
            }
            else
            {
                Consulta_estado = "0";
            }
            clint.rellenar(this.nombre.Text, Consulta_estado, this.ID1.SelectedItem.ToString() + this.ID.Text);
            Tabla.Rows.Clear();
            this.Rellenar_tabla();
        }

        private void Tabla_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow auxiliar = this.Tabla.SelectedRows[0];
            string combo = auxiliar.Cells[0].Value.ToString().Substring(0, 2);
            this.ID1.SelectedIndex = 0;
            switch (combo)
            {
                case string x when x == "J-":
                    {
                        this.ID1.SelectedIndex = 2;
                        break;
                    };
                case string x when x == "V-":
                    {
                        this.ID1.SelectedIndex = 0;
                        break;
                    };
                case string x when x == "E-":
                    {
                        this.ID1.SelectedIndex = 1;
                        break;
                    };

            }
            ID.Text = auxiliar.Cells[0].Value.ToString().Substring(2);
            nombre.Text = auxiliar.Cells[1].Value.ToString();
            telef.Text = auxiliar.Cells[2].Value.ToString();
            correo.Text = auxiliar.Cells[3].Value.ToString();
            clint.Recupera(auxiliar.Cells[0].Value.ToString());
            ID.Enabled = false;
            ID1.Enabled = false;
            aregar_btn.Enabled = false;
            editar_btn.Enabled = true;
            eliminar_btn.Enabled = true;
            if (clint.Estado == "1")
            {
                eliminar_btn.Text = "ELIMINAR";
            }
            else
            {
                eliminar_btn.Text = "RECUPERAR";
            }
        }

        private void Tabla_Click(object sender, EventArgs e)
        {
            this.eliminar_btn.Enabled = true;
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow auxiliar = this.Tabla.SelectedRows[0];
            clint.Recupera(auxiliar.Cells[0].Value.ToString());
            string cambio_variable, rec;
            if (clint.Estado == "1")
            {
                rec = "activado";
                cambio_variable = "0";
            }
            else
            {
                rec = "desactivado";
                cambio_variable = "1";
            }
            BoxMessage muuu = new BoxMessage();
            muuu.Aviso_arriba.Text = "Confirmacion de operacion";
            muuu.Cuerpo_men.Text = "¿Desea editar estos datos?";
            muuu.ShowDialog();
            if (!muuu.Condicion) return;
            clint.Eliminar(cambio_variable);
            muuu.Aviso_arriba.Text = "Operacion completada";
            muuu.Cuerpo_men.Text = "Se ha " + rec + " el cliente satisfactoriamente";
            muuu.si.Visible = false;
            muuu.no.Text = "Ok";
            muuu.ShowDialog();
            this.Start_up();
        }

        private void editar_btn_Click(object sender, EventArgs e)
        {
            bool aux = true;
            //verifica el nombre
            if ((this.nombre.Text.Length >= 1) && (this.nombre.Text.Length <= 30))
            {
                Errores.SetError(this.nombre, "");
            }
            else
            {
                Errores.SetError(this.nombre, "Ingrese un valor de entre 1 y 30");
                aux = false;
            }
            //verifica el telefono
            if ((this.telef.Text.Length >= 1) && (this.telef.Text.Length <= 14))
            {
                Errores.SetError(this.telef, "");
            }
            else
            {
                Errores.SetError(this.telef, "Ingrese un valor de entre 1 y 14");
                aux = false;
            }
            //verifica el correo
            if ((this.correo.Text.Length >= 1) && (this.correo.Text.Length <= 45))
            {
                Errores.SetError(this.correo, "");
            }
            else
            {
                Errores.SetError(this.correo, "Ingrese un valor de entre 1 y 45");
                aux = false;
            }

            if (aux)
            {
                BoxMessage muuu = new BoxMessage();
                muuu.Aviso_arriba.Text = "Confirmacion de operacion";
                muuu.Cuerpo_men.Text = "¿Desea editar estos datos?";
                muuu.ShowDialog();
                if (!muuu.Condicion) return;
                clint.ID = this.ID1.SelectedItem.ToString() + this.ID.Text;
                clint.Nombre = this.nombre.Text;
                clint.Telefono = this.telef.Text;
                clint.Correo = this.correo.Text;

                clint.Actualizar();
                muuu.Aviso_arriba.Text = "Operacion completada";
                muuu.Cuerpo_men.Text = "Se ha actualizado el cliente satisfactoriamente";
                muuu.si.Visible = false;
                muuu.no.Text = "Ok";
                this.Start_up();



            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
