using Microsoft.ProjectOxford.Search.Core;
using Microsoft.ProjectOxford.Search.Web;
using System;
using Xunit;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for the WebSearchClient class.
    /// </summary>
    /// /// <seealso cref="Microsoft.ProjectOxford.Search.Web.WebSearchClient" />
    public class WebSearchClientTest
    {
        /// <summary>
        /// Tests the GetWebResults() method.
        /// </summary>
        [Fact]
        [Trait("Category","WebSearch")]
        public void GetWebResultsTest()
        {
            var request = new WebSearchRequest();
            request.Query = "unicorns";
            request.Count = 10;
            request.Offset = 0;
            request.Market = "en-US";
            request.SafeSearch = SafeSearch.Moderate;

            var client = new WebSearchClient(AppSettings.Instance.SearchApiKey);

            var response = client.GetWebResults(request);

            Assert.True(response.WebPages.Results.Count > 0);
        }
    }
}
