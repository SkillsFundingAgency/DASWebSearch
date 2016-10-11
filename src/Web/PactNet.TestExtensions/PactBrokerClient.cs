using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using PactNet.Models;

namespace PactNet.TestExtensions
{
    public class PactBrokerClient : IDisposable
    {
        private readonly WebClient _client;

        public PactBrokerClient()
        {
            _client = new WebClient();
        }

        public void Upload(string pactBrokerUri, string providerName, string consumerName)
        {
            var details = new PactDetails { Provider = new Pacticipant { Name = providerName }, Consumer = new Pacticipant { Name = consumerName } };
            var filename = details.GeneratePactFileName();
            var dir = Directory.GetCurrentDirectory();

            if (!File.Exists("../../pacts/" + filename))
            {
                throw new FileNotFoundException("couldn't find the pact file", Path.Combine(dir, filename));
            }

            _client.Headers.Add("Content-Type", "application/json");
            var url = $"{pactBrokerUri}/pacts/provider/{providerName.Replace(" ", "%20")}/consumer/{consumerName.Replace(" ", "%20")}/version/{GetVersion()}";
            Console.WriteLine($"PUT {url}");
            _client.UploadFile(
                url,
                "PUT",
                $"../../pacts/{filename}");

        }

        private static string GetVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fileVersionInfo.ProductVersion;
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}