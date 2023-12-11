using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonMaaku.Library.Entities.Chatto
{
	public class Message : IEntity
	{
		public User User { get; set; }
		public ChatHub ChatHub { get; set; }
		public string Content { get; set; }
		public ContentType ContentType { get; set; }
		public int Id { get ; set ; }
		public bool IsActive { get ; set ; }
		public DateTime DateCreated { get ; set ; }
		public DateTime DateModified { get ; set ; }
		public int CreatedByUserId { get ; set ; }
		public int UpdatedByUserId { get ; set ; }
	}
	public enum ContentType
	{
		Text,
		Emoji,
		Image
	}
}
