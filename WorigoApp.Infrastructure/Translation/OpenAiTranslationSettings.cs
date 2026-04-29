namespace WorigoApp.Infrastructure.Translation
{
    public class OpenAiTranslationSettings
    {
        public string ApiKey { get; set; } = string.Empty;
        public string Model { get; set; } = "gpt-5-nano";
        public string BaseUrl { get; set; } = "https://api.openai.com/v1/";
    }
}
