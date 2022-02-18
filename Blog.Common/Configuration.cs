namespace Blog.Common
{
	public class Configuration
	{
		public GeneralConfig General { get; set; }
	}

	public class GeneralConfig
	{
		public string DbConnection { get; set; }
	}
}