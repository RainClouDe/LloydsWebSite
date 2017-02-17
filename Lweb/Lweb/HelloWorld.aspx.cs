using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lweb
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            ServiceReference1.ID_Table[] detailslist;

            detailslist = proxy.GetUserDetails();

            for (int i = 0; i < detailslist.Length; i++)
            {
                testdiv.InnerHtml = detailslist[i].Name;
                testdiv.InnerHtml += detailslist[i].Surname;
            }
        }
    }
}