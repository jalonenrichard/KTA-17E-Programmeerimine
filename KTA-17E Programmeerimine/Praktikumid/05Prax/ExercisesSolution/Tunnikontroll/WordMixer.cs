using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tunnikontroll
{
    class WordMixer
    {
        /// <summary>
        /// Original sentence to mix
        /// </summary>
        private string SentenceToMix { get; set; }
        /// <summary>
        /// List of all the words in the original sentence
        /// </summary>
        private List<string> WordsInSentence { get; set; }
        /// <summary>
        /// List of mixed words
        /// </summary>
        public List<string> MixedWords { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="sentenceToMix">Word to mix</param>
        public WordMixer(string sentenceToMix)
        {
            SentenceToMix = sentenceToMix;
            WordsInSentence = new List<string>();
            MixedWords = new List<string>();
            PopulateWordList();
        }

        /// <summary>
        /// Populate the list with all the words
        /// </summary>
        private void PopulateWordList()
        {
            SentenceToMix.Trim();
            WordsInSentence = SentenceToMix.Split(" ").ToList();
        }

        public void MixWords()
        {
            foreach(string word in WordsInSentence)
            {
                MixWord(word);
            }
        } 

        /// <summary>
        /// Mix the words in the sentence
        /// </summary>
        private void MixWord(string word)
        {
            if (word.Length > 3)
            {
                StringBuilder stringBuilder = new StringBuilder();
                string newString = word.Substring(1, word.Length - 2);

                char[] characters = newString.ToCharArray();

                for (int i = 0; i < newString.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        if ((i + 1) < characters.Length)
                        {
                            stringBuilder.Append(characters[i + 1]);
                        }
                        stringBuilder.Append(characters[i]);
                    }
                }
                stringBuilder.Insert(0, word[0]);
                stringBuilder.Insert(word.Length - 1, word[word.Length - 1]);
                MixedWords.Add(stringBuilder.ToString());
            }

        }
    }
}
