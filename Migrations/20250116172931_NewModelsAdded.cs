using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotNetCources.Migrations
{
    /// <inheritdoc />
    public partial class NewModelsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Categories_CategoryId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Countries_CountryId",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_CountryId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "DateAt",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Teachers",
                newName: "VK");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Teachers",
                newName: "OK");

            migrationBuilder.RenameColumn(
                name: "TeacherCourceStatus",
                table: "Courses",
                newName: "Featured");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Bio",
                keyValue: null,
                column: "Bio",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Teachers",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "Teachers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "CartOrderId",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Teachers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Teachers",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "GitHub",
                table: "Teachers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Teachers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "LinkedIn",
                table: "Teachers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Courses",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Courses",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(32)",
                oldMaxLength: 32)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Courses",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AlterColumn<int>(
                name: "PlatformStatus",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseId",
                table: "Courses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Courses",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "Courses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Courses",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherCourseStatus",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Categories",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(32)",
                oldMaxLength: 32)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Categories",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(32)",
                oldMaxLength: 32)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Categories",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CartOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SubTotal = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TaxFee = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    InitialTotal = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Saved = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FullName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StripeSessionId = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Oid = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartOrders_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TaxFee = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Country = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CartId = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "QuestionAnswer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QAId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionAnswer_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Variants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VariantId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Variants_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CartOrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    TaxFee = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    InitialTotal = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    Saved = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    AppliedCoupon = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Oid = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartOrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartOrderItems_CartOrders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "CartOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartOrderItems_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartOrderItems_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "QuestionAnswerMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QAMId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAnswerMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionAnswerMessages_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionAnswerMessages_QuestionAnswer_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuestionAnswer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VariantItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VariantId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    File = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Duration = table.Column<TimeSpan>(type: "time(6)", nullable: true),
                    ContentDuration = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Preview = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    VariantItemId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariantItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VariantItems_Variants_VariantId",
                        column: x => x.VariantId,
                        principalTable: "Variants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CartOrderId = table.Column<int>(type: "int", nullable: true),
                    CartOrderItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coupons_CartOrderItems_CartOrderItemId",
                        column: x => x.CartOrderItemId,
                        principalTable: "CartOrderItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Coupons_CartOrders_CartOrderId",
                        column: x => x.CartOrderId,
                        principalTable: "CartOrders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Coupons_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_CartOrderId",
                table: "Teachers",
                column: "CartOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CartId",
                table: "Courses",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartOrderItems_CourseId",
                table: "CartOrderItems",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CartOrderItems_OrderId",
                table: "CartOrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CartOrderItems_TeacherId",
                table: "CartOrderItems",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_CartOrders_StudentId",
                table: "CartOrders",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CourseId",
                table: "Carts",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_CartOrderId",
                table: "Coupons",
                column: "CartOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_CartOrderItemId",
                table: "Coupons",
                column: "CartOrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_TeacherId",
                table: "Coupons",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswer_CourseId",
                table: "QuestionAnswer",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswerMessages_CourseId",
                table: "QuestionAnswerMessages",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswerMessages_QuestionId",
                table: "QuestionAnswerMessages",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_VariantItems_VariantId",
                table: "VariantItems",
                column: "VariantId");

            migrationBuilder.CreateIndex(
                name: "IX_Variants_CourseId",
                table: "Variants",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Carts_CartId",
                table: "Courses",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Categories_CategoryId",
                table: "Courses",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_CartOrders_CartOrderId",
                table: "Teachers",
                column: "CartOrderId",
                principalTable: "CartOrders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Carts_CartId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Categories_CategoryId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_CartOrders_CartOrderId",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "QuestionAnswerMessages");

            migrationBuilder.DropTable(
                name: "VariantItems");

            migrationBuilder.DropTable(
                name: "CartOrderItems");

            migrationBuilder.DropTable(
                name: "QuestionAnswer");

            migrationBuilder.DropTable(
                name: "Variants");

            migrationBuilder.DropTable(
                name: "CartOrders");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_CartOrderId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CartId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "About",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "CartOrderId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "GitHub",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "LinkedIn",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "File",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TeacherCourseStatus",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "VK",
                table: "Teachers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "OK",
                table: "Teachers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Featured",
                table: "Courses",
                newName: "TeacherCourceStatus");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Teachers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Teachers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Teachers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Courses",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Courses",
                type: "varchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Courses",
                type: "double",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<bool>(
                name: "PlatformStatus",
                table: "Courses",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAt",
                table: "Courses",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Courses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Categories",
                type: "varchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Categories",
                type: "varchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Categories",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_CountryId",
                table: "Teachers",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Categories_CategoryId",
                table: "Courses",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Countries_CountryId",
                table: "Teachers",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
