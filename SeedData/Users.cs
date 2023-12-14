using JonMaaku.Library.Entities;

namespace JonMaaku.Library.SeedData
{
	public static class Users
	{

		public static User Administrator = new User()
		{
			Id = 1,
			UserName = "jonmaaku-admin",
			Email = "admin@gmail.com",
			SecurityStamp = Guid.NewGuid().ToString(),
			NormalizedUserName = "JONMAAKU-ADMIN",
			NormalizedEmail = "ADMIN@GMAIL.COM"
		};


		public static User Developer = new User()
		{
			Id = 2,
			UserName = "jonmaaku-developer",
			FirstName = "Jhon Mark",
			LastName = "Acopiado",
			Email = "dev@gmail.com",
			SecurityStamp = Guid.NewGuid().ToString(),
			NormalizedEmail = "DEV@GMAIL.COM",
			NormalizedUserName = "JONMAAKU-DEVELOPER"
		};
		public static User Manager = new User()
		{
			Id = 3,
			UserName = "jonmaaku-manager",
			FirstName = "Jhon Mark",
			LastName = "Acopiado",
			Email = "manager@gmail.com",
			SecurityStamp = Guid.NewGuid().ToString(),
			NormalizedUserName = "JONMAAKU-MANAGER",
			NormalizedEmail = "MANAGER@GMAIL.COM"
		};
		public static User User = new User()
		{
			Id = 4,
			UserName = "jonmaaku",
			FirstName = "Jhon Mark",
			LastName = "Acopiado",
			Email = "jacopiado@fullscale.io",
			SecurityStamp = Guid.NewGuid().ToString(),
			NormalizedUserName = "JONMAAKU",
			NormalizedEmail = "JACOPIADO@FULLSCALE.IO"
		};

		public static IEnumerable<User> Data = new List<User>()
		{
			Administrator,
			Developer,
			Manager,
			User
		};
	}
}
