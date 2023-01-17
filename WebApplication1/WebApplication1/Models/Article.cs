using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Article
    {
        public int codeArt { get; }

        public string? nomArt { get; set; }
        public int prixArt { get; set; }
        public int stockArt { get; set; }
        public DateTime ExpDate { get; set; }
    }
}
