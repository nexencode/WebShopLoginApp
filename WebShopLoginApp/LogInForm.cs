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

namespace WebShopLoginApp
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //const string connectionString = ConfigurationManager.ConnectionStrings["WebShopProjectFinal"];
            SqlConnection sqlcon = new SqlConnection();

            string query = $"select * from Users where Username ='" + usernameTxtBox.Text.Trim() + "'and Password = '" + passwordTxtBox.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                frmAdminDashboard objFrmAdminDashboard = new frmAdminDashboard();
                MessageBox.Show($"Uspesno se se ulogovali");
                this.Hide();
                objFrmAdminDashboard.Show();
            }
            else
            {
                MessageBox.Show($"Check username and password!");
            }

            //if (usernameTxtBox.Text.Trim() == "Nemanja" && passwordTxtBox.Text.Trim() == "123")
            //{
            //    frmAdminDashboard objFrmAdminDashboard = new frmAdminDashboard();
            //    MessageBox.Show($"Uspesno se se ulogovali");
            //    this.Hide();
            //    objFrmAdminDashboard.Show();
            //}
            //else
            //{ 
            //    MessageBox.Show($"Check username and password!");
            //}
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowAdminDash_Click(object sender, EventArgs e)
        {
            frmAdminDashboard objFrmAdminDashboard = new frmAdminDashboard();
            this.Hide();
            objFrmAdminDashboard.Show();
        }
    }
}
