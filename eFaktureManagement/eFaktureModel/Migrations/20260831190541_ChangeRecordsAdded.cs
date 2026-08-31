using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace eFaktureModel.Migrations
{
    /// <inheritdoc />
    public partial class ChangeRecordsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserInvoices",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "PublicPurchaseContractorRecordChanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false),
                    SyncType = table.Column<int>(type: "integer", nullable: false),
                    RecordedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicPurchaseContractorRecordChanges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseInvoiceAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InvoiceId = table.Column<long>(type: "bigint", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoiceAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseInvoiceAttachments_PurchaseInvoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "PurchaseInvoice",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseInvoiceRecordChanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false),
                    SyncType = table.Column<int>(type: "integer", nullable: false),
                    RecordedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoiceRecordChanges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegisteredCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    eFaktureCompanyId = table.Column<int>(type: "integer", nullable: true),
                    BugetCompanyNumber = table.Column<string>(type: "text", nullable: false),
                    RegistrationCode = table.Column<string>(type: "text", nullable: false),
                    VatRegistrationCode = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CountryId = table.Column<int>(type: "integer", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsPrivateCompany = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisteredCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoiceAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InvoiceId = table.Column<long>(type: "bigint", nullable: false),
                    FileName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoiceAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesInvoiceAttachments_SalesInvoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "SalesInvoice",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoiceRecordChanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RecordStatus = table.Column<int>(type: "integer", nullable: false),
                    SyncType = table.Column<int>(type: "integer", nullable: false),
                    RecordedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoiceRecordChanges", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserInvoices_UserId",
                table: "UserInvoices",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoiceAttachments_InvoiceId",
                table: "PurchaseInvoiceAttachments",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoiceAttachments_InvoiceId",
                table: "SalesInvoiceAttachments",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInvoices_AspNetUsers_UserId",
                table: "UserInvoices",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserInvoices_AspNetUsers_UserId",
                table: "UserInvoices");

            migrationBuilder.DropTable(
                name: "PublicPurchaseContractorRecordChanges");

            migrationBuilder.DropTable(
                name: "PurchaseInvoiceAttachments");

            migrationBuilder.DropTable(
                name: "PurchaseInvoiceRecordChanges");

            migrationBuilder.DropTable(
                name: "RegisteredCompanies");

            migrationBuilder.DropTable(
                name: "SalesInvoiceAttachments");

            migrationBuilder.DropTable(
                name: "SalesInvoiceRecordChanges");

            migrationBuilder.DropIndex(
                name: "IX_UserInvoices_UserId",
                table: "UserInvoices");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserInvoices",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
