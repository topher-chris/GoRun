<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DataChart.WebForm1" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div style="height: 354px; width: 476px;">
   <asp:Chart ID="Chart1" runat="server" Width="350px" Height="229px">
    <Titles><asp:Title Text="Total marks of location"></asp:Title>
    </Titles>
    <Series>
        <asp:Series Name="Series1" ChartType="StackedColumn">  
        </asp:Series>
    </Series>
    <ChartAreas>
        <asp:ChartArea Name="ChartArea1">
            <AxisX Title="Location Name"></AxisX>
            <AxisY Title="Total Marks"></AxisY>
        </asp:ChartArea>
    </ChartAreas>
</asp:Chart>

        </div>
    </form>
</body>
</html>
