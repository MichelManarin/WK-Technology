using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_produto_categoria_CategoriaId",
                table: "produto");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "produto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_produto_categoria_CategoriaId",
                table: "produto",
                column: "CategoriaId",
                principalTable: "categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_produto_categoria_CategoriaId",
                table: "produto");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "produto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_produto_categoria_CategoriaId",
                table: "produto",
                column: "CategoriaId",
                principalTable: "categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
