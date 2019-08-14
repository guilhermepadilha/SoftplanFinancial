using RepoGit.Domain.Entities;
using System.Collections.Generic;

namespace RepoGit.Application.Interface
{
    public interface IRepoGitAppService
    {
        IList<Git> GetAllGitRepositories();
    }
}