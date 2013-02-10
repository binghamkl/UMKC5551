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
    public partial class TimerPostBack : System.Web.UI.Page
    {


        /*-- Constructors --*/

        #region -- Constructor() --
        public TimerPostBack()
        {

        }
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

        #region -- uxTimerPostback_Tick(object sender, EventArgs e) Event Handler --
        protected void uxTimerPostback_Tick(object sender, EventArgs e)
        {
            uxCurrentTime.Text = DateTime.Now.ToLongTimeString();
        }
        #endregion

    }
}