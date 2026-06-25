namespace WorigoApp.Application.Bases
{
    /// <summary>
    /// BaseException sınıfını temsil eder.
    /// </summary>
    public class BaseException : ApplicationException
    {
/// <summary>
/// BaseException sınıfının yeni bir örneğini başlatır.
/// </summary>
public BaseException() { }
/// <summary>
/// BaseException sınıfının yeni bir örneğini başlatır.
/// </summary>
public BaseException(string message) : base(message) { }
    }
}
