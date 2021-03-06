using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            /// Model to Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<Command, CommandUpdateDto>();

            /// Target to Model
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();



        }
    }
}