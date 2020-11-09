using Microsoft.EntityFrameworkCore.Migrations;

namespace QlCoffe.Migrations
{
    public partial class @as : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "coffes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TênCoffe = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Môtả = table.Column<string>(nullable: true),
                    Sốlượng = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coffes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "coffes",
                columns: new[] { "Id", "Môtả", "Price", "Sốlượng", "TênCoffe" },
                values: new object[] { 1, "Một cốc Espresso nguyên bản được bắt đầu bởi những hạt Arabica chất lượng, phối trộn với tỉ lệ cân đối hạt Robusta, cho ra vị ngọt caramel, vị chua dịu và sánh đặc. Để đạt được sự kết hợp này, chúng tôi xay tươi hạt cà phê cho mỗi lần pha.", 35.0, null, "ESPRESSO" });

            migrationBuilder.InsertData(
                table: "coffes",
                columns: new[] { "Id", "Môtả", "Price", "Sốlượng", "TênCoffe" },
                values: new object[] { 2, "Vị thơm béo của bọt sữa và sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng, và vị ngọt đậm của sốt caramel.", 55.0, null, "CARAMEL MACCHIATO" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[] { 1, "trung123", "trung123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coffes");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
