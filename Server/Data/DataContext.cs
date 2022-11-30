using BlazorEcommerce.Shared.Models;

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
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                });

            //Metodo criado para iniciar a tabela ja com valores, ao rodar a migration.
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "A Saga Wingfeather: nos Limites do mar Sombrio da Escuridão",
                    Description = "AVENTURA. PERIGO. JOIAS PERDIDAS. E AS TERRÍVEIS VACAS-DENTADAS DE SKREE.",
                    ImageUrl = "https://m.media-amazon.com/images/I/51RgW3SkK+S._SX344_BO1,204,203,200_.jpg",
                    Price = 9.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "O rei de amarelo",
                    Description = "Escrito em 1895 por Robert W. Chambers “O Rei de Amarelo” influenciou uma enorme geração de escritores. O livro é formado por quatro histórias que guardam relações entre si, tendo como pano de fundo uma entidade misteriosa chamada ‘O Rei de Amarelo.",
                    ImageUrl = "https://m.media-amazon.com/images/I/51W6T1CC8NL._SX346_BO1,204,203,200_.jpg",
                    Price = 7.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Neuromancer: 1",
                    Description = "O Céu sobre o porto tinha cor de televisão num canal fora do ar. Considerada a obra precursora do movimento cyberpunk e um clássico da ficção científica moderna, Neuromancer conta a história de Case, um cowboy do ciberespaço e hacker da matrix. Como punição por tentar enganar os patrões, seu sistema nervoso foi contaminado por uma toxina que o impede de entrar no mundo virtual. Agora, ele vaga pelos subúrbios de Tóquio, cometendo pequenos crimes para sobreviver, e acaba se envolvendo em uma jornada que mudará para sempre o mundo e a percepção da realidade. Evoluindo de Blade Runner e antecipando Matrix, Neuromancer é o romance de estreia de William Gibson. Esta obra distópica, publicada em 1984, antevê, de modo muito preciso, vários aspectos fundamentais da sociedade atual e de sua relação com a tecnologia. Foi o primeiro livro a ganhar a chamada “tríplice coroa da ficção científica”: os prestigiados prêmios Hugo, Nebula e Philip K. Dick.",
                    ImageUrl = "https://m.media-amazon.com/images/I/51TMmMNtZiL._SX331_BO1,204,203,200_.jpg",
                    Price = 8.99m,
                    CategoryId = 1
                }
                );
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
