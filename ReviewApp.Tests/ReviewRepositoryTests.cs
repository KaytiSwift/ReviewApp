using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewApp.Tests
{
    public class ReviewRepositoryTests
    {
        [Fact]
        public void GetAll_Returns_3_Reviews()
        {
            var underTest = new ReviewRepository();
            var result = underTest.GetAll();
            Assert.Equal(3, result.Count);
        }

    }
}
