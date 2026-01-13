using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrelloClone.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRedundantFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardLists_CardListListId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_CardListListId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "CardListListId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "BoradId",
                table: "CardLists");

            migrationBuilder.RenameColumn(
                name: "ListId",
                table: "Cards",
                newName: "CardListId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardListId",
                table: "Cards",
                column: "CardListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardLists_CardListId",
                table: "Cards",
                column: "CardListId",
                principalTable: "CardLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_CardLists_CardListId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_CardListId",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "CardListId",
                table: "Cards",
                newName: "ListId");

            migrationBuilder.AddColumn<int>(
                name: "CardListListId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BoradId",
                table: "CardLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardListListId",
                table: "Cards",
                column: "CardListListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_CardLists_CardListListId",
                table: "Cards",
                column: "CardListListId",
                principalTable: "CardLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
