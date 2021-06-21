using Newtonsoft.Json;
using System;
using System.IO;
using x_wingbackend.Models;
using System.Collections.Generic;
namespace x_wingbackend.DataEngine
{
    public static class DataWrite{
        static public void PlayerAdd(Player player)
        {
            List<Player> lista = JsonConvert.DeserializeObject<List<Player>>(File.ReadAllText(@"./Data/players.json"));
            lista.Add(player);
            File.WriteAllText(@"./Data/players.json", JsonConvert.SerializeObject(lista));
        }
        static public void ShipAdd(Ship ship)
        {
            List<Ship> lista = JsonConvert.DeserializeObject<List<Ship>>(File.ReadAllText(@"./Data/ships.json"));
            lista.Add(ship);
            File.WriteAllText(@"./Data/ships.json", JsonConvert.SerializeObject(lista));
        }

    }
}