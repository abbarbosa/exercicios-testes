using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Console_test
{
    public class BookList
    {
        public string Title {  get; set; }

        public string Description { get; set; }
  

        public BookList(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
