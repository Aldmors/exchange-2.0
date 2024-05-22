﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExchangeServerAPI.Models
{
    public class Authentication
    {
        public int AuthenticationId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? Password { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? TwoFa { get; set; }
    }
}