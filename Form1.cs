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

namespace Contact_Application
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=Clearance;Initial Catalog=contact;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtSurname.Text == "" || txtIDNumber.Text == "" || txtAge.Text == "" || cmbGender.Text == "" || txtConatc.Text == "" || txtEmail.Text == "" || txtHome.Text == "")
            {
                MessageBox.Show("Enter all the field");
            }
            else
            {
                con.Open();
                string query = "insert into Contact values ('" + txtName.Text + "', '" + txtSurname.Text + "', '" + txtIDNumber.Text + "', '" + txtAge.Text + "', '" + cmbGender.SelectedItem.ToString() + "', '" + txtConatc.Text + "', '" + txtEmail.Text + "', '" + txtHome.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thank you for your details, we will contact you in due time");
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtIDNumber.Text = "";
            txtAge.Text = "";
            cmbGender.Text = "";
            txtConatc.Text = "";
            txtEmail.Text = "";
            txtHome.Text = "";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
        }
    }
}
