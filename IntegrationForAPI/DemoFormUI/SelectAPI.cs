using Integration.Business.Concrete.TSoft;
using Integration.Core.Utilities.Helper;
using Integration.DataAccess.Concrete.TSoft;
using System;
using System.Windows.Forms;

namespace DemoFormUI
{
    public partial class SelectAPI : Form
    {
        private TSoftLoginFrm loginFrm=new TSoftLoginFrm();
        public SelectAPI()
        {
            InitializeComponent();
        }


        private void btnTsoftApi_Click(object sender, EventArgs e)
        {
            loginFrm.ShowDialog();
        }
    }
}