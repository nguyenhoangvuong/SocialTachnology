//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FivePSocialNetwork.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sex_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sex_User()
        {
            this.Users = new HashSet<User>();
        }
    
        public int sex_id { get; set; }
        public string sex_name { get; set; }
        public Nullable<bool> sex_activate { get; set; }
        public Nullable<System.DateTime> sex_dateCreate { get; set; }
        public Nullable<System.DateTime> sex_dateEdit { get; set; }
        public Nullable<bool> sex_recycleBin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}