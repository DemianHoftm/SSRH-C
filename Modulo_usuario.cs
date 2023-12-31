using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SRRH
{
    public partial class Modulo_usuario : Form
    {

        private ErrorProvider Errores;
        private usuario Aux_usu;
        private string nombre_actual;
        public Modulo_usuario(string Usuario_actual)
        {
            InitializeComponent();
            this.aregar_btn.Click += new EventHandler(aregar_btn_Click);
            this.Tabla.DoubleClick += new EventHandler(Seleccion);
            this.restart_btn.Click += new EventHandler(Borrador_event);
            nombre_actual = Usuario_actual;
            Aux_usu = new usuario();


            Errores = new ErrorProvider();
            this.Start_Up();
        }

        private void Borrador_event(object sender, EventArgs e)
        {
            this.Start_Up();
        }

        public void Start_Up()
        {
            this.Nombre.Clear();
            this.contra.Clear();
            this.checkBox1.Checked = false;
            this.editar_btn.Enabled = false;
            this.eliminar_btn.Enabled = false;
            this.aregar_btn.Enabled = true;
            this.Nombre.Enabled = true;
            this.eliminar_btn.Text = "ELIMINAR";
            Aux_usu.Consulta("", 1); //tomara unicamente a los que son activos
            this.Llenar_Tabla();
            Errores.Clear();
        }




        public void Llenar_Tabla()//Esta funcion es para llenar la tabla mediante el dataTable
        {
            this.Tabla.Rows.Clear();
            string auxiliar = "";
            foreach (DataRow actual in Aux_usu.dtusu.Rows)//recorrerá cada fila del data table
            {
                if (actual.Field<string>(2) == "1")//asigna si es activo o inactivo
                {
                    auxiliar = "Activo";
                }
                else
                {
                    auxiliar = "Inactivo";
                }

                Tabla.Rows.Add(
                actual.Field<string>(0),
                actual.Field<string>(1),
                auxiliar);//Se añade la nueva columna

            }
            Aux_usu.dtusu.Clear(); //limpiar la datatable para evitar problemas futuros

        }

        private void Seleccion(object sender, EventArgs e)
        {
            DataGridViewRow auxiliar = this.Tabla.SelectedRows[0];
            Nombre.Text = auxiliar.Cells[0].Value.ToString();
            if (auxiliar.Cells[2].Value.ToString() == "Activo")
            {
                checkBox1.Checked = true;
                this.eliminar_btn.Text = "ELIMINAR";
            }
            else
            {
                checkBox1.Checked = false;
                this.eliminar_btn.Text = "HABILITAR";
            }
            this.eliminar_btn.Enabled = true;
            this.Nombre.Enabled = false;
            this.aregar_btn.Enabled = false;
            this.editar_btn.Enabled = true;
            this.checkBox1.Enabled = true;
            if (auxiliar.Cells[1].Value.ToString() == "ADMINISTRADOR")
            {
                this.comboBox1.SelectedIndex = 1;
            }
            else
            {
                this.comboBox1.SelectedIndex = 0;

            }
        }



        private void aregar_btn_Click(object sender, EventArgs e)
        {
            bool auxiliar = true;

            if ((this.Nombre.Text.Length >= 1) && (this.Nombre.Text.Length <= 12))
            {
                if (Aux_usu.Buscar_Nom(Nombre.Text))
                {
                    Errores.SetError(this.Nombre, "Ya existe un usuario con este nombre");
                    auxiliar = false;
                    Aux_usu.dt_usu.Clear();
                }
                else
                {
                    Errores.SetError(this.Nombre, "");
                }

            }
            else
            {
                Errores.SetError(this.Nombre, "Introduzca un valor entre 1 y 12 caracteres");
                auxiliar = false;
            }
            if ((this.contra.Text.Length >= 1) && (this.contra.Text.Length <= 12))
            {
                Errores.SetError(this.Nombre, "");
            }
            else
            {
                Errores.SetError(this.contra, "Introduzca un valor entre 1 y 9 caracteres");
                auxiliar = false;
            }

            if (auxiliar)
            {
                BoxMessage muuu = new BoxMessage();
                muuu.Aviso_arriba.Text = "Confirmacion de operacion";
                muuu.Cuerpo_men.Text = "¿Desea agregar estos datos?";
                muuu.ShowDialog();
                if (!muuu.Condicion) return;
                Aux_usu.Nombre = Nombre.Text;
                Aux_usu.Pass = contra.Text;
                Aux_usu.Guardar();
                muuu.Aviso_arriba.Text = "Operacion completada";
                muuu.Cuerpo_men.Text = "Se ha guardado el usuario satisfactoriamente";
                muuu.si.Visible = false;
                muuu.no.Text = "Ok";
                muuu.ShowDialog();
                this.Start_Up();
            }

        }

        private void contra_MouseEnter(object sender, EventArgs e)
        {
            this.contra.UseSystemPasswordChar = false;
        }

        private void contra_MouseLeave(object sender, EventArgs e)
        {
            this.contra.UseSystemPasswordChar = true;
        }

        private void editar_btn_Click(object sender, EventArgs e)
        {
            bool auxiliar = true;
            if ((this.contra.Text.Length >= 1) && (this.contra.Text.Length <= 12))
            {
                Errores.SetError(this.Nombre, "");
            }
            else
            {
                Errores.SetError(this.contra, "Introduzca un valor entre 1 y 9 caracteres");
                auxiliar = false;
            }

            if (auxiliar)
            {
                Aux_usu.Nombre = Nombre.Text;
                Aux_usu.Pass = contra.Text;
                if (checkBox1.Enabled)
                {
                    Aux_usu.Estado = 1;
                }
                else
                {
                    Aux_usu.Estado = 0;
                }
                BoxMessage muuu = new BoxMessage();
                muuu.Aviso_arriba.Text = "Confirmacion de operacion";
                muuu.Cuerpo_men.Text = "¿Desea actualizar estos datos?";
                muuu.ShowDialog();
                if (!muuu.Condicion) return;
                Aux_usu.Rol = Convert.ToInt16(comboBox1.SelectedIndex.ToString());
                Aux_usu.Actualizar();
                muuu.Aviso_arriba.Text = "Operacion completada";
                muuu.Cuerpo_men.Text = "Se ha actualizado el usuario satisfactoriamente";
                muuu.si.Visible = false;
                muuu.no.Text = "Ok";
                muuu.ShowDialog();
                this.Start_Up();

            }
        }

        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            if (nombre_actual == Nombre.Text)
            {
                MessageBox.Show("No se puede eliminar a si mismo");
                return;
            }
            string recup;
            Aux_usu.Nombre = Nombre.Text;
            string cambio_estado = "";
            DataGridViewRow auxiliar = this.Tabla.SelectedRows[0];
            if (auxiliar.Cells[2].Value.ToString() == "Activo")
            {
                cambio_estado = "0";
                recup = "desactivado";
            }
            else
            {
                recup = "activado";
                cambio_estado = "1"; //Se invierte para que se actualice el estado
            }
            BoxMessage muuu = new BoxMessage();
            muuu.Aviso_arriba.Text = "Confirmacion de operacion";
            muuu.Cuerpo_men.Text = "¿Desea continuar?";
            muuu.ShowDialog();
            if (!muuu.Condicion) return;
            Aux_usu.Eliminar(cambio_estado);
            muuu.Aviso_arriba.Text = "Operacion completada";
            muuu.Cuerpo_men.Text = "Se ha " + recup + " el usuario satisfactoriamente";
            muuu.si.Visible = false;
            muuu.no.Text = "Ok";
            muuu.ShowDialog();
            this.Start_Up();
        }

        private void Consultar_btt_Click(object sender, EventArgs e)
        {
            Int16 Consulta_estado; //Auxiliar para estado
            if (checkBox1.Checked)
            {
                Consulta_estado = 1;
            }
            else
            {
                Consulta_estado = 0;
            }
            Aux_usu.Consulta(this.Nombre.Text, Consulta_estado);
            this.Llenar_Tabla();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }




}
