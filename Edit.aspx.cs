using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Application3
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            string password = TextBox2.Text;
            string newpassword = TextBox3.Text;
            bool b = Customer.ChangePassword(username, password, newpassword);
            if (b == true)
            {
                Label1.Text = "Successful Change Paasword";
            }
            else Label1.Text = "Failed Change Paasword";
        }
    }
}