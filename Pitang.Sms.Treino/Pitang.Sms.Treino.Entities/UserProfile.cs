﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pitang.Sms.Treino.Entities
{
    public class UserProfile : BaseEntity
    {

        [MaxLength(60, ErrorMessage = "Este campo deve conter entre no maximo 60 caracteres")]
        public string Name { get; set; }

        public byte[] ProfileImage { get; set; }

        [Required]
        public virtual UserModel User { get; set; }

    }
}
