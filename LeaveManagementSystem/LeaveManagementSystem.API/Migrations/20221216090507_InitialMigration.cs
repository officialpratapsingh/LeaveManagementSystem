using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    empName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empAge = table.Column<int>(type: "int", nullable: false),
                    empNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leaves",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    leaveType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    fromDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    toDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    submittedTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LeaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveStatuses_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaveStatuses_Leaves_LeaveId",
                        column: x => x.LeaveId,
                        principalTable: "Leaves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveStatuses_EmployeeId",
                table: "LeaveStatuses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveStatuses_LeaveId",
                table: "LeaveStatuses",
                column: "LeaveId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveStatuses");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Leaves");
        }
    }
}
