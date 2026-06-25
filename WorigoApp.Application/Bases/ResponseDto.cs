namespace WorigoApp.Application.Bases
{
    /// <summary>
    /// ResponseDto sınıfını temsil eder.
    /// </summary>
    public class ResponseDto<T>
    {
/// <summary>
/// Data değerini alır veya ayarlar.
/// </summary>
public T Data { get; set; }

/// <summary>
/// StatusCode değerini alır veya ayarlar.
/// </summary>
public int StatusCode { get; set; }

/// <summary>
/// IsSuccess değerini alır veya ayarlar.
/// </summary>
public bool IsSuccess { get; set; }

/// <summary>
/// Errors değerini alır veya ayarlar.
/// </summary>
public List<string> Errors { get; set; } = new List<string>();
/// <summary>
/// Success işlemini gerçekleştirir.
/// </summary>
public ResponseDto<T> Success()
        {
            return new ResponseDto<T> { Data = Data, StatusCode = 200, IsSuccess = true, Errors = new List<string>() };
        }
/// <summary>
/// Success işlemini gerçekleştirir.
/// </summary>
public ResponseDto<T> Success(T data)
        {
            return new ResponseDto<T> { Data = data, StatusCode = 200, IsSuccess = true, Errors = new List<string>() };
        }
/// <summary>
/// Fail işlemini gerçekleştirir.
/// </summary>
public ResponseDto<T> Fail(T data, List<string> errors, int statusCode)
        {
            return new ResponseDto<T> { Data = data, Errors = errors, StatusCode = statusCode, IsSuccess = false };
        }
/// <summary>
/// Fail işlemini gerçekleştirir.
/// </summary>
public ResponseDto<T> Fail(List<string> errors, int statusCode)
        {
            return new ResponseDto<T> {  Errors = errors, StatusCode = statusCode, IsSuccess = false };
        }
/// <summary>
/// Fail işlemini gerçekleştirir.
/// </summary>
public ResponseDto<T> Fail(T data, string errors, int statusCode)
        {
            Errors ??= new List<string>();
            Errors.Add(errors);
            return new ResponseDto<T> { Data = data, Errors = Errors, StatusCode = statusCode, IsSuccess = false };
        }
/// <summary>
/// Fail işlemini gerçekleştirir.
/// </summary>
public ResponseDto<T> Fail(string errors, int statusCode)
        {
            Errors ??= new List<string>();
            Errors.Add(errors);
            return new ResponseDto<T> { Errors = Errors, StatusCode = statusCode, IsSuccess = false };
        }

    }
}
