using Domain;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class SubmissionRepository : ISubmissionRepository
    {
        private readonly ApplicationDbContext context;

        public SubmissionRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task CreateSubmission(Submission submission)
        {
            context.Submissions.Add(submission);
            await context.SaveChangesAsync();


        }

        public async Task<List<Submission>> GetAllSubmissions()
        {
            var submissions = await context.Submissions.OrderBy(ob => ob.SurName).ToListAsync();
            return submissions;
        }

        public void UpdateSerialNumber(SerialNumber serialNumber)
        {
            context.SerialNumbers.Update(serialNumber);
        }

        public async Task<SerialNumber> ValidSubmissionSerialNumber(int serialKey)
        {
            var productSerialNumber = await context.SerialNumbers.FirstOrDefaultAsync(x => x.SerialKey == serialKey);
            return productSerialNumber;
        }
    }
}
