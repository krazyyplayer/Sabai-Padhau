//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SabaiPadhau.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCertificate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCertificate()
        {
            this.UserRoles = new HashSet<UserRole>();
        }
    
        public int CertificateId { get; set; }
        public string GovernmentVerifiedImage { get; set; }
        public Nullable<bool> IsVerified { get; set; }
        public Nullable<int> UserId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
