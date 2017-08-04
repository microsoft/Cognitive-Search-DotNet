using Microsoft.ProjectOxford.Search.Core;
using Microsoft.ProjectOxford.Search.News;
using System;
using Xunit;

namespace Microsoft.ProjectOxford.Search.Test
{
    public class NewsSearchClientTest
    {
        /// <summary>
        /// Tests the GetNews() method.
        /// </summary>
        [Fact]
        [Trait("Category","NewsSearch")]
        public void GetNewsTest()
        {
            var request = new NewsSearchRequest();
            request.Query = "unicorns";
            request.Count = 10;
            request.Offset = 0;
            request.Market = "en-US";
            request.SafeSearch = SafeSearch.Moderate;

            var client = new NewsSearchClient(AppSettings.Instance.SearchApiKey);

            var response = client.GetNews(request);

            Assert.True(response.Results.Count > 0);
        }
    }
}
