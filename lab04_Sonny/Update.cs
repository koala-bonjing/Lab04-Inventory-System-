using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04_Sonny
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        //
        Database DB = new Database();

        //
        DataTable DT = new DataTable();

        //
        string sql = "";

        //
        MySqlCommand cmd = new MySqlCommand();

        //
        MySqlConnection conn = new MySqlConnection("server=localhost; user=root; database=Salecodb; pwd=;");
        public void UpdateVAl()
        {
            

            try
            {
               
                conn.Open();
                sql = @"UPDATE product
                            SET p_descript = @descript, p_qoh = @stock, p_min = @minStock, 
                            WHERE p_code = @pcode";

                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@id", txtId.Text);
                    command.Parameters.AddWithValue("@descript", txtdescript.Text);
                    command.Parameters.AddWithValue("@stock", Convert.ToInt32(txtstock.Text));
                    command.Parameters.AddWithValue("@min_Stocks", Convert.ToInt32(txtMinStock.Text));
                    command.Parameters.AddWithValue("@price", Convert.ToDouble(txtprice.Text));
                    command.Parameters.AddWithValue("@discount", Convert.ToDouble(txtDiscount.Text));

                    command.ExecuteNonQuery();

                    MessageBox.Show("Input Updated");
                }
            }
            catch
            {

            }
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateVAl();
        }
    }
}
