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

namespace serkansipahiProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=serkansProject;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            String username, password;

            username = usernameTextBox.Text;
            password = passwordTextBox.Text;

            try
            {
                string queery = "SELECT * From Login WHERE username = '" + usernameTextBox.Text + "' AND password = '" + passwordTextBox.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(queery, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = usernameTextBox.Text;
                    password = passwordTextBox.Text;

                    Menuform form2 = new Menuform();
                    form2.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                    usernameTextBox.Clear();
                }
            }

            catch
            {
                MessageBox.Show("Error!");
            }

            finally
            {
                conn.Close();
            }

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            usernameTextBox.Focus();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
