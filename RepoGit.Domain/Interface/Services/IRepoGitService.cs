using RepoGit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoGit.Domain.Interface.Services
{
    public interface IRepoGitService
    {
        IList<Git> GetAllGitRepositories();
    }
}
