using Newtonsoft.Json;
using System;
using System.Diagnostics;
using VoidSharp.Other;

namespace VoidSharp.Cheat
{
    class AutoAccept
    {
        public static IntPtr handle;
        public static Matchmaking.ReadyCheck readyCheck = new Matchmaking.ReadyCheck();

        public static void FindMatch()
        {
            Process[] p = System.Diagnostics.Process.GetProcessesByName("LeagueClientUx");
            if (p.Length != 0)
            {
                try
                {
                    string JsonReadyCheck = API.GetRequest(RestSharp.Method.Get, "/lol-matchmaking/v1/ready-check");
                    readyCheck = JsonConvert.DeserializeObject<Matchmaking.ReadyCheck>(JsonReadyCheck);
                    if (readyCheck.State == "InProgress") API.GetRequest(RestSharp.Method.Post, "/lol-matchmaking/v1/ready-check/accept");
                }
                catch { };
            }
        }
    }
}
