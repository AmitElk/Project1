using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Application3
{
    public partial class Hellow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["customer"] != null)
            {
                Customer cust = (Customer)Session["customer"];
                Label1.Text = $"Welcome user {cust.UserName}";
            }
            else { Response.Redirect("login.aspx"); }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Edit.aspx");
        }
    }
}