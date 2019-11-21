using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources
{
    public static class Resources
    {
        #region Default.aspx

        public const string USER_EMAIL = "Recipient email";
        public const string USER_MESSAGE = "Your message";
        public const string SEND = "Send message";
        public const string INVALID_EMAIL = "Invalid email.\nPlease check  entered email.";

        #endregion

        #region Master

        public const string MASTER_MESSAGE = "Message";
        public const string SENDER = "Sender";
        public const string  CREDO = "Communicate is easy";
        public const string FOOTER = "Test task";

        #endregion

        #region Sended

        public const string BACK = "Back";
        public const string WAS_SENED = "The letter was sent to ";

        #endregion

        #region Backend

        public const string COOKIES_SET = "localhostCookies";
        public const string EMAIL = "email";
        public const string MESSAGE = "message";
        public const string PATH_TO_SENDED = "~/Sended.aspx";

        #endregion
    }
}
