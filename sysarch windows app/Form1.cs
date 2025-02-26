using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sysarch_windows_app
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=127.0.0.1; database=department_sysarch; uid=root; pwd=sukhoi57;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadColleges();
            LoadDepartments();
        }

        private void LoadColleges()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CollegeID, CollegeName FROM college";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            comboBoxCollege.DataSource = dt;
                            comboBoxCollege.DisplayMember = "CollegeName";  // Show name
                            comboBoxCollege.ValueMember = "CollegeID";  // Store ID
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading colleges: " + ex.Message);
                }
            }
        }

      
        private void LoadDepartments(bool showAll =false)
        {
           using (MySqlConnection conn = new MySqlConnection(connectionString))
    {

        try
        {
            conn.Open();
            string query = @"
                SELECT d.DepartmentID, c.CollegeID, d.DepartmentName, d.DepartmentCode,  d.IsActive
                FROM department d
                INNER JOIN college c ON d.CollegeID = c.CollegeID
                WHERE d.IsActive = 1";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewDepartments.DataSource = dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading departments: " + ex.Message);
        }
    }
        }




        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            return true;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadDepartments();


        }



        private void dataGridViewDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDepartments.Rows[e.RowIndex];


                if (row.Cells.Count > 3)
                {
                    textBox3.Text = row.Cells[0].Value?.ToString();
                    textBox1.Text = row.Cells[1].Value?.ToString();
                    textBox2.Text = row.Cells[2].Value?.ToString();
                    checkBox1.Checked = row.Cells[3].Value != DBNull.Value && Convert.ToBoolean(row.Cells[3].Value);
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO department (DepartmentName, DepartmentCode, CollegeID, IsActive) VALUES (@Name, @Code, @CollegeID, 1)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Code", textBox2.Text);
                        cmd.Parameters.AddWithValue("@CollegeID", comboBoxCollege.SelectedValue);  
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Department added successfully!");
                    LoadDepartments(); // Refresh DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE department SET IsActive = 1 WHERE DepartmentID = @DepartmentID";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@DepartmentID", textBox3.Text);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Department restored successfully.");
                        LoadDepartments();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: nothing here" + ex.Message);
                    }
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE department SET DepartmentName = @DepartmentName, DepartmentCode = @DepartmentCode, IsActive = @IsActive WHERE DepartmentID = @DepartmentID";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@DepartmentName", textBox1.Text);
                            cmd.Parameters.AddWithValue("@DepartmentCode", textBox2.Text);
                            cmd.Parameters.AddWithValue("@IsActive", checkBox1.Checked ? 1 : 0);
                            cmd.Parameters.AddWithValue("@DepartmentID", textBox3.Text);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Department updated successfully.");
                        LoadDepartments();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE department SET IsActive = 0 WHERE DepartmentID = @DepartmentID";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@DepartmentID", Convert.ToInt32(textBox3.Text));  // Convert string to int
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Department deleted.");
                            }
                            else
                            {
                                MessageBox.Show("No department found with that ID.");
                            }
                        }
                        LoadDepartments();  // Refresh DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           // LoadColleges(checkBox2.Checked);
            LoadDepartments(checkBox2.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            College college = new College();
            college.Show();
            this.Hide();
        }

        private void comboBoxCollege_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
