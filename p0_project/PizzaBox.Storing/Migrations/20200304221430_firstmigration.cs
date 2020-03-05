using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    PizzaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.PizzaId);
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                column: "PizzaId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Pizzas",
                column: "PizzaId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizzas");
        }
    }
}
