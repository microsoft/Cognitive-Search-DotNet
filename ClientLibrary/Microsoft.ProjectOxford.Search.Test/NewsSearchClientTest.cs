using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Microsoft.ProjectOxford.Search.News;
using Microsoft.ProjectOxford.Search.Core;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for news search client.
    /// </summary>
    [TestClass]
    public class NewsSearchClientTest
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

        #region Test Methods

        /// <summary>
        /// Tests the GetNews() method.
        /// </summary>
        [TestMethod]
        [TestCategory("News search")]
        public void GetNewsTest()
        {
            var request = new NewsSearchRequest();
            request.Query = "unicorns";
            request.Count = 10;
            request.Offset = 0;
            request.Market = "en-US";
            request.SafeSearch = SafeSearch.Moderate;

            var client = new NewsSearchClient(this.apiKey);

            var response = client.GetNews(request);

            Assert.IsTrue(response.Results.Count > 0);
        }

        #endregion Test Methods
    }
}
