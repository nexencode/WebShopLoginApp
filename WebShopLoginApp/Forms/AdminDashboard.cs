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
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customizeDesign()
        {
            panelUsers.Visible = false;
            panelRoles.Visible = false;
            panelProducts.Visible = false;
            panelFinance.Visible = false;
            //..
        }

        private void hideSubMenu()
        {
            if (panelUsers.Visible == true)
            {
                panelUsers.Visible = false;
            }
            if (panelRoles.Visible == true)
            {
                panelRoles.Visible = false;
            }
            if (panelProducts.Visible == true)
            {
                panelProducts.Visible = false;
            }
            if (panelFinance.Visible == true)
            {
                panelFinance.Visible = false;
            }
        }
        
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #region Users Panel
        private void btnUsers_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUsers);
        }

        private void butUserCreate_Click(object sender, EventArgs e)
        {
            //Show Create User Form
            openChildForm(new frmCreateUser());

            hideSubMenu();
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnUserDelet_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnUserFilter_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            //Show Create User Form
            openChildForm(new frmFilterUsers());
        } 
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Roles Panel
        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRoles);
        }

        private void btnRoleCreate_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnRoleUpdate_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnRoleDelete_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        #region Products Panel
        private void btnProducts_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProducts);

        }

        private void btnProductsCreate_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnProductsUpdate_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnProductsDelete_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        #region Finance Panel
        private void btnFinance_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFinance);

        }

        private void btnFncSetDisocunt_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnFncRefundMoney_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelLoadForm.Controls.Add(childForm);
            panelLoadForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
