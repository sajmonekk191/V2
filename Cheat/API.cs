using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace VoidSharp.Cheat
{
    class API
    {
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
                    catch
                    {
                        throw new Exception("League Procces not found!");
                    }
                }
            }
            else
            {
                throw new Exception("League Procces not found!");
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
    }
}
