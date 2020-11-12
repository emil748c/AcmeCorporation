using Application.ViewModels;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappings
{
    public class ViewModelToDomainMapping : Profile
    {
        public ViewModelToDomainMapping()
        {
            CreateMap<CreateSubmissionViewModel, Submission>();
            CreateMap<SerialNumberViewModel, SerialNumber>();
        }
    }
}
