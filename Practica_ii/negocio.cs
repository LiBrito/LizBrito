using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using P2;

namespace Practica_ii
{
    public class negocio
    {
        private DB_conn objeto_1 = new DB_conn();

        public DataTable mostrarprod()
        {
            DataTable tabla = new DataTable ();
            tabla = objeto_1.muestra();
            return tabla;
        }
        public DataSet act()
        {
            DataSet lala = new DataSet();
            lala = objeto_1.actualizar();
            return lala;
        }

        public void insert(string id, string nombre, string state, string categoria, string fdate, string vdate, string stock)
        {
            objeto_1.insertar(Convert.ToInt32(id), nombre, state, categoria, Convert.ToDateTime(fdate), Convert.ToDateTime(vdate), Convert.ToInt32(stock));
        }
        public void delete(string id)
        {
            objeto_1.delete(Convert.ToInt32(id));
        }

        public void modify(string id, string nombre, string state, string categoria, string fdate, string vdate, string stock)
        {
            objeto_1.modificar(Convert.ToInt32(id), nombre, state, categoria, Convert.ToDateTime(fdate), Convert.ToDateTime(vdate), Convert.ToInt32(stock));
        }
    }
}
