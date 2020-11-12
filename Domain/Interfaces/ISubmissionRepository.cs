using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ISubmissionRepository
    {
        Task<List<Submission>> GetAllSubmissions();
        Task CreateSubmission(Submission submission);
        Task<SerialNumber> ValidSubmissionSerialNumber(int serialKey);
        void UpdateSerialNumber(SerialNumber serialNumber);
    }
}
