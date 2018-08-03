using Microsoft.AspNetCore.Identity;
namespace Entity
{
    /// <summary>
    /// Represents the application user.
    /// </summary>
    public class ApplicationUser : 
        IdentityUser<string>
    {
    }
}