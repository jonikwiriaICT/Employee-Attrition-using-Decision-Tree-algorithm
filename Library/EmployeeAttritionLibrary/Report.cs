using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Foundation;
using Newtonsoft.Json;

namespace EmployeeAttritionLibrary
{
    public partial class SysAdminModel : _Database
    {

        public string chartGender = string.Empty;
        public string chartMaritalStatus = string.Empty;
        public string chartResult = string.Empty;
        public void GetSentimentReport()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mssqlConnectionString"].ToString());
            con.Open();
            SqlCommand comm = new SqlCommand("select Name, sum(AttritionYes) as y from qryFinalReport group by Name order by count(Name)", con);
            DataTable dt = new DataTable();
            dt.Load(comm.ExecuteReader());
            chartGender = JsonConvert.SerializeObject(dt);

        }
    }
}
