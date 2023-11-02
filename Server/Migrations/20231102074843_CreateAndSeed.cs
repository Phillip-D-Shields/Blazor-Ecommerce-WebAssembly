using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class CreateAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Russia’s literary world is shaken to its foundations when a mysterious gentleman – a professor of black magic – arrives in Moscow, accompanied by a bizarre retinue of servants. It soon becomes clear that he is the Devil himself, come to wreak havoc among the cultural elite of a disbelieving capital. But the Devil’s mission quickly becomes entangled with the fate of the Master – a man who has turned his back on his former life and taken refuge in a lunatic asylum – and his past lover, Margarita.Both a satirical romp and a daring analysis of the nature of good and evil, innocence and guilt, The Master and Margarita is the crowning achievement of one of the greatest Russian writers of the twentieth century.", "https://images.thenile.io/r1000/9781847497826.jpg", 50.50m, "The Master and Margarita" },
                    { 2, "New look for two of the 20th century's most important novelsWinston Smith works for the Ministry of Truth in London, chief city of Airstrip One. Big Brother stares out from every poster, the Thought Police uncover every act of betrayal. When Winston finds love with Julia, he discovers that life does not have to be dull and deadening, and awakens to new possibilities. Despite the police helicopters that hover and circle overhead, Winston and Julia begin to question the Party; they are drawn towards conspiracy. Yet Big Brother will not tolerate dissent - even in the mind. For those with original thoughts they invented Room 101 ...Nineteen Eight-Four is George Orwell's terrifying vision of a totalitarian future in which everything and everyone is slave to a tyrannical regime.", "https://images.thenile.io/r1000/9780141036144.jpg", 25.00m, "1984" },
                    { 3, "The irreverent and highly entertaining fantasy about the playful irresponsibility of nuclear scientists'All of the true things I am about to tell you are shameless lies.'Dr Felix Hoenikker, one of the founding fathers of the atomic bomb, has left a deadly legacy to the world. For he is the inventor of Ice-nine, a lethal chemical capable of freezing the entire planet. The search for its whereabouts leads to Hoenikker's three eccentric children, to a crazed dictator in the Caribbean, to madness.Will Felix Hoenikker's death wish come true? Will his last, fatal gift to humankind bring about the end that, for all of us, is nigh?Told with deadpan humour and bitter irony, Kurt Vonnegut's cult tale of global apocalypse preys on our deepest fears of witnessing the end and, worse still, surviving it . . .", "https://images.thenile.io/r1000/9780241951606.jpg", 30.00m, "Cat's Cradle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
