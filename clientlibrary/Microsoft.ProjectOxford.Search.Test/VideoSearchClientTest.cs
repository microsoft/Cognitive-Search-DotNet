using Microsoft.ProjectOxford.Search.Core;
using Microsoft.ProjectOxford.Search.Video;
using System;
using Xunit;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for the VideoSearchClient class.
    /// </summary>
    /// /// <seealso cref="Microsoft.ProjectOxford.Search.Video.VideoSearchClient" />
    public class VideoSearchClientTest
    {
        /// <summary>
        /// Tests the Validate() method to ensure a query is specified.
        /// </summary>
        [Fact]
        [Trait("Category", "VideoSearch")]
        public void ValidateTest_QueryNotSpecified()
        {
            var request = new VideoSearchRequest();
            Assert.Throws<QueryNotSpecifiedException>(() => request.Validate());
        }

        /// <summary>
        /// Tests the GetVideos() method.
        /// </summary>
        [Fact]
        [Trait("Category","VideoSearch")]
        public void GetVideosTest()
        {
            var request = new VideoSearchRequest();
            request.Query = "cats";
            request.Count = 10;
            request.Offset = 0;
            request.Market = "en-US";
            request.SafeSearch = SafeSearch.Moderate;

            var client = new VideoSearchClient(AppSettings.Instance.SearchApiKey);

            var response = client.GetVideos(request);

            Assert.True(response.Videos.Count > 0);
        }
    }
}
