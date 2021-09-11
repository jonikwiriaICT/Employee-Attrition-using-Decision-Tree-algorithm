<%@ Page Title="" Language="C#" MasterPageFile="~/PredictingMaster.master" AutoEventWireup="true" CodeFile="EmployeeAttrition.aspx.cs" Inherits="EmployeeAttrition" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="content">
        <div class="row">
            <div class="col-md-7">
                <div id="formView" runat="server">
                    <div class="panel">
                        <div class="panel-heading ">
                            <div class="panel-title ">
                                <h4>Employee Information</h4>

                                <div class="btn-group pull-right ">
                                    <button type="button" class="btn btn-info">Action</button>
                                    <button type="button" class="btn btn-info dropdown-toggle" data-toggle="dropdown">
                                        <span class="caret"></span>
                                        <span class="sr-only">Toggle Dropdown</span>
                                    </button>
                                    <ul class="dropdown-menu" role="menu">
                                        <li>
                                            <asp:LinkButton ID="lnkGoBack" OnClick="ViewRecord" runat="server"><i class=" fa fa-eyedropper"></i>View Record</asp:LinkButton>

                                        </li>

                                    </ul>
                                </div>
                                <br />
                            </div>
                        </div>
                        <div class="panel-body">
                            <div class="box box-primary">
                                <div class="box-body box-profile">

                                    <br />
                                    <br />
                                    <asp:Panel ID="PnlEmployee" runat="server">
                                        <asp:HiddenField ID="rec_id" runat="server" />
                                        <asp:HiddenField ID="attrition_yes" runat="server" />
                                        <asp:HiddenField ID="atrition_no" runat="server" />
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Employee ID</label>
                                            </div>
                                            <div class="col-md-9">

                                                <asp:TextBox ID="id" CssClass="form-control decimal" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Age</label>
                                            </div>
                                            <div class="col-md-9">

                                                <asp:TextBox ID="Age" CssClass="form-control decimal" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Business Travel</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:DropDownList ID="BusinessTravel" CssClass="form-control select2-dropdown" runat="server"></asp:DropDownList>


                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Daily Rate</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:DropDownList ID="DailyRate" CssClass="form-control select2-dropdown" runat="server"></asp:DropDownList>


                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Department</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:DropDownList ID="Department" CssClass="form-control select2-dropdown" runat="server"></asp:DropDownList>


                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Distance From Home</label>
                                            </div>
                                            <div class="col-md-9">


                                                <asp:TextBox ID="DistanceFromHome" CssClass="form-control decimal" runat="server"></asp:TextBox>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Education</label>
                                            </div>
                                            <div class="col-md-9">

                                                <asp:DropDownList ID="Education" CssClass="form-control select2-dropdown" runat="server"></asp:DropDownList>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Education Field</label>
                                            </div>
                                            <div class="col-md-9">

                                                <asp:DropDownList ID="EducationField" CssClass="form-control select2-dropdown" runat="server"></asp:DropDownList>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Environment Satisfaction</label>
                                            </div>
                                            <div class="col-md-9">

                                                <asp:DropDownList ID="EnvironmentSatisfaction" CssClass="form-control select2-dropdown" runat="server"></asp:DropDownList>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Gender</label>
                                            </div>
                                            <div class="col-md-9">

                                                <asp:DropDownList ID="Gender" CssClass="form-control select2-dropdown" runat="server"></asp:DropDownList>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Hourly Rate</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:TextBox ID="HourlyRate" CssClass="form-control decimal" runat="server"></asp:TextBox>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Job Involvement</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:DropDownList ID="JobInvolvement" CssClass="form-control select2-dropdown" runat="server"></asp:DropDownList>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Job Level</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:DropDownList ID="JobLevel" CssClass="form-control select2-dropdown" runat="server"></asp:DropDownList>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Job Role</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:DropDownList ID="JobRole" CssClass="form-control select2-dropdown" runat="server"></asp:DropDownList>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Job Satisfaction</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:DropDownList ID="JobSatisfaction" CssClass="form-control select2-dropdown" runat="server"></asp:DropDownList>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Marital Status</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:DropDownList ID="MaritalStatus" CssClass="form-control select2-dropdown" runat="server"></asp:DropDownList>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Montly Income</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:TextBox ID="MonthlyIncome" CssClass="form-control decimal" runat="server"></asp:TextBox>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Montly Rate</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:TextBox ID="MonthlyRate" CssClass="form-control decimal" runat="server"></asp:TextBox>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Number of Companies worked</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:TextBox ID="NumCompaniesWorked" CssClass="form-control decimal" runat="server"></asp:TextBox>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Over Time</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:DropDownList ID="OverTime" CssClass="form-control select2-dropdown" runat="server"></asp:DropDownList>

                                            </div>
                                        </div>

                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Percentage Salary Hike</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:TextBox ID="PercentSalaryHike" CssClass="form-control decimal" runat="server"></asp:TextBox>

                                            </div>
                                        </div>

                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Percentage Rating</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:DropDownList ID="PerformanceRating" CssClass="form-control select2-dropdown" runat="server"></asp:DropDownList>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Relationship Satisfaction</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:DropDownList ID="RelationshipSatisfaction" CssClass="form-control select2-dropdown" runat="server"></asp:DropDownList>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Standard Hours</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:TextBox ID="StandardHours" CssClass="form-control decimal" runat="server"></asp:TextBox>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Stock Option Level</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:DropDownList ID="StockOptionLevel" CssClass="form-control select2-dropdown" runat="server"></asp:DropDownList>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Total Woking Years</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:TextBox ID="TotalWorkingYears" CssClass="form-control decimal" runat="server"></asp:TextBox>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Training Time Last Year</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:TextBox ID="TrainingTimesLastYear" CssClass="form-control decimal" runat="server"></asp:TextBox>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Work Life Balance</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:DropDownList ID="WorkLifeBalance" CssClass="form-control select2-dropdown" runat="server"></asp:DropDownList>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Years at Company</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:TextBox ID="YearsAtCompany" CssClass="form-control decimal" runat="server"></asp:TextBox>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Years in Current Role</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:TextBox ID="YearsInCurrentRole" CssClass="form-control decimal" runat="server"></asp:TextBox>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Years since last promotion</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:TextBox ID="YearsSinceLastPromotion" CssClass="form-control decimal" runat="server"></asp:TextBox>

                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-3">
                                                <label style="font-size: 12px">Years with Current Manager</label>
                                            </div>
                                            <div class="col-md-9">
                                                <asp:TextBox ID="YearsWithCurrManager" CssClass="form-control decimal" runat="server"></asp:TextBox>

                                            </div>
                                        </div>

                                        <div class="row">
                                            <div class="col-md-12">
                                                <asp:LinkButton ID="lnkSaveChanges" OnClick="SaveChangesClicked" CssClass="btn btn-sm btn-primary pull-right  " runat="server"><i class="fa fa-save "></i>&nbsp Save Changes</asp:LinkButton>
                                            </div>
                                        </div>

                                    </asp:Panel>



                                </div>
                            </div>

                        </div>
                    </div>
                </div>

            </div>
            <!-- /.col -->

            <!-- /.col -->
        </div>
        <div class="row">
            <div class="col-md-12">
                <div id="TableView" runat="server">
                    <div class="nav-tabs-custom">
                        <div class="panel ">
                            <div class="panel-heading ">
                                <div class="panel-title ">
                                    <h4>Product Record</h4>

                                    <div class="btn-group pull-right ">
                                        <button type="button" class="btn btn-info">Action</button>
                                        <button type="button" class="btn btn-info dropdown-toggle" data-toggle="dropdown">
                                            <span class="caret"></span>
                                            <span class="sr-only">Toggle Dropdown</span>
                                        </button>
                                        <ul class="dropdown-menu" role="menu">
                                            <li>
                                                <asp:LinkButton ID="LinkButton1" OnClick="AddNewRecordClicked" runat="server"><i class=" fa fa-plus-circle"></i>Add New Record</asp:LinkButton>

                                            </li>

                                        </ul>
                                    </div>
                                    <br />
                                </div>
                            </div>
                            <div class="panel-body">
                                <div class="box box-primary">
                                    <div class="box-body box-profile">
                                        <div class="table-responsive">
                                            <asp:GridView ID="TableResult" runat="server" Font-Size="10px"
                                                CssClass="table table-bordered table-striped catr" AutoGenerateColumns="true" AllowCustomPaging="true"
                                                OnSelectedIndexChanged="tableChanged" OnRowDeleting="TableDelete"
                                                EmptyDataText="There is no record for the selected item">
                                                <Columns>
                                                    <asp:TemplateField HeaderStyle-Width="7%" HeaderText="Delete Record" Visible="true" HeaderStyle-CssClass=" thead-default" ItemStyle-HorizontalAlign="Center" FooterStyle-HorizontalAlign="Center">
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="lbDelete" runat="server" Font-Size="14px" CssClass="btn btn-sm btn-danger"
                                                                CausesValidation="False" CommandName="Delete" CommandArgument='<%# Container.DataItemIndex %>'>
                                                                <i class="fa fa-trash"></i>
                                                            </asp:LinkButton>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderStyle-Width="5%" HeaderText="Edit Record" ItemStyle-HorizontalAlign="Center" FooterStyle-HorizontalAlign="Center">
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="lbSelect" Font-Size="14px" runat="server" CssClass="btn btn-sm btn-info"
                                                                CausesValidation="False" CommandName="Select" CommandArgument='<%# Container.DataItemIndex %>'>
                                                                <i class="fa fa-edit "></i>
                                                            </asp:LinkButton>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>


                                                </Columns>
                                            </asp:GridView>
                                            <div class="Pager"></div>
                                            <asp:DataList CellPadding="5" RepeatDirection="Horizontal" runat="server" ID="dlPager"
                                                OnItemCommand="dlPager_ItemCommand">
                                                <ItemTemplate>

                                                    <nav class="pagination">
                                                        <ul class="pagination">
                                                            <li class="page-item ">
                                                                <asp:LinkButton Enabled='<%#Eval("Enabled") %>' CssClass="page-link " runat="server" ID="lnkPageNo" Text='<%#Eval("Text") %>' CommandArgument='<%#Eval("Value") %>' CommandName="PageNo"></asp:LinkButton>

                                                            </li>
                                                        </ul>
                                                    </nav>

                                                </ItemTemplate>
                                            </asp:DataList>

                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>

                        <!-- /.tab-content -->
                    </div>
                </div>
                <!-- /.nav-tabs-custom -->
            </div>
        </div>
        <!-- /.row -->

    </section>

    <div class="modal fade" id="DeleteRecord" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabels"
        aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabels">Delete Record</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <asp:Label ID="Label1" CssClass="text-danger " runat="server" Text="Label"></asp:Label>
                </div>
                <div class="modal-footer bg-whitesmoke br">

                    <asp:LinkButton ID="lnkDelete" CssClass="btn btn-sm btn-danger" OnClick="lbDeleteYes_Click" runat="server"><i class="fa fa-trash"></i>&nbsp Delete</asp:LinkButton>
                </div>
            </div>
        </div>
    </div>
    <script src="floating-whatsapp-master/jquery-3.3.1.min.js"></script>
    <script src="ckeditor/ckeditor.js"></script>
    <script>
        function showDelete() {
            $('#DeleteRecord').modal('show')
        }
    </script>

</asp:Content>


