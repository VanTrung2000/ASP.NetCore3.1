using Microsoft.EntityFrameworkCore.Migrations;

namespace QlCoffe.Migrations
{
    public partial class tr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "coffes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCoffe = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Despition = table.Column<string>(nullable: true),
                    Soluong = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coffes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_coffes_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Cafe" },
                    { 2, "Trà sữa" },
                    { 3, "Nước ép hoa quả" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[] { 1, "trung123", "trung123" });

            migrationBuilder.InsertData(
                table: "coffes",
                columns: new[] { "Id", "CategoryId", "Despition", "NameCoffe", "Price", "Soluong" },
                values: new object[] { 1, 1, "Một cốc Espresso nguyên bản được bắt đầu bởi những hạt Arabica chất lượng, phối trộn với tỉ lệ cân đối hạt Robusta, cho ra vị ngọt caramel, vị chua dịu và sánh đặc. Để đạt được sự kết hợp này, chúng tôi xay tươi hạt cà phê cho mỗi lần pha.", "ESPRESSO", 35.0, null });

            migrationBuilder.InsertData(
                table: "coffes",
                columns: new[] { "Id", "CategoryId", "Despition", "NameCoffe", "Price", "Soluong" },
                values: new object[] { 2, 1, "Vị thơm béo của bọt sữa và sữa tươi, vị đắng thanh thoát của cà phê Espresso hảo hạng, và vị ngọt đậm của sốt caramel.", "CARAMEL MACCHIATO", 55.0, null });

            migrationBuilder.CreateIndex(
                name: "IX_coffes_CategoryId",
                table: "coffes",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coffes");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
