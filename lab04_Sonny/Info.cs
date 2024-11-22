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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }
        //Same as Form1.frm lang nothing special
        Database DB = new Database();
        DataTable dt = new DataTable();
        string sql = "";

        private void dtgIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Info_Load(object sender, EventArgs e)
        {
            
            //Same lang san Form1 yaa
            sql = @"SELECT p.p_code, p.p_descript, p.p_price, v.v_name, v.v_code 
                   FROM product p 
                   JOIN vendor v ON p.v_code = v.v_code;";
            dt = DB.getData2(sql);
            dtgIn.DataSource = dt;
        }
    }
}
