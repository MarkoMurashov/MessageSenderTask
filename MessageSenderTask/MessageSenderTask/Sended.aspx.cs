using System;
using System.Web;
using static Resources.Resources;

namespace MessageSenderTask
{
    public partial class Sended : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            btnBack.Text = BACK;

            HttpCookie cookieReq = Request.Cookies[COOKIES_SET];

            if (cookieReq != null)
            {
                lblResponse.Text = WAS_SENED + cookieReq[EMAIL];
            }

        }
    }
}