using Login2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Razor.TagHelpers;

[HtmlTargetElement("td", Attributes = "i-role")]
public class RoleUsersTH : TagHelper
{
    private readonly UserManager<AppUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public RoleUsersTH(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

    [HtmlAttributeName("i-role")]
    public string RoleId { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        if (string.IsNullOrEmpty(RoleId))
        {
            output.Content.SetContent("No Role ID provided");
            return;
        }

        var role = await _roleManager.FindByIdAsync(RoleId);
        if (role == null)
        {
            output.Content.SetContent("Role not found");
            return;
        }

        var usersInRole = new List<string>();

        // Use a new instance of UserManager if needed
        var users = _userManager.Users.ToList();
        foreach (var user in users)
        {
            if (await _userManager.IsInRoleAsync(user, role.Name))
            {
                usersInRole.Add(user.UserName);
            }
        }

        output.Content.SetContent(usersInRole.Count == 0 ? "No Users" : string.Join(", ", usersInRole));
    }
}
