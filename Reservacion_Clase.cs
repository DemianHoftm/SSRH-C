using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRRH
{
    internal class Reservacion_Clase
    {
        private DBAccess Acceso;
        public DataTable re;
        private string num_re, client, _estado, nom_usu;
        private decimal _descuento;
        private decimal _subtotal;
        DateTime entrada, salida, reser;
        public decimal Total { get { return _subtotal; } set { _subtotal = value; } }
        public string Numero_Reser { get { return num_re; } set { num_re = value; } }
        public DateTime Entrada { get { return entrada; } set { entrada = value; } }
        public DateTime Salida { get { return salida; } set { salida = value; } }
        public DateTime Reservado { get { return reser; } set { reser = value; } }
        public string Numero_Cliente { get { return client; } set { client = value; } }
        public string Estado { get { return _estado; } set { _estado = value; } }
        public string Usuario { get { return nom_usu; } set { nom_usu = value; } }
        public decimal Descuento { get { return _descuento; } set { _descuento = value; } }

        public Reservacion_Clase()
        {
            Acceso = new DBAccess();
            re = new DataTable();
        }
        //funcion para tener el aproximado de huespedes
        public void Get_huespedes(string ano)
        {
            string seleccion = "SELECT MONTH(R.Fech_Entr) ,SUM(T.Num_Per) " +
                "FROM Reservacion AS R INNER JOIN Hab_Reserv AS HR ON R.ID_Reser = HR.ID_Reser " +
                "INNER JOIN Habitacion AS H ON HR.Num_Hab = H.Num_Hab INNER JOIN Tipo AS T ON H.ID = T.ID " +
                "where YEAR(R.Fech_Entr) = '"+ano+"' GROUP BY MONTH(R.Fech_Entr)";
            Acceso.readDatathroughAdapter(seleccion, this.re);

        }

        //funcion para tener el aproximado de dias
        public void Get_dias(string ano)
        {
            string seleccion = "SELECT MONTH(Fech_Entr) as Mes, AVG(DATEDIFF(day, Fech_Entr, Fech_Sal)) " +
                "FROM Reservacion WHERE YEAR(Fech_Entr) = '"+ano+"' GROUP BY MONTH(Fech_Entr);";
            Acceso.readDatathroughAdapter(seleccion, this.re);

        }

        //Recupera los valores necesarios para la edicion y eliminacion.
        public void Recupera(string muu) {
            string seleccion = "SELECt C.Codi_Clien, C.Nom_Clie, R.Descuento, R.Total, R.Fech_Entr, R.Fech_Sal, R.Estado " +
                "FROM Reservacion AS R INNER JOIN Cliente AS C ON R.Codi_Clien = C.Codi_Clien " +
                "WHERE R.ID_Reser = '"+muu+"'";
            Acceso.readDatathroughAdapter(seleccion, this.re);
        }

        //Devuelve la cantidad diaria sin descuento que se pagaria por reservacion
        public decimal Get_Bruto(string la_vaca) {
            SqlCommand selection = new SqlCommand("SELECt SUM(T.Precio) FROM " +
                "Hab_Reserv AS HR INNER JOIN Habitacion AS H ON HR.Num_Hab = H.Num_Hab" +
                " INNER JOIN Tipo AS T ON H.ID = T.ID WHERE HR.ID_Reser = '"+ la_vaca + "'", this.Acceso.Con);
           return (decimal)selection.ExecuteScalar();
        
        
        }

        //Funcion para buscar por rango de estadia con valores
        public void Consulta_estadia(string fecha_en, string fecha_sal, string cliente, string reserva, string estado)
        {
            string seleccion = "SELECT R.ID_Reser, R.Codi_Clien, R.Fech_Entr, R.Fech_Sal " +
                "FROM Reservacion AS R WHERE " +
                "((R.ID_Reser LIKE '%" + reserva + "%') OR (R.Codi_Clien LIKE '%" + cliente + "%')" +
                " AND ((R.Fech_Sal BETWEEN '" + fecha_en + "' AND '" + fecha_sal + "') OR " +
                "(R.Fech_Entr BETWEEN '" + fecha_en + "' AND '" + fecha_sal + "'))) AND (R.Estado = '" + estado + "')";
            Acceso.readDatathroughAdapter(seleccion, this.re);
        }

        //Funcion para buscar por rango de estadia
        public void Consulta_estadia(string fecha_en, string fecha_sal, string estado) {
            string seleccion = "SELECT R.ID_Reser, R.Codi_Clien, R.Fech_Entr, R.Fech_Sal " +
                "FROM Reservacion AS R WHERE " +
                "((R.Fech_Sal BETWEEN '" + fecha_en + "' AND '" + fecha_sal + "') OR " +
                "(R.Fech_Entr BETWEEN '" + fecha_en + "' AND '" + fecha_sal + "')) AND (R.Estado = '" + estado + "')";
            Acceso.readDatathroughAdapter(seleccion, this.re);
        }
        //Funcion para buscar por rango de reserva con valores
        public void Consulta_reserva(string fecha_en, string fecha_sal, string id, string clien, string estado)
        {
            string seleccion = "SELECT R.ID_Reser, R.Codi_Clien, R.Fech_Entr, R.Fech_Sal " +
                "FROM Reservacion AS R WHERE " +
                "((R.ID_Reser LIKE '%" + id + "%') OR (R.Codi_Clien LIKE '%" + clien + "%')" +
                " AND (R.Fech_Res BETWEEN '" + fecha_en + "' AND '" + fecha_sal + "')) AND (R.Estado = '" + estado + "')";
            Acceso.readDatathroughAdapter(seleccion, this.re);
        }
        //Funcion para buscar por rango de reserva
        public void Consulta_reserva(string fecha_en, string fecha_sal, string estado)
        {
            string seleccion = "SELECT R.ID_Reser, R.Codi_Clien, R.Fech_Entr, R.Fech_Sal " +
                "FROM Reservacion AS R WHERE " +
                "(R.Fech_Res BETWEEN '" + fecha_en + "' AND '" + fecha_sal + "') AND (R.Estado = '" + estado + "')";
            Acceso.readDatathroughAdapter(seleccion, this.re);
        }

        //Funcion para comprobar si se ha pagado todo 
        public bool Balance(string id_reserva)
        {
            Pago_Clase pagare = new Pago_Clase();
            decimal pagado = pagare.balance(id_reserva);
            SqlCommand seleccion = new SqlCommand("SELECT Total FROM Reservacion WHERE ID_Reser = '" + id_reserva + "'", Acceso.Con);
            decimal total = (decimal)seleccion.ExecuteScalar();
            if (pagado >= total) return true; else return false;
        }


        //Funcion que toma los numero de las habitaciones que esten ocupadas por una reservacion 
        public string Habitacion_Ocupadas(string ID_RESERVA)
        {
            this.re.Clear();
            string busqueda = "SELECT Num_Hab, ID_Reser FROM Hab_Reserv WHERE ID_Reser = '" + ID_RESERVA + "'";
            Acceso.readDatathroughAdapter(busqueda, this.re);
            string auxiliar = re.Rows[0].Field<string>(0);
            for (int i = 1; i < re.Rows.Count; i++)//recorrerá cada fila del data table
            {
                auxiliar = auxiliar + ", " + re.Rows[i].Field<string>(0);
            }
            this.re.Clear();
            return auxiliar;
        }
        public void Habitacion_Ocupadas_dt(string ID_RESERVA)
        {
            this.re.Clear();
            string busqueda = "SELECT HR.Num_Hab, T.Precio FROM Hab_Reserv AS HR INNER JOIN Habitacion AS H ON HR.Num_Hab = H.Num_Hab INNER JOIN Tipo AS T" +
                " ON H.ID = T.ID WHERE HR.ID_Reser = '" + ID_RESERVA + "'";
            Acceso.readDatathroughAdapter(busqueda, this.re);
            string auxiliar = re.Rows[0].Field<string>(0);
            
        }
        //Funcion que toma los numero de las habitaciones que esten ocupadas en el rango de fechas. 
        public string[] Habitacion_Ocupadas(string entrada, string salida)
        {
            string busqueda = "SELECT HR.Num_Hab FROM Reservacion AS R " +
                "INNER JOIN  Hab_Reserv as HR on R.ID_Reser = HR.ID_Reser" +
                " WHERE (R.Fech_Sal BETWEEN '" + entrada + "' AND '" + salida + "') OR " +
                "(R.Fech_Entr BETWEEN '" + entrada + "' AND '" + salida + "')";
            Acceso.readDatathroughAdapter(busqueda, this.re);
            string[] auxiliar = new string[re.Rows.Count];            
            for (int i = 0; i < re.Rows.Count; i++)//recorrerá cada fila del data table
            {
                auxiliar[i] = re.Rows[i].Field<string>(0);
            }
            this.re.Clear();
            return auxiliar;
        }

        //Funcion para actualizar el estado de la reservacion
        public void Cambio_Estado(string nombre, string valor_estado)
        {
            SqlCommand acutalizar = new SqlCommand("UPDATE Reservacion SET Estado = @est WHERE ID_Reser = @num");
            acutalizar.Parameters.AddWithValue("@num", nombre);
            acutalizar.Parameters.AddWithValue("@est", valor_estado);
            Acceso.executeQuery(acutalizar);
        }

        public void actualizar(string id, decimal des, decimal totaalQuemas) {
            SqlCommand actualizar = new SqlCommand("UPDATE Reservacion SET Descuento = @des, Total = @tot WHERE ID_Reser = @num");
            actualizar.Parameters.AddWithValue("@des", des);
            actualizar.Parameters.AddWithValue("@num", id);
            actualizar.Parameters.AddWithValue("@tot", totaalQuemas);
            Acceso.executeQuery(actualizar);
        }
        public string Insertar(string[] habitaciones)
        {
            string pollo = this.Generador_ID();
            SqlCommand insertar = new SqlCommand("INSERT INTO Reservacion" +
                "(ID_Reser, Codi_Clien, Fech_Res, Fech_Entr, Fech_Sal, Estado, Nom_Usu, Descuento, Total)" +
                " VALUES(@id, @codi_client, @f_re, @f_en, @f_out, '1', @usu, @des, @tot)");
            insertar.Parameters.AddWithValue("@id", pollo);
            //con la linea superior llamo a generar un numero aleatorio que no exista ya en la base de datos y se envia a guardar
            insertar.Parameters.AddWithValue("@codi_client", this.Numero_Cliente);
            insertar.Parameters.AddWithValue("@f_out", this.Salida.ToString("yyyy-MM-dd"));
            insertar.Parameters.AddWithValue("@f_en", this.Entrada.ToString("yyyy-MM-dd"));
            insertar.Parameters.AddWithValue("@usu", this.Usuario);
            insertar.Parameters.AddWithValue("@des", this.Descuento.ToString());
            insertar.Parameters.AddWithValue("@f_re", DateTime.Now.ToString("yyyy-MM-dd"));
            insertar.Parameters.AddWithValue("@tot", this.Total.ToString());
            Acceso.executeQuery(insertar);
            //procedo a guardar las habitaciones reservadas en la tabla relacional
            this.ingresa_hab(pollo, habitaciones);



            return pollo;
        }
        private void ingresa_hab(string pollo, string[] habitaciones) {
            SqlCommand  insertar = new SqlCommand("INSERT INTO Hab_Reserv (ID_Reser, Num_Hab) VALUES('" + pollo + "', '" + habitaciones[0] + "')");
            for (int i = 1; i < habitaciones.Length; i++)
            {
                insertar.CommandText = insertar.CommandText + ", ('" + pollo + "', '" + habitaciones[i] + "')";
            }

            Acceso.executeQuery(insertar);

        }
        private string Generador_ID()
        {
            Random generador = new Random();
            int auxiliar = generador.Next(0, 16777215);//creo un auxiliar y le asigno un valor aleatorio
            string hexa = auxiliar.ToString("X4"); //convierto el numero decimal a hexadecimal
            while (this.Buscar_Numero(hexa)) //mientras se encuentre un valor del hexa, se genera otro
            {
                auxiliar = generador.Next(0, 16777215);
                hexa = auxiliar.ToString("X4");
            }
            return (hexa);
        }
        //Con esto busco el ID en la tabla y devuelvo un bool
        private bool Buscar_Numero(string entrada)
        {
            string selecion = "SELECT ID_Reser FROM Reservacion WHERE ID_Reser = '" + entrada + "'"; //comando sql

            Acceso.readDatathroughAdapter(selecion, this.re);
            if (re.Rows.Count == 1) //si la cantidad de entradas en la tabla es igual a 1 se procede
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
