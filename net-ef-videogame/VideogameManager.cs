using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    public static class VideogameManager
    {
        private const string ConnectionString = "Data Source=localhost;Initial Catalog=videogames;Integrated Security=True;Encrypt=False;TrustServerCertificate=False";
        public static void InserisciVideogioco(Videogioco videogame)
        {
            using (var context = new VideogameContext())
            {
                context.Videogame.Add(videogame);
                context.SaveChanges();
                Console.WriteLine("Videogioco creato con successo.\n");
            }
        }
        public static void CercaVideogiocoPerId(int videogameId)
        {
            using (var context = new VideogameContext())
            {
                var videogame = context.Videogame.FirstOrDefault(v => v.id == videogameId);
                if (videogame != null)
                {
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine($"Nome: {videogame.name}");
                    Console.WriteLine($"Date di Rilascio: {videogame.ReleaseDate}");
                    Console.WriteLine($"Descrizione: {videogame.overview}");
                    Console.WriteLine($"Creato il: {videogame.CreatedAt}");
                    Console.WriteLine($"Aggiornato il: {videogame.UpdatedAt}");
                    Console.WriteLine($"Id della Casa di produzione: {videogame.SoftwareHouseID}");
                    Console.WriteLine("-------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Nessun videogioco trovato con questo id.");
                }
            }
        }
        public static void CercaVideogiocoPerNome(string searchString)
        {
            using (var context = new VideogameContext())
            {
                var videogames = context.Videogame
                                        .Where(v => v.name.Contains(searchString))
                                        .ToList();

                foreach (var videogame in videogames)
                {
                    Console.WriteLine($"Id: {videogame.id}");
                    Console.WriteLine($"Name: {videogame.name}");
                    Console.WriteLine($"Data di rilascio: {videogame.ReleaseDate}");
                    Console.WriteLine("---------------------------------------");
                }
            }
        }
        public static void CancellaVideogioco(int videogameId)
        {
            using (var context = new VideogameContext())
            {
                var videogame = context.Videogame.FirstOrDefault(v => v.id == videogameId);
                if (videogame != null)
                {
                    context.Videogame.Remove(videogame);
                    context.SaveChanges();
                    Console.WriteLine("Videogioco cancellato con successo.");
                }
                else
                {
                    Console.WriteLine("Nessun videogioco trovato con questo id.");
                }
            }
        }
        public static void InserisciSoftwareHouse(SoftwareHouse casa)
        {
            using (var context = new VideogameContext())
            {
                context.CasaDiSviluppo.Add(casa);
                context.SaveChanges();
                Console.WriteLine("Casa di sviluppo creata con successo.\n");
            }
        }
    }
}
