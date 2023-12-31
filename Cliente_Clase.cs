using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SRRH
{
    internal class Cliente_Clase
    {
        private DBAccess Acceso;
        public DataTable dt_client;
        private string _nombre, _id, _correo, _telf, estado;
        public string Estado { get { return estado; } set { estado = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string ID { get { return _id; } set { _id = value; } }
        public string Correo { get { return _correo; } set { _correo = value; } }
        public string Telefono { get { return _telf; } set { _telf = value; } }

        public Cliente_Clase() {
            Acceso = new DBAccess();
            dt_client = new DataTable(); //elemento donde se almacenan los datos
           //Borrar la tabla despues de cada uso para no perder espacio de memoria
        }

        //funcion para guardar al cliente en la base de datos, por defecto se guarda activado
        public void Insertar()
        {
            SqlCommand insertar = new SqlCommand("INSERT INTO Cliente(Codi_Clien, Nom_Clie, Telf_Clie, Corre_Clie, Estado) VALUES(@id, @Nom, @Telf, @corr, '1')");
            insertar.Parameters.AddWithValue("@id", this.ID);
            insertar.Parameters.AddWithValue("@Nom", this.Nombre);
            insertar.Parameters.AddWithValue("@Telf", this.Telefono);
            insertar.Parameters.AddWithValue("@corr", this.Correo);

            Acceso.executeQuery(insertar);
        }
        //Funcion para eliminar al cliente, se cambia el estado a inactivo
        public void Eliminar(string entrada)
        {
            SqlCommand acutalizar = new SqlCommand("UPDATE Cliente SET Estado = @est WHERE Codi_Clien = @id");
            acutalizar.Parameters.AddWithValue("@id", this.ID);
            acutalizar.Parameters.AddWithValue("@est", entrada);
            Acceso.executeQuery(acutalizar);

        }
        //Utilizado para actualizar los datos del cliente
        public void Actualizar()
        {
            SqlCommand acutalizar = new SqlCommand("UPDATE Cliente SET Nom_Clie = @Nom, Telf_Clie = @Telf, Corre_Clie = @corr WHERE Codi_Clien = @ID");
            acutalizar.Parameters.AddWithValue("@Nom", this.Nombre);
            acutalizar.Parameters.AddWithValue("@ID", this.ID);
            acutalizar.Parameters.AddWithValue("@Telf", this.Telefono);
            acutalizar.Parameters.AddWithValue("@corr", this.Correo);

            Acceso.executeQuery(acutalizar);

        }
        //Esta funcion es usada para buscar y rellenar las tablas, sirve para buscar por multiples parametros
        public void rellenar(string nombre_entrada, string estado_entrada, string entrada_id)
        {
            string selection = "SELECT * FROM Cliente WHERE " +
                "(Nom_Clie LIKE '%" + nombre_entrada + "%' AND Estado = '" + estado_entrada + "') OR " +
                "(Codi_Clien like '%" + entrada_id + "%' AND Estado = '" + estado_entrada + "') ";
            //este comando fuerza a que se seleccione unicamente los del estado indicado y que tengan cualquier otra similitud

            Acceso.readDatathroughAdapter(selection, this.dt_client);
        }

        public void Recupera(string ID)
        {
            string selecion = "SELECT * FROM Cliente WHERE Codi_clien = '" + ID + "'"; //comando sql

            Acceso.readDatathroughAdapter(selecion, this.dt_client);
            if (dt_client.Rows.Count == 1) //si la cantidad de entradas en la tabla es igual a 1 se procede
            {
                this.ID = ID;
                this.Estado = dt_client.Rows[0].Field<string>(4); //convierte el estado 
               
            }

        }


        //Esta funcion se usa para comprobar que exista un cliente con dicho ID
        public bool Buscar(string entrada_id)
        {
            string selecion = "SELECT * FROM Cliente WHERE  Codi_Clien = '"+ entrada_id + "'"; //comando sql
            Acceso.readDatathroughAdapter(selecion, this.dt_client);
            if (dt_client.Rows.Count == 1) //si la cantidad de entradas en la tabla es igual a 1 se procede
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

}
