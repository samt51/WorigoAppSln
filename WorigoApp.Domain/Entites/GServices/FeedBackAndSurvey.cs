using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// geri bildirim ve anket
    /// </summary>
    public class FeedBackAndSurvey : EntityBase
    {
        public int? DepartmentId { get; set; }
        public string FeedBack { get; set; }
        public FeedBackAndSurvey(int? departmentId, string feedBack)
        {
            this.DepartmentId = departmentId;
            this.FeedBack = feedBack;
        }
    }
}
