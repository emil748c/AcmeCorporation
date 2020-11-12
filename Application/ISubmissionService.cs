using Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface ISubmissionService
    {
        Task<List<GetListSubmissionsViewModel>> GetAllSubmissions();
        Task CreateSubmission(CreateSubmissionViewModel createSubmissionViewModel);


    }
}
