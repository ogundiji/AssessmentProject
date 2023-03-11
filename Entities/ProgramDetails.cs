using Cosmonaut.Attributes;
using Newtonsoft.Json;

namespace AssessmentProject.Entities
{
    [CosmosCollection("ProgramDetails")]
    public class ProgramDetails
    {
        [CosmosPartitionKey]
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;
        public string ProgramTitle { get; set; }=string.Empty;
        public string ProgramSummary { get; set; } = string.Empty;
        public string ProgramDescription { get; set; } = string.Empty;
        public string ProgramSkills { get; set; } = string.Empty;
        public string ProgramBenefit { get; set; } = string.Empty;
        public string ApplicationCriteria { get; set; } = string.Empty;
        public string TypeOfProgram { get; set; } = string.Empty;
        public string ProgramStart { get; set; } = string.Empty;
        public string ApplicationOpen { get; set; } = string.Empty;
        public string ApplicationClose { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public bool isFullyRemote { get; set; }
        public string MinimumQualification { get; set; } = string.Empty;  
        public long MaxNumberOfApplication { get; set; }

    }
}
