using Microsoft.ProjectOxford.Search.Autosuggest;
using Microsoft.ProjectOxford.Search.Core;
using System;
using Xunit;

namespace Microsoft.ProjectOxford.Search.Test
{
    /// <summary>
    /// Unit tests for the AutosuggestClient class.
    /// </summary>
    /// <seealso cref="Microsoft.ProjectOxford.Search.Autosuggest.AutosuggestClient" />
    public class AutosuggestClientTest
    {
        /// <summary>
        /// Tests the Validate() method to ensure a query is specified.
        /// </summary>
        [Fact]
        [Trait("Category","Autosuggest")]
        public void ValidateTest_QueryNotSpecified()
        {
            var request = new AutosuggestRequest();
            Assert.Throws< QueryNotSpecifiedException>(()=> request.Validate());
        }

        /// <summary>
        /// Tests the GetSuggestions() method.
        /// </summary>
        [Fact]
        [Trait("Category","Autosuggest")]
        public void GetSuggestionsTest()
        {
            var request = new AutosuggestRequest();
            request.Query = "bill gates";
            request.Market = "en-us";

            var client = new AutosuggestClient(AppSettings.Instance.AutosuggestApiKey);

            var response = client.GetSuggestions(request);

            Assert.True(response.SuggestionGroups.Count >= 0);
            Assert.True(response.SuggestionGroups[0].SearchSuggestions.Count >= 0);
        }
    }
}
