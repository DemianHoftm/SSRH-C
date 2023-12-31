namespace SRRH
{
    public partial class Login : Form
    {
        public usuario ingreso;
        public bool acceso; //aqui se guardara si se permite o no acceder
        public Login()
        {
            InitializeComponent();
            acceso = false;
            ingreso = new usuario();
            this.pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(enter);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.login();
        }

        public void login()
        {

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

                            this.Close();
                        }
                        else
                        {
                            acceso = true; //aqui se ingresa como si fuese cajero

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.login();
            }
        }
    }
}