using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// Translation sınıfını temsil eder.
/// </summary>
public class Translation : EntityBase
    {
/// <summary>
/// Translation sınıfının yeni bir örneğini başlatır.
/// </summary>
public Translation()
        {

        }
/// <summary>
/// Translation sınıfının yeni bir örneğini başlatır.
/// </summary>
public Translation(int id, string tableName, int recordId, string fieldName, string translationValue, string languageCode)
        {
            this.Id = id;
            this.TableName = tableName;
            this.RecordId = recordId;
            this.FieldName = fieldName;
            this.TranslationValue = translationValue;
            this.LanguageCode = languageCode;
        }
        /// <summary>
        /// Table İsmi
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// İlgili tablodaki id'si
        /// </summary>
        public int RecordId { get; set; }
        /// <summary>
        /// Sütun adı
        /// </summary>
        public string FieldName { get; set; }
        /// <summary>
        /// Çevrilmiş Değer
        /// </summary>
        public string TranslationValue { get; set; }
        /// <summary>
        /// Hedef Dil
        /// </summary>
        public string LanguageCode { get; set; }//hedef dil
    }
}
