
using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeAttritionLibrary;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

public partial class EmployeeAttrition : System.Web.UI.Page
{
    SysAdminModel objAdm = new SysAdminModel();
    DataSet ds;
    DataTable Dt;
    static string sRecValue;
    static int itrig = 0;
    public int TotalPage { get; set; }
    public int CurrentPage { get; set; }

   
    private void GetBusinessTravel()
    {
        try
        {
            DataSet ds = objAdm.GetDropDown ("BusinessTravel");
            BusinessTravel.DataSource = ds;
            BusinessTravel.DataValueField = "Code";
            BusinessTravel.DataTextField = "Desc";
            BusinessTravel.DataBind();
        }
        catch (Exception ex)
        {

        }
    }
    private void ActivateDropDown()
    {
        try
        {
            GetBusinessTravel();
            GetDailyRate();
            GetDepartment();
            GetEducation();
            GetEducationField();
            GetEnvironmentSatisfaction();
            GetGender();
            GetJobInvolvement();
            GetJobLevel();
            GetJobRole();
            GetJobSatisfaction();
            GetMaritalStatus();
            GetOverTime();
            GetPerformanceRating();
            GetRelationshipSatisfaction();
            GetStandardOptionLevel();
            GetWorkLifeBalance();
        }
        catch(Exception ex)
        {

        }
    }
    private void GetWorkLifeBalance()
    {
        try
        {
            DataSet ds = objAdm.GetDropDown("WorkLifeBalance");
            WorkLifeBalance.DataSource = ds;
            WorkLifeBalance.DataValueField = "Code";
            WorkLifeBalance.DataTextField = "Desc";
            WorkLifeBalance.DataBind();
        }
        catch (Exception ex)
        {

        }
    }
    private void GetStandardOptionLevel()
    {
        try
        {
            DataSet ds = objAdm.GetDropDown("StockOptionLevel");
            StockOptionLevel.DataSource = ds;
            StockOptionLevel.DataValueField = "Code";
            StockOptionLevel.DataTextField = "Desc";
            StockOptionLevel.DataBind();
        }
        catch (Exception ex)
        {

        }
    }
    private void GetRelationshipSatisfaction()
    {
        try
        {
            DataSet ds = objAdm.GetDropDown("RelationshipSatisfaction");
            RelationshipSatisfaction.DataSource = ds;
            RelationshipSatisfaction.DataValueField = "Code";
            RelationshipSatisfaction.DataTextField = "Desc";
            RelationshipSatisfaction.DataBind();
        }
        catch (Exception ex)
        {

        }
    }
    private void GetPerformanceRating()
    {
        try
        {
            DataSet ds = objAdm.GetDropDown("PerformanceRating");
            PerformanceRating.DataSource = ds;
            PerformanceRating.DataValueField = "Code";
            PerformanceRating.DataTextField = "Desc";
            PerformanceRating.DataBind();
        }
        catch (Exception ex)
        {

        }
    }
    private void GetOverTime()
    {
        try
        {
            DataSet ds = objAdm.GetDropDown("OverTime");
            OverTime.DataSource = ds;
            OverTime.DataValueField = "Code";
            OverTime.DataTextField = "Desc";
            OverTime.DataBind();
        }
        catch (Exception ex)
        {

        }
    }
    private void GetMaritalStatus()
    {
        try
        {
            DataSet ds = objAdm.GetDropDown("MaritalStatus");
            MaritalStatus.DataSource = ds;
            MaritalStatus.DataValueField = "Code";
            MaritalStatus.DataTextField = "Desc";
            MaritalStatus.DataBind();
        }
        catch (Exception ex)
        {

        }
    }

    private void GetJobSatisfaction()
    {
        try
        {
            DataSet ds = objAdm.GetDropDown("JobSatisfaction");
            JobSatisfaction.DataSource = ds;
            JobSatisfaction.DataValueField = "Code";
            JobSatisfaction.DataTextField = "Desc";
            JobSatisfaction.DataBind();
        }
        catch (Exception ex)
        {

        }
    }
    private void GetJobRole()
    {
        try
        {
            DataSet ds = objAdm.GetDropDown("JobRole");
            JobRole.DataSource = ds;
            JobRole.DataValueField = "Code";
            JobRole.DataTextField = "Desc";
            JobRole.DataBind();
        }
        catch (Exception ex)
        {

        }
    }
    private void GetJobLevel()
    {
        try
        {
            DataSet ds = objAdm.GetDropDown("JobLevel");
            JobLevel.DataSource = ds;
            JobLevel.DataValueField = "Code";
            JobLevel.DataTextField = "Desc";
            JobLevel.DataBind();
        }
        catch (Exception ex)
        {

        }
    }
    private void GetJobInvolvement()
    {
        try
        {
            DataSet ds = objAdm.GetDropDown("JobInvolvement");
            JobInvolvement.DataSource = ds;
            JobInvolvement.DataValueField = "Code";
            JobInvolvement.DataTextField = "Desc";
            JobInvolvement.DataBind();
        }
        catch (Exception ex)
        {

        }
    }
    private void GetGender()
    {
        try
        {
            DataSet ds = objAdm.GetDropDown("Gender");
            Gender.DataSource = ds;
            Gender.DataValueField = "Code";
            Gender.DataTextField = "Desc";
            Gender.DataBind();
        }
        catch (Exception ex)
        {

        }
    }
    private void GetEnvironmentSatisfaction()
    {
        try
        {
            DataSet ds = objAdm.GetDropDown("EnvironmentSatisfaction");
            EnvironmentSatisfaction.DataSource = ds;
            EnvironmentSatisfaction.DataValueField = "Code";
            EnvironmentSatisfaction.DataTextField = "Desc";
            EnvironmentSatisfaction.DataBind();
        }
        catch (Exception ex)
        {

        }
    }
    private void GetEducationField()
    {
        try
        {
            DataSet ds = objAdm.GetDropDown("EducationField");
            EducationField.DataSource = ds;
            EducationField.DataValueField = "Code";
            EducationField.DataTextField = "Desc";
            EducationField.DataBind();
        }
        catch (Exception ex)
        {

        }
    }
    private void GetEducation()
    {
        try
        {
            DataSet ds = objAdm.GetDropDown("Education");
            Education.DataSource = ds;
            Education.DataValueField = "Code";
            Education.DataTextField = "Desc";
            Education.DataBind();
        }
        catch (Exception ex)
        {

        }
    }
    private void GetDepartment()
    {
        try
        {
            DataSet ds = objAdm.GetDropDown("Department");
            Department.DataSource = ds;
            Department.DataValueField = "Code";
            Department.DataTextField = "Desc";
            Department.DataBind();
        }
        catch (Exception ex)
        {

        }
    }
    private void GetDailyRate()
    {
        try
        {
            DataSet ds = objAdm.GetDropDown("DailyRate");
            DailyRate.DataSource = ds;
            DailyRate.DataValueField = "Code";
            DailyRate.DataTextField = "Desc";
            DailyRate.DataBind();
        }
        catch (Exception ex)
        {

        }
    }

    protected void AddNewRecord(object sender, EventArgs e)
    {
        try
        {

        }
        catch (Exception ex)
        {

        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            
                if (!IsPostBack)
                {
                    ActivateDropDown();
                    LoadGrid();
                    formView.Visible = false;
                    TableView.Visible = true;
                }
                //LoadGrid(); 





        }
        catch (Exception ex)
        {

        }
    }
    protected void AddNewRecordClicked(object sender, EventArgs e)
    {
        try
        {
            formView.Visible = true;
            TableView.Visible = false;
            LoadGrid();
            objAdm.clearPanel(PnlEmployee);
            itrig = 0;
        }
        catch (Exception ex)
        {

        }
    }
    protected void ViewRecord(object sender, EventArgs e)
    {
        try
        {
            formView.Visible = false;
            TableView.Visible = true;
            LoadGrid();
            itrig = 0;
        }
        catch (Exception ex)
        {

        }
    }

    protected void Page_Init(object sender, EventArgs e)
    {
        try
        {

        }
        catch (Exception ex)
        {

        }
    }
    protected void Page_UnLoad(object sender, EventArgs e)
    {
        try
        {
            objAdm.CloseConnection();
        }
        catch (Exception ex)
        {

        }
    }
    private void DisplaySuccess(String sMessage)
    {
        try
        {
            (this.Master as PredictingMaster).DisplayMessage(sMessage, PredictingMaster.MsgType.Success);
        }
        catch (Exception ex)
        {
            Session["msg"] = ex.Message.ToString();
            Response.Redirect("~/en");
        }
    }
    private void DisplayError(String sMessage)
    {
        try
        {
            (this.Master as PredictingMaster).DisplayMessage(sMessage, PredictingMaster.MsgType.Error);
        }
        catch (Exception ex)
        {
            Session["msg"] = ex.Message.ToString();
            Response.Redirect("~/en");
        }
    }

    private void DisplayWarning(String sMessage)
    {
        try
        {
            (this.Master as PredictingMaster).DisplayMessage(sMessage, PredictingMaster.MsgType.Warning);
        }
        catch (Exception ex)
        {
            Session["msg"] = ex.Message.ToString();
            Response.Redirect("~/en");
        }
    }



    public void bindGrid(int currentPage)
    {

        TableResult.DataSource = objAdm.PopulateData(currentPage, "GetEmployeeReport", Session["ID"].ToString ());
        TableResult.DataBind();

        generatePager(objAdm._TotalRowCount, objAdm.pageSize, currentPage);


    }
    protected void dlPager_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "PageNo")
        {
            bindGrid(Convert.ToInt32(e.CommandArgument));
        }
        TableResult.UseAccessibleHeader = true;
        TableResult.HeaderRow.TableSection = TableRowSection.TableHeader;
    }
    public void generatePager(int totalRowCount, int pageSize, int currentPage)
    {
        int totalLinkInPage = 5;
        int totalPageCount = (int)Math.Ceiling((decimal)totalRowCount / pageSize);

        int startPageLink = Math.Max(currentPage - (int)Math.Floor((decimal)totalLinkInPage / 2), 1);
        int lastPageLink = Math.Min(startPageLink + totalLinkInPage - 1, totalPageCount);

        if ((startPageLink + totalLinkInPage - 1) > totalPageCount)
        {
            lastPageLink = Math.Min(currentPage + (int)Math.Floor((decimal)totalLinkInPage / 2), totalPageCount);
            startPageLink = Math.Max(lastPageLink - totalLinkInPage + 1, 1);
        }

        List<ListItem> pageLinkContainer = new List<ListItem>();

        if (startPageLink != 1)
            pageLinkContainer.Add(new ListItem("First", "1", currentPage != 1));
        for (int i = startPageLink; i <= lastPageLink; i++)
        {
            pageLinkContainer.Add(new ListItem(i.ToString(), i.ToString(), currentPage != i));
        }
        if (lastPageLink != totalPageCount)
            pageLinkContainer.Add(new ListItem("Last", totalPageCount.ToString(), currentPage != totalPageCount));

        dlPager.DataSource = pageLinkContainer;
        dlPager.DataBind();
    }
    private void LoadGrid()
    {
        try
        {
            bindGrid(1);
            TableResult.UseAccessibleHeader = true;
            TableResult.HeaderRow.TableSection = TableRowSection.TableHeader;
        }
        catch (Exception ex)
        {

        }
    }


    protected void tableChanged(object sender, EventArgs e)
    {
        try
        {

            itrig = 1;
            GridViewRow dgi = TableResult.SelectedRow;
            rec_id.Value = dgi.Cells[objAdm.getColumnIndexByName(TableResult, "RecID")].Text;
            ActivateDropDown();
            objAdm.getPanelByRecID(PnlEmployee);
            formView.Visible = true;
            TableView.Visible = false;
        }
        catch (Exception ex)
        {

        }
    }
    protected void TableDelete(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            GridViewRow dgi = TableResult.Rows[e.RowIndex];
            rec_id.Value = dgi.Cells[objAdm.getColumnIndexByName(TableResult, "RecID")].Text;
            Label1.ForeColor = System.Drawing.Color.DarkRed;
            Label1.Text = "Are you sure that you want to delete Record with ID:" + " " + rec_id.Value + " " + " ?";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "LaunchServerSide", "$(function() { showDelete(); });", true);

        }
        catch (Exception ex)
        {
        }
    }

    protected void lbDeleteYes_Click(object sender, EventArgs e)
    {
        try
        {
           
                string sTbl = "EmployeeDataset";
                if (objAdm.DeleteRecord(rec_id.Value, sTbl) == true)
                {
                    DisplaySuccess("Record deleted successfully.");
                    LoadGrid();


                }
                else
                {

                }
           
        }
        catch (Exception ex)
        {

        }
    }

    protected void SaveChangesClicked(object sender, EventArgs e)
    {
        try
        {
           
                string sYearMonthDay = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString();

            Session["ID"] = id.Text;
                if (itrig == 0)
                {
                    if (objAdm.CRUDEngineer(rec_id.Value, id.Text, Age.Text,  BusinessTravel.SelectedValue,  DailyRate.Text,  Department.SelectedValue,  DistanceFromHome.Text,  Education.SelectedValue,  EducationField.SelectedValue,  EnvironmentSatisfaction.SelectedValue,  Gender.SelectedValue,  HourlyRate.Text,  JobInvolvement.SelectedValue,  JobLevel.SelectedValue,  JobRole.SelectedValue,  JobSatisfaction.SelectedValue,  MaritalStatus.SelectedValue,  MonthlyIncome.Text, MonthlyRate.Text, NumCompaniesWorked.Text, OverTime.SelectedValue,  PercentSalaryHike.Text,  PerformanceRating.SelectedValue,  RelationshipSatisfaction.SelectedValue,  StandardHours.Text,  StockOptionLevel.SelectedValue,  TotalWorkingYears.Text,  TrainingTimesLastYear.Text,  WorkLifeBalance.Text,YearsAtCompany.Text,  YearsInCurrentRole.Text, YearsSinceLastPromotion.Text,  YearsWithCurrManager.Text, "INSERT") == true)
                    {
                        LoadGrid();
                        DisplaySuccess(objAdm.ErrorMessage);

                        objAdm.clearPanel(PnlEmployee);
                        itrig = 0;
                        LoadGrid();
                        //formView.Visible = false;
                        //TableView.Visible = true;
                    }
                    else
                    {
                        DisplayError(objAdm.ErrorMessage);
                        LoadGrid();
                        formView.Visible = false;
                        TableView.Visible = true;
                    }
                }
                if (itrig == 1)
                {
                if (objAdm.CRUDEngineer(rec_id.Value, id.Text, Age.Text, BusinessTravel.SelectedValue, DailyRate.Text, Department.SelectedValue, DistanceFromHome.Text, Education.SelectedValue, EducationField.SelectedValue, EnvironmentSatisfaction.SelectedValue, Gender.SelectedValue, HourlyRate.Text, JobInvolvement.SelectedValue, JobLevel.SelectedValue, JobRole.SelectedValue, JobSatisfaction.SelectedValue, MaritalStatus.SelectedValue, MonthlyIncome.Text, MonthlyRate.Text, NumCompaniesWorked.Text, OverTime.SelectedValue, PercentSalaryHike.Text, PerformanceRating.SelectedValue, RelationshipSatisfaction.SelectedValue, StandardHours.Text, StockOptionLevel.SelectedValue, TotalWorkingYears.Text, TrainingTimesLastYear.Text, WorkLifeBalance.Text, YearsAtCompany.Text, YearsInCurrentRole.Text, YearsSinceLastPromotion.Text, YearsWithCurrManager.Text, "UPDATE") == true)
                { LoadGrid();
                        DisplaySuccess(objAdm.ErrorMessage);

                        objAdm.clearPanel(PnlEmployee);
                        itrig = 0;
                        LoadGrid();
                        //formView.Visible = false;
                        //TableView.Visible = true;
                    }
                    else
                    {
                        DisplayError(objAdm.ErrorMessage);
                        LoadGrid();
                        formView.Visible = false;
                        TableView.Visible = true;
                    }
                }

        
        }
        catch (Exception ex)
        {

        }
    }

}