//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZzukBotAuthenticationServer.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class core_edit_history
    {
        public decimal id { get; set; }
        public string @class { get; set; }
        public decimal comment_id { get; set; }
        public decimal member { get; set; }
        public long time { get; set; }
        public string old { get; set; }
        public string @new { get; set; }
        public Nullable<bool> @public { get; set; }
        public string reason { get; set; }
    }
}
