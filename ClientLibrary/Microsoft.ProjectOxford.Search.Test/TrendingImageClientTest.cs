using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.ProjectOxford.Search.Image;
using System.Configuration;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for the TrendingImageClient class.
    /// </summary>
    [TestClass]
    public class TrendingImageClientTest
    {
        #region Fields

        private string apiKey = "";

        #endregion Fields

        #region Test Initialization

        /// <summary>
        /// Intializes this instance.
        /// </summary>
        [TestInitialize]
        public void Intialize()
        {
            apiKey = ConfigurationManager.AppSettings["searchApiKey"];
        }

        #endregion Test Initialization

        #region Test Methods

        /// <summary>
        /// Tests the GetImages() method.
        /// </summary>
        [TestMethod]
        [TestCategory("Trending images")]
        public void GetImagesTest()
        {
            var client = new TrendingImageClient(this.apiKey);

            var response = client.GetImages();

            Assert.IsTrue(response.Categories.Count > 0);
        }

        #endregion Test Methods
    }
}
