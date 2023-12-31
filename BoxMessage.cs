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
    public partial class BoxMessage : Form
    {
        public bool Condicion;
        public BoxMessage()
        {
            InitializeComponent();
        }

        private void si_Click(object sender, EventArgs e)
        {
            Condicion = true;
            this.Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            Condicion = false;
            this.Close();
        }
    }
}
