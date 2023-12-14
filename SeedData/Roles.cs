using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonMaaku.Library.SeedData
{
	public static class Roles
	{
		public static IdentityRole<int> Admin = new IdentityRole<int>("admin")
		{
			Id = 1,
			NormalizedName = "ADMIN"
		};
		public static IdentityRole<int> CoAdmin = new IdentityRole<int>("co-admin")
		{
			Id = 2,
			NormalizedName = "CO-ADMIN"
		};
		public static IdentityRole<int> Developer = new IdentityRole<int>("developer")
		{
			Id = 3, NormalizedName = "DEVELOPER"
		};
		public static IdentityRole<int> Manager = new IdentityRole<int>("manager")
		{
			Id = 4,
			NormalizedName = "MANAGER"
		};
		public static IdentityRole<int> User = new IdentityRole<int>("user")
		{
			Id = 5,
			NormalizedName = "USER"
		};

		public static IEnumerable<IdentityRole<int>> Data = new List<IdentityRole<int>>()
		{
			Admin,
			CoAdmin,
			Developer,
			Manager,
			User
		};
	}
}
