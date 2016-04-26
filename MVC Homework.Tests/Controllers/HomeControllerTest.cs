using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_Homework;
using MVC_Homework.Controllers;

namespace MVC_Homework.Tests.Controllers
{
    [TestClass]
    public class ClassmateControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            ClassmateController controller = new ClassmateController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


    }
}
