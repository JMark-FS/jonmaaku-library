using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonMaaku.Library.Entities
{
	public interface IEntity
	{
		int Id { get; set; }
		bool IsActive { get; set; }
		DateTime DateCreated { get; set; }
		DateTime DateModified { get; set; }
		int CreatedByUserId { get; set; }
		int UpdatedByUserId { get; set; }
	}

}
