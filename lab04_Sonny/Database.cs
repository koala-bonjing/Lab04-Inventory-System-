using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace lab04_Sonny
{
    //Database class for establish connection between the database and the system
    class Database
    {
        //connection string 
        public string connectionString = "server=localhost; user=root; database=Salecodb; pwd=;";

        //method to get the data accept a string sql as a parameter: suludan an method san 'sql' :sql = query code
        public DataTable getData1(string sql, MySqlParameter parameter)

        {
            //Datatable to represent the rows/column of the database 
            DataTable dt = new DataTable();

            //MySqlConnection Class: amo ini ha Erika! an insasabi ni sir na 'SqlConnection' 1st step ini after mag declare connnection string
            //Amo ya an 1st: Establish connection between the databse and the system, tas an ipass mo na parameter is an name san connection string
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Nah try & catch akoo para error handling 
                try
                {
                    //MySqlCommand Class: amo man ini an 'SqlCommand', didi man isusulod an commands mo. an query code baga
                    //e.g: "sql = @"SELECT p.p_code, p.p_descript, p.p_price, v.v_name 
                    //FROM product p
                    // JOIN vendor v ON p.v_code = v.v_code; "; 
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        if (parameter != null)
                        {
                            cmd.Parameters.Add(parameter);
                        }
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
                //Ini an Exeception na i tothrow san program kun may sala 
                catch (MySqlException ex) 
                {
                    MessageBox.Show("Sql Error: " + ex.Message);
                }
                //Close 'function?' dunno kun function an gahoy sun
                //always magclose every tapos san code mo na inopen mo ha para di ka mapagal
                finally
                {
                    connection.Close();
                }
                //Return dt since an ginamit ta na return type is 'Datatable'. Here ho: ' public 'DataTable' getData(string sql)'
                return dt;
            }
            

        }
        public DataTable getData2(string sql)

        {
            //Datatable to represent the rows/column of the database 
            DataTable dt = new DataTable();

            //MySqlConnection Class: amo ini ha Erika! an insasabi ni sir na 'SqlConnection' 1st step ini after mag declare connnection string
            //Amo ya an 1st: Establish connection between the databse and the system, tas an ipass mo na parameter is an name san connection string
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                //Nah try & catch akoo para error handling 
                try
                {
                    //MySqlCommand Class: amo man ini an 'SqlCommand', didi man isusulod an commands mo. an query code baga
                    //e.g: "sql = @"SELECT p.p_code, p.p_descript, p.p_price, v.v_name 
                    //FROM product p
                    // JOIN vendor v ON p.v_code = v.v_code; "; 
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                        
                    }
                }
                //Ini an Exeception na i tothrow san program kun may sala 
                catch (MySqlException ex)
                {
                    MessageBox.Show("Sql Error: " + ex.Message);
                }
                //Close 'function?' dunno kun function an gahoy sun
                //always magclose every tapos san code mo na inopen mo ha para di ka mapagal
                finally
                {
                    connection.Close();
                }
                //Return dt since an ginamit ta na return type is 'Datatable'. Here ho: ' public 'DataTable' getData(string sql)'
                return dt;
            }


        }


    }
}
