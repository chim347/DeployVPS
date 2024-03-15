using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinhChiDoiSOS.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabaseEdit1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("0c6e6de9-838a-48d0-8471-94d678dbf27c"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("1229e46b-66e9-4505-8176-5f4bfcc8adb9"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("53bbf75d-0c85-4c8d-b7f0-7fe99ed0413b"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("5dfb42c9-2604-47ed-a833-167189317b12"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("71b8b4a0-f541-45bf-80f7-aea7a0f040d5"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("849f1104-106c-4ab8-8391-3e9df2601e76"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("90cf7f86-ea9e-404d-ad3a-6979363c2c86"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("aac28861-b78b-4117-88f5-2394cd3f5417"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("ab7ae2f2-b418-4a28-a90d-2ec935803963"));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("2a7ce08a-0967-439a-b0af-d3f0c80197d6"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("58698e2d-fb2a-48c1-b064-085dd11c48d0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("6e4caa08-8b57-4090-8bb4-3507199e0be3"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("c125f973-8af1-417e-87be-ff5f46ffdf5c"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAuQIJ0K24C2eSRO5j7rSMBsWo7uQLpcCJnwPjCTJ7/0GmnAd4gRP2zHKKtF1ghtrw==");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2b729efa-3446-405b-9dc7-059a4c451296"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3a477216-d412-43ca-b05f-653bc84f6609"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("18fff9c2-ff95-454c-9556-02ddfab87c50"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7593));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("25ff2950-58ef-4303-8fc7-0e89538a70b2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("54b8bdd4-b49e-4775-ab42-9ff7b4dd0df6"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("5582c691-4042-40a4-a32b-cde2edcb5fe5"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("72c14f87-15ae-4b85-81d1-005562d806c3"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("a89744ca-73d3-4f08-9548-9cf8af8938fb"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("b8c5cf22-b246-4ca1-b8bf-0f6e7d475027"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("c0daa7c5-4331-44bf-a33e-23679c959b12"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("092cd36a-4a80-48ef-bd7a-f4e3e63871bd"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8129), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F10.png?alt=media&token=326aa412-9ffd-4a44-ae1a-8e6381571c96" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("0b1820a0-2c22-47ac-80f4-3630863bb890"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8113), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F6.png?alt=media&token=c5ed7f55-00a5-4e1d-9392-2e8d74366f11" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("0f3633c8-5e37-4f73-b3f6-35933e195046"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8121), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F8.png?alt=media&token=23a73921-2c42-430d-9d81-9891d5d4c421" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("17617323-50a0-492c-a220-84ea0235735f"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8153), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F17.png?alt=media&token=5abfa254-9207-401f-a0c7-e26a8dd21758" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("2ae51909-7baa-4de0-ae83-c13c0498b157"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8138), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F13.png?alt=media&token=87ec19fe-4d4c-4a31-b483-4edd092b37ca" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("2e2c200b-4115-4f49-8516-2a33654c2c00"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8160), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F19.png?alt=media&token=6063eac6-6089-4c1e-b8dc-c3462f6f614d" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("37437d9f-7753-4ee4-a04d-e1ce1651c54f"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8101), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F5.png?alt=media&token=fef3d98d-4a75-43e8-a646-90f6ce108eb2" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("491f2b78-009d-4d2e-8ad7-02c25e44dd95"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8135), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F12.png?alt=media&token=aac969a3-f28e-4835-ad03-664e1a6bcc3f" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("4edc5c6e-daa5-48a5-9f1b-d63ee7eb6fc3"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8167), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F21.png?alt=media&token=9e29f660-da22-4402-a06c-399e2daea67c" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("59a9e104-7d3b-43a9-afc1-0c58b3ae4016"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8143), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F14.png?alt=media&token=cfc0e696-e3c0-4bb7-8c3e-06278e059fac" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("5e3e996b-cf80-46be-93a1-e822fda0d50e"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8116), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F7.png?alt=media&token=75541064-4a88-4d7b-bad7-6d0d889d78a1" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("689782fb-f292-47fb-9e78-990e92a0e390"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8097), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F4.png?alt=media&token=8e16723e-692c-4d85-ad9d-9c2bae33b4f8" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("7ba022bb-325a-4058-a4d9-63892767d7ed"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8173), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F22.png?alt=media&token=5ed305ab-386a-4c35-ac2b-7707d09780f9" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("8d4a29c0-775f-49f6-9598-5dbfacccced9"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8090), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F2.png?alt=media&token=9124ffdd-26cf-4702-b5af-f9b6a22e3d5a" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("984f2fb4-d29c-4959-8a52-1f43f3380dba"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8093), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F3.png?alt=media&token=01ae1758-b877-4044-bd95-984962050222" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("ade4f561-1316-489d-b752-dc042dd5b700"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8149), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F16.png?alt=media&token=7ce38317-edbf-4419-b2d5-757aa307880e" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("af316d79-6367-4029-a241-bf49fa9c0f56"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8125), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F9.png?alt=media&token=0a7613e0-d0bd-4b64-9cd4-6db423f75e39" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("bac1c26d-ff9f-4cc7-b4bf-f6009b1c5830"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8157), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F18.png?alt=media&token=a53f2edb-e9c2-48fb-ba1b-239e3f4ecf7f" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("d343e947-dbba-4631-9796-9364369efac4"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8146), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F15.png?alt=media&token=6aeac7f1-056f-42ac-b42f-df01d35ace77" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("e6513d6e-0d42-480c-925f-7bf931f86cd0"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8164), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F20.png?alt=media&token=f2764426-42d0-48b8-abc4-1a0e0e5a7cb8" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("e71a9882-2634-411f-a74c-3a49ae3989b9"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8083), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F1.png?alt=media&token=b8507450-c048-4ca1-8ded-0bb0f9d8ee43" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("eeb8ae18-c9a8-485a-9846-c8647d861dc6"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(8132), "https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/ChuanDoan%2F11.png?alt=media&token=19fdb013-bb67-4c08-a1df-a45811cdd546" });

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("81e210f8-9274-44c5-9256-481acce0e8ec"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("edd4ae9e-0e26-4ed4-9812-0fbe587fcdb3"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("1761d6c6-1155-4534-8d44-9362db753a9a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("2f55aa8b-e887-4808-9e18-7c6556464f16"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("481abb77-ebd3-47b0-9e9f-718368076074"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5ef458ed-6776-43b4-ba9d-9cc9c47d7511"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7aa3b055-2b09-4d6a-82e0-89e75a365940"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("807ebc7e-3f10-4c2e-b8b2-138b20a314cc"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("842765e5-aec9-402e-93cd-3f3bb3998608"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c672ebe0-2a8e-4a0e-b21f-f70e0d87efa2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3db0b18-003a-4046-873b-264d3498360c"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.InsertData(
                table: "CourseDetail",
                columns: new[] { "Id", "Conlusion", "Content", "CourseId", "CreateBy", "Created", "ImageUrl", "IsDelete", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("08193f04-b021-4098-b897-e066567469d1"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\nHướng Dẫn Vận Chuyển Người Bệnh An Toàn Trong Mọi Tình Huống\r\n    </h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Việc vận chuyển người bệnh là một phần quan trọng trong sơ cứu và chăm sóc y tế. Tuy nhiên, nếu không thực hiện đúng cách, nó có thể gây ra thêm tổn thương và biến chứng cho người bệnh. Trong bài viết này, chúng ta sẽ tìm hiểu về cách vận chuyển người bệnh một cách an toàn và hiệu quả trong mọi tình huống.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://baoquangbinh.vn/dataimages/202107/original/images704000_cc3.jpg\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n1. Đánh Giá Tình Hình\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trước khi vận chuyển bất kỳ người bệnh nào, hãy đánh giá tình hình và quyết định liệu có cần gọi xe cấp cứu hay không. Nếu không có xe cấp cứu, đảm bảo rằng bạn có đủ sự trang bị và kiến thức để vận chuyển một cách an toàn.\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n2. Chuẩn Bị Môi Trường\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nĐảm bảo không gian vận chuyển rộng rãi và an toàn.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nLoại bỏ các vật dụng nguy hiểm khỏi lối đi.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nLàm cho không gian thoáng đãng và dễ dàng tiếp cận.\r\n        </p>\r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n3. Sử Dụng Kỹ Thuật Đúng\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nSử dụng các kỹ thuật vận chuyển như chuyển lên giường, ghế hoặc xe lăn một cách cẩn thận và nhẹ nhàng.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nLuôn sử dụng tư thế bảo vệ cho cơ thể của người bệnh, đặc biệt là đầu, cổ và cột sống.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nSử dụng hỗ trợ bổ sung như gối, băng cố định và dây đai an toàn nếu cần thiết.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n4. Giao Tiếp Và Động Viên\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nLuôn giữ liên lạc với người bệnh và cung cấp sự động viên và an ủi.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nGiải thích mọi động tác và kế hoạch di chuyển trước khi thực hiện.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n5. Sự Theo Dõi Sau Khi Vận Chuyển\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nSau khi đặt người bệnh vào vị trí mới, đảm bảo rằng họ đang cảm thấy thoải mái và không gặp phải bất kỳ vấn đề nào.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nKiểm tra các dấu hiệu và triệu chứng có thể báo hiệu về tình trạng tồn tại hoặc mới.\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Việc vận chuyển người bệnh đòi hỏi sự chuẩn bị kỹ lưỡng, kiến thức và kỹ năng. Quan trọng nhất là phải luôn đặt sự an toàn và thoải mái của người bệnh lên hàng đầu. Hy vọng rằng với những hướng dẫn trên, bạn sẽ có thêm niềm tin và kiến thức để vận chuyển người bệnh một cách an toàn và hiệu quả trong mọi tình huống.\r\n        </p>\r\n    </div>\r\n</div>\r\n", new Guid("5ef458ed-6776-43b4-ba9d-9cc9c47d7511"), null, new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7353), null, false, null, null, null },
                    { new Guid("394ba278-843d-41b7-aa95-8148a2e36f7e"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n        <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n            5 Cách Phát Ra Tín Hiệu Cầu Cứu Hiệu Quả Trong Tình Huống Khẩn Cấp\r\n        </h1>\r\n        <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">Kiến thức Sơ cấp cứu</p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong một tình huống khẩn cấp, khả năng phát ra tín hiệu cầu cứu có thể là yếu tố quyết định giữa sự sống và\r\n            cái chết. Tuy nhiên, không phải ai cũng biết cách phát ra tín hiệu cầu cứu một cách hiệu quả. Trong bài viết\r\n            này, chúng ta sẽ khám phá 5 cách phát ra tín hiệu cầu cứu mà bạn nên biết để có thể thu hút sự chú ý và giúp\r\n            đỡ trong một tình huống khẩn cấp.\r\n        </p>\r\n        <img\r\n            style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n            src=\"https://e.khoahoc.tv/photos/image/2015/07/01/SOS_2.jpg\"\r\n            alt=\"svg\"\r\n        />\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">1. Tiếng Hét Lớn</p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Một trong những cách phổ biến nhất để phát ra tín hiệu cầu cứu là hét lớn. Hãy hét càng to càng tốt để\r\n                thu hút sự chú ý của người xung quanh và gửi đi tín hiệu rằng bạn đang gặp vấn đề và cần sự giúp đỡ.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                2. Sử Dụng Còi Cứu Hộ\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Mang theo một còi cứu hộ là một ý tưởng tốt để có thể phát ra tín hiệu cầu cứu một cách nhanh chóng và\r\n                dễ dàng. Khi gặp phải tình huống khẩn cấp, bạn chỉ cần thổi vào còi một cách mạnh mẽ để thu hút sự chú ý\r\n                của người xung quanh.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                3. Sử Dụng Đèn Pin\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Trong tình huống mà việc gọi cầu cứu bằng tiếng không hiệu quả, việc sử dụng đèn pin có thể là một\r\n                phương tiện hiệu quả khác để thu hút sự chú ý của người xung quanh, đặc biệt là vào ban đêm hoặc trong\r\n                điều kiện ánh sáng yếu.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                4. Sử Dụng Gương Soi Ánh Sáng Mặt Trời\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nếu bạn bị mắc kẹt và không thể di chuyển, việc sử dụng một chiếc gương nhỏ hoặc vật phản quang để soi\r\n                ánh sáng mặt trời có thể là một cách hiệu quả để phát ra tín hiệu cầu cứu và thu hút sự chú ý của người\r\n                đi ngang qua.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                5. Sử Dụng Biểu Tượng Cầu Cứu Quốc Tế\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nếu bạn có một biểu tượng cầu cứu quốc tế như biểu tượng SOS, bạn có thể sử dụng nó để tạo ra tín hiệu\r\n                cầu cứu và gửi đi thông điệp rằng bạn đang cần sự giúp đỡ khẩn cấp.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">Kết luận</p>\r\n        </div>\r\n\r\n        <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Biết cách phát ra tín hiệu cầu cứu là một kỹ năng quan trọng và có thể cứu sống trong một tình huống\r\n                khẩn cấp. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để\r\n                thực hiện điều này một cách an toàn và hiệu quả. Hãy nhớ, sự chuẩn bị và kiến thức là chìa khóa cho mọi\r\n                sự thành công trong tình huống khẩn cấp.\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n", new Guid("1761d6c6-1155-4534-8d44-9362db753a9a"), null, new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7378), null, false, null, null, null },
                    { new Guid("46423e7d-edfa-4707-a488-3d65f68429a7"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n       Tư Thế Nằm Nghiêng An Toàn Trong Sơ Cấp Cứu: Biết Để Bảo Vệ Bản Thân và Người Khác\r\n    </h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Nhắc đến sơ cấp cứu, việc biết cách giữ tư thế nằm nghiêng an toàn có thể là yếu tố quyết định giữa sự cứu chữa thành công và biến chứng nghiêm trọng. Trong bài viết này, chúng ta sẽ tìm hiểu về các tư thế nằm nghiêng cơ bản mà bạn có thể áp dụng trong các trường hợp khẩn cấp.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://suckhoe123.vn/uploads/suc-khoe/2021_05/20200424_172336_448622_nghieng.max-1800x1800.jpg\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            Tại sao Tư Thế Nằm Nghiêng Quan Trọng?\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong một số trường hợp, đặc biệt là khi có nguy cơ nôn mửa hoặc hít phải chất lỏng, máu hoặc cơ hội nằm nghiêng có thể ngăn chặn việc phụt ngược chất lỏng vào đường hô hấp, giữ cho đường thoát khí mở rộng và giảm áp lực lên cổ và phổi.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nCách Thực Hiện Tư Thế Nằm Nghiêng\r\n        </p>\r\n    </div>\r\n\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n1. Tư Thế Nằm Nghiêng Đơn Giản:\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            - Đặt người bệnh nằm sấp và kéo một chân về phía trên.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Đặt một bộ phận dưới đầu để giữ cho đầu của họ nghiêng về một bên.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Đảm bảo đầu và cổ của họ đều ở vị trí tự nhiên.\r\n        </p>\r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            2. Tư Thế Nằm Nghiêng Phức Tạp:\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            - Đặt người bệnh nằm sấp.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Đặt một tấm gối hoặc đối vật cứng dưới người bệnh từ dưới đầu đến dưới đùi của họ.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Kéo một chân của họ về phía trên và đặt gối hoặc chăn dưới chân để giữ cho cơ thể họ nghiêng.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Giữ đầu và cổ của họ trong một tư thế tự nhiên.\r\n        </p>\r\n\r\n    </div>\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Lưu Ý Quan Trọng\r\nLuôn Giữ Đầu và Cổ Trong Tư Thế Tự Nhiên: Đảm bảo rằng đầu và cổ của người bệnh luôn được giữ trong một tư thế tự nhiên và không bị ép vào bất kỳ hướng nào khi thực hiện tư thế nằm nghiêng.\r\nTheo Dõi Tình Trạng Của Người Bệnh: Luôn lưu ý đến các biểu hiện của người bệnh và sẵn sàng điều chỉnh tư thế nếu cần thiết.\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n", new Guid("f3db0b18-003a-4046-873b-264d3498360c"), null, new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7349), null, false, null, null, null },
                    { new Guid("5b9d9094-1cb2-4c95-88b2-543dfceede16"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\nSơ Cứu Cho Thao Tác Heimlich: Biết Cách Cứu Mạng Trong Trường Hợp Hóc Thức Ăn\r\n</h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Trong tình huống khẩn cấp khi một người đang bị hóc thức ăn và không thể nói hoặc thở, thao tác Heimlich là một kỹ năng cứu mạng quan trọng. Trong bài viết này, chúng ta sẽ tìm hiểu cách thực hiện thao tác Heimlich một cách đúng đắn để cứu mạng cho người đang bị hóc.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://www.topontiki.gr/wp-content/uploads/2023/08/Untitled-design-2023-08-14T190744.334.jpg\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n1. Đánh Giá Tình Hình\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\"> \r\nTrước tiên, hãy đảm bảo rằng người đó thực sự đang bị hóc thức ăn và không thể nói hoặc thở. Nếu họ vẫn có thể nói hoặc ho thở, họ có thể tự giải quyết vấn đề và bạn chỉ cần đề xuất họ làm theo.\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n2. Thực Hiện Thao Tác Heimlich\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Đứng phía sau: Đứng phía sau người bị hóc, đặt một chân giữa chân họ để tạo sự ổn định.        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Bám vào phía sau: Đặt một bàn tay lớn vào phía trên của hốc ngực của họ, đặt còn lại vào phía dưới, trên phần dưới của lồng ngực.\r\n        </p>\r\n<p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Thực hiện cú đẩy: Đẩy mạnh và nhanh chóng vào trong và lên trên, hướng ra phía trên, nhưng không đặt quá cao lên phần xương sườn.\r\n        </p>\r\n<p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Lặp lại nếu cần thiết: Lặp lại cú đẩy cho đến khi vật thể bị hóc được thải ra hoặc cho đến khi đội cứu hộ đến.\r\n        </p>\r\n    \r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n3. Sự Theo Dõi Và Hỗ Trợ Sau Khi Thực Hiện\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nTheo dõi người bị hóc cho đến khi họ hoàn toàn ổn định.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nNếu người bị hóc mất ý thức hoặc ngừng hô hấp, thực hiện CPR ngay lập tức.\r\n        </p>\r\n       \r\n    </div>\r\n    \r\n   \r\n  \r\n<div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nKết luận\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n           Thao tác Heimlich là một kỹ năng cứu mạng quan trọng mà mọi người nên biết. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để thực hiện thao tác Heimlich một cách an toàn và hiệu quả trong trường hợp cần thiết. Hãy nhớ, sự chuẩn bị và kiến thức là chìa khóa cho mọi sự thành công trong sơ cứu.\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n", new Guid("7aa3b055-2b09-4d6a-82e0-89e75a365940"), null, new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7364), null, false, null, null, null },
                    { new Guid("942a5f4a-d695-4f9c-80bb-e9a56197ac2d"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n        <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n            10 Cách Thắt Nút Dây Cơ Bản Mà Bạn Nên Biết\r\n        </h1>\r\n        <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">Kiến thức Sơ cấp cứu</p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Thắt nút là một trong những kỹ năng cơ bản mà ai cũng nên biết, không chỉ trong các hoạt động dã ngoại mà\r\n            còn trong cuộc sống hàng ngày. Từ việc thắt dây giày đến thắt dây dẹt trên thùng đồ, việc biết cách thắt nút\r\n            một cách đúng đắn có thể giúp bạn giữ dây chặt chẽ và an toàn. Trong bài viết này, chúng ta sẽ khám phá 10\r\n            cách thắt nút dây cơ bản mà bạn nên biết.\r\n        </p>\r\n        <img\r\n            style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n            src=\"https://chuyendaychi.com/wp-content/uploads/2018/05/n%C3%BAt-th%E1%BA%AFt-d%C3%A2y-th%E1%BA%A3-di%E1%BB%81u.jpg\"\r\n            alt=\"svg\"\r\n        />\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                1. Nút Dây Dẹt (Overhand Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây dẹt là một trong những nút đơn giản nhất và được sử dụng phổ biến trong cuộc sống hàng ngày. Đây\r\n                là cách thắt nút cơ bản nhất để ngăn dây khỏi tự lỏng ra.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                2. Nút Dây Buộc (Square Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buộc là một trong những nút được sử dụng rộng rãi để nối hai đoạn dây lại với nhau một cách chắc\r\n                chắn và an toàn.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                3. Nút Dây Chặn (Slip Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây chặn là một loại nút có thể điều chỉnh kích thước và được sử dụng để buộc dây một cách nhanh\r\n                chóng và dễ dàng.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                4. Nút Dây Leo Cây (Clove Hitch)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây leo cây là một nút linh hoạt được sử dụng để buộc dây vào một vật thể tròn như cây hoặc ống.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                5. Nút Dây Buông (Bowline Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buông là một trong những nút an toàn nhất để tạo ra một lỗ hoặc vòng không bao giờ tự động co\r\n                lại.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                6. Nút Dây Buộc Gói (Package Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buộc gói là một loại nút được sử dụng để buộc chặt các gói hàng hoặc túi.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                7. Nút Dây Buộc Dính (Sheet Bend)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buộc dính là một cách tốt để nối hai đoạn dây có đường kính khác nhau lại với nhau một cách chắc\r\n                chắn.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                8. Nút Dây Leo Núi (Figure Eight Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây leo núi là một loại nút được sử dụng rộng rãi trong leo núi và leo dã ngoại vì nó giữ dây chắc\r\n                chắn và không bao giờ tự động co lại.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                9. Nút Dây Buộc Thuyền (Anchor Hitch)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buộc thuyền là một nút đơn giản được sử dụng để buộc dây vào một đinh, cột hoặc vật thể tương\r\n                tự.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                10. Nút Dây Đồng Đều (Trucker's Hitch)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây đồng đều là một cách tốt để tạo ra một vòng đeo chắc chắn và được sử dụng rộng rãi trong việc\r\n                buộc chặt và cố định hàng hoặc dụng cụ.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">Kết luận</p>\r\n        </div>\r\n\r\n        <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Biết cách thắt nút là một kỹ năng quan trọng và hữu ích trong mọi tình huống. Hy vọng rằng bài viết này\r\n                đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để thực hiện các loại nút cơ bản một cách\r\n                an toàn và hiệu quả. Hãy thực hành thường xuyên để trở thành một chuyên gia thực sự trong việc thắt nút!\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n", new Guid("842765e5-aec9-402e-93cd-3f3bb3998608"), null, new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7371), null, false, null, null, null },
                    { new Guid("b0296068-1b95-473f-afb8-d4ad07bb1bc6"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\nCPR - Kỹ Năng Hồi Sinh Tim Phổi Cơ Bản Mà Mọi Người Cần Biết    </h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Trong một tình huống khẩn cấp khi người khác đột ngột gặp phải ngừng tim phổi, kỹ năng CPR (Cardiopulmonary Resuscitation) - hồi sinh tim phổi là một kỹ năng quan trọng có thể cứu mạng. Trong bài viết này, chúng ta sẽ tìm hiểu về CPR cơ bản và cách thực hiện nó một cách hiệu quả.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://th.bing.com/th/id/R.3c96bb6b124829db33aa812a1814ee9d?rik=dnxzH5j9nJ0rnw&pid=ImgRaw&r=0\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nCPR là gì?\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            CPR là quá trình cung cấp áp lực hồi sinh tim phổi thông qua việc nén tim và cung cấp hơi thở nhân tạo, nhằm duy trì lưu lượng máu và ôxy đến não và các cơ quan quan trọng khác.\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nBước 1: Kiểm Tra An Toàn\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nKiểm tra khu vực xung quanh để đảm bảo an toàn cho bản thân và người bệnh.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nGọi cấp cứu nếu có sẵn.\r\n        </p>\r\n    \r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nBước 2: Kiểm Tra Tình Trạng\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nGọi lên và kiểm tra phản ứng của người bệnh.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nKiểm tra hơi thở và dấu hiệu sống\r\n        </p>\r\n       \r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nBước 3: Báo Cáo Và Bắt Đầu CPR\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nNếu người bệnh không hít thở và không có nhịp tim, bắt đầu CPR ngay lập tức.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nNén tim: Đặt lòng bàn tay ở giữa ngực, nén tim khoảng 5-6cm sâu với tần suất khoảng 100-120 lần mỗi phút.\r\n        </p>\r\n<p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nHơi thở nhân tạo: Thực hiện 2 hơi thở nhân tạo với miệng che miệng và mũi người bệnh.\r\n        </p>\r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nBước 4: Tiếp Tục CPR\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nTiếp tục lặp lại chu trình nén tim và hơi thở cho đến khi cứu thương viên đến hoặc người bệnh hồi phục.\r\n        </p>\r\n    </div>\r\n</div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nLưu Ý Quan Trọng\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nThực hiện CPR một cách nhanh chóng và mạnh mẽ, nhưng đồng thời cẩn thận để tránh gây tổn thương.\r\nĐảm bảo bạn đã được đào tạo và tự tin trước khi thực hiện CPR trên người bệnh.\r\n        </p>\r\n    </div>\r\n<div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nKết luận\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            CPR là một kỹ năng quan trọng mà ai cũng nên biết, vì nó có thể là yếu tố quyết định giữa sự sống và cái chết trong một tình huống khẩn cấp. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan về CPR và cung cấp thông tin cần thiết để bạn có thể thực hiện nó một cách hiệu quả khi cần thiết. Hãy nhớ, một phút cứu mạng có thể phát huy tác dụng lớn!\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n", new Guid("481abb77-ebd3-47b0-9e9f-718368076074"), null, new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7357), null, false, null, null, null },
                    { new Guid("bd37c5d4-b8aa-496f-93eb-d3d67095046d"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n        Nguyên Tắc An Toàn Trong Sơ Cứu: Bảo Vệ Sức Khỏe Mọi Người\r\n    </h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Sơ cứu là một kỹ năng cơ bản mà mỗi người nên biết, vì nó có thể giữ lại mạng sống cho người khác trong những tình huống khẩn cấp. Tuy nhiên, sự hiểu biết về những nguyên tắc an toàn trong quá trình thực hiện sơ cứu cũng quan trọng không kém. Dưới đây là những nguyên tắc quan trọng cần tuân thủ để đảm bảo an toàn cho cả người cứu thương lẫn người bị nạn.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/SoCapCuu%2Fsocapcuu.jpg?alt=media&token=8f3138c9-174e-4933-867e-c4ae18095c1f\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            1. Bảo Vệ Bản Thân Đầu Tiên\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Khi đối mặt với tình huống sơ cứu, quyết định đầu tiên và quan trọng nhất là bảo vệ chính bạn. Đảm bảo rằng không có nguy hiểm nào tiếp tục tồn tại trước khi tiếp cận người bị nạn. Đeo bảo hộ cá nhân nếu có thể, và luôn đánh giá an toàn cho cả mình và người xung quanh.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            2. Gọi Cấp Cứu Trước Khi Hành Động\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trước khi bắt đầu thực hiện bất kỳ biện pháp sơ cứu nào, việc gọi đến số điện thoại cấp cứu là điều quan trọng. Cung cấp thông tin chi tiết về tình hình và tuân theo hướng dẫn từ bác sĩ điều phối giúp đảm bảo có kế hoạch chăm sóc y tế chính xác và nhanh chóng.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            3. Đánh Giá An Toàn Của Môi Trường\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trước khi tiếp cận nạn nhân, hãy đánh giá môi trường xung quanh để đảm bảo an toàn cho cả người cứu thương và người bị nạn. Loại bỏ các nguy cơ tiềm ẩn như lửa, điện áp cao, hoặc vật dụng gây nguy hiểm.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            4. Động Tác Nhẹ Nhàng và Hiệu Quả\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong quá trình thực hiện sơ cứu, hãy luôn tuân thủ nguyên tắc \"động tác nhẹ nhàng\". Tránh gây thêm tổn thương cho nạn nhân và chỉ thực hiện những biện pháp mà bạn đã được đào tạo. Sự nhẹ nhàng kết hợp với hiệu quả sẽ giúp giảm nguy cơ gặp phải tác động phụ không mong muốn.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            5. Đề Xuất Giúp Đỡ Từ Người Xung Quanh\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong một tình huống khẩn cấp, không ngần ngại hỏi xem có ai khác có kỹ năng sơ cứu hay không. Sự hợp tác giữa mọi người có thể tăng khả năng cứu sống và giảm áp lực cho người cứu thương chính.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Nhớ rằng, việc thực hiện sơ cứu không chỉ là về việc cứu sống mà còn là về cách làm đúng để đảm bảo an toàn cho tất cả mọi người liên quan. Hãy hiểu rõ và áp dụng những nguyên tắc an toàn này để sẵn sàng đối mặt với mọi tình huống khẩn cấp một cách hiệu quả và an toàn.\r\n        </p>\r\n    </div>\r\n</div>\r\n", new Guid("2f55aa8b-e887-4808-9e18-7c6556464f16"), null, new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7344), null, false, null, null, null },
                    { new Guid("cb519716-88d0-4210-a5e9-53bef3d6021c"), null, "    <div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n        <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n            Bí Quyết Xác Định Phương Hướng Bằng Lá Cây: Kỹ Năng Sinh Tồn Cơ Bản\r\n        </h1>\r\n        <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">Kiến thức Sơ cấp cứu</p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong các tình huống khẩn cấp hoặc khi bị lạc trong thiên nhiên, việc biết cách xác định phương hướng có thể\r\n            là yếu tố quyết định giữa sự sống và cái chết. Mặc dù hiện đại có nhiều công nghệ giúp xác định hướng, nhưng\r\n            việc sử dụng các phương tiện tự nhiên như lá cây vẫn là một kỹ năng cơ bản mà bất kỳ ai cũng nên biết. Trong\r\n            bài viết này, chúng ta sẽ khám phá cách sử dụng lá cây để xác định phương hướng.\r\n        </p>\r\n        <img\r\n            style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n            src=\"https://bizweb.dktcdn.net/100/032/885/files/cac-ky-nang-sinh-ton-trong-rung-ban-nen-biet.jpg?v=1664768241728\"\r\n            alt=\"svg\"\r\n        />\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                1. Lá Cây Như Một Dụng Cụ Xác Định Phương Hướng\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Lá cây có thể được sử dụng để xác định hướng chính xác bằng cách nhìn vào cách mà các lá hình dạng và\r\n                màu sắc của chúng thay đổi dựa trên hướng mặt trời.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                2. Hướng Dựa Trên Sự Chiếu Sáng\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Lá Cây Láng: Lá cây sẽ láng hơn ở phía nam so với phía bắc vì mặt trời chiếu sáng trực tiếp vào phía\r\n                nam. Kích Thước Của Bóng Dáng: Khi mặt trời ở trên đỉnh, bóng của cây sẽ nằm ở phía dưới cây về phía\r\n                phía đông. Khi mặt trời ở phía tây, bóng của cây sẽ nằm ở phía dưới cây về phía tây.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                3. Sử Dụng Cây Cây Đồng Thời\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Cây Cây Cây Tập Trung: Các cây sẽ tập trung nhiều ở phía bắc vì phía nam thường có ít ánh sáng mặt trời\r\n                hơn.\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Cây Cây Cây Dày Đặc: Cây sẽ dày đặc hơn ở phía nam do nhận được nhiều ánh sáng mặt trời hơn.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">4. Sự Thực Hành</p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Thực hành thường xuyên và thử nghiệm với lá cây để làm quen với cách chúng phản ánh ánh sáng và hướng\r\n                của mặt trời trong các điều kiện khác nhau.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">Kết luận</p>\r\n        </div>\r\n\r\n        <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Biết cách sử dụng lá cây để xác định phương hướng là một kỹ năng cơ bản và quan trọng trong việc sinh\r\n                tồn trong môi trường tự nhiên. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến\r\n                thức cần thiết để thực hiện điều này một cách hiệu quả. Hãy thực hành và trở thành một bậc thầy trong\r\n                việc xác định hướng bằng lá cây!\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n", new Guid("807ebc7e-3f10-4c2e-b8b2-138b20a314cc"), null, new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7375), null, false, null, null, null },
                    { new Guid("ef17af21-341c-4f31-b69c-375dce326c34"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n        <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n            10 Cách thắt nút dây cơ bản mà bạn nên biết\r\n        </h1>\r\n        <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">Kiến thức Sơ cấp cứu</p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong những tình huống khẩn cấp, khả năng tạo lửa có thể là yếu tố quyết định giữa sự sống và cái chết. Dù\r\n            bạn đang dã ngoại, mắc kẹt trong rừng hoặc gặp phải tình huống khẩn cấp khác, biết cách tạo lửa từ những vật\r\n            dụng cơ bản có thể cực kỳ hữu ích. Trong bài viết này, chúng ta sẽ khám phá những cách tạo lửa đơn giản mà\r\n            bất kỳ ai cũng có thể thực hiện.\r\n        </p>\r\n        <img\r\n            style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n            src=\"https://st.quantrimang.com/photos/image/2016/11/08/tao-lua-650.jpg\"\r\n            alt=\"svg\"\r\n        />\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                1. Sử dụng đánh lửa\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Một trong những cách đơn giản nhất để tạo lửa là sử dụng đánh lửa hoặc bật lửa di động. Đảm bảo rằng bạn\r\n                luôn giữ một chiếc đánh lửa hoặc bật lửa trong túi hoặc trong hành trang của mình.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                2. Sử Dụng Que Diêm\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Que diêm là một phương tiện khác để tạo lửa nhanh chóng và dễ dàng. Hãy đảm bảo rằng bạn luôn mang theo\r\n                một số que diêm trong túi hoặc hành trang của mình.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                3. Sử Dụng Các Vật Dụng Tự Nhiên\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nếu bạn không có đánh lửa hoặc que diêm, bạn vẫn có thể tạo lửa bằng cách sử dụng các vật dụng tự nhiên\r\n                như cây khô, lá khô, vỏ cây, hoặc cành cây sấy khô dưới ánh nắng mặt trời.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                4. Sử Dụng Kỹ Thuật Friction\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Một kỹ thuật khác để tạo lửa là sử dụng ma sát. Bạn có thể sử dụng hai vật dụng có thể tạo ra ma sát\r\n                mạnh mẽ khi chúng va chạm với nhau như các cành cây, bàn tay, hoặc một miếng vải và một cành cây.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                5. Sử Dụng Kính Lúp\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nếu bạn có một kính lúp, bạn có thể sử dụng nó để tập trung ánh nắng mặt trời vào một điểm nhỏ trên vật\r\n                liệu cháy để tạo nên lửa.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">Kết luận</p>\r\n        </div>\r\n\r\n        <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Biết cách tạo lửa từ những vật dụng cơ bản có thể là một kỹ năng quan trọng trong mọi tình huống khẩn\r\n                cấp. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để thực\r\n                hiện điều này một cách an toàn và hiệu quả. Đừng quên, luôn luôn lưu ý đến sự an toàn khi làm việc với\r\n                lửa.\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n", new Guid("c672ebe0-2a8e-4a0e-b21f-f70e0d87efa2"), null, new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7368), null, false, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("0d085bfa-8d7e-496b-b86e-ff4f60198269"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1822976f-01d7-4a12-ba20-46e5004cc71c"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f04befb-e7a8-4c34-87fe-5a61795fdc2a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f7bfe1c-b663-4f08-9713-83394f85319d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("231d86a8-97cb-4b12-b734-4c72fd8e6c67"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("280f5a0e-0379-4b8e-a09d-aacda21cddaf"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("39047891-ae02-4927-849b-a950f85f4480"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("3ba5c72a-2843-4dd8-a958-f008a6bff38b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("46f2f761-1478-44fd-adae-ff50940ea9aa"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("48ae3bff-69b9-49f6-ad3e-e7408e44c081"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("4de6137f-63c7-4e2b-876c-f6084cadd849"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("52a8aef1-343c-41e0-a97b-6e63fc1afb5d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("558f2622-5ba7-4f13-8086-b7bf91970fa0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6a30dbfe-0c1c-4d34-b968-52bf9dabb48e"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6ad7ebcd-55b2-419c-ab60-8fcd257c3e1a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a1969abb-e4ea-4f53-8ce2-e13136591218"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a89d9710-d2c2-4327-a604-d97ba4a99d4f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b2590647-632f-48bb-adee-5cd6b9a5fb7f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b7a6e1f1-75fb-4e26-b6f9-420dd470369d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b8055c5b-a7fe-4d1b-8fbc-5ebd33fac035"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("bd166379-995b-449d-b381-db1fd362be0c"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c2d48bf7-05fd-4743-95db-a32c8d53de88"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c813800b-ba50-4270-b3a6-9313e7884646"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("cdd95a29-4f65-487a-ae60-2f043c4c63f8"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d16ccff2-a7a8-4b9a-80fd-dd8b37aeb3b7"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d390145b-b53a-4ccc-afe3-bb9b218332c0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("e6e9f4ca-33ec-4df4-a15f-bb69c61a4691"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("ef525797-2ec8-405e-9eb9-826b621fe47a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5c43ff6a-1903-4fdc-911b-52e32cbe3633"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5dca6c16-f112-4517-8655-3b03cfb7a716"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("76b241ee-7275-4449-ad4d-6813ac2c112a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("93aeda91-ae3c-448a-bb89-497f28256563"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("a403ff66-6735-4516-ae28-23de65c52cea"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("07f89298-3fe2-4f16-a33d-209a7feb9526"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0a4e0c7b-3455-4d10-a25c-d5d78e84efb1"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0c3aa435-c958-4152-a7a6-309bf52337d0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0cff733f-47e0-4656-b356-557d02ef9f9c"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0de1b351-990b-49d2-b1d9-aff6f2f6c0e2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0e4ebaac-a0e4-4aa8-8d6c-6eefa8dc4d63"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0e6d3177-7510-4290-8ae7-02c7dcf2bd46"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("116c0f70-7610-4383-9c5f-10cd086f198a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1262623d-475a-4015-bc55-282650e90cde"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("15f7c3e2-71bf-4c82-95a7-d49ef1b76e99"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("17676ce9-6d78-489b-8803-a651875391e9"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1aedfbb6-ef6c-40c3-b5e0-8c11ae6157e4"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1e9dae67-083c-40a3-9d33-1de20e22c900"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("201cafab-4d18-461e-83db-3f15ad9ba19c"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2162f4cd-abe5-4945-ac9c-49c2e12acc88"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("22034197-b916-4c2a-b8b5-cc60ec336b20"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2563e2fa-324f-41a0-b780-7034fb55152b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2803f828-f218-4eae-b560-19b1c4903c96"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("294142fc-8261-4d46-b670-5301cd5ce420"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2977fa59-3ebe-407c-b804-42c381020f74"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("299b419b-4894-4d0e-820f-e62774aab8c6"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("29ef856c-1ceb-4ce4-8de0-adebd76d8589"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2b581b39-6ff7-465e-b28d-8e8dbdef52aa"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2de49840-07b0-478c-b045-a46e311bfc2d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2e524aca-1a0f-4125-a7c7-da24663d327b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("346a6ce7-fd63-4788-9c8d-72da3a606b20"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("350bcba3-0e35-448a-b6a3-0da6d377e80e"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("3985bbaa-790d-4301-a500-02c0feac422f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("3fce95fa-36d0-452f-912f-a66689bcd54f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40e1f63e-7e31-4466-bd67-7aee4c28dd7f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40f3b8ce-43a1-4256-a8ae-9d96ea94f127"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40f9158a-50bb-4800-b104-7f43f452b4da"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("41fa54be-cb59-42ad-a6bd-48f705b7bd7a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("45dc3263-0892-40fa-bc5b-2a9cd86be147"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("4787dab5-0205-412a-a0b3-d15f716a25f1"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("479d98e3-0a00-4294-9678-f0e03bd75048"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5074c5aa-b04b-41df-89a2-3177705c1a57"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51328c0e-fefd-4cf0-8407-9dd7e2e7afc4"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51b70068-3066-4e06-a5ba-bf3cf1d9639f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("53ab9697-804f-4492-93c7-cfcf2c975c2a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("55c613db-7c7d-4c61-aaba-bdfb6ee2222b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("57b75328-ba3b-4c89-af42-f3f98f6460ec"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5e313fda-e478-4f37-9bd8-2310ed956e41"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5f589b73-6307-4ba1-9b6e-a0aea9dbb10a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("616fcfd4-aad3-4881-8fc2-cfbbfa2077dd"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("632ba757-0dc2-4a89-8462-285041471db2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("64d9b4f9-b12a-4c66-9b12-e1f79e4b7878"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("6e3bd858-0dad-4cfb-ad3c-18ea0a51ba59"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7179302f-70cf-482c-9027-f94ed74ff7a1"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("773c3118-1127-4c00-b8ae-4acf2fff8e84"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("79509a95-2ce1-496e-82f6-98b31940c359"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7978618a-d7be-4975-8db9-648a435925ce"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7f0b42f9-0602-4a55-b9d8-ced88911e477"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("80ca4742-e86a-4b7e-b1de-7d71184ee956"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("81725d34-8224-438c-995e-2a02006295fb"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("886cee20-5a0a-4f87-a059-aa0759c065d4"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("89c531da-3abc-4859-8337-408d8d556d06"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("89d12998-fd7a-4858-8f65-6ca330469d80"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8c19130d-a281-47f4-9753-697267f4ecbd"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8d5d44f6-39a9-4483-b121-ba884210360a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8df4266c-fd44-4e86-8cf0-f030ca219e71"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("905a8ca1-92ef-445f-a4aa-1838d653af5b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("910cae89-7155-499f-8b69-0071b959fe59"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9420bbd8-3702-438b-9470-9fa5fff9a0ba"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("94c10218-2f11-4892-a64d-2c729f254536"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9951c3aa-3245-4a3b-ae23-26339b08ece0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9ae701b5-c513-4d0b-a2b1-eef8ef995e18"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9e6064b5-db1e-456f-b113-0034f1a6fdd4"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a0ae585b-182f-4df1-b596-429571d81c3d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a29dae04-810f-4034-aad7-e293a28047aa"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a4dca733-6788-469b-9980-6da0759e8089"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a5f66dd3-7f64-4f32-90b3-19a8615380ab"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a6205571-be0e-4b95-9ffd-a5addedb4bd7"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a82eaf8a-5cb2-4815-9394-59110a2a3699"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aa158c9c-5a68-4059-b1ae-e4085adcd51f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aa97700c-2471-4845-87c7-4d5d19e4e835"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aa9d9c94-ce3f-42a2-acff-84f85608748c"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aaa16c5a-126a-43fe-921e-d856958c576b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("abac6286-767d-4baa-bc63-2fcc3e70a48e"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("ac02f0ed-e9be-4cfa-99c8-2aa060954bd9"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aed8237a-800e-47da-8aa7-b8935b0d4401"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("af068e17-d32c-43e2-9f3a-af0602ff6731"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b02698b9-8560-4c1b-967b-8c4cf7c68c03"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b07906a8-521b-4970-a421-2cc61520f749"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b1b7706a-3faa-4943-a8b2-6d3854a47ec4"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b7667346-a9df-4869-8ee4-814e44426b77"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b8a7ec77-865b-4864-b52c-e0951b48e322"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b8da47d7-edd8-484a-b06d-691a07b2739f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b9ea8984-a752-4ac4-8bf2-e30a90e497d0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("ba4b51a1-460c-4a32-801e-1c65b8d624b5"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("bc199684-de95-437c-8d1a-8c1e8f6cc1d2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("bc5db5fe-b982-44e6-a591-b2596ccd5522"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("bf2ea4b1-05db-4175-96ca-87008a609fe9"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("c88d5f35-4c11-42a4-b355-d0052b08687e"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cc4601b6-d9f9-4094-bc57-7105aa236761"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cd8eb190-a455-4f5f-bc21-8900c829ad46"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cec9cab3-beaf-440e-88ef-91452dc4b077"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("ceca8b5d-a8c6-457f-a681-eebcfacfe9f4"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("d3a98af4-5c3e-4b87-9938-788264ff9a36"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("d53d9426-a3d9-401c-b7b3-7af4974a6572"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("d8f9cc58-73bb-49cb-b8a5-c9693ff067de"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("dab66311-12f2-44ce-8719-83d67e21bfdd"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("de66382b-5819-4d2c-b0af-37e7eaf682b5"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("df288229-2da4-4832-9913-70c1a7e05e8f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e091b4cd-98f8-4fe3-97ba-9c016c7822e2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e57daddb-f9b7-483b-b4ab-153957577e7f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e66354a9-760d-4826-a002-04a81ba09c8d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e73411bc-d4d7-4801-bdd9-d7df984b01aa"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e848a319-5e9a-4dba-975d-8c1e5247a97a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("eea55b8b-fa03-4ecb-819a-ca9a6f9d43ef"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("eebeef97-4736-476c-99af-dfd4ed9f5255"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("efe5f9c2-9615-41b1-a4db-b229dea17bef"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("f160154b-b34a-49f6-89a8-0f80311d0641"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("f4f0a748-18a6-4546-b4d0-62ac473c7394"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("fbf0061b-5f88-45f1-8546-ca2e9d5ed35d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("01ea28b2-56ff-44e8-883a-ef8890bd426d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("04e48a25-de79-4a3a-88be-33a8d5829017"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("05eb9523-cbad-4abb-97df-00159d409a78"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("090a2b95-7b45-4600-ad80-dd2853cc9685"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("0cb0d678-9454-4391-bd9e-2b536a50f1f7"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("0e53c113-06cc-4b91-8fd4-d5c62ea70309"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("1645e54a-16db-4c4c-8de9-3d86f1ee1a36"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("16cfebea-d7d0-440d-b4bd-43bbfe6610e0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b11f26c-7206-48a5-801c-9610b99b5738"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b7a46a0-f703-4dcf-b4f8-66826e128514"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("32475e06-c246-437b-9298-4523809622c2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("327ca2f9-33cd-421c-b0b2-288582ca465b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("3fe4bdf1-ebdf-43df-868a-09eb274f6f22"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("41455e11-ec85-4698-9a2d-f57c64a45762"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("46e01fa7-af0b-4d0f-8125-56b5772d191b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("4b467404-7405-430b-b458-8aacac949a5b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("4f09916e-7a24-455b-be1e-11340ae4ad68"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("514f5b35-23a3-489f-afc5-9c80511fab60"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5490695b-c2d8-4e4d-92e1-690da77e395d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5a876ed2-ed72-40a0-b099-a50ba8028dd3"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("61105e2b-b22e-4eb2-897f-941818211986"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("65a9fd83-5d8b-4e25-93b8-4125d1281ab7"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("73a06b9b-83ab-46b1-90e3-3aa6c2773995"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("76d5c903-e2e0-4d17-a3bb-09b6a8ae6cd4"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("791a9161-5dab-4fa6-ad27-6b2694af4e5b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7b026ebe-11c7-4585-a395-2b42a4489647"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7c35e76d-56b9-4ebe-b66a-63e9ce2e9237"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7c57b22b-c472-419c-ad81-ee87410c36de"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("831c6f2e-7c32-4ae6-8af6-fdb3897c612b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("8ef3e270-6c5a-4393-9060-de98e98e6e84"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("91a89827-bdc9-4b2b-a318-65735075a8eb"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("995fd02a-9f64-45a5-9424-0ec2c9f891a0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("9bc401f4-517b-4765-885f-1c480893f229"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("a7247c61-4ce6-478c-8c6f-56df1c72fe1d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("afcbcbd1-a29a-4647-b7b3-41c1f6fc45f0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b51c1608-7f38-427d-b4d7-c9cd62ff253e"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b92e56fc-1be9-4973-9254-d9cd74a70414"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("bfe028fa-949f-44c8-95c9-fbb4537114c9"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("c4cce2a8-1b2e-4443-a59e-e4bec4f2fe0a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("c55d01ce-f82b-4ef4-b9b2-42452d718e50"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("cd0aa7d8-c354-441d-9ed0-ec97d2e91ef2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ce0ced0c-38e6-4bdb-9d66-e5bfdfdc35ba"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ce2acc73-28a0-4dd4-9368-c71c81a60665"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("d9d4ba6a-da09-4482-bf40-e9f9a216cd03"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ddbc8b2d-b7e7-445f-9a7b-2194f5ab7704"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("e4b92110-7298-48ea-bbe1-1cc21ccfe6b1"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("e9619b3b-a906-4ada-b211-84543a3b31df"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("f6b44c79-92d9-4128-9d6c-40aa134bf0b2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fd228cde-7079-4d6a-835b-1df8215fa5bb"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fedb71a7-bb4b-441a-b30e-0af28d6d83a3"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("27891a29-9107-45a3-812c-766d52779ab7"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("636af2b3-96fe-4fed-9e59-23c5c5941a14"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("80ee8583-ff0b-49ae-81d2-0e5b0724ade7"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("a2ecd786-f8bd-47f8-8900-be1407c3ccd0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("cbc76dac-42da-4b4b-807d-aab23b875e93"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e27d22b8-e12d-4906-985c-bcc6a28aeeab"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e5919e2d-642b-46da-980d-ef68f365c0da"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 17, 21, 41, 247, DateTimeKind.Local).AddTicks(7095));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("08193f04-b021-4098-b897-e066567469d1"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("394ba278-843d-41b7-aa95-8148a2e36f7e"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("46423e7d-edfa-4707-a488-3d65f68429a7"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("5b9d9094-1cb2-4c95-88b2-543dfceede16"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("942a5f4a-d695-4f9c-80bb-e9a56197ac2d"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("b0296068-1b95-473f-afb8-d4ad07bb1bc6"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("bd37c5d4-b8aa-496f-93eb-d3d67095046d"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("cb519716-88d0-4210-a5e9-53bef3d6021c"));

            migrationBuilder.DeleteData(
                table: "CourseDetail",
                keyColumn: "Id",
                keyValue: new Guid("ef17af21-341c-4f31-b69c-375dce326c34"));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("2a7ce08a-0967-439a-b0af-d3f0c80197d6"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("58698e2d-fb2a-48c1-b064-085dd11c48d0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("6e4caa08-8b57-4090-8bb4-3507199e0be3"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "AnswerContents",
                keyColumn: "Id",
                keyValue: new Guid("c125f973-8af1-417e-87be-ff5f46ffdf5c"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "871a809a-b3fa-495b-9cc2-c5d738a866cf",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENgNdSAVhQ2qhHo766PiesfrGgpm6ypTHtiOGJgLLeMnpwecOkvfFUUOq+xjSvvU0A==");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2b729efa-3446-405b-9dc7-059a4c451296"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3a477216-d412-43ca-b05f-653bc84f6609"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("18fff9c2-ff95-454c-9556-02ddfab87c50"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("1a6c1329-ee6f-4a7d-a5e6-c7da5d43ed9c"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("25ff2950-58ef-4303-8fc7-0e89538a70b2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("54b8bdd4-b49e-4775-ab42-9ff7b4dd0df6"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("5582c691-4042-40a4-a32b-cde2edcb5fe5"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("72c14f87-15ae-4b85-81d1-005562d806c3"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("a89744ca-73d3-4f08-9548-9cf8af8938fb"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("b8c5cf22-b246-4ca1-b8bf-0f6e7d475027"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "CategoryKeyword",
                keyColumn: "Id",
                keyValue: new Guid("c0daa7c5-4331-44bf-a33e-23679c959b12"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("092cd36a-4a80-48ef-bd7a-f4e3e63871bd"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9319), "https://drive.google.com/file/d/1vkQF6QBu7YtGTAgm4FOxutDXgwSN4kpA/view?usp=drive_link" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("0b1820a0-2c22-47ac-80f4-3630863bb890"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9304), "https://drive.google.com/file/d/10zCLBj1cOdk2ySwNpKx7A2it9lwQSatG/view?usp=drive_link" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("0f3633c8-5e37-4f73-b3f6-35933e195046"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9311), "https://drive.google.com/file/d/1_VMTU0eDi5W46cMYOqNRdHd_xh2rgHhG/view?usp=drive_link" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("17617323-50a0-492c-a220-84ea0235735f"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9376), "https://drive.google.com/file/d/1SZp5VE0mgyw8ticH5NBv6U5dBN-g7LbS/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("2ae51909-7baa-4de0-ae83-c13c0498b157"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9361), "https://drive.google.com/file/d/1gyl93eFdbWf_OUooLdnLOlCE6dYY5hjy/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("2e2c200b-4115-4f49-8516-2a33654c2c00"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9381), "https://drive.google.com/file/d/1Ap2czeqg098D08CutbvWGqLNZk-qFlWZ/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("37437d9f-7753-4ee4-a04d-e1ce1651c54f"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9301), "https://drive.google.com/file/d/1N7hna2bkdj4-x7FGrI0Nn-GS_0AM1tqq/view?usp=drive_link" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("491f2b78-009d-4d2e-8ad7-02c25e44dd95"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9358), "https://drive.google.com/file/d/1dPIcGMCLKDymtV0nCwtYeG7W3fWNIfVm/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("4edc5c6e-daa5-48a5-9f1b-d63ee7eb6fc3"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9388), "https://drive.google.com/file/d/186fqnyQNpSi-XsSSk-UzREErhXn1H0qy/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("59a9e104-7d3b-43a9-afc1-0c58b3ae4016"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9365), "https://drive.google.com/file/d/1XbiTTseCwGGzI34wyylh5DbXcPVVPgZc/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("5e3e996b-cf80-46be-93a1-e822fda0d50e"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9309), "https://drive.google.com/file/d/1VBzzP4G2-dMcdixPrt8PMZM5EnW9J6b7/view?usp=drive_link" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("689782fb-f292-47fb-9e78-990e92a0e390"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9298), "https://drive.google.com/file/d/1RJnfe72KSUgKDhcW5QV1NWvpl4wKkVIr/view?usp=drive_link" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("7ba022bb-325a-4058-a4d9-63892767d7ed"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9392), "https://drive.google.com/file/d/1nsJymL6ZkwtaOnBwqa0XAJJyAc3mQhqT/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("8d4a29c0-775f-49f6-9598-5dbfacccced9"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9293), "https://drive.google.com/file/d/1h3rtJwG0lv2pa6xwsbigXp00eolmMGQF/view?usp=drive_link" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("984f2fb4-d29c-4959-8a52-1f43f3380dba"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9295), "https://drive.google.com/file/d/1-ODJaLBwdBjLqQGwjqeeHQ477hc7tZpz/view?usp=drive_link" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("ade4f561-1316-489d-b752-dc042dd5b700"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9373), "https://drive.google.com/file/d/1XipVGadCsPVVCpiD6XljvOeI4YfgR7_2/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("af316d79-6367-4029-a241-bf49fa9c0f56"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9315), "https://drive.google.com/file/d/1noq83y-YayPBNVT7pl1j0RPWS_Z9ZORG/view?usp=drive_link" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("bac1c26d-ff9f-4cc7-b4bf-f6009b1c5830"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9379), "https://drive.google.com/file/d/1NQcUMsfzIQrG3IORn7iVXgnyO4c6ZCZ0/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("d343e947-dbba-4631-9796-9364369efac4"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9370), "https://drive.google.com/file/d/1a-hvucwa8BKaZEk2ZcsezcWSiXu7Jtfd/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("e6513d6e-0d42-480c-925f-7bf931f86cd0"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9385), "https://drive.google.com/file/d/1rpwIoXV58EN-lBdFbGqmmYKh5Ad3ZClG/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("e71a9882-2634-411f-a74c-3a49ae3989b9"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9288), "https://drive.google.com/file/d/1wj5O76ORv_qRzr-BF8fqRPEjIHFNqjiD/view?usp=drive_link" });

            migrationBuilder.UpdateData(
                table: "ChuanDoan",
                keyColumn: "Id",
                keyValue: new Guid("eeb8ae18-c9a8-485a-9846-c8647d861dc6"),
                columns: new[] { "Created", "UrlImage" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9322), "https://drive.google.com/file/d/1bC8kxb_q2vCpb0y2q5BGik79IhtYE8Ns/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("81e210f8-9274-44c5-9256-481acce0e8ec"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "ComboCourse",
                keyColumn: "Id",
                keyValue: new Guid("edd4ae9e-0e26-4ed4-9812-0fbe587fcdb3"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("1761d6c6-1155-4534-8d44-9362db753a9a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("2f55aa8b-e887-4808-9e18-7c6556464f16"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("481abb77-ebd3-47b0-9e9f-718368076074"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5ef458ed-6776-43b4-ba9d-9cc9c47d7511"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7aa3b055-2b09-4d6a-82e0-89e75a365940"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("807ebc7e-3f10-4c2e-b8b2-138b20a314cc"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("842765e5-aec9-402e-93cd-3f3bb3998608"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c672ebe0-2a8e-4a0e-b21f-f70e0d87efa2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3db0b18-003a-4046-873b-264d3498360c"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.InsertData(
                table: "CourseDetail",
                columns: new[] { "Id", "Conlusion", "Content", "CourseId", "CreateBy", "Created", "ImageUrl", "IsDelete", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("0c6e6de9-838a-48d0-8471-94d678dbf27c"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n       Tư Thế Nằm Nghiêng An Toàn Trong Sơ Cấp Cứu: Biết Để Bảo Vệ Bản Thân và Người Khác\r\n    </h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Nhắc đến sơ cấp cứu, việc biết cách giữ tư thế nằm nghiêng an toàn có thể là yếu tố quyết định giữa sự cứu chữa thành công và biến chứng nghiêm trọng. Trong bài viết này, chúng ta sẽ tìm hiểu về các tư thế nằm nghiêng cơ bản mà bạn có thể áp dụng trong các trường hợp khẩn cấp.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://suckhoe123.vn/uploads/suc-khoe/2021_05/20200424_172336_448622_nghieng.max-1800x1800.jpg\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            Tại sao Tư Thế Nằm Nghiêng Quan Trọng?\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong một số trường hợp, đặc biệt là khi có nguy cơ nôn mửa hoặc hít phải chất lỏng, máu hoặc cơ hội nằm nghiêng có thể ngăn chặn việc phụt ngược chất lỏng vào đường hô hấp, giữ cho đường thoát khí mở rộng và giảm áp lực lên cổ và phổi.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nCách Thực Hiện Tư Thế Nằm Nghiêng\r\n        </p>\r\n    </div>\r\n\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n1. Tư Thế Nằm Nghiêng Đơn Giản:\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            - Đặt người bệnh nằm sấp và kéo một chân về phía trên.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Đặt một bộ phận dưới đầu để giữ cho đầu của họ nghiêng về một bên.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Đảm bảo đầu và cổ của họ đều ở vị trí tự nhiên.\r\n        </p>\r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            2. Tư Thế Nằm Nghiêng Phức Tạp:\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            - Đặt người bệnh nằm sấp.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Đặt một tấm gối hoặc đối vật cứng dưới người bệnh từ dưới đầu đến dưới đùi của họ.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Kéo một chân của họ về phía trên và đặt gối hoặc chăn dưới chân để giữ cho cơ thể họ nghiêng.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Giữ đầu và cổ của họ trong một tư thế tự nhiên.\r\n        </p>\r\n\r\n    </div>\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Lưu Ý Quan Trọng\r\nLuôn Giữ Đầu và Cổ Trong Tư Thế Tự Nhiên: Đảm bảo rằng đầu và cổ của người bệnh luôn được giữ trong một tư thế tự nhiên và không bị ép vào bất kỳ hướng nào khi thực hiện tư thế nằm nghiêng.\r\nTheo Dõi Tình Trạng Của Người Bệnh: Luôn lưu ý đến các biểu hiện của người bệnh và sẵn sàng điều chỉnh tư thế nếu cần thiết.\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n", new Guid("f3db0b18-003a-4046-873b-264d3498360c"), null, new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8820), null, false, null, null, null },
                    { new Guid("1229e46b-66e9-4505-8176-5f4bfcc8adb9"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n        <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n            10 Cách thắt nút dây cơ bản mà bạn nên biết\r\n        </h1>\r\n        <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">Kiến thức Sơ cấp cứu</p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong những tình huống khẩn cấp, khả năng tạo lửa có thể là yếu tố quyết định giữa sự sống và cái chết. Dù\r\n            bạn đang dã ngoại, mắc kẹt trong rừng hoặc gặp phải tình huống khẩn cấp khác, biết cách tạo lửa từ những vật\r\n            dụng cơ bản có thể cực kỳ hữu ích. Trong bài viết này, chúng ta sẽ khám phá những cách tạo lửa đơn giản mà\r\n            bất kỳ ai cũng có thể thực hiện.\r\n        </p>\r\n        <img\r\n            style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n            src=\"https://st.quantrimang.com/photos/image/2016/11/08/tao-lua-650.jpg\"\r\n            alt=\"svg\"\r\n        />\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                1. Sử dụng đánh lửa\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Một trong những cách đơn giản nhất để tạo lửa là sử dụng đánh lửa hoặc bật lửa di động. Đảm bảo rằng bạn\r\n                luôn giữ một chiếc đánh lửa hoặc bật lửa trong túi hoặc trong hành trang của mình.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                2. Sử Dụng Que Diêm\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Que diêm là một phương tiện khác để tạo lửa nhanh chóng và dễ dàng. Hãy đảm bảo rằng bạn luôn mang theo\r\n                một số que diêm trong túi hoặc hành trang của mình.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                3. Sử Dụng Các Vật Dụng Tự Nhiên\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nếu bạn không có đánh lửa hoặc que diêm, bạn vẫn có thể tạo lửa bằng cách sử dụng các vật dụng tự nhiên\r\n                như cây khô, lá khô, vỏ cây, hoặc cành cây sấy khô dưới ánh nắng mặt trời.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                4. Sử Dụng Kỹ Thuật Friction\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Một kỹ thuật khác để tạo lửa là sử dụng ma sát. Bạn có thể sử dụng hai vật dụng có thể tạo ra ma sát\r\n                mạnh mẽ khi chúng va chạm với nhau như các cành cây, bàn tay, hoặc một miếng vải và một cành cây.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                5. Sử Dụng Kính Lúp\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nếu bạn có một kính lúp, bạn có thể sử dụng nó để tập trung ánh nắng mặt trời vào một điểm nhỏ trên vật\r\n                liệu cháy để tạo nên lửa.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">Kết luận</p>\r\n        </div>\r\n\r\n        <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Biết cách tạo lửa từ những vật dụng cơ bản có thể là một kỹ năng quan trọng trong mọi tình huống khẩn\r\n                cấp. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để thực\r\n                hiện điều này một cách an toàn và hiệu quả. Đừng quên, luôn luôn lưu ý đến sự an toàn khi làm việc với\r\n                lửa.\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n", new Guid("c672ebe0-2a8e-4a0e-b21f-f70e0d87efa2"), null, new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8834), null, false, null, null, null },
                    { new Guid("53bbf75d-0c85-4c8d-b7f0-7fe99ed0413b"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\nHướng Dẫn Vận Chuyển Người Bệnh An Toàn Trong Mọi Tình Huống\r\n    </h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Việc vận chuyển người bệnh là một phần quan trọng trong sơ cứu và chăm sóc y tế. Tuy nhiên, nếu không thực hiện đúng cách, nó có thể gây ra thêm tổn thương và biến chứng cho người bệnh. Trong bài viết này, chúng ta sẽ tìm hiểu về cách vận chuyển người bệnh một cách an toàn và hiệu quả trong mọi tình huống.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://baoquangbinh.vn/dataimages/202107/original/images704000_cc3.jpg\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n1. Đánh Giá Tình Hình\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trước khi vận chuyển bất kỳ người bệnh nào, hãy đánh giá tình hình và quyết định liệu có cần gọi xe cấp cứu hay không. Nếu không có xe cấp cứu, đảm bảo rằng bạn có đủ sự trang bị và kiến thức để vận chuyển một cách an toàn.\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n2. Chuẩn Bị Môi Trường\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nĐảm bảo không gian vận chuyển rộng rãi và an toàn.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nLoại bỏ các vật dụng nguy hiểm khỏi lối đi.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nLàm cho không gian thoáng đãng và dễ dàng tiếp cận.\r\n        </p>\r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n3. Sử Dụng Kỹ Thuật Đúng\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nSử dụng các kỹ thuật vận chuyển như chuyển lên giường, ghế hoặc xe lăn một cách cẩn thận và nhẹ nhàng.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nLuôn sử dụng tư thế bảo vệ cho cơ thể của người bệnh, đặc biệt là đầu, cổ và cột sống.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nSử dụng hỗ trợ bổ sung như gối, băng cố định và dây đai an toàn nếu cần thiết.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n4. Giao Tiếp Và Động Viên\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nLuôn giữ liên lạc với người bệnh và cung cấp sự động viên và an ủi.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nGiải thích mọi động tác và kế hoạch di chuyển trước khi thực hiện.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n5. Sự Theo Dõi Sau Khi Vận Chuyển\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nSau khi đặt người bệnh vào vị trí mới, đảm bảo rằng họ đang cảm thấy thoải mái và không gặp phải bất kỳ vấn đề nào.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nKiểm tra các dấu hiệu và triệu chứng có thể báo hiệu về tình trạng tồn tại hoặc mới.\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Việc vận chuyển người bệnh đòi hỏi sự chuẩn bị kỹ lưỡng, kiến thức và kỹ năng. Quan trọng nhất là phải luôn đặt sự an toàn và thoải mái của người bệnh lên hàng đầu. Hy vọng rằng với những hướng dẫn trên, bạn sẽ có thêm niềm tin và kiến thức để vận chuyển người bệnh một cách an toàn và hiệu quả trong mọi tình huống.\r\n        </p>\r\n    </div>\r\n</div>\r\n", new Guid("5ef458ed-6776-43b4-ba9d-9cc9c47d7511"), null, new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8824), null, false, null, null, null },
                    { new Guid("5dfb42c9-2604-47ed-a833-167189317b12"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\nCPR - Kỹ Năng Hồi Sinh Tim Phổi Cơ Bản Mà Mọi Người Cần Biết    </h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Trong một tình huống khẩn cấp khi người khác đột ngột gặp phải ngừng tim phổi, kỹ năng CPR (Cardiopulmonary Resuscitation) - hồi sinh tim phổi là một kỹ năng quan trọng có thể cứu mạng. Trong bài viết này, chúng ta sẽ tìm hiểu về CPR cơ bản và cách thực hiện nó một cách hiệu quả.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://th.bing.com/th/id/R.3c96bb6b124829db33aa812a1814ee9d?rik=dnxzH5j9nJ0rnw&pid=ImgRaw&r=0\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nCPR là gì?\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            CPR là quá trình cung cấp áp lực hồi sinh tim phổi thông qua việc nén tim và cung cấp hơi thở nhân tạo, nhằm duy trì lưu lượng máu và ôxy đến não và các cơ quan quan trọng khác.\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nBước 1: Kiểm Tra An Toàn\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nKiểm tra khu vực xung quanh để đảm bảo an toàn cho bản thân và người bệnh.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nGọi cấp cứu nếu có sẵn.\r\n        </p>\r\n    \r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nBước 2: Kiểm Tra Tình Trạng\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nGọi lên và kiểm tra phản ứng của người bệnh.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nKiểm tra hơi thở và dấu hiệu sống\r\n        </p>\r\n       \r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nBước 3: Báo Cáo Và Bắt Đầu CPR\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nNếu người bệnh không hít thở và không có nhịp tim, bắt đầu CPR ngay lập tức.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nNén tim: Đặt lòng bàn tay ở giữa ngực, nén tim khoảng 5-6cm sâu với tần suất khoảng 100-120 lần mỗi phút.\r\n        </p>\r\n<p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nHơi thở nhân tạo: Thực hiện 2 hơi thở nhân tạo với miệng che miệng và mũi người bệnh.\r\n        </p>\r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nBước 4: Tiếp Tục CPR\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nTiếp tục lặp lại chu trình nén tim và hơi thở cho đến khi cứu thương viên đến hoặc người bệnh hồi phục.\r\n        </p>\r\n    </div>\r\n</div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nLưu Ý Quan Trọng\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nThực hiện CPR một cách nhanh chóng và mạnh mẽ, nhưng đồng thời cẩn thận để tránh gây tổn thương.\r\nĐảm bảo bạn đã được đào tạo và tự tin trước khi thực hiện CPR trên người bệnh.\r\n        </p>\r\n    </div>\r\n<div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nKết luận\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            CPR là một kỹ năng quan trọng mà ai cũng nên biết, vì nó có thể là yếu tố quyết định giữa sự sống và cái chết trong một tình huống khẩn cấp. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan về CPR và cung cấp thông tin cần thiết để bạn có thể thực hiện nó một cách hiệu quả khi cần thiết. Hãy nhớ, một phút cứu mạng có thể phát huy tác dụng lớn!\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n", new Guid("481abb77-ebd3-47b0-9e9f-718368076074"), null, new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8826), null, false, null, null, null },
                    { new Guid("71b8b4a0-f541-45bf-80f7-aea7a0f040d5"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n        <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n            5 Cách Phát Ra Tín Hiệu Cầu Cứu Hiệu Quả Trong Tình Huống Khẩn Cấp\r\n        </h1>\r\n        <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">Kiến thức Sơ cấp cứu</p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong một tình huống khẩn cấp, khả năng phát ra tín hiệu cầu cứu có thể là yếu tố quyết định giữa sự sống và\r\n            cái chết. Tuy nhiên, không phải ai cũng biết cách phát ra tín hiệu cầu cứu một cách hiệu quả. Trong bài viết\r\n            này, chúng ta sẽ khám phá 5 cách phát ra tín hiệu cầu cứu mà bạn nên biết để có thể thu hút sự chú ý và giúp\r\n            đỡ trong một tình huống khẩn cấp.\r\n        </p>\r\n        <img\r\n            style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n            src=\"https://e.khoahoc.tv/photos/image/2015/07/01/SOS_2.jpg\"\r\n            alt=\"svg\"\r\n        />\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">1. Tiếng Hét Lớn</p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Một trong những cách phổ biến nhất để phát ra tín hiệu cầu cứu là hét lớn. Hãy hét càng to càng tốt để\r\n                thu hút sự chú ý của người xung quanh và gửi đi tín hiệu rằng bạn đang gặp vấn đề và cần sự giúp đỡ.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                2. Sử Dụng Còi Cứu Hộ\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Mang theo một còi cứu hộ là một ý tưởng tốt để có thể phát ra tín hiệu cầu cứu một cách nhanh chóng và\r\n                dễ dàng. Khi gặp phải tình huống khẩn cấp, bạn chỉ cần thổi vào còi một cách mạnh mẽ để thu hút sự chú ý\r\n                của người xung quanh.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                3. Sử Dụng Đèn Pin\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Trong tình huống mà việc gọi cầu cứu bằng tiếng không hiệu quả, việc sử dụng đèn pin có thể là một\r\n                phương tiện hiệu quả khác để thu hút sự chú ý của người xung quanh, đặc biệt là vào ban đêm hoặc trong\r\n                điều kiện ánh sáng yếu.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                4. Sử Dụng Gương Soi Ánh Sáng Mặt Trời\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nếu bạn bị mắc kẹt và không thể di chuyển, việc sử dụng một chiếc gương nhỏ hoặc vật phản quang để soi\r\n                ánh sáng mặt trời có thể là một cách hiệu quả để phát ra tín hiệu cầu cứu và thu hút sự chú ý của người\r\n                đi ngang qua.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                5. Sử Dụng Biểu Tượng Cầu Cứu Quốc Tế\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nếu bạn có một biểu tượng cầu cứu quốc tế như biểu tượng SOS, bạn có thể sử dụng nó để tạo ra tín hiệu\r\n                cầu cứu và gửi đi thông điệp rằng bạn đang cần sự giúp đỡ khẩn cấp.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">Kết luận</p>\r\n        </div>\r\n\r\n        <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Biết cách phát ra tín hiệu cầu cứu là một kỹ năng quan trọng và có thể cứu sống trong một tình huống\r\n                khẩn cấp. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để\r\n                thực hiện điều này một cách an toàn và hiệu quả. Hãy nhớ, sự chuẩn bị và kiến thức là chìa khóa cho mọi\r\n                sự thành công trong tình huống khẩn cấp.\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n", new Guid("1761d6c6-1155-4534-8d44-9362db753a9a"), null, new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8843), null, false, null, null, null },
                    { new Guid("849f1104-106c-4ab8-8391-3e9df2601e76"), null, "    <div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n        <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n            Bí Quyết Xác Định Phương Hướng Bằng Lá Cây: Kỹ Năng Sinh Tồn Cơ Bản\r\n        </h1>\r\n        <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">Kiến thức Sơ cấp cứu</p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong các tình huống khẩn cấp hoặc khi bị lạc trong thiên nhiên, việc biết cách xác định phương hướng có thể\r\n            là yếu tố quyết định giữa sự sống và cái chết. Mặc dù hiện đại có nhiều công nghệ giúp xác định hướng, nhưng\r\n            việc sử dụng các phương tiện tự nhiên như lá cây vẫn là một kỹ năng cơ bản mà bất kỳ ai cũng nên biết. Trong\r\n            bài viết này, chúng ta sẽ khám phá cách sử dụng lá cây để xác định phương hướng.\r\n        </p>\r\n        <img\r\n            style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n            src=\"https://bizweb.dktcdn.net/100/032/885/files/cac-ky-nang-sinh-ton-trong-rung-ban-nen-biet.jpg?v=1664768241728\"\r\n            alt=\"svg\"\r\n        />\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                1. Lá Cây Như Một Dụng Cụ Xác Định Phương Hướng\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Lá cây có thể được sử dụng để xác định hướng chính xác bằng cách nhìn vào cách mà các lá hình dạng và\r\n                màu sắc của chúng thay đổi dựa trên hướng mặt trời.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                2. Hướng Dựa Trên Sự Chiếu Sáng\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Lá Cây Láng: Lá cây sẽ láng hơn ở phía nam so với phía bắc vì mặt trời chiếu sáng trực tiếp vào phía\r\n                nam. Kích Thước Của Bóng Dáng: Khi mặt trời ở trên đỉnh, bóng của cây sẽ nằm ở phía dưới cây về phía\r\n                phía đông. Khi mặt trời ở phía tây, bóng của cây sẽ nằm ở phía dưới cây về phía tây.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                3. Sử Dụng Cây Cây Đồng Thời\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Cây Cây Cây Tập Trung: Các cây sẽ tập trung nhiều ở phía bắc vì phía nam thường có ít ánh sáng mặt trời\r\n                hơn.\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Cây Cây Cây Dày Đặc: Cây sẽ dày đặc hơn ở phía nam do nhận được nhiều ánh sáng mặt trời hơn.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">4. Sự Thực Hành</p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Thực hành thường xuyên và thử nghiệm với lá cây để làm quen với cách chúng phản ánh ánh sáng và hướng\r\n                của mặt trời trong các điều kiện khác nhau.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">Kết luận</p>\r\n        </div>\r\n\r\n        <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Biết cách sử dụng lá cây để xác định phương hướng là một kỹ năng cơ bản và quan trọng trong việc sinh\r\n                tồn trong môi trường tự nhiên. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến\r\n                thức cần thiết để thực hiện điều này một cách hiệu quả. Hãy thực hành và trở thành một bậc thầy trong\r\n                việc xác định hướng bằng lá cây!\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n", new Guid("807ebc7e-3f10-4c2e-b8b2-138b20a314cc"), null, new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8840), null, false, null, null, null },
                    { new Guid("90cf7f86-ea9e-404d-ad3a-6979363c2c86"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n        <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n            10 Cách Thắt Nút Dây Cơ Bản Mà Bạn Nên Biết\r\n        </h1>\r\n        <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">Kiến thức Sơ cấp cứu</p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Thắt nút là một trong những kỹ năng cơ bản mà ai cũng nên biết, không chỉ trong các hoạt động dã ngoại mà\r\n            còn trong cuộc sống hàng ngày. Từ việc thắt dây giày đến thắt dây dẹt trên thùng đồ, việc biết cách thắt nút\r\n            một cách đúng đắn có thể giúp bạn giữ dây chặt chẽ và an toàn. Trong bài viết này, chúng ta sẽ khám phá 10\r\n            cách thắt nút dây cơ bản mà bạn nên biết.\r\n        </p>\r\n        <img\r\n            style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n            src=\"https://chuyendaychi.com/wp-content/uploads/2018/05/n%C3%BAt-th%E1%BA%AFt-d%C3%A2y-th%E1%BA%A3-di%E1%BB%81u.jpg\"\r\n            alt=\"svg\"\r\n        />\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                1. Nút Dây Dẹt (Overhand Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây dẹt là một trong những nút đơn giản nhất và được sử dụng phổ biến trong cuộc sống hàng ngày. Đây\r\n                là cách thắt nút cơ bản nhất để ngăn dây khỏi tự lỏng ra.\r\n            </p>\r\n        </div>\r\n\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                2. Nút Dây Buộc (Square Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buộc là một trong những nút được sử dụng rộng rãi để nối hai đoạn dây lại với nhau một cách chắc\r\n                chắn và an toàn.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                3. Nút Dây Chặn (Slip Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây chặn là một loại nút có thể điều chỉnh kích thước và được sử dụng để buộc dây một cách nhanh\r\n                chóng và dễ dàng.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                4. Nút Dây Leo Cây (Clove Hitch)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây leo cây là một nút linh hoạt được sử dụng để buộc dây vào một vật thể tròn như cây hoặc ống.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                5. Nút Dây Buông (Bowline Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buông là một trong những nút an toàn nhất để tạo ra một lỗ hoặc vòng không bao giờ tự động co\r\n                lại.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                6. Nút Dây Buộc Gói (Package Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buộc gói là một loại nút được sử dụng để buộc chặt các gói hàng hoặc túi.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                7. Nút Dây Buộc Dính (Sheet Bend)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buộc dính là một cách tốt để nối hai đoạn dây có đường kính khác nhau lại với nhau một cách chắc\r\n                chắn.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                8. Nút Dây Leo Núi (Figure Eight Knot)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây leo núi là một loại nút được sử dụng rộng rãi trong leo núi và leo dã ngoại vì nó giữ dây chắc\r\n                chắn và không bao giờ tự động co lại.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                9. Nút Dây Buộc Thuyền (Anchor Hitch)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây buộc thuyền là một nút đơn giản được sử dụng để buộc dây vào một đinh, cột hoặc vật thể tương\r\n                tự.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n                10. Nút Dây Đồng Đều (Trucker's Hitch)\r\n            </p>\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Nút dây đồng đều là một cách tốt để tạo ra một vòng đeo chắc chắn và được sử dụng rộng rãi trong việc\r\n                buộc chặt và cố định hàng hoặc dụng cụ.\r\n            </p>\r\n        </div>\r\n        <div style=\"margin-bottom: 40px;\">\r\n            <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">Kết luận</p>\r\n        </div>\r\n\r\n        <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n            <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n                Biết cách thắt nút là một kỹ năng quan trọng và hữu ích trong mọi tình huống. Hy vọng rằng bài viết này\r\n                đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để thực hiện các loại nút cơ bản một cách\r\n                an toàn và hiệu quả. Hãy thực hành thường xuyên để trở thành một chuyên gia thực sự trong việc thắt nút!\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n", new Guid("842765e5-aec9-402e-93cd-3f3bb3998608"), null, new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8837), null, false, null, null, null },
                    { new Guid("aac28861-b78b-4117-88f5-2394cd3f5417"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\n        Nguyên Tắc An Toàn Trong Sơ Cứu: Bảo Vệ Sức Khỏe Mọi Người\r\n    </h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Sơ cứu là một kỹ năng cơ bản mà mỗi người nên biết, vì nó có thể giữ lại mạng sống cho người khác trong những tình huống khẩn cấp. Tuy nhiên, sự hiểu biết về những nguyên tắc an toàn trong quá trình thực hiện sơ cứu cũng quan trọng không kém. Dưới đây là những nguyên tắc quan trọng cần tuân thủ để đảm bảo an toàn cho cả người cứu thương lẫn người bị nạn.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://firebasestorage.googleapis.com/v0/b/linhchidoisos.appspot.com/o/SoCapCuu%2Fsocapcuu.jpg?alt=media&token=8f3138c9-174e-4933-867e-c4ae18095c1f\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            1. Bảo Vệ Bản Thân Đầu Tiên\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Khi đối mặt với tình huống sơ cứu, quyết định đầu tiên và quan trọng nhất là bảo vệ chính bạn. Đảm bảo rằng không có nguy hiểm nào tiếp tục tồn tại trước khi tiếp cận người bị nạn. Đeo bảo hộ cá nhân nếu có thể, và luôn đánh giá an toàn cho cả mình và người xung quanh.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            2. Gọi Cấp Cứu Trước Khi Hành Động\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trước khi bắt đầu thực hiện bất kỳ biện pháp sơ cứu nào, việc gọi đến số điện thoại cấp cứu là điều quan trọng. Cung cấp thông tin chi tiết về tình hình và tuân theo hướng dẫn từ bác sĩ điều phối giúp đảm bảo có kế hoạch chăm sóc y tế chính xác và nhanh chóng.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            3. Đánh Giá An Toàn Của Môi Trường\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trước khi tiếp cận nạn nhân, hãy đánh giá môi trường xung quanh để đảm bảo an toàn cho cả người cứu thương và người bị nạn. Loại bỏ các nguy cơ tiềm ẩn như lửa, điện áp cao, hoặc vật dụng gây nguy hiểm.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            4. Động Tác Nhẹ Nhàng và Hiệu Quả\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong quá trình thực hiện sơ cứu, hãy luôn tuân thủ nguyên tắc \"động tác nhẹ nhàng\". Tránh gây thêm tổn thương cho nạn nhân và chỉ thực hiện những biện pháp mà bạn đã được đào tạo. Sự nhẹ nhàng kết hợp với hiệu quả sẽ giúp giảm nguy cơ gặp phải tác động phụ không mong muốn.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n            5. Đề Xuất Giúp Đỡ Từ Người Xung Quanh\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Trong một tình huống khẩn cấp, không ngần ngại hỏi xem có ai khác có kỹ năng sơ cứu hay không. Sự hợp tác giữa mọi người có thể tăng khả năng cứu sống và giảm áp lực cho người cứu thương chính.\r\n        </p>\r\n    </div>\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n            Nhớ rằng, việc thực hiện sơ cứu không chỉ là về việc cứu sống mà còn là về cách làm đúng để đảm bảo an toàn cho tất cả mọi người liên quan. Hãy hiểu rõ và áp dụng những nguyên tắc an toàn này để sẵn sàng đối mặt với mọi tình huống khẩn cấp một cách hiệu quả và an toàn.\r\n        </p>\r\n    </div>\r\n</div>\r\n", new Guid("2f55aa8b-e887-4808-9e18-7c6556464f16"), null, new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8815), null, false, null, null, null },
                    { new Guid("ab7ae2f2-b418-4a28-a90d-2ec935803963"), null, "<div style=\"width: 100%; margin-top: 200px; justify-content: center; align-items: center; align-content: center; position: relative; display: grid;\">\r\n    <h1 style=\"font-size: 45px; font-weight: 900; color: #000000; justify-content: center; text-align: center; margin-bottom: 10px;\">\r\nSơ Cứu Cho Thao Tác Heimlich: Biết Cách Cứu Mạng Trong Trường Hợp Hóc Thức Ăn\r\n</h1>\r\n    <p style=\"font-size: 28px; color: #000000; margin-bottom: 60px; text-align: center;\">\r\n        Kiến thức Sơ cấp cứu\r\n    </p>\r\n    <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n        Trong tình huống khẩn cấp khi một người đang bị hóc thức ăn và không thể nói hoặc thở, thao tác Heimlich là một kỹ năng cứu mạng quan trọng. Trong bài viết này, chúng ta sẽ tìm hiểu cách thực hiện thao tác Heimlich một cách đúng đắn để cứu mạng cho người đang bị hóc.\r\n    </p>\r\n    <img\r\n        style=\"width: 600px; height: 400px; margin-bottom: 40px; margin-top: 40px; margin-left: auto; margin-right: auto;\"\r\n        src=\"https://www.topontiki.gr/wp-content/uploads/2023/08/Untitled-design-2023-08-14T190744.334.jpg\"\r\n        alt=\"svg\"\r\n    />\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n1. Đánh Giá Tình Hình\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\"> \r\nTrước tiên, hãy đảm bảo rằng người đó thực sự đang bị hóc thức ăn và không thể nói hoặc thở. Nếu họ vẫn có thể nói hoặc ho thở, họ có thể tự giải quyết vấn đề và bạn chỉ cần đề xuất họ làm theo.\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n2. Thực Hiện Thao Tác Heimlich\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Đứng phía sau: Đứng phía sau người bị hóc, đặt một chân giữa chân họ để tạo sự ổn định.        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Bám vào phía sau: Đặt một bàn tay lớn vào phía trên của hốc ngực của họ, đặt còn lại vào phía dưới, trên phần dưới của lồng ngực.\r\n        </p>\r\n<p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Thực hiện cú đẩy: Đẩy mạnh và nhanh chóng vào trong và lên trên, hướng ra phía trên, nhưng không đặt quá cao lên phần xương sườn.\r\n        </p>\r\n<p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n- Lặp lại nếu cần thiết: Lặp lại cú đẩy cho đến khi vật thể bị hóc được thải ra hoặc cho đến khi đội cứu hộ đến.\r\n        </p>\r\n    \r\n\r\n    </div>\r\n    <div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\n3. Sự Theo Dõi Và Hỗ Trợ Sau Khi Thực Hiện\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nTheo dõi người bị hóc cho đến khi họ hoàn toàn ổn định.\r\n        </p>\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\nNếu người bị hóc mất ý thức hoặc ngừng hô hấp, thực hiện CPR ngay lập tức.\r\n        </p>\r\n       \r\n    </div>\r\n    \r\n   \r\n  \r\n<div style=\"margin-bottom: 40px;\">\r\n        <p style=\"display: flex; font-size: 30px; font-weight: 900; width: 50%; margin: auto;\">\r\nKết luận\r\n        </p>\r\n    </div>\r\n\r\n\r\n    <div style=\"margin-top: 40px; margin-bottom: 80px;\">\r\n        <p style=\"display: flex; font-size: 26.7px; font-weight: 500; width: 50%; margin: auto;\">\r\n           Thao tác Heimlich là một kỹ năng cứu mạng quan trọng mà mọi người nên biết. Hy vọng rằng bài viết này đã cung cấp cho bạn cái nhìn tổng quan và kiến thức cần thiết để thực hiện thao tác Heimlich một cách an toàn và hiệu quả trong trường hợp cần thiết. Hãy nhớ, sự chuẩn bị và kiến thức là chìa khóa cho mọi sự thành công trong sơ cứu.\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n", new Guid("7aa3b055-2b09-4d6a-82e0-89e75a365940"), null, new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8830), null, false, null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("0d085bfa-8d7e-496b-b86e-ff4f60198269"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1822976f-01d7-4a12-ba20-46e5004cc71c"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f04befb-e7a8-4c34-87fe-5a61795fdc2a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("1f7bfe1c-b663-4f08-9713-83394f85319d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("231d86a8-97cb-4b12-b734-4c72fd8e6c67"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("280f5a0e-0379-4b8e-a09d-aacda21cddaf"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("39047891-ae02-4927-849b-a950f85f4480"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("3ba5c72a-2843-4dd8-a958-f008a6bff38b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("46f2f761-1478-44fd-adae-ff50940ea9aa"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("48ae3bff-69b9-49f6-ad3e-e7408e44c081"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("4de6137f-63c7-4e2b-876c-f6084cadd849"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("52a8aef1-343c-41e0-a97b-6e63fc1afb5d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("558f2622-5ba7-4f13-8086-b7bf91970fa0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6a30dbfe-0c1c-4d34-b968-52bf9dabb48e"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("6ad7ebcd-55b2-419c-ab60-8fcd257c3e1a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a1969abb-e4ea-4f53-8ce2-e13136591218"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("a89d9710-d2c2-4327-a604-d97ba4a99d4f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b2590647-632f-48bb-adee-5cd6b9a5fb7f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b7a6e1f1-75fb-4e26-b6f9-420dd470369d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("b8055c5b-a7fe-4d1b-8fbc-5ebd33fac035"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("bd166379-995b-449d-b381-db1fd362be0c"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c2d48bf7-05fd-4743-95db-a32c8d53de88"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("c813800b-ba50-4270-b3a6-9313e7884646"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("cdd95a29-4f65-487a-ae60-2f043c4c63f8"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d16ccff2-a7a8-4b9a-80fd-dd8b37aeb3b7"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("d390145b-b53a-4ccc-afe3-bb9b218332c0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("e6e9f4ca-33ec-4df4-a15f-bb69c61a4691"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Emergency",
                keyColumn: "Id",
                keyValue: new Guid("ef525797-2ec8-405e-9eb9-826b621fe47a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5c43ff6a-1903-4fdc-911b-52e32cbe3633"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("5dca6c16-f112-4517-8655-3b03cfb7a716"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("76b241ee-7275-4449-ad4d-6813ac2c112a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("93aeda91-ae3c-448a-bb89-497f28256563"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "EmergencyCategory",
                keyColumn: "Id",
                keyValue: new Guid("a403ff66-6735-4516-ae28-23de65c52cea"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("07f89298-3fe2-4f16-a33d-209a7feb9526"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0a4e0c7b-3455-4d10-a25c-d5d78e84efb1"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0c3aa435-c958-4152-a7a6-309bf52337d0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0cff733f-47e0-4656-b356-557d02ef9f9c"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0de1b351-990b-49d2-b1d9-aff6f2f6c0e2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0e4ebaac-a0e4-4aa8-8d6c-6eefa8dc4d63"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("0e6d3177-7510-4290-8ae7-02c7dcf2bd46"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("116c0f70-7610-4383-9c5f-10cd086f198a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1262623d-475a-4015-bc55-282650e90cde"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("15f7c3e2-71bf-4c82-95a7-d49ef1b76e99"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("17676ce9-6d78-489b-8803-a651875391e9"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1aedfbb6-ef6c-40c3-b5e0-8c11ae6157e4"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("1e9dae67-083c-40a3-9d33-1de20e22c900"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("201cafab-4d18-461e-83db-3f15ad9ba19c"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2162f4cd-abe5-4945-ac9c-49c2e12acc88"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("22034197-b916-4c2a-b8b5-cc60ec336b20"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2563e2fa-324f-41a0-b780-7034fb55152b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2803f828-f218-4eae-b560-19b1c4903c96"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("294142fc-8261-4d46-b670-5301cd5ce420"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2977fa59-3ebe-407c-b804-42c381020f74"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("299b419b-4894-4d0e-820f-e62774aab8c6"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("29ef856c-1ceb-4ce4-8de0-adebd76d8589"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2b581b39-6ff7-465e-b28d-8e8dbdef52aa"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2de49840-07b0-478c-b045-a46e311bfc2d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("2e524aca-1a0f-4125-a7c7-da24663d327b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("346a6ce7-fd63-4788-9c8d-72da3a606b20"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("350bcba3-0e35-448a-b6a3-0da6d377e80e"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("3985bbaa-790d-4301-a500-02c0feac422f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("3fce95fa-36d0-452f-912f-a66689bcd54f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40e1f63e-7e31-4466-bd67-7aee4c28dd7f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40f3b8ce-43a1-4256-a8ae-9d96ea94f127"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("40f9158a-50bb-4800-b104-7f43f452b4da"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("41fa54be-cb59-42ad-a6bd-48f705b7bd7a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("45dc3263-0892-40fa-bc5b-2a9cd86be147"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("4787dab5-0205-412a-a0b3-d15f716a25f1"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("479d98e3-0a00-4294-9678-f0e03bd75048"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5074c5aa-b04b-41df-89a2-3177705c1a57"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51328c0e-fefd-4cf0-8407-9dd7e2e7afc4"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("51b70068-3066-4e06-a5ba-bf3cf1d9639f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("53ab9697-804f-4492-93c7-cfcf2c975c2a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("55c613db-7c7d-4c61-aaba-bdfb6ee2222b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("57b75328-ba3b-4c89-af42-f3f98f6460ec"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5e313fda-e478-4f37-9bd8-2310ed956e41"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("5f589b73-6307-4ba1-9b6e-a0aea9dbb10a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("616fcfd4-aad3-4881-8fc2-cfbbfa2077dd"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("632ba757-0dc2-4a89-8462-285041471db2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("64d9b4f9-b12a-4c66-9b12-e1f79e4b7878"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("6e3bd858-0dad-4cfb-ad3c-18ea0a51ba59"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7179302f-70cf-482c-9027-f94ed74ff7a1"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("773c3118-1127-4c00-b8ae-4acf2fff8e84"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("79509a95-2ce1-496e-82f6-98b31940c359"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7978618a-d7be-4975-8db9-648a435925ce"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("7f0b42f9-0602-4a55-b9d8-ced88911e477"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("80ca4742-e86a-4b7e-b1de-7d71184ee956"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("81725d34-8224-438c-995e-2a02006295fb"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("886cee20-5a0a-4f87-a059-aa0759c065d4"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("89c531da-3abc-4859-8337-408d8d556d06"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("89d12998-fd7a-4858-8f65-6ca330469d80"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8c19130d-a281-47f4-9753-697267f4ecbd"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8d5d44f6-39a9-4483-b121-ba884210360a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("8df4266c-fd44-4e86-8cf0-f030ca219e71"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("905a8ca1-92ef-445f-a4aa-1838d653af5b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("910cae89-7155-499f-8b69-0071b959fe59"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9420bbd8-3702-438b-9470-9fa5fff9a0ba"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("94c10218-2f11-4892-a64d-2c729f254536"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9951c3aa-3245-4a3b-ae23-26339b08ece0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9ae701b5-c513-4d0b-a2b1-eef8ef995e18"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("9e6064b5-db1e-456f-b113-0034f1a6fdd4"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a0ae585b-182f-4df1-b596-429571d81c3d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a29dae04-810f-4034-aad7-e293a28047aa"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a4dca733-6788-469b-9980-6da0759e8089"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a5f66dd3-7f64-4f32-90b3-19a8615380ab"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a6205571-be0e-4b95-9ffd-a5addedb4bd7"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("a82eaf8a-5cb2-4815-9394-59110a2a3699"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aa158c9c-5a68-4059-b1ae-e4085adcd51f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aa97700c-2471-4845-87c7-4d5d19e4e835"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aa9d9c94-ce3f-42a2-acff-84f85608748c"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aaa16c5a-126a-43fe-921e-d856958c576b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("abac6286-767d-4baa-bc63-2fcc3e70a48e"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("ac02f0ed-e9be-4cfa-99c8-2aa060954bd9"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("aed8237a-800e-47da-8aa7-b8935b0d4401"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("af068e17-d32c-43e2-9f3a-af0602ff6731"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b02698b9-8560-4c1b-967b-8c4cf7c68c03"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b07906a8-521b-4970-a421-2cc61520f749"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b1b7706a-3faa-4943-a8b2-6d3854a47ec4"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b7667346-a9df-4869-8ee4-814e44426b77"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b8a7ec77-865b-4864-b52c-e0951b48e322"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b8da47d7-edd8-484a-b06d-691a07b2739f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("b9ea8984-a752-4ac4-8bf2-e30a90e497d0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("ba4b51a1-460c-4a32-801e-1c65b8d624b5"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("bc199684-de95-437c-8d1a-8c1e8f6cc1d2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("bc5db5fe-b982-44e6-a591-b2596ccd5522"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("bf2ea4b1-05db-4175-96ca-87008a609fe9"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("c88d5f35-4c11-42a4-b355-d0052b08687e"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cc4601b6-d9f9-4094-bc57-7105aa236761"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cd8eb190-a455-4f5f-bc21-8900c829ad46"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("cec9cab3-beaf-440e-88ef-91452dc4b077"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("ceca8b5d-a8c6-457f-a681-eebcfacfe9f4"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("d3a98af4-5c3e-4b87-9938-788264ff9a36"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("d53d9426-a3d9-401c-b7b3-7af4974a6572"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("d8f9cc58-73bb-49cb-b8a5-c9693ff067de"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("dab66311-12f2-44ce-8719-83d67e21bfdd"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("de66382b-5819-4d2c-b0af-37e7eaf682b5"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("df288229-2da4-4832-9913-70c1a7e05e8f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e091b4cd-98f8-4fe3-97ba-9c016c7822e2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e57daddb-f9b7-483b-b4ab-153957577e7f"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e66354a9-760d-4826-a002-04a81ba09c8d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e73411bc-d4d7-4801-bdd9-d7df984b01aa"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("e848a319-5e9a-4dba-975d-8c1e5247a97a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("eea55b8b-fa03-4ecb-819a-ca9a6f9d43ef"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("eebeef97-4736-476c-99af-dfd4ed9f5255"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("efe5f9c2-9615-41b1-a4db-b229dea17bef"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("f160154b-b34a-49f6-89a8-0f80311d0641"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("f4f0a748-18a6-4546-b4d0-62ac473c7394"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "EmergencyDetail",
                keyColumn: "Id",
                keyValue: new Guid("fbf0061b-5f88-45f1-8546-ca2e9d5ed35d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("01ea28b2-56ff-44e8-883a-ef8890bd426d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("04e48a25-de79-4a3a-88be-33a8d5829017"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("05eb9523-cbad-4abb-97df-00159d409a78"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("090a2b95-7b45-4600-ad80-dd2853cc9685"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("0cb0d678-9454-4391-bd9e-2b536a50f1f7"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("0e53c113-06cc-4b91-8fd4-d5c62ea70309"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("1645e54a-16db-4c4c-8de9-3d86f1ee1a36"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("16cfebea-d7d0-440d-b4bd-43bbfe6610e0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b11f26c-7206-48a5-801c-9610b99b5738"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("2b7a46a0-f703-4dcf-b4f8-66826e128514"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("32475e06-c246-437b-9298-4523809622c2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("327ca2f9-33cd-421c-b0b2-288582ca465b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("3fe4bdf1-ebdf-43df-868a-09eb274f6f22"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("41455e11-ec85-4698-9a2d-f57c64a45762"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("46e01fa7-af0b-4d0f-8125-56b5772d191b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("4b467404-7405-430b-b458-8aacac949a5b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("4f09916e-7a24-455b-be1e-11340ae4ad68"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("514f5b35-23a3-489f-afc5-9c80511fab60"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5490695b-c2d8-4e4d-92e1-690da77e395d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("5a876ed2-ed72-40a0-b099-a50ba8028dd3"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("61105e2b-b22e-4eb2-897f-941818211986"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("65a9fd83-5d8b-4e25-93b8-4125d1281ab7"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("73a06b9b-83ab-46b1-90e3-3aa6c2773995"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("76d5c903-e2e0-4d17-a3bb-09b6a8ae6cd4"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("791a9161-5dab-4fa6-ad27-6b2694af4e5b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7b026ebe-11c7-4585-a395-2b42a4489647"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7c35e76d-56b9-4ebe-b66a-63e9ce2e9237"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("7c57b22b-c472-419c-ad81-ee87410c36de"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("831c6f2e-7c32-4ae6-8af6-fdb3897c612b"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("8ef3e270-6c5a-4393-9060-de98e98e6e84"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("91a89827-bdc9-4b2b-a318-65735075a8eb"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("995fd02a-9f64-45a5-9424-0ec2c9f891a0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("9bc401f4-517b-4765-885f-1c480893f229"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("a7247c61-4ce6-478c-8c6f-56df1c72fe1d"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("afcbcbd1-a29a-4647-b7b3-41c1f6fc45f0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b51c1608-7f38-427d-b4d7-c9cd62ff253e"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("b92e56fc-1be9-4973-9254-d9cd74a70414"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("bfe028fa-949f-44c8-95c9-fbb4537114c9"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("c4cce2a8-1b2e-4443-a59e-e4bec4f2fe0a"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("c55d01ce-f82b-4ef4-b9b2-42452d718e50"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("cd0aa7d8-c354-441d-9ed0-ec97d2e91ef2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ce0ced0c-38e6-4bdb-9d66-e5bfdfdc35ba"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ce2acc73-28a0-4dd4-9368-c71c81a60665"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("d9d4ba6a-da09-4482-bf40-e9f9a216cd03"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("ddbc8b2d-b7e7-445f-9a7b-2194f5ab7704"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("e4b92110-7298-48ea-bbe1-1cc21ccfe6b1"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("e9619b3b-a906-4ada-b211-84543a3b31df"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("f6b44c79-92d9-4128-9d6c-40aa134bf0b2"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fd228cde-7079-4d6a-835b-1df8215fa5bb"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: new Guid("fedb71a7-bb4b-441a-b30e-0af28d6d83a3"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("27891a29-9107-45a3-812c-766d52779ab7"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("636af2b3-96fe-4fed-9e59-23c5c5941a14"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("80ee8583-ff0b-49ae-81d2-0e5b0724ade7"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("a2ecd786-f8bd-47f8-8900-be1407c3ccd0"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("cbc76dac-42da-4b4b-807d-aab23b875e93"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e27d22b8-e12d-4906-985c-bcc6a28aeeab"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "MiniContent",
                keyColumn: "Id",
                keyValue: new Guid("e5919e2d-642b-46da-980d-ef68f365c0da"),
                column: "Created",
                value: new DateTime(2024, 3, 11, 16, 43, 13, 131, DateTimeKind.Local).AddTicks(8714));
        }
    }
}
