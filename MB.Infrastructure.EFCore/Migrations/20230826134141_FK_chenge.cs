using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MB.Infrastructure.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class FK_chenge : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Art_ArtCategory_Id",
                table: "Art");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Art",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Art_ArtCategoryId",
                table: "Art",
                column: "ArtCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Art_ArtCategory_ArtCategoryId",
                table: "Art",
                column: "ArtCategoryId",
                principalTable: "ArtCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Art_ArtCategory_ArtCategoryId",
                table: "Art");

            migrationBuilder.DropIndex(
                name: "IX_Art_ArtCategoryId",
                table: "Art");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Art",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Art_ArtCategory_Id",
                table: "Art",
                column: "Id",
                principalTable: "ArtCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
