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
    
    public partial class SelectVolunteerByServiceNew_Result
    {
        public long volunteer { get; set; }
        public long BirthId { get; set; }
        public long mother { get; set; }
        public long ServiceManagementId { get; set; }
        public int StatusRequest { get; set; }
        public string MotherEmail { get; set; }
        public Nullable<long> DayId { get; set; }
        public Nullable<int> MotherDay { get; set; }
        public string VolunteerName { get; set; }
        public string TheService { get; set; }
        public string volunteerEmail { get; set; }
        public long serviceId { get; set; }
    }
}