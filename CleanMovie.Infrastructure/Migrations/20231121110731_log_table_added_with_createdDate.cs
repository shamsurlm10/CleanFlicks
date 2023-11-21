using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanMovie.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class log_table_added_with_createdDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Logs",
                newName: "Created");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Logs",
                newName: "DateTime");
        }
    }
}
