using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private string connectionStr;
        public Form1()
        {
            InitializeComponent();
            connectionStr = ConfigurationManager.ConnectionStrings["P111DB"].ConnectionString;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            //string query = "select TypeName from GroupType where Id = 2";
            string queryList = "select * from GroupType";
            FillCombobox(queryList, cmbGroupType);

            string queryDgv = "Select * from GETDETAILSTUDENT";

            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(queryDgv, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgv.DataSource = table;
                }
            }
        }

        private async void CmbGroupType_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbGroup.Items.Clear();
            string grouptype=cmbGroupType.Text;
            string queryList= $"select* from Groups where " +
                $"GroupTypeId = (select Id from GroupType " +
                $"where TypeName = '{grouptype}')";
            FillCombobox(queryList, cmbGroup);
        }

        private async void FillCombobox(string query,ComboBox cmb)
        {
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = await comm.ExecuteReaderAsync();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cmb.Items.Add(reader.GetValue(1));
                        }
                    }
                }
            }
        }

        private async void BtnSaveStd_Click(object sender, EventArgs e)
        {
            string name = txtStdName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string group = cmbGroup.Text;

            if (name == "" || surname == "" || group == "")
            {
                MessageBox.Show("Filled all input", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            string query = $"insert into Student " +
                $"values('{name}','{surname}',(Select Id From Groups where GroupName='{group}'))";
            using(SqlConnection conn=new SqlConnection(connectionStr))
            {
                conn.Open();
                using(SqlCommand comm=new SqlCommand(query, conn))
                {
                    int resultNonQuery = await comm.ExecuteNonQueryAsync();
                    if (resultNonQuery != 0)
                    {
                        MessageBox.Show("Succesfully added", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
