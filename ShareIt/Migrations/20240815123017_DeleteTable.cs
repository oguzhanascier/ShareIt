using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShareIt.Migrations
{
    /// <inheritdoc />
    public partial class DeleteTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sharings_AspNetUsers_UserId",
                table: "Sharings");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Sharings",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Sharings",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserDTO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDTO", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sharings_UserId1",
                table: "Sharings",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Sharings_AspNetUsers_UserId",
                table: "Sharings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sharings_UserDTO_UserId1",
                table: "Sharings",
                column: "UserId1",
                principalTable: "UserDTO",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sharings_AspNetUsers_UserId",
                table: "Sharings");

            migrationBuilder.DropForeignKey(
                name: "FK_Sharings_UserDTO_UserId1",
                table: "Sharings");

            migrationBuilder.DropTable(
                name: "UserDTO");

            migrationBuilder.DropIndex(
                name: "IX_Sharings_UserId1",
                table: "Sharings");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Sharings");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Sharings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sharings_AspNetUsers_UserId",
                table: "Sharings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
