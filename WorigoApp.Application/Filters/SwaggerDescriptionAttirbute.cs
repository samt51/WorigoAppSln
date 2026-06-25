namespace WorigoApp.Application.Filters
{
    /// <summary>
    /// SwaggerDescriptionAttirbute sınıfını temsil eder.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class SwaggerDescriptionAttirbute : Attribute
    {
/// <summary>
/// Summary değerini alır veya ayarlar.
/// </summary>
public string Summary { get; }
/// <summary>
/// SwaggerDescriptionAttirbute sınıfının yeni bir örneğini başlatır.
/// </summary>
public SwaggerDescriptionAttirbute(string summary)
        {
            Summary = summary;
        }
    }
}
