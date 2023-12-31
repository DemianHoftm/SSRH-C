using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRRH
{
    internal class Habitacion_clase
    {
        private string _Numero, _estado, _ID;
        public string Numero { get { return _Numero; } set { _Numero = value; } }
        public string ID { get { return _ID; } set { _ID = value; } }
        public string Estado { get { return _estado; } set { _estado = value; } }
        private DBAccess Acceso;
        public DataTable dt_hab;
        public Habitacion_clase()
        {
            Acceso = new DBAccess(); //objeto para controlar la base de datos
            dt_hab = new DataTable(); //elemento donde se almacenan los datos
            //Borrar la tabla despues de cada uso para no perder espacio de memoria
        }
        //Funcion para recoger la cantidad total de habitaciones segun su tipo
        public int[] Get_Cantidad(string nombre)
        {
            SqlCommand selection = new SqlCommand("SELECT COUNT(H.Num_Hab) FROM Habitacion AS H INNER JOIN Tipo AS T ON H.ID = T.ID " +
                "WHERE T.Nom = '" + nombre + "' AND H.Estado = '1'", Acceso.Con);


            int[] ropeFuego = new int[2];
            Acceso.createConn();
            ropeFuego[1] = (int)selection.ExecuteScalar(); //Realizo el comando execute escalar para
            //Que se retorne unicament el primer resultado de la consulta, que a demas se convierte a int
            selection.CommandText = "SELECT COUNT(H.Num_Hab) FROM Habitacion AS H INNER JOIN Tipo AS T ON H.ID = T.ID WHERE T.Nom = '" + nombre + "' AND H.Estado = '0'";
            ropeFuego[0] = (int)selection.ExecuteScalar();
            //Recupero el conteo de los activos y los inactivos y los envio como un array           
            
            return ropeFuego;
        }

        //Funcion para recoger el precio total de todas las habitaciones seleccionadas
        public decimal Get_Total_Raw(string[] almacen)
        {
            SqlCommand selection = new SqlCommand("SELECT SUM(T.Precio) FROM Habitacion AS H INNER JOIN Tipo AS T ON H.ID = T.ID " +
                "WHERE H.Num_Hab = '" + almacen[0] + "' ", Acceso.Con);
            for (int i = 1; i < almacen.Count(); i++)
            {
                selection.CommandText = selection.CommandText + " OR H.Num_Hab = '" + almacen[i] + "' ";
            }
            Acceso.createConn();
            var ropeFuego = (decimal)selection.ExecuteScalar(); //Realizo el comando execute escalar para
            //Que se retorne unicament el primer resultado de la consulta, que a demas se convierte a decimal
            return ropeFuego;
        }

        //Esta funcion comprueba que no haya una habitacion con el numero ingresado
        public bool comprobar_numero(string entrada)
        {
            string selecion = "SELECT Num_Hab FROM Habitacion WHERE Num_Hab = '" + entrada + "'"; //comando sql

            Acceso.readDatathroughAdapter(selecion, this.dt_hab);
            if (dt_hab.Rows.Count == 1) //si la cantidad de entradas en la tabla es igual a 1 se procede
            {
                return true; //si lo encuentra retorna true
            }
            else
            {
                return false;
            }
        }

        //Actualiza los datos de la habitacion
        public void Actualizar(string nombre) //la entrada será el nombre del nuevo tipo
        {
            SqlCommand actualizar = new SqlCommand("UPDATE Habitacion SET ID = @en WHERE Num_Hab = @num");
            actualizar.Parameters.AddWithValue("@num", this.Numero);
            actualizar.Parameters.AddWithValue("@en", nombre);
            Acceso.executeQuery(actualizar);
        }
        //Funcion para llenar a la tabla de forma basica 
        public void Rellenar_Bas( string Estado_busqueda)
        {

            string seleccion = "SELECT H.Num_Hab,T.Nom, H.Estado FROM Habitacion AS H INNER JOIN Tipo AS T ON H.ID = T.ID " +
                "WHERE H.Estado = '" + Estado_busqueda + "'";

            /*enlazo ambas tablas para obtener la informacion de ambas tablas y poder buscar mediante nombre
             Asi mismo si se le ingresa numero o nombre de tipo se buscaran todos los que tengan ese nombre o numero y 
            tengan el estado seleccionado
 Sin embargo, si la busqueda es sin nombre ni tipo, no se cumple ninguno de los dos primeros and
  y se ejecuta el ultimo tomando unicamente a las habitaciones por su estado
             */
            Acceso.readDatathroughAdapter(seleccion, dt_hab);
        }
        public void Rellenar_Bas_nost(string Numero_busqueda, string Estado_busqueda, string Nombre_busqueda)
        {

            string seleccion = "SELECT H.Num_Hab,T.Nom, H.Estado FROM Habitacion AS H INNER JOIN Tipo AS T ON H.ID = T.ID " +
                "WHERE (H.Num_Hab = '" + Numero_busqueda + "' AND H.Estado = '" + Estado_busqueda + "') OR " +
                "(T.Nom = '" + Nombre_busqueda + "' AND H.Estado = '" + Estado_busqueda + "')";

            /*enlazo ambas tablas para obtener la informacion de ambas tablas y poder buscar mediante nombre
             Asi mismo si se le ingresa numero o nombre de tipo se buscaran todos los que tengan ese nombre o numero y 
            tengan el estado seleccionado
 Sin embargo, si la busqueda es sin nombre ni tipo, no se cumple ninguno de los dos primeros and
  y se ejecuta el ultimo tomando unicamente a las habitaciones por su estado
             */
            Acceso.readDatathroughAdapter(seleccion, dt_hab);
        }
        //Funcion para actualizar el estado de la habitacion
        public void Cambio_Estado(string nombre, string valor_estado)
        {
            SqlCommand acutalizar = new SqlCommand("UPDATE Habitacion SET Estado = @est WHERE Num_Hab = @num");
            acutalizar.Parameters.AddWithValue("@num", nombre);
            acutalizar.Parameters.AddWithValue("@est", valor_estado);
            Acceso.executeQuery(acutalizar);
            
        }
        //Funcion para insertar en la base de dato
        public void insertar()
        {
            SqlCommand insertar = new SqlCommand("INSERT INTO Habitacion(Num_Hab, ID, Estado) VALUES(@num, @id, '1')");
            insertar.Parameters.AddWithValue("@num", this.Numero);
            insertar.Parameters.AddWithValue("@id", this.ID);
            Acceso.executeQuery(insertar);
        }
    }
}
