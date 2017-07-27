using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Microsoft.ProjectOxford.Search.Web;
using Microsoft.ProjectOxford.Search.Core;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for the WebSearchClient class.
    /// </summary>
    [TestClass]
    public class WebSearchClientTest
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
        /// Tests the GetWebResults() method.
        /// </summary>
        [TestMethod]
        [TestCategory("Web search")]
        public void GetWebResultsTest()
        {
            var request = new WebSearchRequest();
            request.Query = "unicorns";
            request.Count = 10;
            request.Offset = 0;
            request.Market = "en-US";
            request.SafeSearch = SafeSearch.Moderate;

            var client = new WebSearchClient(this.apiKey);

            var response = client.GetWebResults(request);

            Assert.IsTrue(response.WebPages.Results.Count > 0);
        }

        #endregion Test Methods

    }
}
