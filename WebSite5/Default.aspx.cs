using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{

    static string constr = ConfigurationManager.ConnectionStrings["db2con"].ConnectionString.ToString();
    SqlConnection con = new SqlConnection(constr);

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnadd_Click(object sender, EventArgs e)
    {

        con.Open();
        try
        {

            string id = txtid.Text;
            string uname = txtname.Text;
            string pass = txtpass.Text;
            string email = txtemail.Text;
            string city = txtdrp.Text;

            string query = " insert into land(id, uname, pass, email, city) values(@id, @uname, @pass, @email, @city)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("uname", uname);
            cmd.Parameters.AddWithValue("pass", pass);
            cmd.Parameters.AddWithValue("email", email);
            cmd.Parameters.AddWithValue("city", city);

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                lblinfo.Text = "product added";

            }
        }
        catch (Exception ex)
        {
            lblinfo.Text = "Already Exists!";
        }
        con.Close();
    }
}

    