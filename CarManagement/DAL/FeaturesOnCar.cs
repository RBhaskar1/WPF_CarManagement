//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class FeaturesOnCar
    {
        public int Car_For_Sale_ID { get; set; }
        public int Car_Feature_ID { get; set; }
        public int ID { get; set; }
    
        public virtual CarFeature CarFeature { get; set; }
        public virtual IndividualCar IndividualCar { get; set; }
    }
}
