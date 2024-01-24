using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class InstrumentoNegocio
    {
        public List<Insturmento> Listar()
        {
            List<Insturmento> lista = new List<Insturmento>();
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            try
            {
                conn.ConnectionString = "server=.\\SQLEXPRESS; database=INSTRUMENTOS_DB; integrated security=true";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select Marca, Modelo, CantidadCuerdas, UrlImagenEjemplo, Color, IdTipo, IdMadera, Precio From GUITARRA";
                cmd.Connection = conn;

                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Insturmento aux = new Insturmento();
                    aux.Marca = (string)reader["Marca"];
                    aux.Modelo = (string)reader["Modelo"];
                    aux.CantidadCuerdas = (int)reader["CantidadCuerdas"];
                    aux.UrlImagenEjemplo = (string)reader["UrlImagenEjemplo"];
                    aux.Color = (string)reader["Color"];
                    aux.IdTipo = (int)reader["IdTipo"];
                    aux.Precio = (string)reader["Precio"];
                    aux.IdMadera = (int)reader["IdMadera"];                   

                    lista.Add(aux);
                }

                conn.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
