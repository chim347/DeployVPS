using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinhChiDoiSOS.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitAuzeDatabase123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "ChuanDoan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("2a7ce08a-0967-439a-b0af-d3f0c80197d6"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("58698e2d-fb2a-48c1-b064-085dd11c48d0"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("6e4caa08-8b57-4090-8bb4-3507199e0be3"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("c125f973-8af1-417e-87be-ff5f46ffdf5c"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGNza499IjAwplyjzEbrhj5kIs6pXVSF1d65SbONXZXh6XMggag51aAQXhThmxemhQ==");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2b729efa-3446-405b-9dc7-059a4c451296"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3a477216-d412-43ca-b05f-653bc84f6609"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("18fff9c2-ff95-454c-9556-02ddfab87c50"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("25ff2950-58ef-4303-8fc7-0e89538a70b2"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("54b8bdd4-b49e-4775-ab42-9ff7b4dd0df6"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("5582c691-4042-40a4-a32b-cde2edcb5fe5"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("72c14f87-15ae-4b85-81d1-005562d806c3"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("a89744ca-73d3-4f08-9548-9cf8af8938fb"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("b8c5cf22-b246-4ca1-b8bf-0f6e7d475027"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("c0daa7c5-4331-44bf-a33e-23679c959b12"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("092cd36a-4a80-48ef-bd7a-f4e3e63871bd"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7651), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("0b1820a0-2c22-47ac-80f4-3630863bb890"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7636), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("0f3633c8-5e37-4f73-b3f6-35933e195046"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7644), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("17617323-50a0-492c-a220-84ea0235735f"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7673), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("2ae51909-7baa-4de0-ae83-c13c0498b157"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7659), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("2e2c200b-4115-4f49-8516-2a33654c2c00"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7683), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("37437d9f-7753-4ee4-a04d-e1ce1651c54f"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7632), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("491f2b78-009d-4d2e-8ad7-02c25e44dd95"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7657), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("4edc5c6e-daa5-48a5-9f1b-d63ee7eb6fc3"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7688), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("59a9e104-7d3b-43a9-afc1-0c58b3ae4016"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7662), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("5e3e996b-cf80-46be-93a1-e822fda0d50e"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7641), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("689782fb-f292-47fb-9e78-990e92a0e390"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7630), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("7ba022bb-325a-4058-a4d9-63892767d7ed"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7691), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("8d4a29c0-775f-49f6-9598-5dbfacccced9"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7585), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("984f2fb4-d29c-4959-8a52-1f43f3380dba"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7627), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("ade4f561-1316-489d-b752-dc042dd5b700"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7670), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("af316d79-6367-4029-a241-bf49fa9c0f56"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7648), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("bac1c26d-ff9f-4cc7-b4bf-f6009b1c5830"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7675), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("d343e947-dbba-4631-9796-9364369efac4"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7667), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("e6513d6e-0d42-480c-925f-7bf931f86cd0"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7685), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("e71a9882-2634-411f-a74c-3a49ae3989b9"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7580), "" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("eeb8ae18-c9a8-485a-9846-c8647d861dc6"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7654), "" });

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("81e210f8-9274-44c5-9256-481acce0e8ec"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("edd4ae9e-0e26-4ed4-9812-0fbe587fcdb3"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("1761d6c6-1155-4534-8d44-9362db753a9a"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("2f55aa8b-e887-4808-9e18-7c6556464f16"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("481abb77-ebd3-47b0-9e9f-718368076074"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5ef458ed-6776-43b4-ba9d-9cc9c47d7511"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7aa3b055-2b09-4d6a-82e0-89e75a365940"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("807ebc7e-3f10-4c2e-b8b2-138b20a314cc"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("842765e5-aec9-402e-93cd-3f3bb3998608"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c672ebe0-2a8e-4a0e-b21f-f70e0d87efa2"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3db0b18-003a-4046-873b-264d3498360c"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("0d085bfa-8d7e-496b-b86e-ff4f60198269"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1822976f-01d7-4a12-ba20-46e5004cc71c"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f04befb-e7a8-4c34-87fe-5a61795fdc2a"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f7bfe1c-b663-4f08-9713-83394f85319d"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("231d86a8-97cb-4b12-b734-4c72fd8e6c67"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("280f5a0e-0379-4b8e-a09d-aacda21cddaf"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("39047891-ae02-4927-849b-a950f85f4480"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("3ba5c72a-2843-4dd8-a958-f008a6bff38b"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("46f2f761-1478-44fd-adae-ff50940ea9aa"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("48ae3bff-69b9-49f6-ad3e-e7408e44c081"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("4de6137f-63c7-4e2b-876c-f6084cadd849"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("52a8aef1-343c-41e0-a97b-6e63fc1afb5d"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("558f2622-5ba7-4f13-8086-b7bf91970fa0"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6a30dbfe-0c1c-4d34-b968-52bf9dabb48e"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6ad7ebcd-55b2-419c-ab60-8fcd257c3e1a"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a1969abb-e4ea-4f53-8ce2-e13136591218"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a89d9710-d2c2-4327-a604-d97ba4a99d4f"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b2590647-632f-48bb-adee-5cd6b9a5fb7f"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b7a6e1f1-75fb-4e26-b6f9-420dd470369d"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b8055c5b-a7fe-4d1b-8fbc-5ebd33fac035"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("bd166379-995b-449d-b381-db1fd362be0c"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c2d48bf7-05fd-4743-95db-a32c8d53de88"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c813800b-ba50-4270-b3a6-9313e7884646"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("cdd95a29-4f65-487a-ae60-2f043c4c63f8"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d16ccff2-a7a8-4b9a-80fd-dd8b37aeb3b7"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d390145b-b53a-4ccc-afe3-bb9b218332c0"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("e6e9f4ca-33ec-4df4-a15f-bb69c61a4691"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("ef525797-2ec8-405e-9eb9-826b621fe47a"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5c43ff6a-1903-4fdc-911b-52e32cbe3633"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5dca6c16-f112-4517-8655-3b03cfb7a716"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("76b241ee-7275-4449-ad4d-6813ac2c112a"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("93aeda91-ae3c-448a-bb89-497f28256563"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("a403ff66-6735-4516-ae28-23de65c52cea"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0e4ebaac-a0e4-4aa8-8d6c-6eefa8dc4d63"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1262623d-475a-4015-bc55-282650e90cde"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1aedfbb6-ef6c-40c3-b5e0-8c11ae6157e4"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("294142fc-8261-4d46-b670-5301cd5ce420"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("350bcba3-0e35-448a-b6a3-0da6d377e80e"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40e1f63e-7e31-4466-bd67-7aee4c28dd7f"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5074c5aa-b04b-41df-89a2-3177705c1a57"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51328c0e-fefd-4cf0-8407-9dd7e2e7afc4"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51b70068-3066-4e06-a5ba-bf3cf1d9639f"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("64d9b4f9-b12a-4c66-9b12-e1f79e4b7878"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7f0b42f9-0602-4a55-b9d8-ced88911e477"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("89c531da-3abc-4859-8337-408d8d556d06"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8df4266c-fd44-4e86-8cf0-f030ca219e71"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a0ae585b-182f-4df1-b596-429571d81c3d"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a29dae04-810f-4034-aad7-e293a28047aa"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aaa16c5a-126a-43fe-921e-d856958c576b"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("abac6286-767d-4baa-bc63-2fcc3e70a48e"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b07906a8-521b-4970-a421-2cc61520f749"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b7667346-a9df-4869-8ee4-814e44426b77"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cc4601b6-d9f9-4094-bc57-7105aa236761"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e73411bc-d4d7-4801-bdd9-d7df984b01aa"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.InsertData(
                table: "EmergencyDetail",
                columns: new[] { "Id", "ActionContent", "ContentBottom", "ContentLeft", "ContentLeftUrl", "ContentRight", "ContentRightUrl", "CreateBy", "Created", "EmergencyId", "IsDelete", "IsSafe", "LastModified", "LastModifiedBy", "MainPictureUrl", "Step", "TopContent" },
                values: new object[,]
                {
                    { new Guid("0cff733f-47e0-4656-b356-557d02ef9f9c"), "Tắt nguồn điện", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6741), new Guid("d16ccff2-a7a8-4b9a-80fd-dd8b37aeb3b7"), false, false, null, null, "diengiat_main_step_1", 1, "Đảm bảo an toàn cho bệnh nhân" },
                    { new Guid("1e9dae67-083c-40a3-9d33-1de20e22c900"), "Kiếm tra nhịp thở và thực hiện hô hấp nhân tạo", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6709), new Guid("b8055c5b-a7fe-4d1b-8fbc-5ebd33fac035"), false, false, null, null, "dotquy_main_step_2", 2, "Giảm thiểu tổn thương não" },
                    { new Guid("201cafab-4d18-461e-83db-3f15ad9ba19c"), "Đặt nạn nhân nằm sấp", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6819), new Guid("a89d9710-d2c2-4327-a604-d97ba4a99d4f"), false, false, null, null, "hocdivat_main_step_1", 1, "Loại bỏ dị vật khỏi đường thở" },
                    { new Guid("2162f4cd-abe5-4945-ac9c-49c2e12acc88"), "Gọi cấp cứu 115", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6631), new Guid("1f7bfe1c-b663-4f08-9713-83394f85319d"), false, false, null, null, "gayxuong_main_step_1", 1, "Giảm đau sưng" },
                    { new Guid("2977fa59-3ebe-407c-b804-42c381020f74"), "Kê vật mềm dưới đầu người bệnh", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6695), new Guid("b7a6e1f1-75fb-4e26-b6f9-420dd470369d"), false, false, null, null, "cogiat_main_step_3", 3, "Giảm thiểu tổn thương về thần kinh" },
                    { new Guid("299b419b-4894-4d0e-820f-e62774aab8c6"), "Ghi lại các biểu hiện của người bệnh và đưa tới bệnh viện", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6718), new Guid("b8055c5b-a7fe-4d1b-8fbc-5ebd33fac035"), false, true, null, null, "dotquy_main_step_5", 5, "Giảm thiểu tổn thương não" },
                    { new Guid("29ef856c-1ceb-4ce4-8de0-adebd76d8589"), "Uống một liều 300 mg thuốc viên aspirin.", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6662), new Guid("b2590647-632f-48bb-adee-5cd6b9a5fb7f"), false, false, null, null, "truytim_main_step_3", 3, "Duy trì sự sống cho nạn nhân" },
                    { new Guid("2b581b39-6ff7-465e-b28d-8e8dbdef52aa"), "Đặt hai ngón tay vào giữa ngực và ấn mạnh 5 lần", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6835), new Guid("a89d9710-d2c2-4327-a604-d97ba4a99d4f"), false, true, null, null, "hocdivat_main_step_4", 4, "Loại bỏ dị vật khỏi đường thở" },
                    { new Guid("2de49840-07b0-478c-b045-a46e311bfc2d"), "Gọi người hỗ trợ", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6721), new Guid("c2d48bf7-05fd-4743-95db-a32c8d53de88"), false, false, null, null, "duoinuoc_main_step_1", 1, "Cứu sống nạn nhân trước khi tới bệnh viện" },
                    { new Guid("53ab9697-804f-4492-93c7-cfcf2c975c2a"), "Đo lại đường huyết sau 15 phút", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6682), new Guid("52a8aef1-343c-41e0-a97b-6e63fc1afb5d"), false, true, null, null, "haduonghuyet_main_step_3", 3, "Nâng nhanh lượng đường trong máu" },
                    { new Guid("5f589b73-6307-4ba1-9b6e-a0aea9dbb10a"), "Gọi cấp cứu 115", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6705), new Guid("b8055c5b-a7fe-4d1b-8fbc-5ebd33fac035"), false, false, null, null, "dotquy_main_step_1", 1, "Giảm thiểu tổn thương não" },
                    { new Guid("773c3118-1127-4c00-b8ae-4acf2fff8e84"), "Lật nạn nhân nằm ngửa", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6830), new Guid("a89d9710-d2c2-4327-a604-d97ba4a99d4f"), false, false, null, null, "hocdivat_main_step_3", 3, "Loại bỏ dị vật khỏi đường thở" },
                    { new Guid("7978618a-d7be-4975-8db9-648a435925ce"), "Nới lỏng quần áo, phụ kiện", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6712), new Guid("b8055c5b-a7fe-4d1b-8fbc-5ebd33fac035"), false, false, null, null, "dotquy_main_step_3", 3, "Giảm thiểu tổn thương não" },
                    { new Guid("9420bbd8-3702-438b-9470-9fa5fff9a0ba"), "Vỗ mạnh 5 lần vào lưng nạn nhân", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6825), new Guid("a89d9710-d2c2-4327-a604-d97ba4a99d4f"), false, false, null, null, "hocdivat_main_step_2", 2, "Loại bỏ dị vật khỏi đường thở" },
                    { new Guid("9951c3aa-3245-4a3b-ae23-26339b08ece0"), "Chuyển tới cơ sở y tế", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6789), new Guid("d16ccff2-a7a8-4b9a-80fd-dd8b37aeb3b7"), false, true, null, null, "diengiat_main_step_4", 4, "Đảm bảo an toàn cho bệnh nhân" },
                    { new Guid("a4dca733-6788-469b-9980-6da0759e8089"), "Nới lỏng quần áo, thắt lưng", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6686), new Guid("b7a6e1f1-75fb-4e26-b6f9-420dd470369d"), false, false, null, null, "cogiat_main_step_1", 1, "Giảm thiểu tổn thương về thần kinh" },
                    { new Guid("aa9d9c94-ce3f-42a2-acff-84f85608748c"), "Bổ sung đường cho bệnh nhân.", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6678), new Guid("52a8aef1-343c-41e0-a97b-6e63fc1afb5d"), false, false, null, null, "haduonghuyet_main_step_2", 2, "Nâng nhanh lượng đường trong máu" },
                    { new Guid("ac02f0ed-e9be-4cfa-99c8-2aa060954bd9"), "Đỡ đầu và vai nạn nhân, đặt đệm lót dưới đầu gối của họ", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6656), new Guid("b2590647-632f-48bb-adee-5cd6b9a5fb7f"), false, false, null, null, "truytim_main_step_2", 2, "Duy trì sự sống cho nạn nhân" },
                    { new Guid("b8a7ec77-865b-4864-b52c-e0951b48e322"), "Hô hấp nhân tạo hoặc ép tim ngoài lồng ngực", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6786), new Guid("d16ccff2-a7a8-4b9a-80fd-dd8b37aeb3b7"), false, false, null, null, "diengiat_main_step_3", 3, "Đảm bảo an toàn cho bệnh nhân" },
                    { new Guid("b9ea8984-a752-4ac4-8bf2-e30a90e497d0"), "Cởi bỏ quần áo ướt và giữ ấm", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6729), new Guid("c2d48bf7-05fd-4743-95db-a32c8d53de88"), false, false, null, null, "duoinuoc_main_step_3", 3, "Cứu sống nạn nhân trước khi tới bệnh viện" },
                    { new Guid("bc5db5fe-b982-44e6-a591-b2596ccd5522"), "Tách nạn nhân ra khỏi nguồn điện ", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6745), new Guid("d16ccff2-a7a8-4b9a-80fd-dd8b37aeb3b7"), false, false, null, null, "diengiat_main_step_2", 2, "Đảm bảo an toàn cho bệnh nhân" },
                    { new Guid("cd8eb190-a455-4f5f-bc21-8900c829ad46"), "Cố định tạm thời xương gãy bằng nẹp hoặc băng ép", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6635), new Guid("1f7bfe1c-b663-4f08-9713-83394f85319d"), false, false, null, null, "gayxuong_main_step_2", 2, "Giảm đau sưng" },
                    { new Guid("d8f9cc58-73bb-49cb-b8a5-c9693ff067de"), "Đưa đến cơ sở y tế gần nhất", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6702), new Guid("b7a6e1f1-75fb-4e26-b6f9-420dd470369d"), false, true, null, null, "cogiat_main_step_4", 4, "Giảm thiểu tổn thương về thần kinh" },
                    { new Guid("df288229-2da4-4832-9913-70c1a7e05e8f"), "Gọi 115", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6653), new Guid("b2590647-632f-48bb-adee-5cd6b9a5fb7f"), false, false, null, null, "truytim_main_step_1", 1, "Duy trì sự sống cho nạn nhân" },
                    { new Guid("e091b4cd-98f8-4fe3-97ba-9c016c7822e2"), "Ghi lại các dấu hiệu của nạn nhân ", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6668), new Guid("b2590647-632f-48bb-adee-5cd6b9a5fb7f"), false, true, null, null, "truytim_main_step_4", 4, "Duy trì sự sống cho nạn nhân" },
                    { new Guid("e57daddb-f9b7-483b-b4ab-153957577e7f"), "Dùng khăn tay lấy sạch đờm", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6715), new Guid("b8055c5b-a7fe-4d1b-8fbc-5ebd33fac035"), false, false, null, null, "dotquy_main_step_4", 4, "Giảm thiểu tổn thương não" },
                    { new Guid("e848a319-5e9a-4dba-975d-8c1e5247a97a"), "Kiểm tra chỉ số đường huyết", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6674), new Guid("52a8aef1-343c-41e0-a97b-6e63fc1afb5d"), false, false, null, null, "haduonghuyet_main_step_1", 1, "Nâng nhanh lượng đường trong máu" },
                    { new Guid("eea55b8b-fa03-4ecb-819a-ca9a6f9d43ef"), "Đặt nạn nhân nằm ngửa và hồi sức tim phổi", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6724), new Guid("c2d48bf7-05fd-4743-95db-a32c8d53de88"), false, false, null, null, "duoinuoc_main_step_2", 2, "Cứu sống nạn nhân trước khi tới bệnh viện" },
                    { new Guid("eebeef97-4736-476c-99af-dfd4ed9f5255"), "Đặt đầu nạn nhân thấp hơn thân và nâng cao chi gãy", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6638), new Guid("1f7bfe1c-b663-4f08-9713-83394f85319d"), false, true, null, null, "gayxuong_main_step_3", 3, "Giảm đau sưng" },
                    { new Guid("efe5f9c2-9615-41b1-a4db-b229dea17bef"), "Đưa nạn nhân đến cơ sở y tế", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6738), new Guid("c2d48bf7-05fd-4743-95db-a32c8d53de88"), false, true, null, null, "duoinuoc_main_step_4", 4, "Cứu sống nạn nhân trước khi tới bệnh viện" },
                    { new Guid("f160154b-b34a-49f6-89a8-0f80311d0641"), "Đặt nạn nhân nằm nghiêng sang bên trái và đặt cao chân phải ", null, null, null, null, null, null, new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6690), new Guid("b7a6e1f1-75fb-4e26-b6f9-420dd470369d"), false, false, null, null, "cogiat_main_step_2", 2, "Giảm thiểu tổn thương về thần kinh" }
                });

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("01ea28b2-56ff-44e8-883a-ef8890bd426d"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("04e48a25-de79-4a3a-88be-33a8d5829017"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("05eb9523-cbad-4abb-97df-00159d409a78"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("090a2b95-7b45-4600-ad80-dd2853cc9685"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("0cb0d678-9454-4391-bd9e-2b536a50f1f7"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("0e53c113-06cc-4b91-8fd4-d5c62ea70309"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("1645e54a-16db-4c4c-8de9-3d86f1ee1a36"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("16cfebea-d7d0-440d-b4bd-43bbfe6610e0"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b11f26c-7206-48a5-801c-9610b99b5738"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b7a46a0-f703-4dcf-b4f8-66826e128514"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("32475e06-c246-437b-9298-4523809622c2"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("327ca2f9-33cd-421c-b0b2-288582ca465b"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("3fe4bdf1-ebdf-43df-868a-09eb274f6f22"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("41455e11-ec85-4698-9a2d-f57c64a45762"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("46e01fa7-af0b-4d0f-8125-56b5772d191b"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("4b467404-7405-430b-b458-8aacac949a5b"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("4f09916e-7a24-455b-be1e-11340ae4ad68"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("514f5b35-23a3-489f-afc5-9c80511fab60"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5490695b-c2d8-4e4d-92e1-690da77e395d"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5a876ed2-ed72-40a0-b099-a50ba8028dd3"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("61105e2b-b22e-4eb2-897f-941818211986"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("65a9fd83-5d8b-4e25-93b8-4125d1281ab7"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("73a06b9b-83ab-46b1-90e3-3aa6c2773995"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("76d5c903-e2e0-4d17-a3bb-09b6a8ae6cd4"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("791a9161-5dab-4fa6-ad27-6b2694af4e5b"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7b026ebe-11c7-4585-a395-2b42a4489647"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7c35e76d-56b9-4ebe-b66a-63e9ce2e9237"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7c57b22b-c472-419c-ad81-ee87410c36de"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("831c6f2e-7c32-4ae6-8af6-fdb3897c612b"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("8ef3e270-6c5a-4393-9060-de98e98e6e84"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("91a89827-bdc9-4b2b-a318-65735075a8eb"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("995fd02a-9f64-45a5-9424-0ec2c9f891a0"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("9bc401f4-517b-4765-885f-1c480893f229"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("a7247c61-4ce6-478c-8c6f-56df1c72fe1d"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("afcbcbd1-a29a-4647-b7b3-41c1f6fc45f0"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b51c1608-7f38-427d-b4d7-c9cd62ff253e"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b92e56fc-1be9-4973-9254-d9cd74a70414"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("bfe028fa-949f-44c8-95c9-fbb4537114c9"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("c4cce2a8-1b2e-4443-a59e-e4bec4f2fe0a"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("c55d01ce-f82b-4ef4-b9b2-42452d718e50"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("cd0aa7d8-c354-441d-9ed0-ec97d2e91ef2"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ce0ced0c-38e6-4bdb-9d66-e5bfdfdc35ba"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ce2acc73-28a0-4dd4-9368-c71c81a60665"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("d9d4ba6a-da09-4482-bf40-e9f9a216cd03"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ddbc8b2d-b7e7-445f-9a7b-2194f5ab7704"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("e4b92110-7298-48ea-bbe1-1cc21ccfe6b1"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("e9619b3b-a906-4ada-b211-84543a3b31df"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("f6b44c79-92d9-4128-9d6c-40aa134bf0b2"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fd228cde-7079-4d6a-835b-1df8215fa5bb"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fedb71a7-bb4b-441a-b30e-0af28d6d83a3"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("27891a29-9107-45a3-812c-766d52779ab7"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("636af2b3-96fe-4fed-9e59-23c5c5941a14"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("80ee8583-ff0b-49ae-81d2-0e5b0724ade7"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("a2ecd786-f8bd-47f8-8900-be1407c3ccd0"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("cbc76dac-42da-4b4b-807d-aab23b875e93"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e27d22b8-e12d-4906-985c-bcc6a28aeeab"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e5919e2d-642b-46da-980d-ef68f365c0da"),
                column: "Created",
                value: new DateTime(2024, 2, 24, 1, 25, 1, 201, DateTimeKind.Local).AddTicks(6947));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0cff733f-47e0-4656-b356-557d02ef9f9c"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1e9dae67-083c-40a3-9d33-1de20e22c900"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("201cafab-4d18-461e-83db-3f15ad9ba19c"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2162f4cd-abe5-4945-ac9c-49c2e12acc88"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2977fa59-3ebe-407c-b804-42c381020f74"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("299b419b-4894-4d0e-820f-e62774aab8c6"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("29ef856c-1ceb-4ce4-8de0-adebd76d8589"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2b581b39-6ff7-465e-b28d-8e8dbdef52aa"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2de49840-07b0-478c-b045-a46e311bfc2d"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("53ab9697-804f-4492-93c7-cfcf2c975c2a"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5f589b73-6307-4ba1-9b6e-a0aea9dbb10a"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("773c3118-1127-4c00-b8ae-4acf2fff8e84"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7978618a-d7be-4975-8db9-648a435925ce"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9420bbd8-3702-438b-9470-9fa5fff9a0ba"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9951c3aa-3245-4a3b-ae23-26339b08ece0"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a4dca733-6788-469b-9980-6da0759e8089"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aa9d9c94-ce3f-42a2-acff-84f85608748c"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("ac02f0ed-e9be-4cfa-99c8-2aa060954bd9"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b8a7ec77-865b-4864-b52c-e0951b48e322"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b9ea8984-a752-4ac4-8bf2-e30a90e497d0"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("bc5db5fe-b982-44e6-a591-b2596ccd5522"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cd8eb190-a455-4f5f-bc21-8900c829ad46"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("d8f9cc58-73bb-49cb-b8a5-c9693ff067de"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("df288229-2da4-4832-9913-70c1a7e05e8f"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e091b4cd-98f8-4fe3-97ba-9c016c7822e2"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e57daddb-f9b7-483b-b4ab-153957577e7f"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e848a319-5e9a-4dba-975d-8c1e5247a97a"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("eea55b8b-fa03-4ecb-819a-ca9a6f9d43ef"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("eebeef97-4736-476c-99af-dfd4ed9f5255"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("efe5f9c2-9615-41b1-a4db-b229dea17bef"));

            migrationBuilder.DeleteData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("f160154b-b34a-49f6-89a8-0f80311d0641"));

            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "ChuanDoan");

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("2a7ce08a-0967-439a-b0af-d3f0c80197d6"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("58698e2d-fb2a-48c1-b064-085dd11c48d0"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("6e4caa08-8b57-4090-8bb4-3507199e0be3"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("c125f973-8af1-417e-87be-ff5f46ffdf5c"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMfGjjIgehiRJLARe8pBS49p51/AoYO51eugUA7UXx5BtdtAYIZMZ8IkKEyBA27YUw==");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2b729efa-3446-405b-9dc7-059a4c451296"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3a477216-d412-43ca-b05f-653bc84f6609"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("18fff9c2-ff95-454c-9556-02ddfab87c50"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("25ff2950-58ef-4303-8fc7-0e89538a70b2"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("54b8bdd4-b49e-4775-ab42-9ff7b4dd0df6"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("5582c691-4042-40a4-a32b-cde2edcb5fe5"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("72c14f87-15ae-4b85-81d1-005562d806c3"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("a89744ca-73d3-4f08-9548-9cf8af8938fb"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("b8c5cf22-b246-4ca1-b8bf-0f6e7d475027"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("c0daa7c5-4331-44bf-a33e-23679c959b12"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("092cd36a-4a80-48ef-bd7a-f4e3e63871bd"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("0b1820a0-2c22-47ac-80f4-3630863bb890"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("0f3633c8-5e37-4f73-b3f6-35933e195046"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("17617323-50a0-492c-a220-84ea0235735f"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("2ae51909-7baa-4de0-ae83-c13c0498b157"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("2e2c200b-4115-4f49-8516-2a33654c2c00"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("37437d9f-7753-4ee4-a04d-e1ce1651c54f"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("491f2b78-009d-4d2e-8ad7-02c25e44dd95"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("4edc5c6e-daa5-48a5-9f1b-d63ee7eb6fc3"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("59a9e104-7d3b-43a9-afc1-0c58b3ae4016"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("5e3e996b-cf80-46be-93a1-e822fda0d50e"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("689782fb-f292-47fb-9e78-990e92a0e390"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("7ba022bb-325a-4058-a4d9-63892767d7ed"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("8d4a29c0-775f-49f6-9598-5dbfacccced9"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("984f2fb4-d29c-4959-8a52-1f43f3380dba"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("ade4f561-1316-489d-b752-dc042dd5b700"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("af316d79-6367-4029-a241-bf49fa9c0f56"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("bac1c26d-ff9f-4cc7-b4bf-f6009b1c5830"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("d343e947-dbba-4631-9796-9364369efac4"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("e6513d6e-0d42-480c-925f-7bf931f86cd0"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("e71a9882-2634-411f-a74c-3a49ae3989b9"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("eeb8ae18-c9a8-485a-9846-c8647d861dc6"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("81e210f8-9274-44c5-9256-481acce0e8ec"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("edd4ae9e-0e26-4ed4-9812-0fbe587fcdb3"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("1761d6c6-1155-4534-8d44-9362db753a9a"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("2f55aa8b-e887-4808-9e18-7c6556464f16"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("481abb77-ebd3-47b0-9e9f-718368076074"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5ef458ed-6776-43b4-ba9d-9cc9c47d7511"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7aa3b055-2b09-4d6a-82e0-89e75a365940"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("807ebc7e-3f10-4c2e-b8b2-138b20a314cc"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("842765e5-aec9-402e-93cd-3f3bb3998608"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c672ebe0-2a8e-4a0e-b21f-f70e0d87efa2"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3db0b18-003a-4046-873b-264d3498360c"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("0d085bfa-8d7e-496b-b86e-ff4f60198269"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1822976f-01d7-4a12-ba20-46e5004cc71c"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f04befb-e7a8-4c34-87fe-5a61795fdc2a"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f7bfe1c-b663-4f08-9713-83394f85319d"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("231d86a8-97cb-4b12-b734-4c72fd8e6c67"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("280f5a0e-0379-4b8e-a09d-aacda21cddaf"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("39047891-ae02-4927-849b-a950f85f4480"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("3ba5c72a-2843-4dd8-a958-f008a6bff38b"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("46f2f761-1478-44fd-adae-ff50940ea9aa"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("48ae3bff-69b9-49f6-ad3e-e7408e44c081"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("4de6137f-63c7-4e2b-876c-f6084cadd849"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("52a8aef1-343c-41e0-a97b-6e63fc1afb5d"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("558f2622-5ba7-4f13-8086-b7bf91970fa0"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6a30dbfe-0c1c-4d34-b968-52bf9dabb48e"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6ad7ebcd-55b2-419c-ab60-8fcd257c3e1a"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a1969abb-e4ea-4f53-8ce2-e13136591218"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a89d9710-d2c2-4327-a604-d97ba4a99d4f"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b2590647-632f-48bb-adee-5cd6b9a5fb7f"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b7a6e1f1-75fb-4e26-b6f9-420dd470369d"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b8055c5b-a7fe-4d1b-8fbc-5ebd33fac035"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("bd166379-995b-449d-b381-db1fd362be0c"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c2d48bf7-05fd-4743-95db-a32c8d53de88"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c813800b-ba50-4270-b3a6-9313e7884646"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("cdd95a29-4f65-487a-ae60-2f043c4c63f8"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d16ccff2-a7a8-4b9a-80fd-dd8b37aeb3b7"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d390145b-b53a-4ccc-afe3-bb9b218332c0"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("e6e9f4ca-33ec-4df4-a15f-bb69c61a4691"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("ef525797-2ec8-405e-9eb9-826b621fe47a"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5c43ff6a-1903-4fdc-911b-52e32cbe3633"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5dca6c16-f112-4517-8655-3b03cfb7a716"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("76b241ee-7275-4449-ad4d-6813ac2c112a"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("93aeda91-ae3c-448a-bb89-497f28256563"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("a403ff66-6735-4516-ae28-23de65c52cea"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0e4ebaac-a0e4-4aa8-8d6c-6eefa8dc4d63"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1262623d-475a-4015-bc55-282650e90cde"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1aedfbb6-ef6c-40c3-b5e0-8c11ae6157e4"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("294142fc-8261-4d46-b670-5301cd5ce420"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("350bcba3-0e35-448a-b6a3-0da6d377e80e"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40e1f63e-7e31-4466-bd67-7aee4c28dd7f"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5074c5aa-b04b-41df-89a2-3177705c1a57"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51328c0e-fefd-4cf0-8407-9dd7e2e7afc4"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51b70068-3066-4e06-a5ba-bf3cf1d9639f"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("64d9b4f9-b12a-4c66-9b12-e1f79e4b7878"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7f0b42f9-0602-4a55-b9d8-ced88911e477"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("89c531da-3abc-4859-8337-408d8d556d06"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8df4266c-fd44-4e86-8cf0-f030ca219e71"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a0ae585b-182f-4df1-b596-429571d81c3d"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a29dae04-810f-4034-aad7-e293a28047aa"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aaa16c5a-126a-43fe-921e-d856958c576b"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("abac6286-767d-4baa-bc63-2fcc3e70a48e"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b07906a8-521b-4970-a421-2cc61520f749"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b7667346-a9df-4869-8ee4-814e44426b77"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cc4601b6-d9f9-4094-bc57-7105aa236761"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e73411bc-d4d7-4801-bdd9-d7df984b01aa"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("01ea28b2-56ff-44e8-883a-ef8890bd426d"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("04e48a25-de79-4a3a-88be-33a8d5829017"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("05eb9523-cbad-4abb-97df-00159d409a78"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("090a2b95-7b45-4600-ad80-dd2853cc9685"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("0cb0d678-9454-4391-bd9e-2b536a50f1f7"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("0e53c113-06cc-4b91-8fd4-d5c62ea70309"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("1645e54a-16db-4c4c-8de9-3d86f1ee1a36"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("16cfebea-d7d0-440d-b4bd-43bbfe6610e0"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b11f26c-7206-48a5-801c-9610b99b5738"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b7a46a0-f703-4dcf-b4f8-66826e128514"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("32475e06-c246-437b-9298-4523809622c2"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("327ca2f9-33cd-421c-b0b2-288582ca465b"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("3fe4bdf1-ebdf-43df-868a-09eb274f6f22"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("41455e11-ec85-4698-9a2d-f57c64a45762"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("46e01fa7-af0b-4d0f-8125-56b5772d191b"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("4b467404-7405-430b-b458-8aacac949a5b"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("4f09916e-7a24-455b-be1e-11340ae4ad68"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("514f5b35-23a3-489f-afc5-9c80511fab60"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5490695b-c2d8-4e4d-92e1-690da77e395d"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5a876ed2-ed72-40a0-b099-a50ba8028dd3"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("61105e2b-b22e-4eb2-897f-941818211986"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("65a9fd83-5d8b-4e25-93b8-4125d1281ab7"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("73a06b9b-83ab-46b1-90e3-3aa6c2773995"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("76d5c903-e2e0-4d17-a3bb-09b6a8ae6cd4"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("791a9161-5dab-4fa6-ad27-6b2694af4e5b"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7b026ebe-11c7-4585-a395-2b42a4489647"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7c35e76d-56b9-4ebe-b66a-63e9ce2e9237"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7c57b22b-c472-419c-ad81-ee87410c36de"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("831c6f2e-7c32-4ae6-8af6-fdb3897c612b"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("8ef3e270-6c5a-4393-9060-de98e98e6e84"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("91a89827-bdc9-4b2b-a318-65735075a8eb"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("995fd02a-9f64-45a5-9424-0ec2c9f891a0"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("9bc401f4-517b-4765-885f-1c480893f229"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("a7247c61-4ce6-478c-8c6f-56df1c72fe1d"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("afcbcbd1-a29a-4647-b7b3-41c1f6fc45f0"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b51c1608-7f38-427d-b4d7-c9cd62ff253e"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b92e56fc-1be9-4973-9254-d9cd74a70414"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("bfe028fa-949f-44c8-95c9-fbb4537114c9"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("c4cce2a8-1b2e-4443-a59e-e4bec4f2fe0a"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("c55d01ce-f82b-4ef4-b9b2-42452d718e50"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("cd0aa7d8-c354-441d-9ed0-ec97d2e91ef2"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ce0ced0c-38e6-4bdb-9d66-e5bfdfdc35ba"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ce2acc73-28a0-4dd4-9368-c71c81a60665"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("d9d4ba6a-da09-4482-bf40-e9f9a216cd03"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ddbc8b2d-b7e7-445f-9a7b-2194f5ab7704"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("e4b92110-7298-48ea-bbe1-1cc21ccfe6b1"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("e9619b3b-a906-4ada-b211-84543a3b31df"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("f6b44c79-92d9-4128-9d6c-40aa134bf0b2"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fd228cde-7079-4d6a-835b-1df8215fa5bb"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fedb71a7-bb4b-441a-b30e-0af28d6d83a3"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("27891a29-9107-45a3-812c-766d52779ab7"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("636af2b3-96fe-4fed-9e59-23c5c5941a14"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("80ee8583-ff0b-49ae-81d2-0e5b0724ade7"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("a2ecd786-f8bd-47f8-8900-be1407c3ccd0"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("cbc76dac-42da-4b4b-807d-aab23b875e93"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e27d22b8-e12d-4906-985c-bcc6a28aeeab"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e5919e2d-642b-46da-980d-ef68f365c0da"),
                column: "Created",
                value: new DateTime(2024, 2, 22, 15, 32, 6, 195, DateTimeKind.Local).AddTicks(2421));
        }
    }
}
