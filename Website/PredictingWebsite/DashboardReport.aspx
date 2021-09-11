<%@ Page Title="" Language="C#" MasterPageFile="~/PredictingMaster.master" AutoEventWireup="true" CodeFile="DashboardReport.aspx.cs" Inherits="DashboardReport" ValidateRequest ="false"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Content Header (Page header) -->
    <style>
        #container {
            height: 420px;
        }

        .highcharts-figure, .highcharts-data-table table {
            min-width: 360px;
            max-width: 600px;
            margin: 1em auto;
        }

        .highcharts-data-table table {
            font-family: Verdana, sans-serif;
            border-collapse: collapse;
            border: 1px solid #EBEBEB;
            margin: 10px auto;
            text-align: center;
            width: 100%;
            max-width: 500px;
        }

        .highcharts-data-table caption {
            padding: 1em 0;
            font-size: 1.2em;
            color: #555;
        }

        .highcharts-data-table th {
            font-weight: 600;
            padding: 0.5em;
        }

        .highcharts-data-table td, .highcharts-data-table th, .highcharts-data-table caption {
            padding: 0.5em;
        }

        .highcharts-data-table thead tr, .highcharts-data-table tr:nth-child(even) {
            background: #f8f8f8;
        }

        .highcharts-data-table tr:hover {
            background: #f1f7ff;
        }
    </style>
    <section class="content-header">
        <h1>Dashboard
       
            <small>Version 1.0</small>
        </h1>
        <ol class="breadcrumb">
            <li><a href="Dashboard"><i class="fa fa-dashboard"></i>Home</a></li>
            <li class="active">Employee Attrition Dashboard</li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
     

        <div class="row">
            <div class="col-md-12">
                <div class="box">
                    <div class="box-header with-border">
                        <h3 class="box-title">Employee Attrition Report</h3>
                    </div>
                    <!-- /.box-header -->
                    <div class="box-body">
                        <div class="row">
                            <div class="col-md-12 table-responsive ">
                                <figure class="highcharts-figure">
                                    <div id="containerss"></div>
                                    <p class="highcharts-description">
                                        Employee Attrition Report
                                    </p>
                                </figure>
`
                            </div>
                        </div>
                        <!-- /.row -->
                    </div>
                    <!-- ./box-body -->

                    <!-- /.box-footer -->
                </div>
                <!-- /.box -->
            </div>
            <!-- /.col -->
        </div>

     
        <!-- /.row -->

        <!-- Main row -->

    </section>
    <!-- /.content -->
    <script src="floating-whatsapp-master/jquery-3.3.1.min.js"></script>
    <script src="https://code.highcharts.com/highcharts.js"></script>
    <script src="https://code.highcharts.com/highcharts-3d.js"></script>
    <script src="https://code.highcharts.com/modules/cylinder.js"></script>
    <script src="https://code.highcharts.com/modules/funnel3d.js"></script>
    <script src="https://code.highcharts.com/modules/exporting.js"></script>
    <script src="https://code.highcharts.com/modules/accessibility.js"></script>
    <script src="https://code.highcharts.com/modules/pyramid3d.js"></script>
    <script src="https://code.highcharts.com/highcharts.js"></script>
  <script>
      var subjects = <%=chartResult  %>;
      Highcharts.chart('containerss', {
          chart: {
              type: 'pie',
              options3d: {
                  enabled: true,
                  alpha: 45,
                  beta: 0
              }
          },
          title: {
              text: 'Employee Attrition Percentage Analysis'
          },
          accessibility: {
              point: {
                  valueSuffix: '%'
              }
          },
          tooltip: {
              pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
          },
          plotOptions: {
              pie: {
                  allowPointSelect: true,
                  cursor: 'pointer',
                  depth: 35,
                  dataLabels: {
                      enabled: true,
                      format: '{point.name}'
                  }
              }
          },
          series: [{
              name: 'Result Attrition',
              data: subjects
          }]
      });
  </script>
</asp:Content>


