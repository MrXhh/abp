using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace learn.Web.Pages;

public class IndexModel : learnPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
