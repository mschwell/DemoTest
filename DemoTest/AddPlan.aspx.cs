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
    public partial class AddPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddPlan_Click(object sender, EventArgs e)
        {
            int PlanID;
            int.TryParse(txtPlanID.Value, out PlanID);
            string PlanName = txtPlanName.Value;
            decimal PlanFixedCost;
            decimal.TryParse(txtPlanFixedCost.Value, out PlanFixedCost);
            decimal PlanVarCost;
            decimal.TryParse(txtPlanVarCost.Value, out PlanVarCost);
            DBcalls db = new DBcalls();
            db.AddPlan(PlanID, PlanName, PlanFixedCost, PlanVarCost);
        }
    }
}