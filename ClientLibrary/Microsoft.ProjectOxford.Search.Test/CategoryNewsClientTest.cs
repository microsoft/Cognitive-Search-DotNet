using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Microsoft.ProjectOxford.Search.News;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for category news client.
    /// </summary>
    [TestClass]
    public class CategoryNewsClientTest
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
            apiKey = Environment.GetEnvironmentVariable("COG_API_KEY_SEARCH");
        }

        #endregion Test Initialization

        #region Methods

        /// <summary>
        /// Tests the GetCategoryNews() method.
        /// </summary>
        [TestMethod]
        [TestCategory("Category news search")]
        public void GetCategoryNewsTest()
        {
            var request = new CategoryNewsRequest();
            request.Category = Category.Business;

            var client = new CategoryNewsClient(apiKey);
            var response = client.GetCategoryNews(request);

            Assert.IsTrue(response.Results.Count > 0);
        }

        #endregion Methods
    }
}
