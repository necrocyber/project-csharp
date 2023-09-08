using System;
namespace FinalProject
{
	public class Usuario
	{
		private int _id;
		private string _firstName;
		private string _lastName;
		private string _userName;
		private string _password;
		private string _email;

		public Usuario()
		{
            this._id = 0;
            this._firstName = string.Empty;
            this._lastName = string.Empty;
            this._userName = string.Empty;
            this._password = string.Empty;
            this._email = string.Empty;
        }

        public Usuario(
			int id,
			string firstName,
			string lastName,
			string userName,
			string password,
			string email
        )
		{
			this._id = id;
			this._firstName = firstName;
			this._lastName = lastName;
			this._userName = userName;
			this._password = password;
			this._email = email;
		}

		public void showUser()
		{
			Console.WriteLine($"Name: {this._firstName} - Email: {this._email}");
		}
	}
}

