using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorigoApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initializerContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BellBoy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BellBoy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Connection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlootNo = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DryCleaner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DryCleaner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeedBackAndSurveys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    FeedBack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBackAndSurveys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomFoodTypeEnum = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelInformationAndAnnouncements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelInformationAndAnnouncements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseKeeping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseKeeping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageTemplate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    Exception = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Properties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogEvent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomTypeEnum = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpaMassage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpaMassage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalNeed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalNeed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfStar = table.Column<int>(type: "int", nullable: false),
                    Companyid = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotel_Company_Companyid",
                        column: x => x.Companyid,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicesEnumId = table.Column<int>(type: "int", nullable: false),
                    ServiceItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    OrderStatusEnum = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodMenuCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodMenuCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodMenuCategory_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageCategory_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    RoomFoodTypeId = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_FoodType_RoomFoodTypeId",
                        column: x => x.RoomFoodTypeId,
                        principalTable: "FoodType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Room_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Room_RoomType_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentAndRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeedPoint = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductPoint = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeePoint = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    OrderItemId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentAndRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentAndRatings_OrderItems_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CommentAndRatings_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeType_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeType_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodMenuCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Food_FoodMenuCategory_FoodMenuCategoryId",
                        column: x => x.FoodMenuCategoryId,
                        principalTable: "FoodMenuCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_ImageCategory_ImageCategoryId",
                        column: x => x.ImageCategoryId,
                        principalTable: "ImageCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeTypeId = table.Column<int>(type: "int", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_EmployeeType_EmployeeTypeId",
                        column: x => x.EmployeeTypeId,
                        principalTable: "EmployeeType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employee_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContentsOfFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentsOfFood", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContentsOfFood_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FloorNo = table.Column<int>(type: "int", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    StartDateOfWork = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExitDateOfWork = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastOnlineTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OnlineOrOfflineNow = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeDetail_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BellBoy",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[] { 1, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(5041), "1.jpeg", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(5043), "Bagaj Taşıma" });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(1412), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(1428), "Worigo" },
                    { 2, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(1431), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(1431), "Ramada" }
                });

            migrationBuilder.InsertData(
                table: "Connection",
                columns: new[] { "Id", "CreatedDate", "FlootNo", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[] { 1, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(5927), null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(5929), "1q2w3e4r5t" });

            migrationBuilder.InsertData(
                table: "FoodType",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifyDate", "RoomFoodTypeEnum" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4304), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4305), 1 },
                    { 2, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4306), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4306), 2 },
                    { 3, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4307), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4308), 3 },
                    { 4, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4308), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4309), 4 },
                    { 5, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4309), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(4310), 5 }
                });

            migrationBuilder.InsertData(
                table: "HouseKeeping",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(9187), "", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(9192), "Havlu değişimi veya eksiği" },
                    { 2, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(9194), "", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(9195), "Oda Genel temizlik" },
                    { 3, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(9195), "", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(9196), "Çarşaf veya yatak yüzü değişimi" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5325), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5331), "SystemAdmin" },
                    { 2, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5333), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5333), "HotelAdmin" },
                    { 3, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5334), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5334), "Management" },
                    { 4, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5335), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5335), "DepartmentManager" },
                    { 5, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5336), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5336), "Employee" },
                    { 6, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5337), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(5337), "Customer" }
                });

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifyDate", "RoomTypeEnum" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6270), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6273), 1 },
                    { 2, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6274), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6274), 2 },
                    { 3, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6275), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6276), 3 },
                    { 4, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6276), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6277), 4 },
                    { 5, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6278), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6278), 5 },
                    { 6, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6279), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6279), 6 },
                    { 7, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6280), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6280), 7 },
                    { 8, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6281), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6281), 8 },
                    { 9, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6282), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6282), 9 },
                    { 10, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6283), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6283), 10 },
                    { 11, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6284), true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(6284), 11 }
                });

            migrationBuilder.InsertData(
                table: "SpaMassage",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifyDate", "Name", "ParentId", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(18), "Uzak Doğu Masajı", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(19), "Uzak Doğu", null, 200m },
                    { 2, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(22), "Tailand Masajı", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(22), "Tailand Masajı", null, 200m }
                });

            migrationBuilder.InsertData(
                table: "TechnicalNeed",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(734), "Klima ile arıza durumları", "1.jpeg", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(735), "Klima" },
                    { 2, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(737), "TV ile arıza durumları", "1.jpeg", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(737), "TV" },
                    { 3, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(738), "Minibar ile arıza durumları", "1.jpeg", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(738), "Minibar" },
                    { 4, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(739), "Kapı ile arıza durumları", "1.jpeg", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(739), "Kapı" },
                    { 5, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(740), "Elektirk ile arıza durumları", "1.jpeg", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(740), "Elektrik" },
                    { 6, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(741), "Aydınlatma ile arıza durumları", "1.jpeg", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(741), "Aydınlatma" },
                    { 7, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(742), "Aydınlatma ile arıza durumları", "1.jpeg", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(742), "Duş Ve Tuvalet" }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "Adress", "Companyid", "CreatedDate", "Email", "IsActive", "IsDeleted", "Location", "ModifyDate", "Name", "NumberOfStar", "PhoneNumber" },
                values: new object[] { 1, "Bağcılar", 2, new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(1560), "tekstilkent@ramada.com", true, false, "Giyimkent", new DateTime(2024, 10, 12, 15, 28, 2, 467, DateTimeKind.Local).AddTicks(1562), "Tekstilkent", 4, "02126733520" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "CreatedDate", "HotelId", "ImageUrl", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2528), 1, "1.jpeg", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2530), "Ön Büro Resepsiyon Departmanı" },
                    { 2, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2532), 1, "1.jpeg", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2533), "Housekeeping Departmanı" },
                    { 3, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2533), 1, "1.jpeg", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2534), "Yiyecek İçecek ve Mutfak Departmanı" },
                    { 4, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2534), 1, "1.jpeg", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2535), "Teknik Servis Departmanı" },
                    { 5, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2535), 1, "1.jpeg", true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(2536), "Sağlık Kulübü & Spa Departmanı" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeType",
                columns: new[] { "Id", "CreatedDate", "DepartmentId", "HotelId", "IsActive", "IsDeleted", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3451), 1, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3453), "Ön Büro Müdürü" },
                    { 2, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3455), 1, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3455), "Gece Müdürü" },
                    { 3, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3456), 1, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3456), "Ön Büro Şefi" },
                    { 4, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3457), 1, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3457), "Resepsiyonist" },
                    { 5, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3458), 1, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3458), "Concierge Şefi" },
                    { 6, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3459), 1, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3459), "Taşıyıcı/Karşılayıcı Personel" },
                    { 7, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3460), 1, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3460), "Guest Service Agent" },
                    { 8, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3460), 1, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3461), "Guest Relation" },
                    { 9, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3462), 2, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3462), "HK Müdürü" },
                    { 10, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3463), 2, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3463), "Housekeeper" },
                    { 11, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3463), 2, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3464), "Kat Şefi (Floor Supervisor)" },
                    { 12, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3464), 2, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3465), "Oda Görevlisi" },
                    { 13, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3465), 2, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3466), "Meydancı" },
                    { 14, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3466), 3, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3466), "Yiyecek – İçecek Müdürü" },
                    { 15, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3467), 3, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3467), "Barlar Şefi" },
                    { 16, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3468), 3, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3468), "Bar Personeli" },
                    { 17, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3469), 3, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3469), "Mutfak Şefi" },
                    { 18, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3469), 3, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3470), "Mutfak Personeli" },
                    { 19, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3470), 3, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3471), "Restoran Şefi" },
                    { 20, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3471), 3, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3471), "Servis Personeli" },
                    { 21, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3472), 4, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3472), "Teknik Müdür" },
                    { 22, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3473), 4, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3473), "Elektrik Tekniker" },
                    { 23, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3474), 4, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3474), "Mekanik Tekniker" },
                    { 24, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3474), 4, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3475), "Tesisatçı" },
                    { 25, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3475), 5, null, true, false, new DateTime(2024, 10, 12, 15, 28, 2, 466, DateTimeKind.Local).AddTicks(3476), "Masör" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentAndRatings_OrderId",
                table: "CommentAndRatings",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentAndRatings_OrderItemId",
                table: "CommentAndRatings",
                column: "OrderItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContentsOfFood_FoodId",
                table: "ContentsOfFood",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_HotelId",
                table: "Department",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_EmployeeTypeId",
                table: "Employee",
                column: "EmployeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_HotelId",
                table: "Employee",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetail_EmployeeId",
                table: "EmployeeDetail",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeType_DepartmentId",
                table: "EmployeeType",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeType_HotelId",
                table: "EmployeeType",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Food_FoodMenuCategoryId",
                table: "Food",
                column: "FoodMenuCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodMenuCategory_HotelId",
                table: "FoodMenuCategory",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_Companyid",
                table: "Hotel",
                column: "Companyid");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ImageCategoryId",
                table: "Image",
                column: "ImageCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageCategory_HotelId",
                table: "ImageCategory",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_HotelId",
                table: "Room",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomFoodTypeId",
                table: "Room",
                column: "RoomFoodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomTypeId",
                table: "Room",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BellBoy");

            migrationBuilder.DropTable(
                name: "CommentAndRatings");

            migrationBuilder.DropTable(
                name: "Connection");

            migrationBuilder.DropTable(
                name: "ContentsOfFood");

            migrationBuilder.DropTable(
                name: "DryCleaner");

            migrationBuilder.DropTable(
                name: "EmployeeDetail");

            migrationBuilder.DropTable(
                name: "FeedBackAndSurveys");

            migrationBuilder.DropTable(
                name: "HotelInformationAndAnnouncements");

            migrationBuilder.DropTable(
                name: "HouseKeeping");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "SpaMassage");

            migrationBuilder.DropTable(
                name: "TechnicalNeed");

            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "ImageCategory");

            migrationBuilder.DropTable(
                name: "FoodType");

            migrationBuilder.DropTable(
                name: "RoomType");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "FoodMenuCategory");

            migrationBuilder.DropTable(
                name: "EmployeeType");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
