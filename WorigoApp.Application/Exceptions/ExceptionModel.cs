using Newtonsoft.Json;

namespace WorigoApp.Application.Exceptions
{
    public class ExceptionModel
    {
        //public IEnumerable<string> Errors { get; set; }

        public WorigoApp.Application.Bases.Response<ExceptionModel> Response { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    //public class ErrorStatusCode
    //{
    //    public int StatusCode { get; set; }
    //}
}
