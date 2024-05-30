namespace AI_WeirdnessAPI.Models
{
	public class AiWeirdnessDatabaseSettings : IAiWeirdnessDatabaseSettings
	{
        public string ConnectionString { get; set; } = String.Empty;

        public string DatabaseName { get; set; } = String.Empty;

        public string UserCollectionName { get; set; } = String.Empty;
    }
}
