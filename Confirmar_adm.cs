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
    public partial class Confirmar_adm : Form
    {
        public string usuario;
        public bool acceso;
        public Confirmar_adm()
        {
            InitializeComponent();
            this.pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(enter);
        }
        public void login()
        {
            usuario ingreso = new usuario();
            if (ingreso.Buscar_Login(nom.Text))
            {

                if (ingreso.Estado == 0)
                {
                    MessageBox.Show("El usuario está inhabilitado");

                }
                else
                {


                    if (ingreso.Pass == pass.Text)
                    {
                        if (ingreso.Rol == 1)
                        {
                            acceso = true;// Indica al programa si es posible acceder al inicio
                            usuario = ingreso.Nombre;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("USted no cuenta con los privilegios necesarios");
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("clave invalida"); //Mensaje de clave invalida
                        acceso = false; //Indico false para indicar que no debe acceder

                    }
                }
            }
            else
            {
                acceso = false; //Indico false para indicar que no debe acceder
                MessageBox.Show("Usuario invalido");
            }
        }
        private void enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.login();
            }
        }
        private void Agregar_habitacion_a_reservar_Click(object sender, EventArgs e)
        {
            this.login();
        }
    }
}
