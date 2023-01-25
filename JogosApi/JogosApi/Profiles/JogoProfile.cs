
using AutoMapper;
using JogosApi.Data.Dtos;
using JogosApi.Models;

namespace JogosApi.Profiles;

public class JogoProfile : Profile
{
    public JogoProfile()
    {
       CreateMap<CreateJogoDto, Jogo>();

    }

}
