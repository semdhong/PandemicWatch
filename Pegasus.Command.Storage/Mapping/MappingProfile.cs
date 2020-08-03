using AutoMapper.Configuration;
using Pegasus.Command.Shared.DataModels;
using Pegasus.Command.Shared.Dto;
using Pegasus.Command.Shared.Dto.Account;
using Pegasus.Command.Shared.Dto.Sample;
using ApiLogItem = Pegasus.Command.Shared.DataModels.ApiLogItem;
using Message = Pegasus.Command.Shared.DataModels.Message;
using UserProfile = Pegasus.Command.Shared.DataModels.UserProfile;

namespace Pegasus.Command.Storage.Mapping
{
    public class MappingProfile : MapperConfigurationExpression
    {
        /// <summary>
        /// Create automap mapping profiles
        /// </summary>
        public MappingProfile()
        {
            CreateMap<Todo, TodoDto>().ReverseMap();           
            CreateMap<UserProfile, UserProfileDto>().ReverseMap();
            CreateMap<ApiLogItem, ApiLogItemDto>().ReverseMap();
            CreateMap<Message, MessageDto>().ReverseMap();
        }
    }
}
