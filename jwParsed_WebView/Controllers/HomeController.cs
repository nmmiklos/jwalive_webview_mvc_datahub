using Microsoft.AspNetCore.Mvc;
using jwParsed_WebView.Models;
using MySqlConnector;
using System.Collections.Generic;

namespace jwParsed_WebView.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            var creatures = new List<Creature>();
            string connectionString = _configuration.GetConnectionString("DefaultConnection");

            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();

                using (var command = new MySqlCommand("SELECT * FROM jwa_creatures ORDER BY name ASC", connection))
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        creatures.Add(new Creature
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            Rarity = reader.IsDBNull(reader.GetOrdinal("rarity")) ? "" : reader.GetString("rarity"),
                            Class = reader.IsDBNull(reader.GetOrdinal("class")) ? "" : reader.GetString("class"),
                            Health = reader.IsDBNull(reader.GetOrdinal("health")) ? null : reader.GetInt32("health"),
                            Damage = reader.IsDBNull(reader.GetOrdinal("damage")) ? null : reader.GetInt32("damage"),
                            Speed = reader.IsDBNull(reader.GetOrdinal("speed")) ? null : reader.GetInt32("speed"),
                            Armor = reader.IsDBNull(reader.GetOrdinal("armor")) ? null : reader.GetInt32("armor"),
                            Crit = reader.IsDBNull(reader.GetOrdinal("crit")) ? null : reader.GetInt32("crit"),
                            Version = reader.IsDBNull(reader.GetOrdinal("version")) ? "" : reader.GetString("version")
                        });
                    }
                }
            }

            return View(creatures);
        }
    }
}