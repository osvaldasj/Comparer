using Google.Cloud.Vision.V1;



namespace Comparer
{
    public static class ImageRecognition
    {
        public static string ExtractText(string imageName)
        {
            // Instantiates a client
            var client = ImageAnnotatorClient.Create();

            // Load the image file into memory
            var image = Image.FromFile(imageName);

            // Performs text detection on the image file
            var response = client.DetectText(image);

            // Acumulates result to a string
            string result = "";
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                    result = result + annotation.Description + "\n";
            }
            return result;
        }
    }
}
