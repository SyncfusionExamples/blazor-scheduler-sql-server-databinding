using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqlServerDataBinding.Migrations
{
    public partial class SqlServerDataBindingDataAppointmentDataContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointmentDatas",
                columns: table => new
                {
                    RecordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryColor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTimezone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndTimezone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAllDay = table.Column<bool>(type: "bit", nullable: false),
                    RecurrenceID = table.Column<int>(type: "int", nullable: true),
                    RecurrenceRule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecurrenceException = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsReadOnly = table.Column<bool>(type: "bit", nullable: true),
                    IsBlock = table.Column<bool>(type: "bit", nullable: true),
                    CssClass = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentDatas", x => x.RecordID);
                });

            migrationBuilder.InsertData(
                table: "AppointmentDatas",
                columns: new[] { "RecordID", "CategoryColor", "CssClass", "Description", "EndTime", "EndTimezone", "EventCategory", "EventType", "Id", "IsAllDay", "IsBlock", "IsReadOnly", "Location", "OwnerId", "OwnerType", "RecurrenceException", "RecurrenceID", "RecurrenceRule", "StartTime", "StartTimezone", "Subject", "UserID" },
                values: new object[] { 1, null, null, null, new DateTime(2023, 5, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, 1, false, null, null, "Tamilnadu", null, null, null, null, null, new DateTime(2023, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), null, "Meeting", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentDatas");
        }
    }
}
