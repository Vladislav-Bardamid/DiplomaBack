﻿using AutoMapper;
using DiplomaBack.DAL.Entities;

namespace DiplomaBack.ViewModels.Mappings
{
  public class ViewModelToEntityMappingProfile : Profile
  {
    public ViewModelToEntityMappingProfile()
    {
      CreateMap<RegistrationViewModel, User>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
    }
  }
}