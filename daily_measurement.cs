//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace animalWeightTracker_00183727
{
    using System;
    using System.Collections.Generic;
    
    public partial class daily_measurement
    {
        public int Id { get; set; }
        public Nullable<int> log_id { get; set; }
        public Nullable<int> waist_size { get; set; }
        public Nullable<double> weight { get; set; }
        public string shift { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    
        public virtual daily_log daily_log { get; set; }
    }
}
