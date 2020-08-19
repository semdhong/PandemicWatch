using System;
using System.Collections.Generic;
using System.Text;

namespace Pegasus.Command.Shared.Profiles
{
   public class PersonHistoryModel
    {
        public int Id { get; set; }
        public int? PersonProfileId { get; set; }
        public string Remarks { get; set; }
        public DateTime? DateCreate { get; set; }
        public Guid CreatedBy { get; set; }
        public string User { get; set; }
    }
}
