using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "AVENTURA. PERIGO. JOIAS PERDIDAS. E AS TERRÍVEIS VACAS-DENTADAS DE SKREE.", "https://m.media-amazon.com/images/I/51RgW3SkK+S._SX344_BO1,204,203,200_.jpg", 9.99m, "A Saga Wingfeather: nos Limites do mar Sombrio da Escuridão" },
                    { 2, "Escrito em 1895 por Robert W. Chambers “O Rei de Amarelo” influenciou uma enorme geração de escritores. O livro é formado por quatro histórias que guardam relações entre si, tendo como pano de fundo uma entidade misteriosa chamada ‘O Rei de Amarelo.", "https://m.media-amazon.com/images/I/51W6T1CC8NL._SX346_BO1,204,203,200_.jpg", 7.99m, "O rei de amarelo" },
                    { 3, "O Céu sobre o porto tinha cor de televisão num canal fora do ar. Considerada a obra precursora do movimento cyberpunk e um clássico da ficção científica moderna, Neuromancer conta a história de Case, um cowboy do ciberespaço e hacker da matrix. Como punição por tentar enganar os patrões, seu sistema nervoso foi contaminado por uma toxina que o impede de entrar no mundo virtual. Agora, ele vaga pelos subúrbios de Tóquio, cometendo pequenos crimes para sobreviver, e acaba se envolvendo em uma jornada que mudará para sempre o mundo e a percepção da realidade. Evoluindo de Blade Runner e antecipando Matrix, Neuromancer é o romance de estreia de William Gibson. Esta obra distópica, publicada em 1984, antevê, de modo muito preciso, vários aspectos fundamentais da sociedade atual e de sua relação com a tecnologia. Foi o primeiro livro a ganhar a chamada “tríplice coroa da ficção científica”: os prestigiados prêmios Hugo, Nebula e Philip K. Dick.", "https://m.media-amazon.com/images/I/51TMmMNtZiL._SX331_BO1,204,203,200_.jpg", 8.99m, "Neuromancer: 1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
