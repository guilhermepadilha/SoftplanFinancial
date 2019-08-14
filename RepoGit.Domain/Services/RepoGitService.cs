using RepoGit.Domain.Entities;
using RepoGit.Domain.Interface;
using RepoGit.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoGit.Domain.Services
{
    public class RepoGitService : IRepoGitService
    {
        public readonly IRepoGitRepository _repoGitRepository;

        public RepoGitService(IRepoGitRepository repoGitRepository)
        {
            _repoGitRepository = repoGitRepository;
        }

        public IList<Git> GetAllGitRepositories()
        {
            return _repoGitRepository.GetAllGitRepositories();
        }
    }
}
