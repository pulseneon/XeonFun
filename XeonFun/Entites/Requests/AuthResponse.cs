﻿using XeonFun.Entites.Models;

namespace XeonFun.Entites.Requests
{
    public class AuthResponse
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Token { get; set; }

        public AuthResponse(User user, string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Username;
            Email = user.Email;
            Phone = user.Phone;
            Token = token;
        }

        public AuthResponse()
        {
        }
    }
}
