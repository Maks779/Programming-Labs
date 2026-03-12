using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Psotify.DataModel;

Console.WriteLine("=== Starting Psotify Application ===");

using (var db = new PsotifyDbContext())
{
    db.Database.EnsureDeleted();
    db.Database.Migrate();

    var pinkFloyd = new Artist { Name = "Pink Floyd" };
    var metallica = new Artist { Name = "Metallica" };
    var deepPurple = new Artist { Name = "Deep Purple" };

    db.Artists.AddRange(pinkFloyd, metallica, deepPurple);

    db.Songs.AddRange(
        new Song { Title = "Wish You Were Here", Length = "05:40", Artist = pinkFloyd },
        new Song { Title = "Money", Length = "06:22", Artist = pinkFloyd },
        new Song { Title = "One", Length = "07:26", Artist = metallica },
        new Song { Title = "Smoke on the Water", Length = "05:40", Artist = deepPurple }
    );

    db.SaveChanges();
    Console.WriteLine("Initial data seeded successfully.\n");

    Console.WriteLine("--- Task 1 ---");
    var nirvana = new Artist { Name = "Nirvana" };
    var teenSpirit = new Song { Title = "Smells Like Teen Spirit", Length = "05:01", Artist = nirvana };

    db.Artists.Add(nirvana);
    db.Songs.Add(teenSpirit);
    db.SaveChanges(); // One single SaveChanges call
    Console.WriteLine("Nirvana and song added.\n");

    Console.WriteLine("--- Task 3 ---");
    var oneSong = db.Songs.FirstOrDefault(s => s.Title == "One" && s.Artist.Name == "Metallica");
    if (oneSong != null)
    {
        oneSong.Length = "07:30";
        db.SaveChanges();
        Console.WriteLine("Changed length of 'One' to 07:30.\n");
    }

    Console.WriteLine("--- Task 4 ---");
    var smokeSong = db.Songs.FirstOrDefault(s => s.Title == "Smoke on the Water");
    if (smokeSong != null)
    {
        db.Songs.Remove(smokeSong);
        db.SaveChanges();
        Console.WriteLine("Deleted 'Smoke on the Water'.\n");
    }

    Console.WriteLine("--- Task 2 ---");
    var allSongs = db.Songs.Include(s => s.Artist).ToList();
    
    foreach (var song in allSongs)
    {
        Console.WriteLine($"\"{song.Title}\" by {song.Artist.Name} ({song.Length})");
    }
}