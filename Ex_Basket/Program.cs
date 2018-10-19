using Ex_Basket.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Basket
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerBase[] players = new PlayerBase[3];

            FillData(players);

            foreach (var player in players)
            {
                Console.WriteLine($"{Constants.PlayerNamePrefix}: {player.Name}, {player.Choose()}");
            }


            
            Console.ReadLine();
        }

        private static void FillData(PlayerBase[] players)
        {
            for (int i = 0; i < 3; i++)
            {
                PlayerBase player;

                if (i % 2 == 0)
                {
                    player = new OrdinaryPlayer
                    {
                        Name = $"player - {i}",
                        PlayerType = PlayerType.Ordinary
                    };
                }
                else
                {
                    player = new CheaterPlayer
                    {
                        Name = $"player - {i}",
                        PlayerType = PlayerType.Cheater
                    };
                }
                players[i] = player;
            }

        }
    }
}
