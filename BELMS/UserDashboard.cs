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
    public partial class formUserDashboard : Form
    {
        public formUserDashboard()
        {
            InitializeComponent();
        }

        private void formUserDashboard_Load(object sender, EventArgs e)
        {
            loadForm(new formBorrow());
        }

        public void loadForm(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            loadForm(new formBorrow());
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            loadForm(new formHistory());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            formLogin pupuntaDun = new formLogin();
            pupuntaDun.Show();
        }
    }
}
