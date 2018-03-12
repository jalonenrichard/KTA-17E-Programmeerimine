using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HangmanWPF
{
    class WordGenerator
    {
        /// <summary>
        /// Randomly generated word
        /// </summary>
        public string Word { get; private set; }

        /// <summary>
        /// JSON response URL to get the word from
        /// </summary>
        private string _wordURL = "http://api.wordnik.com:80/v4/words.json/randomWords?hasDictionaryDef=true&minCorpusCount=0&minLength=5&maxLength=15&limit=1&api_key=a2a73e7b926c924fad7001ca3111acd55af2ffabf50eb4ae5";

        /// <summary>
        /// Default constructor
        /// </summary>
        public WordGenerator()
        {
            // When WordGenerator object is created, generate a random word
            GenerateWord();
        }

        /// <summary>
        /// Generate a random english word and store it in Word property
        /// </summary>
        private void GenerateWord()
        {
            WebClient client = new WebClient();
            // get a JSON response with a single random word
            string downloadedJsonString = client.DownloadString(_wordURL);
            // the JSON string we get is a JArray type, parse it
            var arr = JArray.Parse(downloadedJsonString);
            // go through the JArray
            foreach(var item in arr)
            {
                // select the field with a header "word"
                string word = JsonConvert.SerializeObject(item.SelectToken("word"));
                // remove quotation marks and trim
                word = word.Replace("\u0022", "").Trim();
                // save it as the random word
                this.Word = word.ToUpper();
            }
        }
    }
}
