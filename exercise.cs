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
    
    public partial class exercise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public exercise()
        {
            this.daily_exercise = new HashSet<daily_exercise>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public string time { get; set; }
        public Nullable<double> calories_burn { get; set; }
        public string exercise_type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<daily_exercise> daily_exercise { get; set; }
    }
}
