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
        public string Username = string.Empty;
        public string UserPassword = string.Empty;
        public string firstname = string.Empty;
        public string middlename = string.Empty;
        public string lastname = string.Empty;
        public string updated_date = string.Empty;
        public string updated_time = string.Empty;
        public string RecID = string.Empty;
        public bool getClientProfile(string username, string sPassword)
        {
            try
            {
                string sPasswordDB = string.Empty;
                DataSet ds = new DataSet();
                string sSQL = "select * from tbl_hr WHERE [username]=@username ";
                SqlCommand objCmd = new SqlCommand();
                objCmd.Parameters.Clear();
                objCmd.Parameters.AddWithValue("@username", username);
                objCmd.CommandText = sSQL;
                ds = ExecuteDataSet(objCmd);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    ErrorMessage = "Invalid User. Contact Administrator.";
                    return false;
                }
                sPasswordDB =ds.Tables[0].Rows[0]["userpassword"].ToString();
                if (sPasswordDB.Trim() == string.Empty)
                {
                    ErrorMessage = "Password Not found in the database.";
                }
                else
                {
                    sPasswordDB = Decrypt(sPasswordDB);
                    if (sPassword != sPasswordDB)
                    {
                        ErrorMessage = "Invalid password.";
                        return false;
                    }
                }
                UserPassword  = sPasswordDB;
                Username = ds.Tables[0].Rows[0]["username"].ToString();
                firstname  = ds.Tables[0].Rows[0]["firstname"].ToString();
                middlename  = ds.Tables[0].Rows[0]["middlename"].ToString();
                lastname   = ds.Tables[0].Rows[0]["lastname"].ToString();
                RecID  = ds.Tables[0].Rows[0]["rec_id"].ToString();
                updated_date  = ds.Tables[0].Rows[0]["updated_date"].ToString();
                updated_time  = ds.Tables[0].Rows[0]["updated_time"].ToString();
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = "No Login Connection.";
                return false;
            }
        }

    
    
    }
}