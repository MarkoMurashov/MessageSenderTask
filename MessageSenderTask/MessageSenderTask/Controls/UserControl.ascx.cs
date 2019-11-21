using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmailValidation;
using static Resources.Resources;

namespace MessageSenderTask.Controls
{
    
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        private IEmailValidator _emailValidatior = new EmailValidator();

        protected void Page_Init(object sender, EventArgs e)
        {
            lbEmail.Text = USER_EMAIL;
            lbMessage.Text = USER_MESSAGE;
            Send.Text = SEND;

            HttpCookie cookieReq = Request.Cookies[COOKIES_SET];

            if (cookieReq != null)
            {
                txtEmail.Text = cookieReq[EMAIL];
                txtMessage.InnerText = cookieReq[MESSAGE];
            }

            txtMessage.Rows = 10;
        
        }

     
        protected void Send_Click(object sender, EventArgs e)
        {
            if (!_emailValidatior.IsValid(txtEmail.Text))
            {
                lbInValid.Visible = true;
                lbInValid.ForeColor = Color.Red;
                lbInValid.Text = INVALID_EMAIL;
            }
            else
            {

                HttpCookie cookie = new HttpCookie(COOKIES_SET);
                cookie.Expires = DateTime.Now.AddDays(20);

                cookie[EMAIL] = txtEmail.Text;
                cookie[MESSAGE] = txtMessage.InnerText;


                Response.Cookies.Add(cookie);

                Response.Redirect(PATH_TO_SENDED);
            }
        }
    }
}