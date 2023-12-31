using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRRH
{
    internal class Bitacora
    {
        private DBAccess Acceso;
        public DataTable dt_bit;
        private string _id, accion, codigo, nom_usu, _modu;
        public string ID { get { return _id; } set { _id = value; } }
        public string Accion { get { return accion; } set { accion = value; } }
        public string Modulo { get { return _modu; } set { _modu = value; } }
        public string Codigo { get { return codigo; } set { codigo = value; } }
        public string Usuario { get { return nom_usu; } set { nom_usu = value; } }


        public Bitacora() {
            Acceso = new DBAccess();
            dt_bit = new DataTable();
        }

        public void Insertar()
        {
            SqlCommand insertar = new SqlCommand("INSERT INTO Bitacora(ID_Bit, Accion, Codigo, Modulo, Nom_Usu, Fecha) VALUES(@id, @acc, @cod, @mod, @usu, @fec)");
            insertar.Parameters.AddWithValue("@id", this.Generador_ID());
            //con la linea superior llamo a generar un numero aleatorio que no exista ya en la base de datos y se envia a guardar
            insertar.Parameters.AddWithValue("@acc", this.Accion);
            insertar.Parameters.AddWithValue("@cod", this.Codigo);
            insertar.Parameters.AddWithValue("@mod", this.Modulo);
            insertar.Parameters.AddWithValue("@usu", this.Usuario);
            insertar.Parameters.AddWithValue("@fec", DateTime.Now.ToString("yyyy-MM-dd"));
            Acceso.executeQuery(insertar);
        }
        
        public void rellenar(string acce, string modu, string usu, string primero, string segundo)//este es para buscar por algun filtro
        {
            SqlCommand selection = new SqlCommand("SELECT Accion, Nom_Usu, Modulo, Codigo, Fecha FROM Bitacora " +
                "WHERE (@acc IS NULL OR Accion = @acc) AND (@nom IS NULL OR Nom_Usu = @nom) AND " +
                "(Fecha BETWEEN '" + primero + "' AND '" + segundo + "') AND " +
                "(@mod IS NULL OR Modulo = @mod)", Acceso.Con);
            //en esta query se van a tomar en condicion unicamente aquellos valores que no sean null
            selection.Parameters.AddWithValue("@mod", modu != null ? modu : (object)DBNull.Value);
            selection.Parameters.AddWithValue("@acc", acce != null ? acce : (object)DBNull.Value);
            selection.Parameters.AddWithValue("@nom", usu != null ? usu : (object)DBNull.Value);
            //aqui realizo una comprobacion de si el parametro es vacio, se utiliza como parametro el valor null de db
            SqlDataAdapter adapter = new SqlDataAdapter(selection);
            adapter.Fill(this.dt_bit);
        }
        public void rellenar(string primero, string segundo)//este es para buscar por algun filtro
        {
            
            string selection = "SELECT Accion, Nom_Usu, Modulo, Codigo, Fecha FROM Bitacora WHERE " +
                "Fecha BETWEEN '" + primero + "' AND '" + segundo + "'";
            Acceso.readDatathroughAdapter(selection, this.dt_bit);
        }

        private string Generador_ID()
        {
            Random generador = new Random();
            int auxiliar = generador.Next(0, 268435455);//creo un auxiliar y le asigno un valor aleatorio
            string hexa = auxiliar.ToString("X4"); //convierto el numero decimal a hexadecimal
            while (this.Buscar_Numero(hexa)) //mientras se encuentre un valor del hexa, se genera otro
            {
                auxiliar = generador.Next(0, 268435455);
                hexa = auxiliar.ToString("X4");
            }
            return (hexa);
        }
        //Con esto busco el ID en la tabla y devuelvo un bool
        private bool Buscar_Numero(string entrada)
        {
            string selecion = "SELECT ID_Bit FROM Bitacora WHERE ID_Bit = '" + entrada + "'"; //comando sql

            Acceso.readDatathroughAdapter(selecion, this.dt_bit);
            if (dt_bit.Rows.Count == 1) //si la cantidad de entradas en la tabla es igual a 1 se procede
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
