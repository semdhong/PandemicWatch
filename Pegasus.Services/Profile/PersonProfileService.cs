using Pegasus.Data;
using Pegasus.Models.Profiles;
using Pegasus.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pegasus.Services.Profile
{
    public class PersonProfileService : IPersonProfileService
    {
        private readonly IRepository<PersonProfile> _repoPersonProfile;
        private readonly IRepository<PersonHistory> _repoPersonHistory;
        private readonly IRepository<Barangay> _repoBarangay;
        private readonly IRepository<LguProfile> _repoLgu;
        public PersonProfileService(IRepository<PersonProfile> repoPersonProfile, IRepository<Barangay> repoBarangay, IRepository<LguProfile> repoLgu, IRepository<PersonHistory> repoPersonHistory)
        {
            _repoPersonProfile = repoPersonProfile;
            _repoBarangay = repoBarangay;
            _repoLgu = repoLgu;
            _repoPersonHistory = repoPersonHistory;
        }

        public void CreatePersonProfile(PersonProfilesModel model)
        {

            var data = new PersonProfile
            {
                Fullname = model.Fullname,
                LguId = model.LguId,
                BrgyId = model.BgryId,
                PersonStatus = model.PersonStatus,
                PrincipalPersonId = model.PrincipalPersonId,
                QDays = model.QDays,
                QDateStarted = model.QDateStarted,
                QDateEnded = model.QDateEnded,
                PicPath = model.PicPath,
                DateCreated = model.DateCreated,
                QrCode = model.CaseNo,
                Contact = model.Contact,
                Address = model.Address,
                SwabTestDate = model.SwabTestDate,
                SwabArea = model.SwabArea,
                CaseNo = model.CaseNo,
                Gender = model.Gender,
                DateLabConfirm = model.DateLabConfirm,
                BrgyRemarks = model.BrgyRemarks,
                CHDOHRemarks = model.CHDOHRemarks,
                IsolationCenter = model.IsolationCenterId,
                Age = model.Age,
                UserAgent = model.UserAgent,
                Family = model.Family,
                 Workmate = model.Workmate,
                  Friend = model.Friend,
                   Symptomatic = model.Symptomatic,
                   Long = model.Long,
                   Lat = model.Lat


            };
            _repoPersonProfile.AddAsync(data);
        }
      
        public List<PersonProfilesModel> GetContacts(int id)
        {
            return _repoPersonProfile.GetAll().Select(x => new PersonProfilesModel
            {
                Id = x.Id,
                Fullname = x.Fullname,
                LguId = x.LguId,
                BgryId = x.BrgyId,
                PersonStatus = x.PersonStatus,
                PrincipalPersonId = x.PrincipalPersonId,
                QDays = x.QDays,
                QDateStarted = x.QDateStarted,
                QDateEnded = x.QDateEnded,
                PicPath = x.PicPath,
                DateCreated = x.DateCreated,
                QrCode = x.QrCode,
                Contact = x.Contact,
                Address = x.Address,
                BrgyVerified = x.BrgyVerified,
                CHDOHVerified = x.CHDOHVerified,
                BrgyRemarks = x.BrgyRemarks,
                CHDOHRemarks = x.CHDOHRemarks,
                SwabTestDate = x.SwabTestDate,
                VerifiedBy = (Guid)x.VerifiedBy,
                ConfirmedBy = (Guid)x.ConfirmedBy,
                VerifiedDate = x.VerifiedDate,
                ConfirmedDate =x.ConfirmedDate,
                Barangay = new Models.Maintenance.BarangayModel
                {
                    Id = x.Brgy.Id,
                    LguId = x.LguId,
                    BarangayAddress = x.Brgy.BarangayAddress,
                    BarangayName = x.Brgy.BarangayName,
                },
                History = x.PersonHistory.Select(d => new PersonHistoryModel
                {
                    Id = d.Id,
                    CreatedBy = (Guid)d.CreatedBy,
                    DateCreate = d.DateCreated,
                    Remarks = d.Remarks
                }).ToList(),
                SwabArea = x.SwabArea,
                CaseNo = x.CaseNo,
                Gender = x.Gender,
                DateLabConfirm = x.DateLabConfirm,
                IsolationCenterId = x.IsolationCenter,
                Age = x.Age,
                UserAgent = (Guid)x.UserAgent,
                Family = x.Family,
                Workmate = x.Workmate,
                Friend = x.Friend,
                Symptomatic = x.Symptomatic,
                Long = x.Long,
                Lat = x.Lat


            }).Where(x => x.PrincipalPersonId == id).ToList();
        }

        public PersonProfilesModel GetPersonProfile(int id)
        {
            return _repoPersonProfile.GetAll().Select(x => new PersonProfilesModel
            {
                Id = x.Id,
                Fullname = x.Fullname,
                LguId = x.LguId,
                BgryId = x.BrgyId,
                PersonStatus = x.PersonStatus,
                PrincipalPersonId = x.PrincipalPersonId,
                QDays = x.QDays,
                QDateStarted = x.QDateStarted,
                QDateEnded = x.QDateEnded,
                PicPath = x.PicPath,
                DateCreated = x.DateCreated,
                QrCode = x.QrCode,
                Contact = x.Contact,
                Address = x.Address,
                BrgyVerified = x.BrgyVerified,
                CHDOHVerified = x.CHDOHVerified,
                BrgyRemarks = x.BrgyRemarks,
                CHDOHRemarks = x.CHDOHRemarks,
                SwabTestDate = x.SwabTestDate,
                VerifiedBy = (Guid)x.VerifiedBy,
                ConfirmedBy = (Guid)x.ConfirmedBy,
                VerifiedDate = x.VerifiedDate,
                ConfirmedDate = x.ConfirmedDate,
                Barangay = new Models.Maintenance.BarangayModel
                {
                    Id = x.Brgy.Id,
                    LguId = x.LguId,
                    BarangayAddress = x.Brgy.BarangayAddress,
                    BarangayName = x.Brgy.BarangayName,
                },
                History = x.PersonHistory.Select(d => new PersonHistoryModel
                {
                    Id = d.Id,
                    CreatedBy = (Guid)d.CreatedBy,
                    DateCreate = d.DateCreated,
                    Remarks = d.Remarks
                }).ToList(),
                SwabArea = x.SwabArea,
                CaseNo = x.CaseNo,
                Gender = x.Gender,
                DateLabConfirm = x.DateLabConfirm,
                IsolationCenterId = x.IsolationCenter,
                Age = x.Age,
                UserAgent = (Guid)x.UserAgent,
                Family = x.Family,
                Workmate = x.Workmate,
                Friend = x.Friend,
                Symptomatic = x.Symptomatic,
                Long = x.Long,
                Lat = x.Lat
            }).FirstOrDefault(x => x.Id == id);
        }

        public PersonProfilesModel GetPersonProfile(string name)
        {
            return _repoPersonProfile.GetAll().Select(x => new PersonProfilesModel
            {
                Id = x.Id,
                Fullname = x.Fullname,
                LguId = x.LguId,
                BgryId = x.BrgyId,
                PersonStatus = x.PersonStatus,
                PrincipalPersonId = x.PrincipalPersonId,
                QDays = x.QDays,
                QDateStarted = x.QDateStarted,
                QDateEnded = x.QDateEnded,
                PicPath = x.PicPath,
                DateCreated = x.DateCreated,
                QrCode = x.QrCode,
                Address = x.Address,
                Contact = x.Contact,
                BrgyVerified = x.BrgyVerified,
                CHDOHVerified = x.CHDOHVerified,
                BrgyRemarks = x.BrgyRemarks,
                CHDOHRemarks = x.CHDOHRemarks,
                SwabTestDate = x.SwabTestDate,
                Family = x.Family,
                Workmate = x.Workmate,
                Friend = x.Friend,
                Symptomatic = x.Symptomatic,
                Long = x.Long,
                Lat = x.Lat
            }).FirstOrDefault(x => x.Fullname == name);
        }

        public IEnumerable<PersonProfilesModel> GetPersonProfiles()
        {
            return _repoPersonProfile.GetAll().Select(x => new PersonProfilesModel
            {
                Id = x.Id,
                Fullname = x.Fullname,
                LguId = x.LguId,
                BgryId = x.BrgyId,
                PersonStatus = x.PersonStatus,
                PrincipalPersonId = x.PrincipalPersonId,
                QDays = x.QDays,
                QDateStarted = x.QDateStarted,
                QDateEnded = x.QDateEnded,
                PicPath = x.PicPath,
                DateCreated = x.DateCreated,
                QrCode = x.QrCode,
                Contact = x.Contact,
                Address = x.Address,
                BrgyVerified = x.BrgyVerified,
                CHDOHVerified = x.CHDOHVerified,
                BrgyRemarks = x.BrgyRemarks,
                CHDOHRemarks = x.CHDOHRemarks,
                SwabTestDate = x.SwabTestDate,
                VerifiedBy = (Guid)x.VerifiedBy,
                ConfirmedBy = (Guid)x.ConfirmedBy,
                VerifiedDate = x.VerifiedDate,
                ConfirmedDate = x.ConfirmedDate,
                Barangay = new Models.Maintenance.BarangayModel
                {
                    Id = x.Brgy.Id,
                    LguId = x.LguId,
                    BarangayAddress = x.Brgy.BarangayAddress,
                    BarangayName = x.Brgy.BarangayName,
                },
                History = x.PersonHistory.Select(d => new PersonHistoryModel
                {
                    Id = d.Id,
                    CreatedBy = (Guid)d.CreatedBy,
                    DateCreate = d.DateCreated,
                    Remarks = d.Remarks
                }).ToList(),
                SwabArea = x.SwabArea,
                CaseNo = x.CaseNo,
                Gender = x.Gender,
                DateLabConfirm = x.DateLabConfirm,
                IsolationCenterId = x.IsolationCenter,
                Age = x.Age,
                UserAgent = (Guid)x.UserAgent,
                Family = x.Family,
                Workmate = x.Workmate,
                Friend = x.Friend,
                Symptomatic = x.Symptomatic,
                Long = x.Long,
                Lat = x.Lat
            });
        }

        public void RemovePersonProfile(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePersonProfile(PersonProfilesModel model)
        {
            _repoPersonProfile.UpdateAsync(new PersonProfile
            {
                Id = model.Id,
                Fullname = model.Fullname,
                LguId = model.LguId,
                BrgyId = model.BgryId,
                PersonStatus = model.PersonStatus,
                PrincipalPersonId = model.PrincipalPersonId,
                QDays = model.QDays,
                QDateStarted = model.QDateStarted,
                QDateEnded = model.QDateEnded,
                PicPath = model.PicPath,
                DateCreated = model.DateCreated,
                QrCode = model.QrCode,
                Address = model.Address,
                Contact = model.Contact,
                BrgyVerified = model.BrgyVerified,
                CHDOHVerified = model.CHDOHVerified,
                BrgyRemarks = model.BrgyRemarks,
                CHDOHRemarks = model.CHDOHRemarks,
                SwabTestDate = model.SwabTestDate,
                SwabArea = model.SwabArea,
                CaseNo = model.CaseNo,
                Gender = model.Gender,
                DateLabConfirm = model.DateLabConfirm,
                IsolationCenter = model.IsolationCenterId,
                Age = model.Age,
                UserAgent = model.UserAgent,
                VerifiedBy = model.VerifiedBy,
                ConfirmedBy = model.ConfirmedBy,
                VerifiedDate = model.VerifiedDate,
                ConfirmedDate = model.ConfirmedDate,

            });
        }

        private string GetQrCode(PersonProfilesModel model)
        {

            var brgy = _repoBarangay.GetAll().FirstOrDefault(x => x.Id == model.BgryId.Value);
            var lgu = _repoLgu.GetAll().FirstOrDefault(x => x.Id == brgy.LguId).LguName;


            return lgu + " " + brgy.BarangayName + " " + model.Fullname;

        }

        #region Person History
        public void CreatePersonHistory(PersonHistoryModel model)
        {
            _repoPersonHistory.AddAsync(new PersonHistory
            {
                PersonProfileid = model.PersonProfileId,
                CreatedBy = model.CreatedBy,
                DateCreated = DateTime.Now,
                Remarks = model.Remarks
            });
        }

        public void UpdatePersonHistory(PersonHistoryModel model)
        {
            _repoPersonHistory.UpdateAsync(new PersonHistory
            {
                Id = model.Id,
                PersonProfileid = model.PersonProfileId,
                CreatedBy = model.CreatedBy,
                DateCreated = DateTime.Now,
                Remarks = model.Remarks
            });
        }

        public IEnumerable<PersonHistoryModel> GetPersonHistoryList(int id)
        {
            return _repoPersonHistory.GetAll().Where(x => x.PersonProfileid == id).Select(x => new PersonHistoryModel
            {
                Id = x.Id,
                CreatedBy = (Guid)x.CreatedBy,
                DateCreate = x.DateCreated,
                Remarks = x.Remarks
            });
        }
        #endregion

    }
}
