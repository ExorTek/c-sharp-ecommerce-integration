using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSoft.Business.Concrete;
using TSoft.Business.Concrete.TSoft;
using TSoft.Core.Utilities.Helper;
using TSoft.DataAccess.Concrete;
using TSoft.DataAccess.Concrete.TSoft;
using TSoft.Entities.Concrete;

namespace MainFrm
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        readonly ProductManager _productManager = new (new EProductDal());
        readonly UserManager _userManager = new (new EUserDal());

        private void button1_Click(object sender, EventArgs e)
        {
            var product = _productManager.GetAll();
            dataGridView1.DataSource = product.Data;
            Debug.WriteLine(product.Data.Count);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            var user = _userManager.Login();
            if (user == null)
            {
                MessageBox.Show("Error", "Login Fail",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                Close();
            }
            else
            {
                MessageBox.Show("Loading", "Login Successful");
                TSoftConfigurationHelper.Token = user.Data[0].Toksen;
            }
        }

    }
}