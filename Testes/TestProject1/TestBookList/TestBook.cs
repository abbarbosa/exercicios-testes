using Console_test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.TestBookList
{
    public class TestBook
    {
        [Fact]
        public void NewBook ()
        {
            var ListBook = new List<BookList>();

            var book = new BookList("one of us is lying", "five teenagers are accused of murdering their friend in detention ");
            
            ListBook.Add(book);

            Assert.Contains(book, ListBook);
        }
    }
}
