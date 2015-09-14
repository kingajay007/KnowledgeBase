using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Models
{
    public class Question
    {
        public int Id { get; set; }
        public String Query { get; set; }

        public virtual ICollection<Choice> Choices { get; set; }

        public virtual Category Category { get; set; }
    }
}
