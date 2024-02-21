using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class User
    {
        public required int Id { get; set; }
        public required string NameUser { get; set; }
        public required string SurnameUser { get; set; }
        public required DateTime Date { get; set; }
    }
}