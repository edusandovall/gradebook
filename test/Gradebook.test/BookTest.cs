using System;
using Xunit;

namespace Gradebook.test
{
    public class BookTest
    {
        [Fact]
        public void BookCalculatesAverageGrade()
        {
            //arrange
            Book book = new Book("");

            book.addGrade(4.5);
            book.addGrade(3.5);
            book.addGrade(2.9);
            book.addGrade(3.7);
            
            //act
            var result = book.getStatistics();

            //assert
            Assert.Equal(3.65, result.average, 2);
            Assert.Equal(2.9, result.lowGrade);
            Assert.Equal(4.5, result.highGrade);
        }
    }
}
