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

namespace TSoftDemoWebCallAPI
{
    public partial class ApiUI : Form
    {
        public ApiUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginHelper loginHelper = new LoginHelper();
            var user = loginHelper.Login("postman");
            Debug.WriteLine(user.Data);
            Debug.WriteLine(user.Message);
            Debug.WriteLine(user.Success);

            ProductHelper productHelper = new ProductHelper();
            string token = "";
            foreach (var u in user.Data)
            {
                token = u.Token;
            }

            var prod = productHelper.GetAllProduct(token);
        }
    }
}