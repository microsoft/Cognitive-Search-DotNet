using Microsoft.ProjectOxford.Search.News;
using System;
using Xunit;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for trending topic client.
    /// </summary>
    public class TrendingTopicClientTest
    {
        /// <summary>
        /// Tests the GetTrendingTopicsTest() method.
        /// </summary>
        [Fact]
        [Trait("Category", "TrendingTopics")]
        public void GetTrendingTopicsTest()
        {
            var request = new TrendingTopicRequest();

            var client = new TrendingTopicClient(AppSettings.Instance.SearchApiKey);
            var response = client.GetTrendingTopics(request);

            Assert.True(response.Results.Count > 0);
        }
    }
}
