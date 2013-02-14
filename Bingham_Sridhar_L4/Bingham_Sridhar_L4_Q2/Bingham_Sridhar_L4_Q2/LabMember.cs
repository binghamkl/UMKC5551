#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Data;
using System.Xml.Serialization;

#endregion

namespace Bingham_Sridhar_L4_Q2
{

    public class LabMember1
    {
        [DataMember]
        [Browsable(false)]
        [XmlIgnore]
        public new EntityKey EntityKey { get; set; }

    }
}