using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    public static class Methods
    {
        public static void SavePlayer(Player player) 
        {
            using (StreamWriter filewrite = new StreamWriter("Player.csv"))
            {
                string[] playerData = player.PlayerData();
                for (int i = 0; i < playerData.Length; i++)
                {
                    filewrite.WriteLine(String.Format(playerData[i]));
                }
            }
        }
    }
}
