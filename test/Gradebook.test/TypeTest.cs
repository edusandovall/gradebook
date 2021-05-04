using System;
using Xunit;

namespace Gradebook.test
{
    public class TypeTest
    {
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
           var book1 = GetBook("Book 1");
           var book2 = GetBook("Book 2"); 

           Assert.Equal("Book 1", book1.Name);
           Assert.Equal("Book 2", book2.Name);
           Assert.NotSame(book1, book2);
        }

        public void TwoVarsCanReferenceSameObject()
        {
           var book1 = GetBook("Book 1");
           var book2 = book1; 

           //Evaluates if two objects points at the same object in memory
           Assert.Same(book1, book2); 
           //Same from above but returns true if it's true
           Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
