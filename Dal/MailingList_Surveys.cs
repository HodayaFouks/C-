//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class MailingList_Surveys
    {
        public int mail_survId { get; set; }
        public string email { get; set; }
        public int surveyId { get; set; }
        public Nullable<int> userId { get; set; }
        public bool isAnswered { get; set; }
    
        public virtual Survey Survey { get; set; }
        public virtual User User { get; set; }
    }
}