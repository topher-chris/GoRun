using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace DataChart
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                GetChartData();
            }

        }
        private void GetChartData()
        {
            string cs = ConfigurationManager.ConnectionStrings["CS"].ConnectionString; //cs is what i named the connection to my azure database
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select LocationName, Rate from RunningSpot", con); //this is used to make a SQL cmd query from my database
                con.Open();                                                      //connection is openned
                SqlDataReader rdr = cmd.ExecuteReader();
                Chart1.Series["Series1"].XValueMember = "LocationName";   //called from Series
                Chart1.Series["Series1"].YValueMembers = "Rate";

                Chart1.DataSource = rdr;                //chart1 can be found in WebForm1.aspx under asp:series
                Chart1.DataBind();
            }
        }

        protected void Chart1_Load(object sender, EventArgs e)
        {

        }
    }
}