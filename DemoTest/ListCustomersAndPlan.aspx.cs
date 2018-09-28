using DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoTest
{
    public partial class ListCustomersAndPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBcalls db = new DBcalls();
            DataTable datTable = db.ListCustomersAndPlans();

            ListCustomersAndPlans.DataSource = datTable;
            ListCustomersAndPlans.DataBind();

        }
    }
}