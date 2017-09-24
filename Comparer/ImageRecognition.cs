using Google.Cloud.Vision.V1;
using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace Comparer
{
    public static class ImageRecognition
    {
        public static string ExtractText(string imageName)
        {
            string _text;
            // Instantiates a client
            var client = ImageAnnotatorClient.Create();

            // Load the image file into memory
            var image = Google.Cloud.Vision.V1.Image.FromFile(imageName);

            // Set language hint
            ImageContext imageContext = new ImageContext();
            List<String> languages = new List<String>();
            languages.Add("lt");
            imageContext.LanguageHints.Add(languages);

            // Extract text from image
            _text = client.DetectDocumentText(image, imageContext).Text;
            return _text;
        }
    }
}
