using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BELMS
{
    public partial class formLibrarianDashboard : Form
    {
        public formLibrarianDashboard()
        {
            InitializeComponent();
        }
        private void formLibrarianDashboard_Load(object sender, EventArgs e)
        {
            loadForm(new formSearch());
        }

        public void loadForm(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain  .Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadForm(new formSearch());
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            loadForm(new formRecords());
        }
        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            loadForm(new formAddBooks());
        }
        private void btnUserRecords_Click(object sender, EventArgs e)
        {
            loadForm(new formUserRecords());
        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            loadForm(new formAddAccount());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            formLogin pupuntaDun = new formLogin();
            pupuntaDun.Show();
        }
    }
}
