﻿using System.Threading.Tasks;
using System.Collections.Generic;

namespace HackerNews
{
    public abstract class HackerNewsAPIService : BaseHttpClientService
    {
        public static Task<List<string>> GetTopStoryIDs() =>
            GetObjectFromAPI<List<string>>("https://hacker-news.firebaseio.com/v0/topstories.json?print=pretty");

        public static Task<StoryModel> GetStory(string storyId) =>
		    GetObjectFromAPI<StoryModel>($"https://hacker-news.firebaseio.com/v0/item/{storyId}.json?print=pretty");
    }
}
