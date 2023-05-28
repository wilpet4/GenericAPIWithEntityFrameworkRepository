using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection.Metadata;

namespace Database.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Pokemon> Pokemon { get; set; }
        public DbSet<PokemonType> PokemonTypes { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Item> Items { get; set; }

        public DatabaseContext() { }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
            .AddJsonFile($"appsettings.json", true, true);

            string connectionString =
            builder.Build().GetConnectionString("DefaultConnection");

            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>()
                .Property(p => p.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<Pokemon>()
                .Navigation(p => p.Types)
                .AutoInclude();

            modelBuilder.Entity<Trainer>()
                .Navigation(p => p.Pokemon)
                .AutoInclude();
        }
        public static void CreateData(DatabaseContext context)
        {
            #region Items
            Item pokeball = new Item()
            {
                Name = "Pokéball",
                Price = 200,
            };
            Item potion = new Item()
            {
                Name = "Potion",
                Price = 300,
            };
            Item escapeRope = new Item()
            {
                Name = "Escape Rope",
                Price = 550,
            };
            Item antidote = new Item()
            {
                Name = "Antidote",
                Price = 100,
            };
            Item burnHeal = new Item()
            {
                Name = "Burn Heal",
                Price = 250,
            };
            Item awakening = new Item()
            {
                Name = "Awakening",
                Price = 200,
            };
            Item paralyzeHeal = new Item()
            {
                Name = "Paralyze Heal",
                Price = 200,
            };
            context.Items.AddRange(new[] 
            { 
                pokeball, 
                potion, 
                escapeRope, 
                antidote, 
                burnHeal, 
                awakening, 
                paralyzeHeal 
            });
            #endregion

            #region Types
            PokemonType rock = new PokemonType() { Value = "Rock" };
            PokemonType ground = new PokemonType() { Value = "Ground" };
            PokemonType water = new PokemonType() { Value = "Water" };
            PokemonType electric = new PokemonType() { Value = "Electric" };
            PokemonType grass = new PokemonType() { Value = "Grass" };
            PokemonType poison = new PokemonType() { Value = "Poison" };
            PokemonType psychic = new PokemonType() { Value = "Psychic" };
            PokemonType bug = new PokemonType() { Value = "Bug" };
            PokemonType fire = new PokemonType() { Value = "Fire" };
            #endregion

            #region Pokemon
            Pokemon geodude = new Pokemon()
            {
                Id = 74,
                Name = "Geodude",
                Types = new List<PokemonType>() { rock, ground }
            };
            Pokemon onix = new Pokemon()
            {
                Id = 95,
                Name = "Onix",
                Types = new List<PokemonType>() { rock, ground }
            };
            Pokemon staryu = new Pokemon()
            {
                Id = 120,
                Name = "Staryu",
                Types = new List<PokemonType>() { water }
            };
            Pokemon starmie = new Pokemon()
            {
                Id = 121,
                Name = "Starmie",
                Types = new List<PokemonType>() { water }
            };
            Pokemon voltorb = new Pokemon()
            {
                Id = 100,
                Name = "Voltorb",
                Types = new List<PokemonType>() { electric }
            };
            Pokemon pikachu = new Pokemon()
            {
                Id = 25,
                Name = "Pikachu",
                Types = new List<PokemonType>() { electric }
            };
            Pokemon raichu = new Pokemon()
            {
                Id = 26,
                Name = "Raichu",
                Types = new List<PokemonType>() { electric }
            };
            Pokemon victreebel = new Pokemon()
            {
                Id = 71,
                Name = "Vicreebel",
                Types = new List<PokemonType>() { grass, poison }
            };
            Pokemon tangela = new Pokemon()
            {
                Id = 114,
                Name = "Tangela",
                Types = new List<PokemonType>() { grass }
            };
            Pokemon vileplume = new Pokemon()
            {
                Id = 45,
                Name = "Vileplume",
                Types = new List<PokemonType>() { grass, poison }
            };
            Pokemon koffing = new Pokemon()
            {
                Id = 109,
                Name = "Koffing",
                Types = new List<PokemonType>() { poison }
            };
            Pokemon muk = new Pokemon()
            {
                Id = 89,
                Name = "Muk",
                Types = new List<PokemonType>() { poison }
            };
            Pokemon weezing = new Pokemon()
            {
                Id = 110,
                Name = "Weezing",
                Types = new List<PokemonType>() { poison }
            };
            Pokemon kadabra = new Pokemon()
            {
                Id = 64,
                Name = "Kadabra",
                Types = new List<PokemonType>() { psychic }
            };
            Pokemon mrMime = new Pokemon()
            {
                Id = 122,
                Name = "Mr. Mime",
                Types = new List<PokemonType>() { psychic }
            };
            Pokemon venomoth = new Pokemon()
            {
                Id = 49,
                Name = "Venomoth",
                Types = new List<PokemonType>() { bug, poison }
            };
            Pokemon alakazam = new Pokemon()
            {
                Id = 65,
                Name = "Alakazam",
                Types = new List<PokemonType>() { psychic }
            };
            Pokemon growlithe = new Pokemon()
            {
                Id = 58,
                Name = "Growlithe",
                Types = new List<PokemonType>() { fire }
            };
            Pokemon ponyta = new Pokemon()
            {
                Id = 77,
                Name = "Ponyta",
                Types = new List<PokemonType>() { fire }
            };
            Pokemon rapidash = new Pokemon()
            {
                Id = 78,
                Name = "Rapidash",
                Types = new List<PokemonType>() { fire }
            };
            Pokemon arcanine = new Pokemon()
            {
                Id = 59,
                Name = "Arcanine",
                Types = new List<PokemonType>() { fire }
            };
            Pokemon rhyhorn = new Pokemon()
            {
                Id = 111,
                Name = "Rhyhorn",
                Types = new List<PokemonType>() { ground, rock }
            };
            Pokemon dugtrio = new Pokemon()
            {
                Id = 51,
                Name = "Dugtrio",
                Types = new List<PokemonType>() { ground }
            };
            Pokemon nidoqueen = new Pokemon()
            {
                Id = 31,
                Name = "Nidoqueen",
                Types = new List<PokemonType>() { poison, ground }
            };
            Pokemon nidoking = new Pokemon()
            {
                Id = 34,
                Name = "Nidoking",
                Types = new List<PokemonType>() { poison, ground }
            };
            Pokemon rhydon = new Pokemon()
            {
                Id = 112,
                Name = "Rhydon",
                Types = new List<PokemonType>() { ground, rock }
            };
            #endregion

            #region Trainers
            Trainer brock = new Trainer() 
            { 
                Name = "Brock",
                Pokemon = new List<Pokemon>() { geodude, onix },
            };
            Trainer misty = new Trainer()
            {
                Name = "Misty",
                Pokemon = new List<Pokemon>() { staryu, starmie },
            };
            Trainer ltSurge = new Trainer()
            {
                Name = "Lt. Surge",
                Pokemon = new List<Pokemon>() { voltorb, pikachu, raichu },
            };
            Trainer erika = new Trainer()
            {
                Name = "Erika",
                Pokemon = new List<Pokemon>() { victreebel, tangela, vileplume },
            };
            Trainer koga = new Trainer()
            {
                Name = "Koga",
                Pokemon = new List<Pokemon>() { koffing, muk, koffing, weezing },
            };
            Trainer sabrina = new Trainer()
            {
                Name = "Sabrina",
                Pokemon = new List<Pokemon>() { kadabra, mrMime, venomoth, alakazam },
            };
            Trainer blaine = new Trainer()
            {
                Name = "Blaine",
                Pokemon = new List<Pokemon>() { growlithe, ponyta, rapidash, arcanine },
            };
            Trainer giovanni = new Trainer()
            {
                Name = "Giovanni",
                Pokemon = new List<Pokemon>() { rhyhorn, dugtrio, nidoqueen, nidoking, rhydon },
            };
            context.AddRange(new[]
{
                brock,
                misty,
                ltSurge,
                erika,
                koga,
                sabrina,
                blaine,
                giovanni,
            });
            #endregion

            context.SaveChanges();
        }
    }
}
