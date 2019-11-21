using System;
using static Resources.Resources;

namespace MessageSenderTask
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLogo.Text = MASTER_MESSAGE;
            lblSender.Text = SENDER;
            lblCredo.Text = CREDO;
            lblFooter.Text = FOOTER;
        }
    }
}