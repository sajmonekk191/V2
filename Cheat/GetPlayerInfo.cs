using VoidSharp.Other;
using Newtonsoft.Json.Linq;
using System.Net;

namespace VoidSharp.Cheat
{
    internal class GetPlayerInfo
    {
        public static float GetAttackSpeed()
        {
            return API.GetActivePlayerData()["championStats"]["attackSpeed"].ToObject<float>();
        }
        public static float GetAttackRange()
        {
            return API.GetActivePlayerData()["championStats"]["attackRange"].ToObject<float>();
        }
        public static float GetPlayerHealth()
        {
            return API.GetActivePlayerData()["championStats"]["currentHealth"].ToObject<float>();
        }

    }
}
