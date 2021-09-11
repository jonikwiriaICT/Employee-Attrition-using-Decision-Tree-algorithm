using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeAttritionLibrary;

public partial class DashboardReport : System.Web.UI.Page
{
    SysAdminModel objAdm = new SysAdminModel();
    public string chartResult = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!this.IsPostBack)
            {
                objAdm.GetSentimentReport();
                chartResult = objAdm.chartGender;
            }
        }
        catch(Exception ex)
        {

        }
    }
    protected void Page_UnLoad(object sender, EventArgs e)
    {
        try
        {
            objAdm.CloseConnection();
        }
        catch(Exception ex)
        {

        }
    }

    protected void Page_Init(object sender, EventArgs e)
    {

    }
}