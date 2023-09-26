using AutoMapper;
using filmesAPI.Data.Dtos;
using filmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmesAPI.Profiles
{
    public class FilmeProfiles : Profile
    {
        public FilmeProfiles()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }



    }
}
