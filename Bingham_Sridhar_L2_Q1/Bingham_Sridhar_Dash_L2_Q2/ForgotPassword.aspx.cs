#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#endregion

public partial class ForgotPassword : System.Web.UI.Page
{

    /*-- Constructors --*/

    /*-- Events --*/

    /*-- Properties --*/

    /*-- Methods --*/

    /*-- Event Handlers --*/

    #region -- Page_Load(object sender, EventArgs e) Event Handler --
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    #endregion

    #region -- uxRecoverPassword_Click(object sender, EventArgs e) Event Handler --
    protected void uxRecoverPassword_Click(object sender, EventArgs e)
    {
        String url = string.Format("ForgotPasswordConfirmation.aspx?Email={0}&Color={1}",
                            Server.UrlEncode(uxEmail.Text), Server.UrlEncode(uxColor.Text));
        Response.Redirect(url);
    }
    #endregion

}