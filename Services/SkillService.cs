using AssessmentProject.Entities;
using Cosmonaut;
using Cosmonaut.Extensions;

namespace AssessmentProject.Services
{
    public class SkillService : ISkillServices
    {
        private readonly ICosmosStore<Skills> _cosmosStore;

        public SkillService(ICosmosStore<Skills> cosmosStore)
        {
            _cosmosStore = cosmosStore;
        }

        public async Task<bool> CreateSkillAsync(Skills payload)
        {
            var request = new Skills
            {
                Id = payload.Id,
                Name = payload.Name
            };

            var response= await _cosmosStore.AddAsync(request);

            return response.IsSuccess;
        }

        public async Task<bool> DeleteSkillAsync(Guid id)
        {
            var response = await _cosmosStore.RemoveByIdAsync(id.ToString(),id.ToString());

            return response.IsSuccess;

        }

        public async Task<List<Skills>> GetSkillsAsync()
        {
            var skillList = await _cosmosStore.Query().ToListAsync();
            return skillList.Select(x => new Skills { Id = Guid.Parse(x.Id).ToString(), Name = x.Name }).ToList();
        }

        public async Task<Skills> GetSkillsByIdAsync(Guid Id)
        {
            var skill = await _cosmosStore.FindAsync(Id.ToString());
            if (skill == null)
                return null;

            return new Skills { Id= Guid.Parse(skill.Id).ToString(),Name= skill.Name };
        }

        public async Task<bool> UpdateSkillAsync(Skills payload)
        {
            var request = new Skills
            {
                Id = payload.Id,
                Name = payload.Name
            };

            var response = await _cosmosStore.UpdateAsync(request);

            return response.IsSuccess;
        }
    }
}
