using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaAcessoDatos
{
    class Conexion
    {
        public SqlConnection conex = new SqlConnection("Data source =DESKTOP-MA7ASJJ\\SQLEXPRESS; " +
            "Initial catalog = SistemaNotas; Integrated Security = True");

        public void abrir_conexion()
        {
            if (conex.State == ConnectionState.Closed)
                conex.Open();
        }
        public void cerrar_conexcion()
        {
            if (conex.State == ConnectionState.Closed)
                conex.Close();
        }
    }
}
