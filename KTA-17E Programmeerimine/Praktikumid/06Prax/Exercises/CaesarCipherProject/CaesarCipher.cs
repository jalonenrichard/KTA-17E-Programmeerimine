using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipherProject
{
    class CaesarCipher
    {
        public CaesarCipher()
        {

        }

        /// <summary>
        /// Encrypt the given text using Caesar Cipher algorithm
        /// </summary>
        /// <param name="inputText">Text to encrypt</param>
        /// <param name="key">The key to shift each letter of the alphabet</param>
        /// <returns></returns>
        public string EncryptText(string inputText, int key)
        {
            string encryptedText = "";
            for (int i = 0; i < inputText.Length; i++)
            {
                // Get the ascii code of the current letter
                int asciiCode = (int)inputText[i];
                // The new ascii code is the current one + our key
                int newAsciiCode = asciiCode + key;
                // Overflow logic when we go over the last letter (z) - code 122
                if (newAsciiCode > 122)
                {
                    // Remainder from the last letter (122)
                    int helper = newAsciiCode - 122;
                    // First letter is (a) - code 97
                    newAsciiCode = 96 + helper;
                }
                // leave SPACE - code 32 - untouched
                else if (asciiCode == 32)
                {
                    newAsciiCode = 32;
                }
                encryptedText += (char)newAsciiCode;
            }
            return encryptedText;
        }

        /// <summary>
        /// Decrypt the text using Caesar Cipher algorithm
        /// </summary>
        /// <param name="inputText">Text to decrypt</param>
        /// <param name="key">Key to shift the alphabet</param>
        /// <returns></returns>
        public string DecryptText(string inputText, int key)
        {
            string decryptedText = "";
            for (int i = 0; i < inputText.Length; i++)
            {
                // Get the ascii code of the current letter
                int asciiCode = (int)inputText[i];
                // The new ascii code is the current one - our key
                int newAsciiCode = asciiCode - key;
                // Overflow logic when we go over the first letter (a) - code 97
                if (newAsciiCode < 97)
                {
                    // Remainder from the first letter (97)
                    int helper = 97 - newAsciiCode;
                    // Last letter is z (122) - remainder
                    newAsciiCode = 122 - helper;
                }
                // leave SPACE - code 32 - untouched
                else if (asciiCode == 32)
                {
                    newAsciiCode = 32;
                }
                decryptedText += (char)newAsciiCode;
            }
            return decryptedText;
        }

    }
}
