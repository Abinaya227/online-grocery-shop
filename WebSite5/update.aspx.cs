using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;


public partial class update : System.Web.UI.Page
{
    static string constr = ConfigurationManager.ConnectionStrings["db2con"].ConnectionString.ToString();
    sqlconnection con = new sqlconnection(constr);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            viewupdate();
        }
    }
    void viewupdate()
    {
        con.Open();
        try
        {
            string id = Request.QueryString["id"].ToString();
            txtid.Text = id;
            string query = "select * from land where id=@id";
            SqlCommand cmd =new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            txtname.Text = dr["uname"].ToString();
            txtpass.Text = dr["pass"].ToString();
            txtemail.Text = dr["email"].ToString();
            txtdrp.Text = dr["city"].ToString();
            dr.Close();
        }
        catch (Exception ex)
        {
            Response.Redirect("~/list.aspx");
        }
        con.Close();
    }
       protected void btnupdate_Click(object sender, EventArgs e)
    {      
     con.Open();
           string id = txtid.Text;
           string uname = txtname.Text;
           string pass = txtpass.Text;
           string email = txtemail.Text;
           string city = txtdrp.Text;
           string query = "update land set uname=@uname,pass=@pass, email=@email,city=@city where id=@id";
               SqlCommand cmd=new SqlCommand(query, con);
           cmd.Parameters.AddWithValue("id",id);
           cmd.Parameters.AddWithValue("uname",uname);
           cmd.Parameters.AddWithValue("pass",pass);
           cmd.Parameters.AddWithValue("email",email);

           cmd.Parameters.AddWithValue("city",city);
           int i = cmd.ExecuteNonQuery();
           con.Close();
           if(i>0)
           {
               Response.Redirect("~/list.aspx");
           }
       }



}