using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Application3
{
    public partial class Registar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = TextBox7.Text;
            string pass = TextBox8.Text;
            string phone = TextBox5.Text;
            bool b = Customer.SingUp(user, pass, phone);
            if (b == true) Label1.Text = "Succes Sing up";
            else Label1.Text = "faild Sing up";

        }
    }
}