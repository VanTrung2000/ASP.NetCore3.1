using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QlCoffe.Models
{
    public class Coffe
    {
        public int Id { set; get; }
        public string NameCoffe { set; get; }
        public double Price { set; get; }
        public string Despition { set; get; }
        public string Soluong {set;get; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
