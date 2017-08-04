using Microsoft.ProjectOxford.Search.Core;
using Microsoft.ProjectOxford.Search.Image;
using System;
using Xunit;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for the ImageSearchClient class.
    /// </summary>
    /// /// <seealso cref="Microsoft.ProjectOxford.Search.Image.ImageSearchClient" />
    public class ImageSearchClientTest
    {
        /// <summary>
        /// Tests the Validate() method to ensure a query is specified.
        /// </summary>
        [Fact]
        [Trait("Category", "ImageSearch")]
        public void ValidateTest_QueryNotSpecified()
        {
            var request = new ImageSearchRequest();
            Assert.Throws<QueryNotSpecifiedException>(() => request.Validate());
        }

        /// <summary>
        /// Tests the GetImages() method.
        /// </summary>
        [Fact]
        [Trait("Category","ImageSearch")]
        public void GetImagesTest()
        {
            var request = new ImageSearchRequest();
            request.Query = "cats";
            request.Count = 10;
            request.Offset = 0;
            request.Market = "en-US";
            request.SafeSearch = SafeSearch.Moderate;

            var client = new ImageSearchClient(AppSettings.Instance.SearchApiKey);

            var response = client.GetImages(request);

            Assert.True(response.Images.Count > 0);
        }
    }
}
