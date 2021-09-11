using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Foundation;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeAttritionLibrary
{
    public partial class SysAdminModel : _Database
    {
        public DataSet GetDropDown(string sParam)
        {
            try
            {
                SqlCommand objCmd = new SqlCommand();
                string sSQL = " select distinct " + sParam + " as [Code], " + sParam + " as [Desc] from EmployeeDataset";
                objCmd.CommandText = sSQL;
                return ExecuteDataSet(objCmd);
            }
            catch (Exception ex)
            {
                ErrorMessage += ex.Message;
                return null;
            }
        }
  
       
		public bool CRUDEngineer(string rec_id, string id, string Age, string BusinessTravel, string DailyRate, string Department, string DistanceFromHome, string Education, string EducationField, string EnvironmentSatisfaction, string Gender, string HourlyRate, string JobInvolvement, string JobLevel, string JobRole, string JobSatisfaction, string MaritalStatus, string MonthlyIncome, string MonthlyRate, string NumCompaniesWorked, string OverTime, string PercentSalaryHike, string PerformanceRating, string RelationshipSatisfaction, string StandardHours, string StockOptionLevel, string TotalWorkingYears, string TrainingTimesLastYear, string WorkLifeBalance, string YearsAtCompany, string YearsInCurrentRole, string YearsSinceLastPromotion, string YearsWithCurrManager, string StatementType)
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("CRUDEngineer", con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@rec_id", rec_id);
			cmd.Parameters.AddWithValue("@id", id);
			cmd.Parameters.AddWithValue("@Age", Age);
			cmd.Parameters.AddWithValue("@BusinessTravel", BusinessTravel);
			cmd.Parameters.AddWithValue("@DailyRate", DailyRate);
			cmd.Parameters.AddWithValue("@Department", Department);
			cmd.Parameters.AddWithValue("@DistanceFromHome", DistanceFromHome);
			cmd.Parameters.AddWithValue("@Education", Education);
			cmd.Parameters.AddWithValue("@EducationField", EducationField);
			cmd.Parameters.AddWithValue("@EnvironmentSatisfaction", EnvironmentSatisfaction);
			cmd.Parameters.AddWithValue("@Gender", Gender);
			cmd.Parameters.AddWithValue("@HourlyRate", HourlyRate);
			cmd.Parameters.AddWithValue("@JobInvolvement", JobInvolvement);
			cmd.Parameters.AddWithValue("@JobLevel", JobLevel);
			cmd.Parameters.AddWithValue("@JobRole", JobRole);
			cmd.Parameters.AddWithValue("@JobSatisfaction", JobSatisfaction);
			cmd.Parameters.AddWithValue("@MaritalStatus", MaritalStatus);
			cmd.Parameters.AddWithValue("@MonthlyIncome", MonthlyIncome);
			cmd.Parameters.AddWithValue("@MonthlyRate", MonthlyRate);
			cmd.Parameters.AddWithValue("@NumCompaniesWorked", NumCompaniesWorked);
			cmd.Parameters.AddWithValue("@OverTime", OverTime);
			cmd.Parameters.AddWithValue("@PercentSalaryHike", PercentSalaryHike);
			cmd.Parameters.AddWithValue("@PerformanceRating", PerformanceRating);
			cmd.Parameters.AddWithValue("@RelationshipSatisfaction", RelationshipSatisfaction);
			cmd.Parameters.AddWithValue("@StandardHours", StandardHours);
			cmd.Parameters.AddWithValue("@StockOptionLevel", StockOptionLevel);
			cmd.Parameters.AddWithValue("@TotalWorkingYears", TotalWorkingYears);
			cmd.Parameters.AddWithValue("@TrainingTimesLastYear", TrainingTimesLastYear);
			cmd.Parameters.AddWithValue("@WorkLifeBalance", WorkLifeBalance);
			cmd.Parameters.AddWithValue("@YearsAtCompany", YearsAtCompany);
			cmd.Parameters.AddWithValue("@YearsInCurrentRole", YearsInCurrentRole);
			cmd.Parameters.AddWithValue("@YearsSinceLastPromotion", YearsSinceLastPromotion);
			cmd.Parameters.AddWithValue("@YearsWithCurrManager", YearsWithCurrManager);
			cmd.Parameters.AddWithValue("@StatementType", StatementType);
			if (ExecuteNonQuery(cmd) <= 0)
			{
				ErrorMessage = "Unable to process transaction";
				return false;
			}
			ErrorMessage = "Record executed successfully .";
			return true;
		}



	}
}