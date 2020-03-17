using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class age : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BLClass B1 = new BLClass();
            try
            {
                txtage.Text =
                    B1.age(DateTime.Parse(txtdob.Text)).ToString();

            }
            catch(customexception E)
            {
                Response.Write(E.Message);
            }
        }
    }
}