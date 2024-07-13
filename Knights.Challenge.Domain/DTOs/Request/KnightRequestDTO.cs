using FluentValidation;
using Knights.Challenge.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Knights.Challenge.Domain.DTOs.Request
{
    public class KnightRequestDTO
    {
        public string Name { get; set; }
        public string Nickname { get; set; }
        public DateTime Birthday { get; set; }
        public List<Weapon> Weapons { get; set; }
        public Attributes Attributes { get; set; }
        public string KeyAttribute { get; set; }
    }
}
