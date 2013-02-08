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
	

    }
}
