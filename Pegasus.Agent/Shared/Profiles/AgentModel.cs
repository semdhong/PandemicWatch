using System;
using System.Collections.Generic;
using System.Text;

namespace Pegasus.Agent.Shared.Profiles
{
   public class AgentModel
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int? PIN { get; set; }
        public string Department { get; set; }

    }
}
