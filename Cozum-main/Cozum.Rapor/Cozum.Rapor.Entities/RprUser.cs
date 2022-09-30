using System;
using System.Collections.Generic;

#nullable disable

namespace Cozum.Rapor.Entities
{
    public partial class RprUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string EMail { get; set; }
        public string Departmant { get; set; }
    }
}
