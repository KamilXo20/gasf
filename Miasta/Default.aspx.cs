using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

public partial class _Default : System.Web.UI.Page
{

    private void OdswiezMiasta()
    {
        try
        {
            // utworzenie polaczenia
            string ConnectStr = Application["ConnectStr"].ToString();
            OleDbConnection con = new OleDbConnection(ConnectStr);
            // stworzenie zrodla danych i pobranie danych
            OleDbDataAdapter myCommand = new OleDbDataAdapter("select * from Wojewodztwa", con);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            DataTable dt = ds.Tables[0];
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "Wojewodztwo";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();

        }

        catch (OleDbException ex)
        {
            labelkomunikat.Text = ex.Message;
        }

    }

    private void Miasta()
    {
        try
        {
            // utworzenie polaczenia
            string ConnectStr = Application["ConnectStr"].ToString();
            OleDbConnection con = new OleDbConnection(ConnectStr);
            // stworzenie zrodla danych i pobranie danych
            OleDbDataAdapter myCommand = new OleDbDataAdapter("select * from Miasta where id_woj=" + DropDownList1.SelectedValue, con);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            DataTable dt = ds.Tables[0];
            DropDownList2.DataSource = dt;
            DropDownList2.DataTextField = "Miasto";
            DropDownList2.DataValueField = "ID";
            DropDownList2.DataBind();
        }
        catch (OleDbException ex)
        {
            labelkomunikat.Text = ex.Message;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            OdswiezMiasta();
        }
              Miasta();
    }

    protected void Button1_Click(object sender, System.EventArgs e)
    {
        // pokazywanie wspolrzednych miasta
        try
        {
            // utworzenie polaczenia
            string ConnectStr = Application["ConnectStr"].ToString();
            OleDbConnection con = new OleDbConnection(ConnectStr);
            // stworzenie zrodla danych i pobranie danych
            OleDbDataAdapter myCommand = new OleDbDataAdapter("select * from Miasta where id=" + DropDownList2.SelectedValue, con);
            DataSet ds = new DataSet();
            myCommand.Fill(ds);
            DataTable dt = ds.Tables[0];

            DataRow dr = dt.Rows[0];
            String longitude = dr["dl"].ToString();
            String latitude = dr["szer"].ToString();

            labelkomunikat.Text = "Wspolrzedne miasta " + longitude + " " + latitude;

        }
        catch (OleDbException ex)
        {
            labelkomunikat.Text = ex.Message;
        }
    }
}