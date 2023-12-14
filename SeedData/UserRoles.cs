using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonMaaku.Library.SeedData
{
	public static class UserRoles
	{
		public static IdentityUserRole<int> AdminUserAdminRole = new IdentityUserRole<int>
		{
			RoleId = 1,
			UserId = 1,
		};
		public static IdentityUserRole<int> DevUserDevRole = new IdentityUserRole<int>
		{
			RoleId = 3,
			UserId = 2,
		};
		public static IdentityUserRole<int> ManagerUserManagerRole = new IdentityUserRole<int>
		{
			RoleId = 4,
			UserId = 3,
		};
		public static IdentityUserRole<int> UserUserUserRole = new IdentityUserRole<int>
		{
			RoleId = 5,
			UserId = 4,
		};

		public static IEnumerable<IdentityUserRole<int>> Data = new List<IdentityUserRole<int>>
		{
			AdminUserAdminRole,
			DevUserDevRole, ManagerUserManagerRole, UserUserUserRole
		};

	}
}
