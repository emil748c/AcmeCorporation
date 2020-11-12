using Application.ViewModels;
using AutoMapper;
using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public class SubmissionService : ISubmissionService
    {
        private readonly ISubmissionRepository repository;
        private readonly IMapper mapper;

        public SubmissionService(ISubmissionRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public async Task CreateSubmission(CreateSubmissionViewModel createSubmissionViewModel)
        {
            var submission = mapper.Map<Submission>(createSubmissionViewModel);
            
            await repository.CreateSubmission(submission);
        }

        public async Task<List<GetListSubmissionsViewModel>> GetAllSubmissions()
        {
            var submissions = await repository.GetAllSubmissions();
            var viewModels = mapper.Map<List<GetListSubmissionsViewModel>>(submissions);
            return viewModels;
        }
    }
}
