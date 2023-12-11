using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonMaaku.Library.Entities.Chatto
{
	public class ChatHub : IEntity
	{
		public int Id { get; set; }
		public IEnumerable<UserChatHub> Members { get; set; }
		public IEnumerable<Message> Messages { get; set; }
		public string? Name { get; set; }
		public bool IsActive { get; set; } = true;
		public DateTime DateCreated { get; set; } = DateTime.Now;
		public DateTime DateModified { get; set; }
		public int CreatedByUserId { get; set; }
		public int UpdatedByUserId { get; set; }
	}
}
