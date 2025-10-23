using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArch.InfraData.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) " +
                                "VALUES ('Caderno Espiral', 'Caderno espiral com 100 folhas', 12.90, 50, 'caderno_espiral.jpg', 1)");
       
            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) " +
                                "VALUES ('Estojo', 'Estojo escolar cinza', 6.65, 100, 'estojo_cinza.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) " +
                                "VALUES ('Mochila Escolar', 'Mochila resistente para uso diário', 89.90, 30, 'mochila_escolar.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products (Name, Description, Price, Stock, Image, CategoryId) " +
                                "VALUES ('Caneta Azul', 'Caneta esferográfica azul', 2.50, 200, 'caneta_azul.jpg', 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
