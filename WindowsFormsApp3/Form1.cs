using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //視窗初始化

        }
    
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strAccount = tbAccount.Text;
            string strPassword = tbPassword.Text;
            string strMessage = "";

            string strUser1 = "john";
            string strPassword1 = "2569";

            strMessage = "Login Account :" + strAccount + "\n";

            //先判斷帳號密碼有沒有輸入
            if ((strAccount == "")||(strPassword==""))
            {
                strMessage = "帳號密碼請勿空白";
            }
            else
            {
                if ((strAccount == strUser1) && (strPassword == strPassword1))
                {
                    //登入成功
                    strMessage = "log in successfully.";
                       
                }
                else
                {
                    //帳號密碼不符
                    if (strAccount != strUser1)
                    {
                        strMessage = "Wrong Account";
                    }
                    else
                    {
                        strMessage = "wrong Password";
                    }
                }
            }

            lblMessage.Text = strMessage;
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            tbAccount.Text = "";
            tbPassword.Text = "";
            lblMessage.Text = "Please Log in";
        }
    }
}
