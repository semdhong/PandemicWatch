using System;
using System.Collections.Generic;
using System.Text;
using Pegasus.Agent.Shared.Maintenance;

namespace Pegasus.Agent.Shared.Profiles
{
    public class PersonProfilesModel
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int? LguId { get; set; }
        public int? BgryId { get; set; }
        public int? UserAgent { get; set; }
        public string QrCode { get; set; }
        public string PicPath { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public int? PrincipalPersonId { get; set; }
        public int? QDays { get; set; }
        public DateTime? QDateStarted { get; set; }
        public DateTime? QDateEnded { get; set; }
        public string PersonStatus { get; set; }
        public bool? BrgyVerified { get; set; }
        public bool? CHDOHVerified { get; set; }
        public BarangayModel Barangay { get; set; }
        public LguProfileModel Lgu { get; set; }
        public AgentModel Agent { get; set; }
        public string BrgyRemarks { get; set; }
        public string CHDOHRemarks { get; set; }
        public DateTime? SwabTestDate { get; set; }
        public string SwabArea { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public DateTime? DateLabConfirm { get; set; }
        public int? IsolationCenterId { get; set; }
        public List<PersonHistoryModel> History { get; set; }
        public IsolationCenterModel IsolationCenter { get; set; }
        public string CaseNo { get; set; }
    }
}
