using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebShopLoginApp
{
    public partial class frmFilterUsers : Form
    {
        List<User> users = new List<User>();
        public frmFilterUsers()
        {
            InitializeComponent();

            FilterUsers.DataSource = users;

            FilterUsers.DisplayMember = "FullInfo";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            users = db.GetUsers(txtLastName.Text);
        }
    }
}
