//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Richard.Tutorial.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdersByUser
    {
        public int OrderByUserId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> OrderId { get; set; }
    
        public virtual Orders Orders { get; set; }
        public virtual Users Users { get; set; }
    }
}
