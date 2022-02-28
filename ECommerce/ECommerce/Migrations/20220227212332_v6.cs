using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Products_ProductId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_payments_Categories_CategoryId",
                table: "payments");

            migrationBuilder.DropIndex(
                name: "IX_payments_CategoryId",
                table: "payments");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ProductId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ProductId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "payments");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "OldPrice",
                table: "Products",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customers",
                newName: "LName");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Customers",
                newName: "FName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Admins",
                newName: "LName");

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DOB",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AdminId",
                table: "Products",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Admins_AdminId",
                table: "Products",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Admins_AdminId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_AdminId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_OrderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DOB",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "FName",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Products",
                newName: "OldPrice");

            migrationBuilder.RenameColumn(
                name: "LName",
                table: "Customers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FName",
                table: "Customers",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "LName",
                table: "Admins",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "payments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_payments_CategoryId",
                table: "payments",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ProductId",
                table: "Customers",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Products_ProductId",
                table: "Customers",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_ProductId",
                table: "Orders",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_payments_Categories_CategoryId",
                table: "payments",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
