namespace Books.Api.Utils
{
    public class ConfigUtils
    {
        public ConfigUtils(){ }

        public string GetBooksConnectionString
        {
            get {
                var configuaration = GetConfiguration();
                string connectionString = configuaration.GetSection("ConnectionStrings").GetSection("booksConnectionString").Value;
                return connectionString;
            }
        }

        private IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                         .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            return builder.Build();
        }
    }
}
