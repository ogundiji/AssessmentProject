using AssessmentProject.Entities;
using AssessmentProject.Models;

namespace AssessmentProject.Repositories
{
    public interface IProgramDetailRepository
    {
        Task<List<ProgramDetails>> GetProgramDetailsAsync();
        Task<bool> CreateProgramDetailsAsync(ProgramDetails payload);
        Task<ProgramDetails> GetProgramDetailsByIdAsync(Guid Id);
        Task<bool> UpdateProgramDetailsAsync(ProgramDetails payload);
        Task<bool> DeleteProgramDetailsAsync(Guid id);
    }
}
