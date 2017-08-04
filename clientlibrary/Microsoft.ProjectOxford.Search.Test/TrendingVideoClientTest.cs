using Microsoft.ProjectOxford.Search.Video;
using System;
using Xunit;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for the TrendingVideoClient class.
    /// </summary>
    /// /// <seealso cref="Microsoft.ProjectOxford.Search.Video.TrendingVideoClient" />
    public class TrendingVideoClientTest
    {
        /// <summary>
        /// Tests the GetVideos() method.
        /// </summary>
        [Fact]
        [Trait("Category","TrendingVideos")]
        public void GetVideosTest()
        {
            var client = new TrendingVideoClient(AppSettings.Instance.SearchApiKey);

            var response = client.GetVideos();

            Assert.True(response.BannerTiles.Count > 0);
            Assert.True(response.Categories.Count > 0);
        }
    }
}
