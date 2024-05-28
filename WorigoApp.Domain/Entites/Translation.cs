using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class Translation : EntityBase
    {
        public Translation()
        {
            
        }
        public string EntityName { get; set; }
        public string Key { get; set; }//UnknownError
        public string Text { get; set; }//Beklenemedsadas error message.
        public string LanguageCode { get; set; }//hedef dil
    }
}
