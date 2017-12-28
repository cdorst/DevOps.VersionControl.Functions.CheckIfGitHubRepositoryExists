using System.Net;
using System.Threading.Tasks;
using static Common.Functions.GetHttpStatusCode.HttpStatusCodeGetter;

namespace DevOps.VersionControl.Functions.CheckIfGitHubRepositoryExists
{
    public static class GitHubRepositoryExistenceChecker
    {
        private const string GitHubUri = "https://github.com";

        public static async Task<bool> Exists(string account, string repository)
            => (await Status(account, repository)) == HttpStatusCode.OK;

        private static async Task<HttpStatusCode> Status(string account, string repository)
            => await GetStatusCode(Uri(account, repository));

        private static string Uri(string account, string repository)
            => $"{GitHubUri}/{account}/{repository}";
    }
}
