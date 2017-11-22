using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Collections.Generic;

namespace C
{
    [Activity(Label = "ComparerApp", MainLauncher = true)]
    public class MainActivity : Activity
    {

        TextView resultText;
        string recognizedText;
        string currImage;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            resultText = FindViewById<TextView>(Resource.Id.resultText);

            FindViewById<Button>(Resource.Id.selectButton).Click += delegate
            {
                var imageIntent = new Intent();
                imageIntent.SetType("image/*");
                imageIntent.SetAction(Intent.ActionGetContent);
                StartActivityForResult(
                    Intent.CreateChooser(imageIntent, "Select photo"), 0);
            };

            FindViewById<Button>(Resource.Id.selectButton).Click += (o, e) =>
            {
                resultText.Text = "Image selected";
            };

            FindViewById<Button>(Resource.Id.recognizeButton).Click += (o, e) =>
            {
                recognizedText = ImageRecognition.ExtractText(currImage);
                resultText.Text = recognizedText;
            };

            FindViewById<Button>(Resource.Id.compareButton).Click += async (o, e) =>
            {
                string url = @"http://192.168.0.200/ComparerApp/api/compareshops";

                using (var client = new HttpClient())
                {
                    var content = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("", recognizedText)
                    });
                    var result = await client.PostAsync(url, content);
                    string resultContent = await result.Content.ReadAsStringAsync();

                    resultText.Text = resultContent;
                }
            };
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (resultCode == Result.Ok)
            {
                var imageView =
                    FindViewById<ImageView>(Resource.Id.imageBox);
                imageView.SetImageURI(data.Data);
                //resultText.Text = data.Data.ToString();
                currImage = data.Data.ToString();
            }
        }

    }
}

