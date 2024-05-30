namespace AI_WeirdnessAPI.Models
{
	public interface IAiWeirdnessDatabaseSettings
	{
		string ConnectionString { get; set; }
		string DatabaseName { get; set; }
		string UserCollectionName { get; set; }

	}
}
