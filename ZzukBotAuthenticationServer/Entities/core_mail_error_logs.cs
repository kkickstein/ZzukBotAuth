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
    
    public partial class core_mail_error_logs
    {
        public int mlog_id { get; set; }
        public int mlog_date { get; set; }
        public string mlog_to { get; set; }
        public string mlog_from { get; set; }
        public string mlog_subject { get; set; }
        public string mlog_content { get; set; }
        public string mlog_msg { get; set; }
        public string mlog_smtp_log { get; set; }
        public string mlog_resend_data { get; set; }
    }
}
