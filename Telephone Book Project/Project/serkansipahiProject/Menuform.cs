using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using serkansipahiProject.PhoneInfo;
using System.Configuration;

namespace serkansipahiProject
{
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();
        }



        Phone ph = new Phone();

        private void Menuform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'serkansProjectDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.serkansProjectDataSet.Person);
            DataTable dt = ph.Select();
            dataGridView1.DataSource = dt;
        }

        public void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtSearch.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            comboBoxLanguage.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ph.Id = txtID.Text;
            ph.Name = txtName.Text;
            ph.Surname = txtSurname.Text;
            ph.phoneNum = txtPhone.Text;
            ph.Address = txtAddress.Text;

            if (radioButtonMale.Checked) ph.Gender = radioButtonMale.Text;
            if (radioButtonFemale.Checked) ph.Gender = radioButtonFemale.Text;
            ph.Language = comboBoxLanguage.Text;

            bool success = ph.Insert(ph);

            if (success == true)
            {
                MessageBox.Show("A new User inserted to DB");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed");
            }

            DataTable dt = ph.Select();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ph.Id = txtID.Text;
            ph.Name = txtName.Text;
            ph.Surname = txtSurname.Text;
            ph.phoneNum = txtPhone.Text;
            ph.Address = txtAddress.Text;

            if (radioButtonMale.Checked) ph.Gender = radioButtonMale.Text;
            if (radioButtonFemale.Checked) ph.Gender = radioButtonFemale.Text;
            ph.Language = comboBoxLanguage.Text;


            bool success = ph.Update(ph);
            if (success == true)
            {
                MessageBox.Show("Record has been updated");


                DataTable dt = ph.Select();
                dataGridView1.DataSource = dt;


                Clear();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void personsDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ph.Id = txtID.Text;
            bool success = ph.Delete(ph);
            if (success)
            {

                MessageBox.Show("Record has been deleted");

                DataTable dt = ph.Select();
                dataGridView1.DataSource = dt;


                Clear();

            }
            else
            {

                MessageBox.Show("Record has not been deleted");
            }
        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["serkansipahiProject.Properties.Settings.serkansProjectConnectionString"].ConnectionString;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstrng);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Person WHERE Id LIKE '%" + keyword + "%' OR Name LIKE '%" + keyword + "%'", conn);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dataGridView1.DataSource = dt;

        }
    }
}
