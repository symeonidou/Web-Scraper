using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScraperConsole
{
    public partial class WebScraper : Form
    {
        private readonly List<string> ImageURLs = new List<string>();
        private Regex FindPattern { get; set; }
        private Regex FileExtension { get; set; }
        private Dictionary<Task<byte[]>, string> Dictionary { get; set; } = new Dictionary<Task<byte[]>, string>();

        private async void ButtonSaveImages_Click(object sender, EventArgs e)
        {
            using var downloadDialog = new FolderBrowserDialog();
            if (downloadDialog.ShowDialog() == DialogResult.OK)
            {
                await DownloadImages(downloadDialog.SelectedPath);
            }
        }

        public WebScraper()
        {
            InitializeComponent();
            FindPattern = new Regex("<img.*src=\"(.*?(jpg|jpeg|png|gif|bmp).*?)\"");
            FileExtension = new Regex(@"\.(png|jpg|jpeg|gif|bmp)");
        }

        private async void ButtonExtractImageURLS_Click(object sender, EventArgs e)
        {
            var getInput = UrlBox.Text;
            


            if (string.IsNullOrWhiteSpace(getInput))
            {
                return;
            }
            if (!getInput.Contains("https://"))
            {
                getInput = $"http://{getInput}";
            }
          
            var urlInputTask = ExtractImages(getInput);
            await urlInputTask;

            var matches = FindPattern.Matches(urlInputTask.Result);

            for (int i = 0; i < matches.Count; i++)
            {
                var result = "";

                if (matches[i].Value.Contains("http"))
                {
                    result = matches[i].Groups[1].Value;
                }
                else if (!string.IsNullOrWhiteSpace(matches[i].Value))
                {
                    result = "gp.se" + matches[i].Groups[1];
                }

                if (!matches[i].Groups[1].ToString().Contains("https://"))
                {
                    ImageURLs.Add("http://" + result);
                }
                else
                {
                    ImageURLs.Add(result);
                }
                TextBox.Text += result + Environment.NewLine;

                NumberBox.Text = "Found " + ImageURLs.Count.ToString() + " images from " + getInput;
            }
        }

        private async Task<string> ExtractImages(string url)
        {
            HttpClient client = new HttpClient();
            var urlInputResult = client.GetStringAsync(url);

            await urlInputResult;

            return urlInputResult.Result;
        }


        private async Task DownloadImages(string path)
        {
            using var client = new HttpClient();
            var imageArray = ImageURLs.ToArray();

            foreach (var image in imageArray)
            {
                var match = FileExtension.Matches(image);
                Dictionary.Add(client.GetByteArrayAsync(image), match[0].Groups[1].Value);
            }

            var i = 1;
            var tasks = Dictionary.Keys;
            while (Dictionary.Count > 0)
            {
                var finishedTasks = await Task.WhenAny(tasks);
                var extension = Dictionary[finishedTasks];
                var result = finishedTasks.Result;

                var fileSream = new FileStream($"{path}\\image{i}.{extension}", FileMode.Create);
                await fileSream.WriteAsync(result, 0, result.Length);
                i++;

                Dictionary.Remove(finishedTasks);
            }
                MessageBox.Show($"We downloaded {i-1} images from {ImageURLs.Count}");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void RandomSuprise()
        {
            {
                string[] suprises = new string[6];
                suprises[0] = "You can do it!";
                suprises[1] = "Enjoy today!";
                suprises[2] = "Don´t give up!";
                suprises[3] = "Dream big!";
                suprises[4] = "Don´t be afraid of change!";
                suprises[5] = "Great things take time!";

                Random rand = new Random();
                int index = rand.Next(suprises.Length);
                MessageBox.Show($"{suprises[index]}");
            }
        }

        private void SupriseBtn_Click(object sender, EventArgs e)
        {
            RandomSuprise();
        }

        private void Header_Click(object sender, EventArgs e)
        {

        }

        private void UrlBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumberBox_Click(object sender, EventArgs e)
        {

        }
    }
}
