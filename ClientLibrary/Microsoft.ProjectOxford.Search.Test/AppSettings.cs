using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.ProjectOxford.Search.Test
{
    public class AppSettings
    {
        private static AppSettings _instance;

        public static AppSettings Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AppSettings();

                return _instance;
            }
        }

        public string AutoSuggestApiKey
        {
            get
            {
                var apiKey = Environment.GetEnvironmentVariable("COG_API_KEY_AUTOSUGGEST");

                if (string.IsNullOrEmpty(apiKey))
                    throw new Exception("Environment variable COG_API_KEY_AUTOSUGGEST not found.");

                return apiKey;
            }
        }

        public string SearchApiKey
        {
            get
            {
                var apiKey = Environment.GetEnvironmentVariable("COG_API_KEY_SEARCH");

                if (string.IsNullOrEmpty(apiKey))
                    throw new Exception("Environment variable COG_API_KEY_SEARCH not found.");

                return apiKey;
            }
        }
    }
}
