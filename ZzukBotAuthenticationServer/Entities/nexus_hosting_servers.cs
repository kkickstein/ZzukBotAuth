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
    
    public partial class nexus_hosting_servers
    {
        public int server_id { get; set; }
        public string server_hostname { get; set; }
        public string server_ip { get; set; }
        public string server_username { get; set; }
        public string server_access { get; set; }
        public string server_type { get; set; }
        public string server_queues { get; set; }
        public Nullable<int> server_max_accounts { get; set; }
        public string server_nameservers { get; set; }
        public Nullable<int> server_monitor_fails { get; set; }
        public Nullable<int> server_monitor_last_sucess { get; set; }
        public Nullable<int> server_monitor_version { get; set; }
        public Nullable<float> server_monitor_load { get; set; }
        public string server_cost { get; set; }
        public string server_monitor { get; set; }
        public int server_dedicated { get; set; }
        public bool server_monitor_acknowledged { get; set; }
        public string server_extra { get; set; }
    }
}
