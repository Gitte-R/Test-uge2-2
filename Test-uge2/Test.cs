using Xunit;

namespace Test_uge2
{
    public class Test
    {
        [Fact]
        public void Is_Book_Borrowed()
        {
            Book Book1 = new Book("I skyggen af krigen", "Leif Davidsen", 320, "Krimi og spænding");
            Book1.BorrowBook();
            Assert.True(Book1.IsBorrowed);
        }

        [Fact]
        public void Is_Book_Returned()
        {
            Book Book1 = new Book("I skyggen af krigen", "Leif Davidsen", 320, "Krimi og spænding");
            Book1.ReturnBook();
            Assert.False(Book1.IsBorrowed);
        }

        [Theory]
        [InlineData(-1, false)]
        [InlineData(2.54, true)]
        [InlineData(6, false)]
        public void Is_Book_Rated(int rating, bool result)
        {
            Book Book1 = new Book("I skyggen af krigen", "Leif Davidsen", 320, "Krimi og spænding");
            Assert.Equal(Book1.RateBook(rating), result);
        }

        [Theory]
        [InlineData(2.54, 2.54)]
        [InlineData(1.46, 1.46)]
        public void Is_Multiple_Ratings_Calculated(double single_rating, double avg_rating)
        {
            Book Book1 = new Book("I skyggen af krigen", "Leif Davidsen", 320, "Krimi og spænding");
            Book1.RateBook(single_rating);
            Assert.Equal(Book1.Rating, avg_rating);
        }

        [Theory]
        [InlineData(2, 4)]
        [InlineData(4, 8)]
        public void CalculateReadingTimeInMinutes(int pages, int result)
        {
            Book Book1 = new Book("I skyggen af krigen", "Leif Davidsen", 320, "Krimi og spænding");
            Book1.CalculateReadingTimeInMinutes(pages);
            Assert.Equal(Book1.CalculateReadingTimeInMinutes(pages), result);
        }
    }
}
