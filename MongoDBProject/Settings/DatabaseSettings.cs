namespace MongoDBProject.Settings
{
	public class DatabaseSettings : IDatabaseSettings
	{
		public string ConectionString { get; set; }
		public string DatabaseName { get; set; }
		public string CustomerCollectionName { get; set; }
	}
}
