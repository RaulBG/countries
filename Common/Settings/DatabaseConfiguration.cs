namespace Common.Settings
{
    public class DatabaseConfiguration
    {
        public string Server { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public bool MultipleActiveResultSets { get; set; }
    }
}
