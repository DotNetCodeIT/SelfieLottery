﻿using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomicGeneratorNumber;
using RandomicGeneratorNumber.Controllers;
using EstrazionePremi.Controllers;

namespace RandomicGeneratorNumber.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Disposizione
            HomeController controller = new HomeController();

            // Azione
            ViewResult result = controller.Index() as ViewResult;

            // Asserzione
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}