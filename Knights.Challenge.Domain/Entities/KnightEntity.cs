using System;
using System.Collections.Generic;

namespace Knights.Challenge.Domain.Entities
{
    public class KnightEntity : BaseEntity
    {
        private DateTime _birthday = new DateTime();
        public KnightEntity()
        {
            Weapons = new List<Weapon>();
        }

        public string Name { get; set; }
        public string Nickname { get; set; }
        public DateTime Birthday
        {
            get => _birthday;
            set => _birthday = value.Date;
        }
        public List<Weapon> Weapons { get; set; }
        public bool Deleted { get; set; }
        
        public Attributes Attributes { get; set; }
        public string KeyAttribute { get; set; }

    }

    public class Weapon
    {
        public string Name { get; set; }
        public int Mod { get; set; }
        public string Attr { get; set; }
        public bool Equipped { get; set; }
    }

    public class Attributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

    }
}
