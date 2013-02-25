#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

#endregion

namespace Sridhar_Bingham_L5.Models
{
    public class GroupMember
    {

        private String _memberName;

        /*-- Constructors --*/

        #region -- Constructor() --
        public GroupMember()
        {

        }
        #endregion

        /*-- Events --*/

        /*-- Properties --*/

        #region -- MemberName Property --
        public String MemberName
        {
            get { return _memberName; }
            set { _memberName = value; }
        }
        #endregion

        /*-- Methods --*/

        /*-- Event Handlers --*/
	
    }
}