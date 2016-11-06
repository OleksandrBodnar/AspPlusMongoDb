using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppTestMongoDb.Models
{
    public class ComputerList
    {
        public IEnumerable<Computer> Computers { get; set; }
        public ComputerFilter Filter { get; set; }
    }
}