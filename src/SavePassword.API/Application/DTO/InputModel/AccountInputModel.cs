﻿namespace SavePassword.API.Application.DTO
{
    public class AccountInputModel
    {
        public string? NickName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string? Note { get; set; }
    }
}
