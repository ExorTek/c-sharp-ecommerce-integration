using Integration.Business.Concrete.TSoft;
using Integration.Core.Utilities.Helper;
using Integration.DataAccess.Concrete.TSoft;
using System;
using System.Windows.Forms;

namespace DemoFormUI
{
    public partial class TSoftLoginFrm : Form
    {
        TSoftMainFrm tSoftMainFrm = new TSoftMainFrm();


        public TSoftLoginFrm()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUserName.Text == "" || tbxPasswd.Text == "")
            {
                epUserNameOrPasswdWrong.Clear();
                epUserNamePasswdNull.SetError(tbxUserName, "Bu alan boş geçilemez");
                epUserNamePasswdNull.SetError(tbxPasswd, "Bu alan boş geçilemez");
                lblErrorUserName.Text = "Bu alan boş geçilemez";
                lblErrorPasswd.Text = "Bu alan boş geçilemez";
            }
            else
            {
                epUserNamePasswdNull.Clear();
                lblErrorUserName.Text = "";
                lblErrorPasswd.Text = "";
                TSoftConfigurationHelper.UserName = tbxUserName.Text;
                TSoftConfigurationHelper.Password = tbxPasswd.Text;
                TSoftUserManager userManager = new TSoftUserManager(new ETSoftUserDal());
                var user = userManager.Login();

                if (user.Success == false)
                {
                    epUserNameOrPasswdWrong.SetError(tbxUserName, "Kullanıcı adı veya şifre yanlış");
                    lblErrorUserName.Text = "Kullanıcı adı veya şifre yanlış";
                }
                else
                {
                    epUserNameOrPasswdWrong.Clear();
                    lblErrorUserName.Text = "";
                    TSoftConfigurationHelper.Token = user.Data[0].Token;
                    this.Close();
                    tSoftMainFrm.ShowDialog();
                }
            }
        }

        private void TSoftLoginFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            tbxPasswd.Text = "";
            tbxUserName.Text = "";
            lblErrorUserName.Text = "";
            lblErrorPasswd.Text = "";
            epUserNameOrPasswdWrong.Clear();
            epUserNamePasswdNull.Clear();
        }
    }
}