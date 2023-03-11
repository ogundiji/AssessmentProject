using AssessmentProject.Dtos;
using AssessmentProject.Entities;

namespace AssessmentProject.Services
{
    public interface ISkillServices
    {
        Task<List<SkillsDto>> GetSkillsAsync();
       
    }
}
