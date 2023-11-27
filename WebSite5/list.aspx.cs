using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class list : System.Web.UI.Page
{

    static string constr = ConfigurationManager.ConnectionStrings["db2con"].ConnectionString.ToString();
    SqlConnection con = new SqlConnection(constr);


    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            viewlist();
        }
    }
    void viewlist()
    {
        con.Open();
        try
        {

            string query = "select * from land";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "land");

            if (ds.Tables["land"].Rows.Count > 0)
            {
                gvview.DataSource = ds.Tables["land"];
                gvview.DataBind();
            }
        }
        catch (Exception ex)
        {
        }
        con.Close();
    }



    protected void gvview_RowCommand1(object sender, GridViewCommandEventArgs e)
    {
         int rowID = Convert.ToInt32(e.CommandArgument.ToString());
            string id = gvview.DataKeys[rowID].Value.ToString();
            if (e.CommandName == "EditProduct")
            {
                Response.Redirect("~/update.aspx?id=" + id);
            }
            if (e.CommandName == "DeleteProduct")
            {
                con.Open();

                try
                {

                    string query = "delete from land where id=@id";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();

                    Response.Redirect("~/list.aspx");
                }

                catch (Exception ex)
                {
                   
                }
                con.Close();
            }


            }

    protected void gvview_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

