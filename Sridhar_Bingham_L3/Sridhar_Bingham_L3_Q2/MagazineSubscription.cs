#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#endregion

namespace Sridhar_Bingham_L3_Q2
{
    public class MagazineSubscription
    {

        private String _first;
        private String _last;
        private String _address;
        private String _city;
        private String _state;
        private String _zipCode;
        private String _magazine;

        /*-- Constructors --*/

        #region -- Constructor() --
        public MagazineSubscription()
        {

        }
        #endregion

        /*-- Events --*/

        /*-- Properties --*/

        #region -- First Property --
        public String First
        {
            get { return _first; }
            set { _first = value; }
        }
        #endregion

        #region -- Last Property --
        public String Last
        {
            get { return _last; }
            set { _last = value; }
        }
        #endregion

        #region -- Address Property --
        public String Address
        {
            get { return _address; }
            set { _address = value; }
        }
        #endregion

        #region -- City Property --
        public String City
        {
            get { return _city; }
            set { _city = value; }
        }
        #endregion

        #region -- State Property --
        public String State
        {
            get { return _state; }
            set { _state = value; }
        }
        #endregion

        #region -- ZipCode Property --
        public String ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }
        #endregion

        #region -- Magazine Property --
        public String Magazine
        {
            get { return _magazine; }
            set { _magazine = value; }
        }
        #endregion

        /*-- Methods --*/
        
		#region -- SaveSubscription() Method --
		public int Save()
		{
            // Do some saving here.  Get the resulting item back.
            return 1;
		}
		#endregion
		
        /*-- Event Handlers --*/
	
        /*-- Factory Methods --*/
        
		#region -- LoadMagazineSubscription() Method --
		public static MagazineSubscription LoadMagazineSubscription(int SubscriptionId)
		{
            // Fake loading.  Add in loading later.
            if (SubscriptionId == 1)
            {
                MagazineSubscription magazineSubscription = new MagazineSubscription();
                magazineSubscription.First = "Vidya";
                magazineSubscription.Last = "Sridhar";
                magazineSubscription.Address = "Address";
                magazineSubscription.City = "City";
                magazineSubscription.State = "State";
                magazineSubscription.ZipCode = "64106";
                magazineSubscription.Magazine = "Time";

                return magazineSubscription;
            }
            else
            {
                return null;
            }
		}
		#endregion
		
    
    }
}
