using Microsoft.ProjectOxford.Search.Image;
using System;
using Xunit;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for the TrendingImageClient class.
    /// </summary>
    /// /// <seealso cref="Microsoft.ProjectOxford.Search.Image.TrendingImageClient" />
    public class TrendingImageClientTest
    {
        /// <summary>
        /// Tests the GetImages() method.
        /// </summary>
        [Fact]
        [Trait("Category","TrendingImages")]
        public void GetImagesTest()
        {
            var client = new TrendingImageClient(AppSettings.Instance.SearchApiKey);

            var response = client.GetImages();

            Assert.True(response.Categories.Count > 0);
        }
    }
}
