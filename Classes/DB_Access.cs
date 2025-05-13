using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flex_Trainer.Classes
{
    internal class DB_Access
    {
        //Hussnain
        //public string ConnectionString = "Data Source=DESKTOP-PFP9UIG\\SQLEXPRESS;Initial Catalog = flex_trainer; Integrated Security = True; Encrypt=False";

        //Sohaib
        public string ConnectionString = "Data Source=MARIO-PC\\SQLEXPRESS;Initial Catalog=flex_trainer;Integrated Security=True;Encrypt=False";

        public DataTable search_to_check(string query)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);

            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(query);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public void query_data(string query)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex) 
            {
                
                MessageBox.Show(ex.Message);
                MessageBox.Show(query);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
