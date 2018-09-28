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
    public partial class AddCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBcalls db = new DBcalls();
            DataTable datTable = db.GetPlans();
            drpCustPlanID.DataSource = datTable;
            drpCustPlanID.DataTextField = "PlanName";
            drpCustPlanID.DataValueField = "PlanID";
            drpCustPlanID.DataBind();
            drpCustPlanID.Items.Insert(0, new ListItem(String.Empty, String.Empty));
            drpCustPlanID.SelectedIndex = 0;
        }

        protected void btnAddCustomer_Click(object sender, EventArgs e)
        {
            int CustID;
            int.TryParse(txtCustID.Value, out CustID);
            string CustName = txtCustName.Value;
            string CustEmail = txtCustEmail.Value;
            int CustPlanID;
            int.TryParse(drpCustPlanID.SelectedValue, out CustPlanID);
            DBcalls db = new DBcalls();
            db.AddCustomer(CustID, CustName, CustEmail, CustPlanID);

        }
    }
}