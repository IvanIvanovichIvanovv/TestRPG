using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Classes
{
    public static class Methods  // klasa statyczna, zawsze istnieje
    {
        public static void SavePlayer(Player Player) 
        {
            using (StreamWriter filewrite = new StreamWriter("Player.csv"))
            {
                filewrite.WriteLine();
            }
        }
    }
}
