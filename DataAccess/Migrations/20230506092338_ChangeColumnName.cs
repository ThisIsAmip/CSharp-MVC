using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class ChangeColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
            name: "FK_Cart_Customers_CustomerID",
            table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_CustomerID",
                table: "Cart");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Cart",
                newName: "UserID");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Cart",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserID",
                table: "Cart",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Users_UserID",
                table: "Cart",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
            name: "FK_Cart_Customers_CustomerID",
            table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_CustomerID",
                table: "Cart");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Cart",
                newName: "UserID");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Cart",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserID",
                table: "Cart",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Users_UserID",
                table: "Cart",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
