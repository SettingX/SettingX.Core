using SettingX.Core.Enums;
using SettingX.Core.Models;

namespace SettingX.Core.Services
{
    public interface IGitService
    {
        SourceControlTypes ResolveSourceControlTypeFromUrl(string url);
        string GetGitRepositoryName(string gitUrl, SourceControlTypes type);
        string GenerateRepositorySettingsGitUrl(
            string gitUrl,
            SourceControlTypes type,
            string branch = "");
        ServiceResult DownloadSettingsFileFromGit(
            string url,
            SourceControlTypes type);
    }
}