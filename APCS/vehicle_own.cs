//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APCS
{
    using System;
    using System.Collections.Generic;
    
    public partial class vehicle_own
    {
        public string w_active { get; set; }
        public int w_id { get; set; }
        public int user_num { get; set; }
        public int vehicle_num { get; set; }
    
        public virtual user user { get; set; }
        public virtual vehicle vehicle { get; set; }
    }
}