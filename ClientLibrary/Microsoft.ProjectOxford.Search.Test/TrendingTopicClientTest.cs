using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.ProjectOxford.Search.News;
using System.Configuration;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for tredning topic client.
    /// </summary>
    [TestClass]
    public class TrendingTopicClientTest
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

        #region Methods

        /// <summary>
        /// Tests the GetTrendingTopicsTest() method.
        /// </summary>
        [TestMethod]
        [TestCategory("Trending topics news search")]
        public void GetTrendingTopicsTest()
        {
            var request = new TrendingTopicRequest();

            var client = new TrendingTopicClient(apiKey);
            var response = client.GetTrendingTopics(request);

            Assert.IsTrue(response.Results.Count > 0);
        }

        #endregion Methods
    }
}
