using Xamarin.Forms;

namespace WebAPIPost
{
    public partial class WebAPIPostPage : ContentPage
    {
		public WebAPIPostPage()
		{
			InitializeComponent();

			buttonSendRequest.Clicked += ButtonSendRequest_Clicked;
		}

		async void ButtonSendRequest_Clicked(object sender, System.EventArgs e)
		{
			var messageModel = await SendPostRequest(entryName.Text, entryEmail.Text);
			labelResult.Text = messageModel.Message;
		}

		async Task<MessageModel> SendPostRequest(string name, string email)
		{
			// Remove this line
			throw new NotImplementedException();

			string url = "http://www.nextflow.in.th/example/phonegap/post/post-object.php";
			string contentType = "application/json"; // or application/xml

			// Create JObject instance as 'jsonObject', then Add( "key" , value);
			//JObject jsonObject = new JObject();


			// Create StringContent object with json, Encoding.UTF8 format, and content type


			var client = new HttpClient();

			// PostAsync to 'url' with 'content'


			// Read Content as JSON String
			//var json = response.Content.ReadAsStringAsync().Result;

			// Convert JSON String to our MessageModel object, then return
			//var messageModel = JsonConvert.DeserializeObject<MessageModel>(json);

			//return messageModel;
		}
    }
}
