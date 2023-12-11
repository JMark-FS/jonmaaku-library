using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonMaaku.Library.Entities
{
	[Index(nameof(UserName), IsUnique = true)]
	public class User: IdentityUser<int>, IEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public override int Id { get; set; }

		[MaxLength(50)]
		public string? LastName { get; set; }

		[MaxLength(50)]
		public string? FirstName { get; set; }

		[Required]
		[MaxLength(250)]
		public override string Email { get; set; }

		[Required]
		[MaxLength(20)]
		public override string UserName { get; set; }
		public DateTime DateCreated { get ; set ; }
		public DateTime DateModified { get ; set ; }
		public int CreatedByUserId { get ; set ; }
		public int UpdatedByUserId { get ; set ; }
		public bool IsActive { get ; set ; }
	}

	public class Role : IdentityRole<int> { }
}
