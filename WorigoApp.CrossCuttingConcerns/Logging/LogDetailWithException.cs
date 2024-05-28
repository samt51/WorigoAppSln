namespace WorigoApp.CrossCuttingConcerns.Logging
{
    public class LogDetailWithException : LogDetail
    {
        public string ExceptionMessage { get; set; }
        public LogDetailWithException()
        {
            ExceptionMessage = string.Empty;
        }
        public LogDetailWithException(string fullname, string methodname, string user, List<LogParameter> logParameters, string exceptionMessage) : base(fullname, methodname, user, logParameters)
        {
            this.ExceptionMessage = exceptionMessage;
        }
    }
}
