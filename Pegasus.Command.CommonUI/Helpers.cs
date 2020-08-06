using System;
using System.Collections.Generic;
using System.Text;

namespace Pegasus.Command.CommonUI
{
    public class Helpers
    {
       
        public string ApiUrl(Enum apitype)
        {
            string url="";
            //Live
            //switch (apitype)
            //{
            //    case ApiType.Admin: url= "https://pegasusapiadmin.azurewebsites.net/api/";break;
            //    case ApiType.Agent: url= "https://pegasusapiagent.azurewebsites.net/api/";break;

            //}
            //Local
            switch (apitype)
            {
                case ApiType.Admin: url = "https://localhost:44399/api"; break;
                case ApiType.Agent: url = "https://localhost:44326/api"; break;

            }

            return url;
        }

       
       
    }

    public enum ApiType
    {
        Admin,Agent
    }
}
