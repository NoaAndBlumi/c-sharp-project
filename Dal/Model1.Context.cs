﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EZER_LAYOLEDETEntities : DbContext
    {
        public EZER_LAYOLEDETEntities()
            : base("name=EZER_LAYOLEDETEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Birth> Birth { get; set; }
        public virtual DbSet<Days> Days { get; set; }
        public virtual DbSet<Kosher> Kosher { get; set; }
        public virtual DbSet<Mother> Mother { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<ServiceAndDaysToVolunteer> ServiceAndDaysToVolunteer { get; set; }
        public virtual DbSet<ServiceManagementToBirth> ServiceManagementToBirth { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<ServiceVolunteerToBirth> ServiceVolunteerToBirth { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Volunteer> Volunteer { get; set; }
    
        public virtual ObjectResult<AllRequest_Result> AllRequest()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AllRequest_Result>("AllRequest");
        }
    
        public virtual ObjectResult<GetRequestByDay_Result> GetRequestByDay(Nullable<long> dayId)
        {
            var dayIdParameter = dayId.HasValue ?
                new ObjectParameter("DayId", dayId) :
                new ObjectParameter("DayId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetRequestByDay_Result>("GetRequestByDay", dayIdParameter);
        }
    
        public virtual ObjectResult<GetRequestByService_Result> GetRequestByService(Nullable<long> serviceId)
        {
            var serviceIdParameter = serviceId.HasValue ?
                new ObjectParameter("ServiceId", serviceId) :
                new ObjectParameter("ServiceId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetRequestByService_Result>("GetRequestByService", serviceIdParameter);
        }
    
        public virtual ObjectResult<selectMotherByServiceAndDay_Result> selectMotherByServiceAndDay(Nullable<long> volunteerId)
        {
            var volunteerIdParameter = volunteerId.HasValue ?
                new ObjectParameter("VolunteerId", volunteerId) :
                new ObjectParameter("VolunteerId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectMotherByServiceAndDay_Result>("selectMotherByServiceAndDay", volunteerIdParameter);
        }
    
        public virtual ObjectResult<SelectVolunteerByServiceAndDayNew_Result> SelectVolunteerByServiceAndDayNew(Nullable<long> motherId)
        {
            var motherIdParameter = motherId.HasValue ?
                new ObjectParameter("motherId", motherId) :
                new ObjectParameter("motherId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectVolunteerByServiceAndDayNew_Result>("SelectVolunteerByServiceAndDayNew", motherIdParameter);
        }
    
        public virtual ObjectResult<SelectVolunteerByServiceNew_Result> SelectVolunteerByServiceNew(Nullable<long> userId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectVolunteerByServiceNew_Result>("SelectVolunteerByServiceNew", userIdParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<VolunteerApproval_Result> VolunteerApproval(Nullable<long> serviceManagmentId, Nullable<long> volunteerId)
        {
            var serviceManagmentIdParameter = serviceManagmentId.HasValue ?
                new ObjectParameter("ServiceManagmentId", serviceManagmentId) :
                new ObjectParameter("ServiceManagmentId", typeof(long));
    
            var volunteerIdParameter = volunteerId.HasValue ?
                new ObjectParameter("VolunteerId", volunteerId) :
                new ObjectParameter("VolunteerId", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VolunteerApproval_Result>("VolunteerApproval", serviceManagmentIdParameter, volunteerIdParameter);
        }
    }
}