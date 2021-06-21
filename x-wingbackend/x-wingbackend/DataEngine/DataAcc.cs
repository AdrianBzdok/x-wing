using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using x_wingbackend.Models;
namespace x_wingbackend.DataEngine
{
    public static class DataAcc{
        static public IEnumerable<Ship> ShipAcc()
        {
            IEnumerable<Ship> lista = JsonConvert.DeserializeObject<IEnumerable<Ship>>(File.ReadAllText(@"./Data/ships.json"));
            return lista;
        }
        static public Player[] PlayerAcc()
        {
            Player[] lista = JsonConvert.DeserializeObject<Player[]>(File.ReadAllText(@"./Data/players.json"));
            return lista;
        }


}}