#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

#endregion

namespace Sridhar_Bingham_L3_Q3
{
    public partial class Extreme : System.Web.UI.Page
    {

        /*-- Constructors --*/

        #region -- Constructor() --
        #endregion

        /*-- Events --*/

        /*-- Properties --*/

        /*-- Methods --*/

        /*-- Event Handlers --*/

        #region -- Page_Load(object sender, EventArgs e) Event Handler --
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region -- uxPostback_Click(object sender, EventArgs e) Event handler --
        protected void uxPostback_Click(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
            uxPostbackResult.Text = "Postback at " + DateTime.Now.ToLongTimeString();
        }
        #endregion

        #region -- uxAjax_Click(object sender, EventArgs e) Event Handler --
        protected void uxAjax_Click(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
            uxAjaxResult.Text = "Postback at " + DateTime.Now.ToLongTimeString();
        }
        #endregion

    }
}