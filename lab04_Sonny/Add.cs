using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab04_Sonny
{
    public partial class Add : Form
    {
       
        public Add()
        {
            InitializeComponent();
        }
        //Same creates an instance of the Class 'Database'
        Database DB = new Database();

        //Datatable
        DataTable DT = new DataTable();

        //'sql' variable to store query code
        string sql = "";

        //SqlCommand 
        MySqlCommand command = new MySqlCommand();

        //SqlConnection
        MySqlConnection conn = new MySqlConnection("server=localhost; user=root; database=Salecodb; pwd=;");

        //Method for adding value
        public void addVal()
        {


            try
            {
                //Open Connection
                conn.Open();

                //Check if the v_code exist from vendor table
                //Binutang ko yaa kay para maaraman kung an v_code is from the table 'vendor'
                //kay an v_code na iinput is dapat an existing v_code na sa database
                int venCode;
                if (!int.TryParse(txtv_code.Text.Trim(), out venCode))
                {
                    MessageBox.Show("Please enter a valid vendor code.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string vendorName = txtvendor.Text.Trim();

                // Check if the vendor already exists
                string venSql = "SELECT COUNT(*) FROM vendor WHERE v_code = @ven_code";
                long venCount;
                using (MySqlCommand venCom = new MySqlCommand(venSql, conn))
                {
                    venCom.Parameters.AddWithValue("@ven_code", venCode);
                    venCount = Convert.ToInt64(venCom.ExecuteScalar());
                }

                // If the vendor doesn't exist, insert it
                //pag wara pa san vendor na in input mo amo na yaa maka add ka
                if (venCount == 0)
                {
                    string insertVendorSql = "INSERT INTO vendor (v_code, v_name) VALUES (@ven_code, @vendor_name)";
                    using (MySqlCommand insertVenCom = new MySqlCommand(insertVendorSql, conn))
                    {
                        insertVenCom.Parameters.AddWithValue("@ven_code", venCode);
                        insertVenCom.Parameters.AddWithValue("@vendor_name", vendorName); // Add vendor name

                        insertVenCom.ExecuteNonQuery();
                        MessageBox.Show("Vendor added successfully!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vendor already exists!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                string sql = @"INSERT INTO product
                     (p_code, p_descript, p_indate, p_qoh, p_min, p_price, p_discount)
                      VALUES
                      (@id, @descript, @date, @stocks, @min_stocks, @price, @discount)";


                //SqlComman to add the values into the databse
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@id", txtId.Text);
                    command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@descript", txtdescript.Text);
                    command.Parameters.AddWithValue("@stocks", Convert.ToInt32(txtstocks.Text));
                    command.Parameters.AddWithValue("@min_stocks", Convert.ToInt32(txtminStocks.Text));
                    command.Parameters.AddWithValue("@price", Convert.ToDouble(txtprice.Text));
                    command.Parameters.AddWithValue("@discount", Convert.ToDouble(txtdiscount.Text));
                    command.Parameters.AddWithValue("@ven_code", Convert.ToInt32(txtv_code.Text));

                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Iclose mo na sya
            finally
            {
                conn.Close();
            }
        }






        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void Add_Load(object sender, EventArgs e)
        {
        }

        //Para man ito sa Info button ko para makita an dataGrid para wara lang 
        
        private void button2_Click(object sender, EventArgs e)
        {
            var newform = new Info();
            newform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Use the addVal() method kay pagparaanuhon?
            addVal();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
