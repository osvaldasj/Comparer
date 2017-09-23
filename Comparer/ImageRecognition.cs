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

            // Extract text from image
            return client.DetectDocumentText(image).Text;
        }
    }
}
