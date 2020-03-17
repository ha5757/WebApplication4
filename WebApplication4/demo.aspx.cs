using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BLClass B = new BLClass();
            try
            {
                txtresult.Text = 
                    B.Divide(txtnumerator.Text,txtdenominator.Text).ToString();
            }
            catch (DivideByZeroException E)
            {
                Response.Write(E.Message);
            }
            catch(FormatException E)
            {
                Response.Write(E.Message);
            }
        }
    }
}