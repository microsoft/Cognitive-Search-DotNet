using Microsoft.ProjectOxford.Search.News;
using System;
using Xunit;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for category news client.
    /// </summary>
    public class CategoryNewsClientTest
    {
        /// <summary>
        /// Tests the GetCategoryNews() method.
        /// </summary>
        [Fact]
        [Trait("Category","CategoryNews")]
        public void GetCategoryNewsTest()
        {
            var request = new CategoryNewsRequest();
            request.Category = Category.Business;

            var client = new CategoryNewsClient(AppSettings.Instance.SearchApiKey);
            var response = client.GetCategoryNews(request);

            Assert.True(response.Results.Count > 0);
        }
    }
}
