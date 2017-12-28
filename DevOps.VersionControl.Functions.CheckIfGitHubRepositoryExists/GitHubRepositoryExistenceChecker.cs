using DevOps.VersionControl.Structures.GitHub;
using System.Net;
using System.Threading.Tasks;
using static Common.Functions.GetHttpStatusCode.HttpStatusCodeGetter;

namespace DevOps.VersionControl.Functions.CheckIfGitHubRepositoryExists
{
    public static class GitHubRepositoryExistenceChecker
    {
        public static async Task<bool> Exists(AccountRepository accountRepository)
            => (await Status(accountRepository)) == HttpStatusCode.OK;

        private static async Task<HttpStatusCode> Status(AccountRepository accountRepository)
            => await GetStatusCode(accountRepository.Uri);
    }
}
