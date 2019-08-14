using RepoGit.Domain.Interface;
using RepoGit.Domain.Entities;
using System.Collections.Generic;

namespace RepoGit.Infra.Data
{
    public class RepoGitRepository : IRepoGitRepository
    {
        public RepoGitRepository()
        {

        }

        public IList<Git> GetAllGitRepositories()
        {
            IList<Git> listaRepositories = new List<Git>();
            listaRepositories.Add(new Git { Nome = "SoftplanFinancial", Url = "https://github.com/guilhermepadilha/SoftplanFinancial.git" });
            listaRepositories.Add(new Git { Nome = "SoftplanBacen", Url = "https://github.com/guilhermepadilha/SoftplanBacen.git" });

            return listaRepositories;
        }
    }
}
