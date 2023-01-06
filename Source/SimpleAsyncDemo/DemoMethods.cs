using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAsyncDemo
{
    using System.Net;

    public class DemoMethods
    {
        public static List<WebsiteDataModel> RunDownloadSync()
        {
            List<string> websites = PrepData();

            List<WebsiteDataModel> output = new List<WebsiteDataModel>();

            foreach (string site in websites)
            {
                WebsiteDataModel results = DownloadWebsite(site);
                output.Add(results);
            }

            return output;
        }

        public static async Task<List<WebsiteDataModel>> RunDownloadAsync(IProgress<ProgressReportModel> progress)
        {
            List<string> websites = PrepData();

            List<WebsiteDataModel> output = new List<WebsiteDataModel>();
            ProgressReportModel report = new ProgressReportModel();
            foreach (string site in websites)
            {
                //WebsiteDataModel results = await Task.Run(() => DownloadWebsite(site));
                WebsiteDataModel results = await DownloadWebsiteAsync(site);
                output.Add(results);
                report.SitesDownloaded = output;
                report.PercentageComplete = (output.Count * 100) / websites.Count;
                progress.Report(report);
            }

            return output;
        }

        public static async Task<List<WebsiteDataModel>> RunDownloadParallelAsync()
        {
            List<string> websites = PrepData();
            List<Task<WebsiteDataModel>> tasks = new List<Task<WebsiteDataModel>>();

            foreach (string site in websites)
            {
                tasks.Add(DownloadWebsiteAsync(site));
            }

            var results = await Task.WhenAll(tasks);

            List<WebsiteDataModel> output = new List<WebsiteDataModel>();
            foreach (var item in results)
            {
                output.Add(item);
            }

            return output;
        }

        private static WebsiteDataModel DownloadWebsite(string websiteURL)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient client = new WebClient();

            output.WebsiteUrl = websiteURL;
            output.WebsiteData = client.DownloadString(websiteURL);

            return output;
        }

        private static async Task<WebsiteDataModel> DownloadWebsiteAsync(string websiteURL)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient client = new WebClient();

            output.WebsiteUrl = websiteURL;
            output.WebsiteData = await client.DownloadStringTaskAsync(websiteURL);

            return output;
        }

        private static List<string> PrepData()
        {
            List<string> output = new List<string>();


            output.Add("https://www.yahoo.com");
            output.Add("https://www.google.com");
            //  output.Add("https://www.microsoft.com/de-de/");
            output.Add("https://www.cnn.com");
            output.Add("https://www.codeproject.com");
            //  output.Add("https://www.stackoverflow.com");
            output.Add("https://github.com/");

            return output;
        }
    }
}
