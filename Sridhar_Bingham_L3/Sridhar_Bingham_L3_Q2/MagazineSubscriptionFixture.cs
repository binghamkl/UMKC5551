#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

#endregion

namespace Sridhar_Bingham_L3_Q2
{
    [TestFixture()]
    public class MagazineSubscriptionFixture
    {


        #region -- TestCreationOfMagazineSubscription() Method --
        [Test()]
        public void TestCreationOfMagazineSubscription()
        {
            MagazineSubscription magazineSubscription = new MagazineSubscription();
            Assert.IsNotNull(magazineSubscription, "Did not create magazine subscription option");
        }
        #endregion

        #region -- MagazineSubscriptionAcceptsNameAddressInformation() Method --
        [Test()]
        public void MagazineSubscriptionAcceptsNameAddressInformation()
        {
            MagazineSubscription magazineSubscription = new MagazineSubscription();
            magazineSubscription.First = "Vidya";
            magazineSubscription.Last = "Sridhar";
            magazineSubscription.Address = "Address";
            magazineSubscription.City = "City";
            magazineSubscription.State = "State";
            magazineSubscription.ZipCode = "64106";

            Assert.AreEqual("Vidya", magazineSubscription.First, "First Name must have set/get");
            Assert.AreEqual("Sridhar", magazineSubscription.Last, "Last Name must have set/get");
            Assert.AreEqual("Address", magazineSubscription.Address, "Address must have setter/getter");
            Assert.AreEqual("City", magazineSubscription.City, "City must have setter/getter");
            Assert.AreEqual("State", magazineSubscription.State, "State must have setter/getter");
            Assert.AreEqual("64106", magazineSubscription.ZipCode, "ZipCode must have setter/getter");

        }
        #endregion

        #region -- SubmitMagazineSubscriptionSavesInformationIntoSubscriptions() Method --
        [Test()]
        public void SubmitMagazineSubscriptionSavesInformationIntoSubscriptions()
        {
            MagazineSubscription magazineSubscription = new MagazineSubscription();
            magazineSubscription.First = "Vidya";
            magazineSubscription.Last = "Sridhar";
            magazineSubscription.Address = "Address";
            magazineSubscription.City = "City";
            magazineSubscription.State = "State";
            magazineSubscription.ZipCode = "64106";
            magazineSubscription.Magazine = "Time";
            int subScriptionId = magazineSubscription.Save();

            MagazineSubscription savedSubscription = MagazineSubscription.LoadMagazineSubscription(subScriptionId);
            Assert.IsNotNull(savedSubscription, "Did not load a saved subscription");
        }
        #endregion
	

    }
}
