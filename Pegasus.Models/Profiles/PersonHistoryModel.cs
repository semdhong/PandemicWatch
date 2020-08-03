using System;
using System.Collections.Generic;
using System.Text;

namespace Pegasus.Models.Profiles
{
   public class PersonHistoryModel
    {
        public int Id { get; set; }
        public int? PersonProfileId { get; set; }
        public string Remarks { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? CreatedBy { get; set; }
    }
}
