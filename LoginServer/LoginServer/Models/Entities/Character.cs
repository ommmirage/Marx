using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginServer.Models.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Nick { get; set; }
        public int Race { get; set; } // 0 - Human, 1 - Elf, 2 - Orc
        public bool Gender { get; set; } // 0 - Male, 1 -Female
        public int Exp { get; set; } 
        public float X { get; set; } = 0.0f;
        public float Y { get; set; } = 0.0f;
        public float Z { get; set; } = 0.0f;

    }
}
