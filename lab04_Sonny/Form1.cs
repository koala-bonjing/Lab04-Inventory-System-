using MySql.Data.MySqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace lab04_Sonny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Inserting Data in the DataGridView

        //First nag create ems san instance san class na 'Database' para ma access an codes didto
        //Create an instance of the Database class
        Database DB = new Database();

        //Creates a Datatable: 'dt' to store the data fetched from the database
        DataTable dt = new DataTable();

        //Query code stores in 'sql'
        string sql = "";

        //Method for Putting datas in to the DataGridView
        public void dataOutput()
        {
            //Query code ini
            sql = @"SELECT p.p_code, p.p_descript, p.p_price, v.v_name 
                   FROM product p 
                   JOIN vendor v ON p.v_code = v.v_code;";

            //Used the 'getData' method from the Class 'Database.cs' in sulod an 'sql' para sa command
            //and stored it inside the 'dt'
            dt = DB.getData2(sql);

            //Nan in sulod na an sulod 'dt' sa "dtgOutput: name yaa san DataGridView ko ha"
            //Used the 'dt' as the DataSource
            dtgOutput.DataSource = dt;

            return;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Used the dataOutput method sa Form
            dataOutput();
        }

        //Searching using button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            string filter = "SELECT * FROM product WHERE p_descript LIKE @search OR p_code LIKE @search"; // Query with a placeholder


            try
            {
                Database DB = new Database();
                DataTable dt = DB.getData1(filter, new MySqlParameter("@search", "%" + search + "%"));

                dtgOutput.DataSource = dt; // Bind the result to DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }
        //Reloads the form
        private void btnReload_Click(object sender, EventArgs e)
        {
            dataOutput();
        }

        //Going to another form 'Add.frm'
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Creating new form--> Add.frm
            var newform = new Add();
            newform.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Creating new form----> Update.frm
            var newform = new Update();
            newform.Show();
        }
    }

}
    