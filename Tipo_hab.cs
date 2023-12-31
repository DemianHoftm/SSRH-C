using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRRH
{
    internal class Tipo_hab
    {
        private string _id, _nom;
        private Int16 _numper;
        private float _precio;
        private DBAccess Acceso;
        public DataTable dt_tip;

        public string Nombre { get { return _nom; } set { _nom = value; } }
        public string ID { get { return _id; } set { _id = value; } }
        public Int16 Num_Per { get { return _numper; } set { _numper = value; } }
        public float Precio { get { return _precio; } set { _precio = value; } }
        public Tipo_hab() {
            Acceso = new DBAccess();
            dt_tip = new DataTable(); //elemento donde se almacenan los datos
            //Borrar la tabla despues de cada uso para no perder espacio de memoria
        }

        //Busca por nombre y retorna el ID
        public string Buscar(string nombre) {
            string selection = "SELECT ID, Nom FROM Tipo WHERE Nom = '" + nombre + "' ";
            this.dt_tip.Clear();
            Acceso.readDatathroughAdapter(selection, this.dt_tip);
            string auxiuliar = "";
            foreach (DataRow dr in dt_tip.Rows)
            {
                auxiuliar = dr.Field<string>(0);
            }
            return (auxiuliar);
        }

        //Funcion para eliminar al cliente, se cambia el estado a inactivo
        public void Eliminar(string entrada)
        {
            SqlCommand acutalizar = new SqlCommand("UPDATE Tipo SET Estado = @est WHERE ID = @id");
            acutalizar.Parameters.AddWithValue("@id", this.ID);
            acutalizar.Parameters.AddWithValue("@est", entrada);
            Acceso.executeQuery(acutalizar);
        }

        //Esta funcion rellena la tabla
        public void rellenar(string est)
        {
            string selection = "SELECT * FROM Tipo WHERE Estado = '"+est+"' ";
            Acceso.readDatathroughAdapter(selection, this.dt_tip);
        }


        public void Actualizar()
        {
            SqlCommand acutalizar = new SqlCommand("UPDATE Tipo SET Nom = @nom, Precio = @prec, Num_Per = @NP WHERE ID = @id");
            acutalizar.Parameters.AddWithValue("@id", this.ID);
            acutalizar.Parameters.AddWithValue("@nom", this.Nombre);
            acutalizar.Parameters.AddWithValue("@prec", this.Precio);
            acutalizar.Parameters.AddWithValue("@NP", this.Num_Per);

            Acceso.executeQuery(acutalizar);
        }

        public void Insertar(){
            SqlCommand insertar = new SqlCommand("INSERT INTO Tipo(ID, Nom, Precio, Num_per, Estado) VALUES(@id, @nom, @prec, @num, '1')");
            insertar.Parameters.AddWithValue("@id", this.Generador_ID());
            //con la linea superior llamo a generar un numero aleatorio que no exista ya en la base de datos y se envia a guardar
            insertar.Parameters.AddWithValue("@nom", this.Nombre);
            insertar.Parameters.AddWithValue("@prec", this.Precio);
            insertar.Parameters.AddWithValue("@num", this.Num_Per);
            Acceso.executeQuery(insertar);
        }


        private string Generador_ID()
        {
            Random generador = new Random();
            int auxiliar = generador.Next(0, 99);//creo un auxiliar y le asigno un valor aleatorio
            while (this.Buscar_Login(auxiliar.ToString())) //mientras se encuentre un valor con el auxiliar, se genera otro
            {
                auxiliar = generador.Next(0, 99);
            }
            return (auxiliar.ToString());
        }
        //Con esto busco el ID en la tabla y devuelvo un bool
        private bool Buscar_Login(string entrada)
        {
            string selecion = "SELECT ID FROM Tipo WHERE ID = '" + entrada + "'"; //comando sql

            Acceso.readDatathroughAdapter(selecion, this.dt_tip);
            if (dt_tip.Rows.Count == 1) //si la cantidad de entradas en la tabla es igual a 1 se procede
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
