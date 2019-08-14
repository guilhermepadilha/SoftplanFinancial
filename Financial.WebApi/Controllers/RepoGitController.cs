using Microsoft.AspNetCore.Mvc;
using RepoGit.Application.Interface;
using RepoGit.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Financial.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepoGitController : Controller
    {
        private readonly IRepoGitAppService _repoGitAppService;

        public RepoGitController(IRepoGitAppService repoGitAppService)
        {
            _repoGitAppService = repoGitAppService;
        }

        [HttpGet]
        [Route("showmethecode")]
        public IList<Git> GetAllGitRepositories()
        {
            try
            {
                return _repoGitAppService.GetAllGitRepositories();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
