using Cosmonaut.Attributes;
using Newtonsoft.Json;

namespace AssessmentProject.Entities
{
    [CosmosCollection("Skills")]
    public class Skills
    {
        [CosmosPartitionKey]
        [JsonProperty("id")]
        public string Id { get; set; }=string.Empty;
        public string Name { get; set; }=string.Empty;
    }
}
