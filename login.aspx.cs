using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;


namespace Application3
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text =String.Empty;
            string userName = TextBox1.Text;
            string password = TextBox2.Text;
            Customer cust = Customer.Login(userName, password);
            if (cust!=null)
            {
                Session["Customer"] = cust;
                Response.Redirect("Hellow.aspx");
            }
             else
            {
                Label1.Text = "wrong username/password";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registar.aspx");

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {

        }
    }
}