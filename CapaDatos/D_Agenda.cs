using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos

{
    public class D_Agenda
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cone"].ConnectionString);

        
        public List <E_Agenda>D_Lista(string buscar)
        {
            SqlDataReader Leer;
            SqlCommand cmd = new SqlCommand("sp_lista", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            Leer = cmd.ExecuteReader();

            List<E_Agenda> Lista = new List<E_Agenda>();
            while (Leer.Read())
            {
                Lista.Add(new E_Agenda
                {
                    ID = Leer.GetInt32(0),
                    Nombre = Leer.GetString(1),
                    Apellido = Leer.GetString(2),
                    Direccion = Leer.GetString(3),
                    Fecha_Nacimiento = Leer.GetString(4),
                    Celular = Leer.GetString(5),
                });
                

            }
            cn.Close();
            Leer.Close();
            return Lista;
            
          
        }
        public void Insertar(E_Agenda Registro) 
        {
           SqlCommand cmd = new SqlCommand("InsertarContactoo",cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();


            cmd.Parameters.AddWithValue("@Nombre", Registro.Nombre);
            cmd.Parameters.AddWithValue("@Apellido",Registro.Apellido);
            cmd.Parameters.AddWithValue("@Direccion", Registro.Direccion);
            cmd.Parameters.AddWithValue("@Fecha_Nacimiento", Registro.Fecha_Nacimiento);
            cmd.Parameters.AddWithValue("@Celular", Registro.Celular);

            cmd.ExecuteNonQuery();
            cn.Close();

        }

        public void Modificar(E_Agenda Registro)
        {
            SqlCommand cmd = new SqlCommand("ModificarContactooo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@ID", Registro.ID);
            cmd.Parameters.AddWithValue("@Nombre", Registro.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Registro.Apellido);
            cmd.Parameters.AddWithValue("@Direccion", Registro.Direccion);
            cmd.Parameters.AddWithValue("@Fecha_Nacimiento", Registro.Fecha_Nacimiento);
            cmd.Parameters.AddWithValue("@Celular", Registro.Celular);

            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Eliminarregistro(E_Agenda Registro)
        {
            SqlCommand cmd = new SqlCommand("EliminarRegistro", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();

            cmd.Parameters.AddWithValue("@ID", Registro.ID);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

    }
   
        
    
}
