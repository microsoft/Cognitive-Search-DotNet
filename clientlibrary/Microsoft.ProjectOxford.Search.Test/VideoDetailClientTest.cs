using Microsoft.ProjectOxford.Search.Core;
using Microsoft.ProjectOxford.Search.Video;
using System;
using Xunit;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for the VideoDetailClient class.
    /// </summary>
    public class VideoDetailClientTest
    {
        private string videoId = "42E6E500F763A94EB0F442E6E500F763A94EB0F4";

        /// <summary>
        /// Tests the Validate() method to ensure a query is specified.
        /// </summary>
        [Fact]
        [Trait("Category","VideoDetail")]
        public void ValidateTest_IdNotSpecified()
        {
            var request = new VideoDetailRequest();
            Assert.Throws< IdNotSpecifiedException>(()=> request.Validate());
        }

        /// <summary>
        /// Tests the GetVideoDetails() method.
        /// </summary>
        [Fact]
        [Trait("Category","VideoDetail")]
        public void GetVideoDetailsTest()
        {
            var request = new VideoDetailRequest() { Id = this.videoId };

            var client = new VideoDetailClient(AppSettings.Instance.SearchApiKey);

            var response = client.GetVideoDetails(request);

            Assert.NotNull(response.VideoResult);
            Assert.True(response.RelatedVideos.Count > 0);
        }
    }
}
