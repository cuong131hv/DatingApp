using System;


namespace API.Entities
{
	public class AppUser
	{
		// Set up user here
		public int Id { get; set; }

		public string UserName { get; set; }

		//hashpassword return byte
		public byte[] PasswordHash { get; set; }

		public byte[] PasswordSalt { get; set; }

	}
}
