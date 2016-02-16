using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace GithubRefit.Models
{
    [Headers("User-Agent: Refit Demo App")]
    public interface IGitHubApi
    {
        [Post("/markdown")]
        Task<string> RenderAsMarkdown([Body] RenderRequest request);
    }
}
