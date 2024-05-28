namespace WorigoApp.CrossCuttingConcerns.Logging.ConfigurationModels
{
    public class FileLogConfiguration
    {
        public string FolderPath { get; set; }
        public FileLogConfiguration()
        {
            FolderPath = string.Empty;
        }
        public FileLogConfiguration(string folderpath)
        {
            this.FolderPath = folderpath;
        }
    }

}
