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
    
    public partial class core_notifications
    {
        public decimal id { get; set; }
        public decimal member { get; set; }
        public string notification_app { get; set; }
        public string notification_key { get; set; }
        public string item_class { get; set; }
        public Nullable<decimal> item_id { get; set; }
        public string member_data { get; set; }
        public long sent_time { get; set; }
        public Nullable<long> read_time { get; set; }
        public long updated_time { get; set; }
        public string item_sub_class { get; set; }
        public Nullable<decimal> item_sub_id { get; set; }
        public string extra { get; set; }
    }
}
