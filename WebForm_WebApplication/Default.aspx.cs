using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_WebApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!Page.IsPostBack)
            {
                List<string> lst = new List<string>()
                 {
                         "Item 1 from list",
                         "Item 2 from list"
                 };
                DropDownList1.DataSource = lst;
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = (Convert.ToInt32(TextBox1.Text) -Convert.ToInt32(TextBox2.Text)).ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropDownList1.SelectedIndex)
            {
                case 0:
                    Label2.Text = "You have selected " + "\" " + DropDownList1.Text + "\"";
                    break;
                case 1:
                    Label2.Text = "Your selected option is: " + "\"" + DropDownList1.Text + "\"";
                    break; 
            }
        }
    }
}