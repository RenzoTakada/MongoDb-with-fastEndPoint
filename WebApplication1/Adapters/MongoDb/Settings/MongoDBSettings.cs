namespace Adapters.MongoDb.Settings
{
    public class MongoDBSettings
    {
        public string ConnectionString { get; set; }
        public string DataBaseName { get; set; }
        public bool IsSSL { get; set; }

    }
}
