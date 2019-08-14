using RepoGit.Application.Interface;
using RepoGit.Domain.Entities;
using RepoGit.Domain.Interface.Services;
using System.Collections.Generic;

namespace RepoGit.Application
{
    public class RepoGitAppService : IRepoGitAppService
    {
        public readonly IRepoGitService _repoGitService;

        public RepoGitAppService(IRepoGitService repoGitService)
        {
            _repoGitService = repoGitService;
        }

        public IList<Git> GetAllGitRepositories()
        {
           return _repoGitService.GetAllGitRepositories();
        }
    }
}
