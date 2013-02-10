#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#endregion

namespace Sridhar_Bingham_L3_Q3
{
    public partial class SiteMaster : System.Web.UI.MasterPage
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

        #region -- uxTimer_Tick(object sender, EventArgs e) Event Handler --
        protected void uxTimer_Tick(object sender, EventArgs e)
        {
            uxTime.Text = DateTime.Now.ToLongTimeString();
        }
        #endregion

    }
}
