using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieStore1.Controllers;
using MovieStore1.Models;
using System.Linq;
using System.Net;
using System.Web;


namespace MovieStore1.Tests.Controllers
{
    [TestClass]
    public class MovieStoreControllerTest1
    {
        [TestMethod]
        public void MovieStoreIndexTestView()
        {
            // Arrange
            MoviesController controller = new MoviesController();

            // Act
         ViewResult result = controller.Index() as ViewResult;

            // Assert
          Assert.IsNotNull(result);
        }
        public void MovieStore_ListOfMovies()
        {
            // Arrange
            MoviesController controller = new MoviesController();

            // Act
            List<Movie> result = controller.ListOfMovies();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expected: "Iron Man 1", actual: result[0].Title);
            Assert.AreEqual(expected: "Iron Man 2", actual: result[1].Title);
            Assert.AreEqual(expected: "Iron Man 3", actual: result[2].Title);
        }

        [TestMethod]
        public void MovieStore_IndexRedirect()
        {
            // Arrange
            MoviesController controller = new MoviesController();

            // Act
            RedirectToRouteResult result = controller.IndexRedirect() as RedirectToRouteResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expected:"Create", actual: result.RouteValues["action"]);
        }
    }
}
