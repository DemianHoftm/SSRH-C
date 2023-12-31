using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRRH
{
    internal class Transferencia_clase
    {
        private string referencia_pago, banco;
        private DBAccess Acceso;
        public DataTable transDT;
        public string Banco { get { return banco; } set { banco = value; } }
        public string Referencia { get { return referencia_pago; } set { referencia_pago = value; } }
        
        public Transferencia_clase()
        {
            Acceso = new DBAccess();
            transDT = new DataTable();
        }

        public void Insertar() {
            SqlCommand insertar = new SqlCommand("INSERT INTO Transferencia " +
                "(Ref, Banco)" +
                " VALUES (@ref, @banc)");
            insertar.Parameters.AddWithValue("@ref", this.Referencia);//ojo aqui, es la reserva
            insertar.Parameters.AddWithValue("@banc", this.Banco);
            Acceso.executeQuery(insertar);
        }

    }
}
