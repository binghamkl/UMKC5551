#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

#endregion

namespace Sridhar_Bingham_L5.Models
{
    public class GroupMembers
    {

        private List<GroupMember> _members = new List<GroupMember>();
        private String _lastFetched;

        /*-- Constructors --*/

        #region -- Constructor() --
        public GroupMembers()
        {

        }
        #endregion

        /*-- Events --*/

        /*-- Properties --*/

        #region -- Members Property --
        public List<GroupMember> Members
        {
            get { return _members; }
            set { _members = value; }
        }
        #endregion

        #region -- LastFetched Property --
        public String LastFetched
        {
            get { return _lastFetched; }
            set { _lastFetched = value; }
        }
        #endregion

        /*-- Methods --*/

        /*-- Event Handlers --*/
	
        /*-- Factory Methods --*/
        
		#region -- ReturnGroupMembers() Method --
		public static GroupMembers ReturnGroupMembers()
		{
            GroupMembers groupMembers = new GroupMembers();
            groupMembers.LastFetched = DateTime.Now.ToLongTimeString();

            GroupMember newMember = new GroupMember();
            newMember.MemberName = "Kendall Bingham";
            groupMembers.Members.Add(newMember);

            newMember = new GroupMember();
            newMember.MemberName = "Vidya Sridhar";
            groupMembers.Members.Add(newMember);

            return groupMembers;
		}
		#endregion
		
    }
}