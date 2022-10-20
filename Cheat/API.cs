using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace VoidSharp.Cheat
{
    class API
    {
        private static int port = 0;
        private static string token = string.Empty;
        public static JObject GetActivePlayerData()
        {
            if (IsLiveGameRunning())
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://127.0.0.1:2999/liveclientdata/activeplayer");

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    try { return JObject.Parse(reader.ReadToEnd()); }
                    catch { throw new Exception("League is not Detected!"); }
                }
            }
            else
            {
                throw new Exception("League is not Detected!");
            }
        }

        public static bool IsLiveGameRunning()
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://127.0.0.1:2999/liveclientdata/allgamedata"); //https://127.0.0.1:2999/liveclientdata/allgamedata
            ServicePointManager.ServerCertificateValidationCallback += delegate (object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                        System.Security.Cryptography.X509Certificates.X509Chain chain,
                        System.Net.Security.SslPolicyErrors sslPolicyErrors)
            {
                return true; // **** Always accept
            };

            request.Method = "GET";

            bool flag = false;

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK) flag = true;
                }
            }
            catch
            {
                return false;
            }

            return flag;
        }
        public static string GetRequest(Method method, string strrequest, object parameter = null, DataFormat dataFormat = DataFormat.None)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(NetClass.NewClass.Main));
            RestClient restClient = new RestClient("https://127.0.0.1:" + port)
            {
                Authenticator = new HttpBasicAuthenticator("riot", token)
            };
            RestRequest request = new RestRequest(strrequest, method);
            var result = restClient.Execute(request);
            if (method == Method.Put && dataFormat == DataFormat.Json)
            {
                request.AddBody(parameter);
            }
            else if (method == Method.Post)
            {
                request.AddBody(parameter);
            }
            return result.Content;
        }
        public class NetClass
        {
            internal bool Main(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
            {
                return true;
            }

            public static readonly NetClass NewClass = new NetClass();
            static RemoteCertificateValidationCallback callback;
        }
    }
}
