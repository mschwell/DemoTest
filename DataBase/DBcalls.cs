using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DBcalls
    {
        public DBcalls()
        {
        }
        public DataTable GetCustomerById(int CustID)
        {
            SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("GetCustomerById", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 5000;

                    sqlCommand.Parameters.Add("@CustID", SqlDbType.Int).Value = CustID;

                    sqlConnection.Open();
                    sqlAdapter.SelectCommand = sqlCommand;
                    sqlAdapter.Fill(dt);
                    sqlConnection.Close();
                }
            }

            return dt;
        }
        public DataTable GetCustomers()
        {
            SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("GetCustomers", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 5000;

                    sqlConnection.Open();
                    sqlAdapter.SelectCommand = sqlCommand;
                    sqlAdapter.Fill(dt);
                    sqlConnection.Close();
                }
            }

            return dt;
        }

        public DataTable ListCustomersAndPlans()
        {
            SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("ListCustomersAndPlans", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 5000;

                    sqlConnection.Open();
                    sqlAdapter.SelectCommand = sqlCommand;
                    sqlAdapter.Fill(dt);
                    sqlConnection.Close();
                }
            }

            return dt;
        }


        public DataTable GetPlans()
        {
            SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("GetPlans", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 5000;

                    sqlConnection.Open();
                    sqlAdapter.SelectCommand = sqlCommand;
                    sqlAdapter.Fill(dt);
                    sqlConnection.Close();
                }
            }

            return dt;
        }

        public bool AddCustomer(int CustID, string CustName, string CustEmail, int CustPlanID)
        {
            SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("AddCustomer", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 5000;

                    sqlCommand.Parameters.Add("@CustID", SqlDbType.Int).Value = CustID;
                    sqlCommand.Parameters.Add("@CustName", SqlDbType.VarChar).Value = CustName;
                    sqlCommand.Parameters.Add("@CustEmail", SqlDbType.VarChar).Value = CustEmail;
                    sqlCommand.Parameters.Add("@CustPlanID", SqlDbType.Int).Value = CustPlanID;

                    sqlConnection.Open();
                    sqlAdapter.SelectCommand = sqlCommand;
                    sqlCommand.ExecuteNonQuery();
                }
            }

            return true;
        }

        public bool AddPlan(int PlanID, string PlanName, decimal PlanFixedCost, decimal PlanVarCost)
        {
            SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("AddPlan", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandTimeout = 5000;

                    sqlCommand.Parameters.Add("@PlanID", SqlDbType.Int).Value = PlanID;
                    sqlCommand.Parameters.Add("@PlanName", SqlDbType.VarChar).Value = PlanName;
                    sqlCommand.Parameters.Add("@PlanFixedCost", SqlDbType.Decimal).Value = PlanFixedCost;
                    sqlCommand.Parameters.Add("@PlanVarCost", SqlDbType.Decimal).Value = PlanVarCost;

                    sqlConnection.Open();
                    sqlAdapter.SelectCommand = sqlCommand;
                    sqlCommand.ExecuteNonQuery();

                }
            }

            return true;
        }

    }
}
