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

namespace sysarch_windows_app
{
    public partial class College : Form
    {
        private string connectionString = "server=127.0.0.1; database=department_sysarch; uid=root; pwd=sukhoi57;";

        public College()
        {
            InitializeComponent();
        }

        private void College_Load(object sender, EventArgs e)
        {
            LoadColleges();
        }

        private void LoadColleges()
        {
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM college WHERE IsActive = 1"; // Load only active colleges
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt; // Assuming dataGridView1 is your College DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO college (CollegeName, CollegeCode, IsActive) VALUES (@CollegeName, @CollegeCode, 1)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CollegeName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@CollegeCode", textBox2.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("College added successfully!");
                    LoadColleges(); // Refresh grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int collegeID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CollegeID"].Value);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE college SET CollegeName = @CollegeName, CollegeCode = @CollegeCode WHERE CollegeID = @CollegeID";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@CollegeID", collegeID);  
                            cmd.Parameters.AddWithValue("@CollegeName", textBox1.Text);
                            cmd.Parameters.AddWithValue("@CollegeCode", textBox2.Text);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("College updated successfully!");
                        LoadColleges();  
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a college to update.");
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int collegeID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CollegeID"].Value);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE college SET IsActive = 0 WHERE CollegeID = @CollegeID";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@CollegeID", collegeID);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("College deleted (soft delete).");
                        LoadColleges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a college to delete.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row is selected (not the header)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
//bomboclatttt fix kunohay
                // Assuming you have textBox1 for CollegeName and textBox2 for CollegeCode
                textBox1.Text = row.Cells["CollegeName"].Value.ToString();
                textBox2.Text = row.Cells["CollegeCode"].Value.ToString();
            }
        }
    }
}
