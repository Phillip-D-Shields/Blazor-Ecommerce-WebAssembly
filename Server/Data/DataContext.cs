using Microsoft.Extensions.Options;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name = "Books", Url = "books" },
               new Category { Id = 2, Name = "Movies", Url = "movies" },
               new Category { Id = 3, Name = "Video Games", Url = "video-games" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Master and Margarita",
                    Description = "Russia’s literary world is shaken to its foundations when a mysterious gentleman – a professor of black magic – arrives in Moscow, accompanied by a bizarre retinue of servants. It soon becomes clear that he is the Devil himself, come to wreak havoc among the cultural elite of a disbelieving capital. But the Devil’s mission quickly becomes entangled with the fate of the Master – a man who has turned his back on his former life and taken refuge in a lunatic asylum – and his past lover, Margarita.Both a satirical romp and a daring analysis of the nature of good and evil, innocence and guilt, The Master and Margarita is the crowning achievement of one of the greatest Russian writers of the twentieth century.",
                    ImageUrl = "https://images.thenile.io/r1000/9781847497826.jpg",
                    Price = 50.50m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "1984",
                    Description = "New look for two of the 20th century's most important novelsWinston Smith works for the Ministry of Truth in London, chief city of Airstrip One. Big Brother stares out from every poster, the Thought Police uncover every act of betrayal. When Winston finds love with Julia, he discovers that life does not have to be dull and deadening, and awakens to new possibilities. Despite the police helicopters that hover and circle overhead, Winston and Julia begin to question the Party; they are drawn towards conspiracy. Yet Big Brother will not tolerate dissent - even in the mind. For those with original thoughts they invented Room 101 ...Nineteen Eight-Four is George Orwell's terrifying vision of a totalitarian future in which everything and everyone is slave to a tyrannical regime.",
                    ImageUrl = "https://images.thenile.io/r1000/9780141036144.jpg",
                    Price = 25.00m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Cat's Cradle",
                    Description = "The irreverent and highly entertaining fantasy about the playful irresponsibility of nuclear scientists'All of the true things I am about to tell you are shameless lies.'Dr Felix Hoenikker, one of the founding fathers of the atomic bomb, has left a deadly legacy to the world. For he is the inventor of Ice-nine, a lethal chemical capable of freezing the entire planet. The search for its whereabouts leads to Hoenikker's three eccentric children, to a crazed dictator in the Caribbean, to madness.Will Felix Hoenikker's death wish come true? Will his last, fatal gift to humankind bring about the end that, for all of us, is nigh?Told with deadpan humour and bitter irony, Kurt Vonnegut's cult tale of global apocalypse preys on our deepest fears of witnessing the end and, worse still, surviving it . . .",
                    ImageUrl = "https://images.thenile.io/r1000/9780241951606.jpg",
                    Price = 30.00m,
                    CategoryId = 1
                },
                 new Product
                 {
                     Id = 4,
                     CategoryId = 2,
                     Price = 4.99m,
                     Title = "The Matrix",
                     Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                 },
                 new Product
                 {
                     Id = 5,
                     CategoryId = 2,
                     Price = 3.99m,
                     Title = "Back to the Future",
                     Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                 },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Price = 2.99m,
                    Title = "Toy Story",
                    Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "Half-Life 2",
                    Price = 49.99m,
                    Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "Diablo II",
                    Price = 9.99m,
                    Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 3,
                    Price = 14.99m,
                    Title = "Day of the Tentacle",
                    Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                },
                new Product
                {
                    Id = 10,
                    CategoryId = 3,
                    Price = 159.99m,
                    Title = "Xbox",
                    Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                },
                new Product
                {
                    Id = 11,
                    CategoryId = 3,
                    Price = 79.99m,
                    Title = "Super Nintendo Entertainment System",
                    Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                }
            );
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
