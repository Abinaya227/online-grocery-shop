using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;


public partial class Default2 : System.Web.UI.Page
{
    static string constr = ConfigurationManager.ConnectionStrings["db2con"].ConnectionString.ToString();
    SqlConnection con = new SqlConnection(constr);

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    Random rs = new Random();
    protected void btnup_Click(object sender, EventArgs e)
    {
        string fileid = " ";
        string filename = fuPicture.fileName.ToString();
        string allowedchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
        for (int i = 0; i < 10; i++)
        {
            fileid += allowedchars.Substring(rs.Next(0, 62), 1);
        }
        fuPicture.SaveAs(Server.MapPath("~/photos/" + fileid + ".jpg"));
    }
}