//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BL
{
    using System;
    using System.Collections.Generic;
    
    public partial class History
    {
        public int ID { get; set; }
        public int Userpassword { get; set; }
        public Nullable<System.DateTime> TestDate { get; set; }
        public int Mark { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
