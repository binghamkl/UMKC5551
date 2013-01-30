#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#endregion

public partial class RegistrationConfirmation : System.Web.UI.Page
{

    /*-- Constructors --*/

    /*-- Events --*/

    /*-- Properties --*/

    /*-- Methods --*/

    /*-- Event Handlers --*/

    #region -- Page_Load(object sender, EventArgs e) Event Handler --
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {
                lblEmail.Text = Server.UrlDecode(Request.QueryString["Email"]);
                lblGender.Text = Server.UrlDecode(Request.QueryString["Gender"]);
                lblName.Text = Server.UrlDecode(Request.QueryString["Name"]);
                lblPassword.Text = Server.UrlDecode(Request.QueryString["Password"]);
                lblPhoneNo.Text = Server.UrlDecode(Request.QueryString["Phone"]);
                lblSubscribeTo.Text = Server.UrlDecode(Request.QueryString["SubscribeTo"]);
            }
        }
        catch (Exception ex)
        {
            uxWarning.Text = ex.Message;
        }
    }
    #endregion

}