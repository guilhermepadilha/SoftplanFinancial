using RepoGit.Domain.Entities;
using System.Collections.Generic;

namespace RepoGit.Domain.Interface
{
    public interface IRepoGitRepository
    {
        IList<Git> GetAllGitRepositories();
    }
}
