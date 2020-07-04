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

            /// Target to Model
            CreateMap<CommandCreateDto, Command>();
        }
    }
}