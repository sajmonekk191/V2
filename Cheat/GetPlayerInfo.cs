using VoidSharp.Other;
using Newtonsoft.Json.Linq;
using System.Net;

namespace VoidSharp.Cheat
{
    internal class GetPlayerInfo
    {
        public static float GetAttackSpeed()
        {
            if (hodnoty.VoidActivated)
                return API.GetActivePlayerData()["championStats"]["attackSpeed"].ToObject<float>();
            else return 0;
        }

        public static float GetAttackRange()
        {
            if (hodnoty.VoidActivated)
                return API.GetActivePlayerData()["championStats"]["attackRange"].ToObject<float>();
            else return 0;
        }
        public static float GetPlayerHealth()
        {
            if (hodnoty.VoidActivated)
                return API.GetActivePlayerData()["championStats"]["currentHealth"].ToObject<float>();
            else return 0;
        }
        public static float GetPlayerMana()
        {
            if (hodnoty.VoidActivated)
                return API.GetActivePlayerData()["championStats"]["resourceValue"].ToObject<float>();
            else return 0;
        }
        public static float GetPlayerMaxMana()
        {
            if (hodnoty.VoidActivated)
                return API.GetActivePlayerData()["championStats"]["resourceMax"].ToObject<float>();
            else return 0;
        }

    }
}
