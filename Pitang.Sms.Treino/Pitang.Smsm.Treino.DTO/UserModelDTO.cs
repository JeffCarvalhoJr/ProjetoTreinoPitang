﻿using System;

namespace Pitang.Smsm.Treino.DTO
{
    public class UserModelDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
    }
}
