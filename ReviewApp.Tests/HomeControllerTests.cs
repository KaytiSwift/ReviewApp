using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using ReviewApp.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewApp.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            var reviewRepo = Substitute.For<IReviewRepository>();
            var underTest = new HomeController(reviewRepo);

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Returns_All_Reviews()
        {
            var reviewRepo = Substitute.For<IReviewRepository>();
            var underTest = new HomeController(reviewRepo);
            

            var result = underTest.Index();
            reviewRepo.Received().GetAll();
        }
    }
}
