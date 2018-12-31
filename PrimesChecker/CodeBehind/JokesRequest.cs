using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace PrimesChecker.CodeBehind
{
    public class JokesRequest
    {
        //This is a simple method to get the joke from the API I found online
        public string GetTheJoke()
        {
            var url = "https://geek-jokes.sameerkumar.website/api";
            var client = new HttpClient();
            var response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode && response != null)
                return response.Content.ReadAsStringAsync().Result;

            return "For some reason we couldn't get the joke! :(";
        }
    }
}