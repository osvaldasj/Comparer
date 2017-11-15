using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Cloud.Vision.V1;
using Google.Apis.Auth.OAuth2;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace C
{
    public static class ImageRecognition
    {
        public static string ExtractText(string imageName)
        {
            string _text;

            // Instantiates a client
            /*var client = ImageAnnotatorClient.Create();

            // Load the image file into memory
            var image = Image.FromFile(imageName);

            // Set language hint
            ImageContext imageContext = new ImageContext();
            List<String> languages = new List<String>();
            languages.Add("lt");
            imageContext.LanguageHints.Add(languages);

            // Extract text from image
            _text = client.DetectDocumentText(image, imageContext).Text;*/

            _text = "maxima"+"\n"+
"3 / 23 / 2017"+ "\n" +
"liesa varškė optima linija, 0,5 % rieb. 0,45" + "\n" +
"grikių kruopos optima linija(4 x 100 g) 0,79" + "\n" +
"grietinė farm milk, 30 % rieb. 0,73" + "\n" +
"pienas optima linija, 3,5 % 0,59" + "\n" +
"saulėgrąžų aliejus optima linija 1,27" + "\n" +
"kiaušiniai optima linija(m, rudi) 0,99" + "\n" +
"pirkinių maišelis 25mk maxima(30 / 7x50 cm) 0,08";

            return _text;
        }
    }
}