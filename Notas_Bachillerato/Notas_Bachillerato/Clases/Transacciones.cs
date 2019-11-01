using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Notas_Bachillerato.Clases
{
    class Transacciones
    {
        private string sql;
        private SqlConnection con;
        private SqlCommand cmd;
        private Usuarios user;

        public Transacciones()
        {
            this.sql = "";
            this.con = new SqlConnection();
            this.cmd = new SqlCommand();
            this.con.ConnectionString = "Data Source=HP-PC\SQLEXPRESS; Initial Catalog=DBNotas_Bachillerato; Integrated Security=True";
        }

        public DataTable consultar(string tabla)
        {
            DataTable datos = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            switch (tabla)
            {
                case "Usuario":
                    this.sql = "select * from Usuario";
                    break;
                case "otra tabla":
                    this.sql = "select a otra tabla";
                    break;
                default:
                    MessageBox.Show("Tabla " + tabla + " no existe!");
                    break;
            }

            try
            {
                this.con.Open();
                adapter = new SqlDataAdapter(this.sql, this.con.ConnectionString);
                adapter.Fill(datos);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrio este error: " + ex.Message);
            }
            finally
            {
                this.con.Close();
            }
            return datos;
        }

        public bool ejecutar(string sql)
        {
            try
            {
                this.cmd.CommandText = sql;
                this.cmd.Connection = this.con;
                this.cmd.Connection.Open();
                this.cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                this.cmd.Connection.Close();
            }
        }

        public bool insertar(object obj, string tabla)
        {
            switch (tabla)
            {
                case "Usuario":
                    this.user = (Usuarios)obj;
                    this.sql = "insert into Usuario values ('" + this.user.NombreUsuario + "'," + this.user.IdDocente + ",'" + this.user.Contra + "'," + this.user.IdTipo + ")";
                break;
                case "otra tabla":
                break;
                default:
                    MessageBox.Show("Tabla inválida");
                break;
            }
            if (ejecutar(this.sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool modificar(object obj, string tabla)
        {
            switch (tabla)
            {
                case "Usuario":
                    this.user = (Usuarios)obj;
                    this.sql = "update Usuario set IdDocente=" + this.user.IdDocente + ", Contraseña='" + this.user.Contra + "', IdTipo=" + this.user.IdTipo + " where Nombre_usuario='" + this.user.NombreUsuario + "'";
                break;
                case "otra tabla":
                break;
                default:
                    MessageBox.Show("Tabla inválida");
                break;
            }
            if (ejecutar(this.sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool eliminar(object obj, string tabla)
        {
            switch (tabla)
            {
                case "Usuario":
                    this.user = (Usuarios)obj;
                    this.sql = "delete Usuario where Nombre_usuario= '"+this.user.NombreUsuario+"'";
                break;
                case "otra tabla":
                break;
                default:
                    MessageBox.Show("Tabla inválida");
                break;
            }
            if (ejecutar(this.sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable filtrar(string tabla, string campo, string criterio)
        {
            DataTable datos = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            this.sql = "select * from " + tabla + " where " + campo + " like '%" + criterio + "%'";

            try
            {
                this.con.Open();
                adapter = new SqlDataAdapter(this.sql, this.con.ConnectionString);
                adapter.Fill(datos);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrio este error: " + ex.Message);
            }
            finally
            {
                this.con.Close();
            }
            return datos;
        }
    }
}
