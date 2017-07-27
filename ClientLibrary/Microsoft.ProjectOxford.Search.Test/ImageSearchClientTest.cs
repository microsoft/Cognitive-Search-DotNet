using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Microsoft.ProjectOxford.Search.Core;
using Microsoft.ProjectOxford.Search.Image;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for the ImageSearchClient class.
    /// </summary>
    [TestClass]
    public class ImageSearchClientTest
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
        /// Tests the Validate() method to ensure a query is specified.
        /// </summary>
        [TestMethod]
        [TestCategory("Image search")]
        [ExpectedException(typeof(QueryNotSpecifiedException))]
        public void ValidateTest_QueryNotSpecified()
        {
            var request = new ImageSearchRequest();
            request.Validate();
        }

        /// <summary>
        /// Tests the GetImages() method.
        /// </summary>
        [TestMethod]
        [TestCategory("Image search")]
        public void GetImagesTest()
        {
            var request = new ImageSearchRequest();
            request.Query = "cats";
            request.Count = 10;
            request.Offset = 0;
            request.Market = "en-US";
            request.SafeSearch = SafeSearch.Moderate;

            var client = new ImageSearchClient(this.apiKey);

            var response = client.GetImages(request);

            Assert.IsTrue(response.Images.Count > 0);
        }

        #endregion Test Methods
    }
}
