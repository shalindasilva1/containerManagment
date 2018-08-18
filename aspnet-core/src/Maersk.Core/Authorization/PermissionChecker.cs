using Abp.Authorization;
using Maersk.Authorization.Roles;
using Maersk.Authorization.Users;

namespace Maersk.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
