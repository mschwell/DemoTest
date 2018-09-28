using DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace DemoTest
{
    public partial class Email : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DBcalls db = new DBcalls();
                DataTable datTable = db.GetCustomers();
                drpCustID.DataSource = datTable;
                drpCustID.DataTextField = "CustName";
                drpCustID.DataValueField = "CustID";
                drpCustID.DataBind();
                drpCustID.Items.Insert(0, new ListItem(String.Empty, String.Empty));
                drpCustID.SelectedIndex = 0;
            }
        }

        protected void btnPreview_Click(object sender, EventArgs e)
        {
            int CustID;
            int.TryParse(drpCustID.SelectedValue, out CustID);
            if (CustID > 0)
            {
                DBcalls db = new DBcalls();
                DataTable datTable = db.GetCustomerById(CustID);
                DataRow row = datTable.Rows[0];
                string CustName = row["CustName"].ToString();
                string CustEmail = row["CustEmail"].ToString();
                spnTo.InnerText = "TO: " + CustEmail;
                spnSubj.InnerText = "SUBJ: Thank you";
                spnBody.InnerText = "BODY: Hello " + CustName + ", thank you for using Energy Simply.";
            }
            else
            {
                spnTo.InnerText = "TO: ";
                spnSubj.InnerText = "SUBJ: ";
                spnBody.InnerText = "BODY: ";
            }

        }

        protected void btnSendEmail_Click(object sender, EventArgs e)
        {
            int CustID;
            int.TryParse(drpCustID.SelectedValue, out CustID);
            DBcalls db = new DBcalls();
            DataTable datTable = db.GetCustomerById(CustID);
            DataRow row = datTable.Rows[0];
            string CustName = row["CustName"].ToString();
            string CustEmail = row["CustEmail"].ToString();
            spnTo.InnerText = "TO: " + CustEmail;
            spnSubj.InnerText = "SUBJ: Thank you";
            spnBody.InnerText = "BODY: Hello " + CustName + ", thank you for using Energy Simply.";

            var apiKey = "";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(CustEmail, CustName);
            var subject = "Thank you";
            var to = new EmailAddress(CustEmail, CustName);
            var plainTextContent = "Hello " + CustName + ", thank you for using Energy Simply.";
            var htmlContent = "Hello " + CustName + ", thank you for using Energy Simply.";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        }
    }
}