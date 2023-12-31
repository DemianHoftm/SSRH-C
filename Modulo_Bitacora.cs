using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRRH
{
    public partial class Modulo_Bitacora : Form
    {
        private Bitacora bit;
        public Modulo_Bitacora()
        {
            InitializeComponent();
            bit = new Bitacora();
            this.startup();
            usuario pezRaya2 = new usuario();
            pezRaya2.Consulta("", 1);
            foreach (DataRow actual in pezRaya2.dtusu.Rows)
            {
                usuario_consul.Items.Add(actual.Field<string>(0));
            }
        }








        public void rellenar()
        {
            Tabla.Rows.Clear();
            foreach (DataRow actual in bit.dt_bit.Rows)//recorrerá cada fila del data table
            {


                Tabla.Rows.Add(
                actual.Field<string>(0), //accion
                actual.Field<string>(1), //usuario
                actual.Field<string>(2),//Modulo
                actual.Field<string>(3), // codigo
                actual.Field<DateTime>(4).ToShortDateString); //fecha

                //Se añade la nueva columna
            }
            bit.dt_bit.Rows.Clear();
        }
        public void startup()
        {
            this.usuario_consul.SelectedIndex = 0;
            this.acce.SelectedIndex = 0;
            this.modulo.SelectedIndex = 0;
            rango2.MinDate = rango2.MinDate.AddDays(1);
            rango1.Value = DateTime.Now;
            rango2.Value = DateTime.Now.AddDays(1);
            Tabla.Rows.Clear();
        }

        private void rango1_Leave(object sender, EventArgs e)
        {
            rango2.Value = rango1.Value;
            rango2.MinDate = rango1.Value.AddDays(1);
        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            this.startup();
        }

        private void Consultar_btt_Click(object sender, EventArgs e)
        {
            if ((usuario_consul.SelectedIndex == 0) && (acce.SelectedIndex == 0) && (modulo.SelectedIndex == 0))
            {
                bit.rellenar(rango1.Value.ToString("yyyy-MM-dd"), rango2.Value.ToString("yyyy-MM-dd"));
                goto fiuuuuuu;
            }
            else
            {
                string urano, anfitrion, zeus;
                if (acce.SelectedIndex == 0) zeus = null; else zeus = acce.SelectedItem.ToString();
                if (usuario_consul.SelectedIndex == 0) anfitrion = null; else anfitrion = usuario_consul.SelectedItem.ToString();
                if (modulo.SelectedIndex == 0) urano = null; else urano = modulo.SelectedItem.ToString();
                bit.rellenar(zeus, urano, anfitrion, rango1.Value.ToString("yyyy-MM-dd"), rango2.Value.ToString("yyyy-MM-dd"));
                goto fiuuuuuu;
            }

        fiuuuuuu:
            this.rellenar();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
