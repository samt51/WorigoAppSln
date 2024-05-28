namespace WorigoApp.CrossCuttingConcerns.Logging
{
    public class LogDetail
    {
        public string FullName { get; set; }
        public string MethodName { get; set; }
        public string User { get; set; }
        public List<LogParameter> Parameters { get; set; }

        public LogDetail()
        {
            FullName = string.Empty;
            MethodName = string.Empty;
            User = string.Empty;
            Parameters = new List<LogParameter>();
        }
        public LogDetail(string fullname, string methodname, string user, List<LogParameter> logParameters)
        {
            this.FullName = fullname;
            this.MethodName = methodname;
            this.User = user;
            this.Parameters = logParameters;
        }
    }
}
