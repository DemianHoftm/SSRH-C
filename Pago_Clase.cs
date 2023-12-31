using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRRH
{
    internal class Pago_Clase
    {
        private string _idref, id_ref, _estado, nom_usu, ref_pago;
        private decimal importe;
        private DateTime realizado;
        public Transferencia_clase Transferencia;
        public string ID { get { return _idref; } set { _idref = value; } }
        public DateTime Realizado_F { get { return realizado; } set { realizado = value; } }
        public string ID_Reserv { get { return id_ref; } set { id_ref = value; } }
        public string Estado { get { return _estado; } set { _estado = value; } }
        public string Usuario { get { return nom_usu; } set { nom_usu = value; } }
        public string Referencia_Pago { get { return ref_pago; } set { ref_pago = value; } }
        public decimal Importe { get { return importe; } set { importe = value; } }

        private DBAccess Acceso;
        public DataTable pagoDT;

        public Pago_Clase() {
            Acceso = new DBAccess();
            pagoDT = new DataTable();
            Transferencia = new Transferencia_clase();
        }

        //funcion para tener los ingresos por mes
        public void Get_ingreso_Anual(string ano) {
            string seleccion = "SELECT MONTH(R.Fech_Entr) ,SUM(P.Importe) " +
                "from Pago AS P INNER JOIN Reservacion AS R ON P.ID_Reser = R.ID_Reser " +
                "where YEAR(R.Fech_Entr) = '" + ano + "' " +
                "GROUP BY MONTH(R.Fech_Entr)";
            Acceso.readDatathroughAdapter(seleccion, this.pagoDT);

        }


        //funcion para actualizar
        public void actualizar(string id, string importe)
        {
            SqlCommand actualiza = new SqlCommand("UPDATE Pago SET Importe = @ipmr " +
                "WHERE idPago = @pd");
            actualiza.Parameters.AddWithValue("@pd", id);
            actualiza.Parameters.AddWithValue("@ipmr", importe);
            Acceso.executeQuery(actualiza);
        }

        //Funcion para eliminar el pago
        public void eliminar(string id) {
            SqlCommand actualiza = new SqlCommand("UPDATE Pago SET Estado = '0' " +
                "WHERE idPago = @pd");
            actualiza.Parameters.AddWithValue("@pd", id);
            Acceso.executeQuery(actualiza);
        }


        //funcion para recuperar datos
        public void recuperar(string identificador) {
            string selecion = "SELECT P.idPago, P.Importe, P.ID_Reser, C.Codi_Clien, C.Nom_Clie" +
                " FROM Pago AS P INNER JOIN Reservacion AS R ON P.ID_Reser = R.ID_Reser INNER JOIN Cliente AS C ON R.Codi_Clien = C.Codi_Clien " +
                "WHERE P.idPago = '" + identificador + "'";
            Acceso.readDatathroughAdapter(selecion, this.pagoDT);
        }

        //Consulta para buscar transferencias
        public void rellenar_trans(string id_refe, string client, string primero, string segundo) {
            SqlCommand seleccion = new SqlCommand("SELECT P.ID_Reser, P.Importe, P.Ref, P.Fech_Realizada, P.idPago " +
                "From Pago AS P INNER JOIN Reservacion AS R ON P.ID_Reser = R.ID_Reser INNER JOIN Cliente AS C ON R.Codi_Clien = C.Codi_Clien " +
                "WHERE (P.Ref != 'EE' AND P.Ref != 'TT') AND (@IDR IS NULL OR P.ID_Reser = @IDR) AND " +
                "(P.Fech_Realizada BETWEEN '" + primero + "' AND '" + segundo + "') AND " +
                "(@CT IS NULL OR C.Codi_Clien = @CT) AND P.Estado = '1'", Acceso.Con);
            Acceso.createConn();
            seleccion.Parameters.AddWithValue("@IDR", id_refe != null ? id_refe : (object)DBNull.Value);
            seleccion.Parameters.AddWithValue("@CT", client != null ? client : (object)DBNull.Value);
            SqlDataAdapter adapter = new SqlDataAdapter(seleccion);
            adapter.Fill(this.pagoDT);
        }
        //Consulta para buscar
        public void rellenar(string id_refe, string client, string primero, string segundo, string cod_ref)
        {
            SqlCommand seleccion = new SqlCommand("SELECT P.ID_Reser, P.Importe, P.Ref, P.Fech_Realizada, P.idPago " +
                "From Pago AS P INNER JOIN Reservacion AS R ON P.ID_Reser = R.ID_Reser INNER JOIN Cliente AS C ON R.Codi_Clien = C.Codi_Clien " +
                "WHERE (@RF IS NULL OR P.Ref= @RF) AND (@IDR IS NULL OR P.ID_Reser = @IDR) AND " +
                "(P.Fech_Realizada BETWEEN '" + primero + "' AND '" + segundo + "') AND " +
                "(@CT IS NULL OR C.Codi_Clien = @CT) AND P.Estado = '1'", Acceso.Con);
            Acceso.createConn();
            seleccion.Parameters.AddWithValue("@IDR", id_refe != null ? id_refe : (object)DBNull.Value);
            seleccion.Parameters.AddWithValue("@CT", client != null ? client : (object)DBNull.Value);
            seleccion.Parameters.AddWithValue("@RF", cod_ref != null ? cod_ref : (object)DBNull.Value);
            SqlDataAdapter adapter = new SqlDataAdapter(seleccion);
            adapter.Fill(this.pagoDT);
        }


        //funcion para insertar un pago con transferencia
        public string insertar(string banco)
        {
            string pollo3MasPollokNunca = this.Generador_ID();
            SqlCommand insertar = new SqlCommand("INSERT INTO Pago" +
                "(idPago, ID_Reser, Ref, Importe, Fech_Realizada, Estado, Nom_Usu)" +
                " VALUES(@id, @REf_id, @Referencia, @import, @f_re, '1', @usu)");
            insertar.Parameters.AddWithValue("@id", pollo3MasPollokNunca);
            //con la linea superior llamo a generar un numero aleatorio que no exista ya en la base de datos y se envia a guardar
            insertar.Parameters.AddWithValue("@Referencia", this.Referencia_Pago); //el pago, ojo aqui

            insertar.Parameters.AddWithValue("@REf_id", this.ID_Reserv);//ojo aqui, es la reserva
            insertar.Parameters.AddWithValue("@usu", this.Usuario);
            insertar.Parameters.AddWithValue("@import", this.Importe);
            
            insertar.Parameters.AddWithValue("@f_re", DateTime.Now.ToString("yyyy-MM-dd"));
            Acceso.executeQuery(insertar);
            Transferencia.Referencia = this.Referencia_Pago;
            Transferencia.Banco = banco;
            Transferencia.Insertar();
            return pollo3MasPollokNunca;
        }

        public decimal balance(string identificador)
        {
            SqlCommand seleccion = new SqlCommand("SELECT SUM(Importe) from Pago where ID_Reser = '" + identificador + "' AND Estado = '1' ", Acceso.Con);
            decimal pagado = 0;
            object resultado = seleccion.ExecuteScalar();
            pagado = (resultado != null && resultado != DBNull.Value) ? (decimal)resultado : 0;
            return pagado;
        }


        //funcion para insertar un pago sin transferencia
        public string insertar() {
            string pollo3MasPollokNunca = this.Generador_ID();
            SqlCommand insertar = new SqlCommand("INSERT INTO Pago" +
                "(idPago, ID_Reser, Ref, Importe, Fech_Realizada, Estado, Nom_Usu)" +
                " VALUES(@id, @REf_id, @Referencia, @import, @f_re, '1', @usu)");
            insertar.Parameters.AddWithValue("@id", pollo3MasPollokNunca);
            //con la linea superior llamo a generar un numero aleatorio que no exista ya en la base de datos y se envia a guardar
            insertar.Parameters.AddWithValue("@Referencia", this.Referencia_Pago); //el pago, ojo aqui
            
            insertar.Parameters.AddWithValue("@REf_id", this.ID_Reserv);//ojo aqui, es la reserva
            insertar.Parameters.AddWithValue("@usu", this.Usuario);
            insertar.Parameters.AddWithValue("@import", this.Importe.ToString());
            insertar.Parameters.AddWithValue("@f_re", DateTime.Now.ToString("yyyy-MM-dd"));
            Acceso.executeQuery(insertar);
            return pollo3MasPollokNunca;
        }

        private string Generador_ID()
        {
            Random generador = new Random();
            int auxiliar = generador.Next(0, 999999999);//creo un auxiliar y le asigno un valor aleatorio
            string busc = auxiliar.ToString();
            while (this.Buscar_Numero(busc)) //mientras se encuentre un valor del numero, se genera otro
            {
                auxiliar = generador.Next(0, 16777215);
                busc = auxiliar.ToString();
            }
            return (busc);
        }
        //Con esto busco el ID en la tabla y devuelvo un bool
        private bool Buscar_Numero(string entrada)
        {
            string selecion = "SELECT idPago FROM Pago WHERE idPago = '" + entrada + "'"; //comando sql

            Acceso.readDatathroughAdapter(selecion, this.pagoDT);
            if (pagoDT.Rows.Count == 1) //si la cantidad de entradas en la tabla es igual a 1 se procede
            {
                return true; //si lo encuentra retorna true
            }
            else
            {
                return false;
            }
        }
    }
}
