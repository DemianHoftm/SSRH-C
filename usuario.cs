using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace SRRH
{
    public class usuario
    {
        private string nombre, pass;
        private Int16 rol, estado;
        private DBAccess Acceso;
        public DataTable dt_usu;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Pass { get { return pass; } set { pass = value; } }
        public Int16 Rol { get { return rol; } set { rol = value; } }
        public Int16 Estado { get { return estado; } set { estado = value; } }
        public DataTable dtusu { get { return dt_usu; } set { dt_usu = value; } }

        public usuario()
        {
            Acceso = new DBAccess();
            dtusu = new DataTable(); //elemento donde se almacenan los datos
            //Borrar la tabla despues de cada uso para no perder espacio de memoria
        }


        public bool Guardar()
        {
            SqlCommand insertar = new SqlCommand("INSERT INTO Usuario(Nom_Usu, Pass_Usu, idRol, Estado) VALUES(@Nom, @Pass, '0', '1')");
            insertar.Parameters.AddWithValue("@Nom", this.Nombre);
            insertar.Parameters.AddWithValue("@Pass", this.Pass);

            int row = Acceso.executeQuery(insertar);
            if (row == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void Actualizar()
        {
            SqlCommand acutalizar = new SqlCommand("UPDATE Usuario SET Pass_Usu = @Pass, Estado = @esta, idRol = @rol WHERE Nom_Usu = @Nom");
            acutalizar.Parameters.AddWithValue("@Nom", this.Nombre);
            acutalizar.Parameters.AddWithValue("@Pass", this.Pass);
            acutalizar.Parameters.AddWithValue("@rol", this.Rol.ToString());
            acutalizar.Parameters.AddWithValue("@esta", this.estado);

            Acceso.executeQuery(acutalizar);
            
        }

        public void Eliminar(string entrada)
        {
            SqlCommand acutalizar = new SqlCommand("UPDATE Usuario SET Estado = @Est WHERE Nom_Usu = @Nom");
            acutalizar.Parameters.AddWithValue("@Est", entrada);
            acutalizar.Parameters.AddWithValue("@Nom", this.Nombre);

            Acceso.executeQuery(acutalizar);
        }

        //Esta funcion busca al usuario basado en su nombre para usarlo durante el login
        public bool Buscar_Login(string entrada)
        {
            string selecion = "SELECT * FROM Usuario WHERE Nom_Usu = '" + entrada + "'"; //comando sql

            Acceso.readDatathroughAdapter(selecion, this.dtusu);
            if (dtusu.Rows.Count == 1) //si la cantidad de entradas en la tabla es igual a 1 se procede
            {
                this.Nombre = entrada; //me salto el 0 por que ya está en entrada
                this.Pass = dtusu.Rows[0].Field<string>(1); //de esta forma se accede a la segunda columna, que es la contraseña
                this.Rol = Convert.ToInt16(dtusu.Rows[0].Field<string>(2)); //de esta forma se accede a la tercera, el rol. 
                this.Estado = Convert.ToInt16(dtusu.Rows[0].Field<string>(3)); //convierte el estado 
                return true; //si lo encuentra retorna true
            }
            else
            {
                return false; //si no lo encuentra retorna false
            }
        }        
        
        //Esta funcion es la usada para la consulta, mediante comando de parecidos
        //Se puede utilizar para rellenar la tabla de forma basica
        public bool Consulta(string nom, Int16 est)
        {
            string selecion = "SELECT U.Nom_Usu, R.Nombre, U.Estado FROM Usuario U INNER JOIN Rol R ON U.idRol = R.idRol WHERE Nom_Usu LIKE '%" + nom + "%' AND Estado =  '"+ est.ToString() +"' "; //comando sql

            Acceso.readDatathroughAdapter(selecion, this.dtusu);
            if (dtusu.Rows.Count >= 1) //si la cantidad de entradas en la tabla es igual a 1 se procede
            {
                return true; //si se encuentra se retorna true
            }
            else
            {
                return false; // Si no se encuentra retorna falseo
            }
        }

        //esta funcion busca el usuario de forma especifica y retorna true si lo encuentra, y falso si no
        //comprueba la existencia del usuario en la tabla
        public bool Buscar_Nom(string nombre) 
        {
            string selecion = "SELECT * FROM Usuario WHERE Nom_Usu = '" + nombre + "'"; //comando sql
            Acceso.readDatathroughAdapter(selecion, this.dtusu); //utilizo el objeto DBA para acceder a la BD
            if (dtusu.Rows.Count == 1) //si la cantidad de entradas en la tabla es igual a 1 se procede
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