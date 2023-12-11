namespace JonMaaku.Library.Entities.Chatto
{
	public class UserChatHub : IEntity
	{
		public int Id { get; set; }
		public User User { get; set; }
		public ChatHub ChatHub { get; set; }
		public UserChatHubStatus Status { get; set; } = UserChatHubStatus.Active;
		public string Nickname { get; set; }
		public bool IsActive { get; set; } = true; 
		public DateTime DateCreated { get; set; } = DateTime.UtcNow;
		public DateTime DateModified { get; set; }
		public int CreatedByUserId { get; set; }
		public int UpdatedByUserId { get; set; }

	}

	public enum UserChatHubStatus
	{
		Online,
		Blocked,
		Active,
		Remove
	}

}
