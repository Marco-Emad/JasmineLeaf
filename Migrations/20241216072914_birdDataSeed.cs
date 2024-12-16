using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JasmineLeaf.Migrations
{
    /// <inheritdoc />
    public partial class birdDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Stage",
                table: "Kolis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 1", "wwwroot/images/birddataset/Original/Original (1).jpeg", "Original (1)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 2", "wwwroot/images/birddataset/Original/Original (2).jpeg", "Original (2)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 3", "wwwroot/images/birddataset/Original/Original (3).jpeg", "Original (3)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 4", "wwwroot/images/birddataset/Original/Original (4).jpeg", "Original (4)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 5", "wwwroot/images/birddataset/Original/Original (5).jpeg", "Original (5)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 6", "wwwroot/images/birddataset/Original/Original (6).jpeg", "Original (6)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 7", "wwwroot/images/birddataset/Original/Original (7).jpeg", "Original (7)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 8", "wwwroot/images/birddataset/Original/Original (8).jpeg", "Original (8)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 9", "wwwroot/images/birddataset/Original/Original (9).jpeg", "Original (9)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 10", "wwwroot/images/birddataset/Original/Original (10).jpeg", "Original (10)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 11", "wwwroot/images/birddataset/Original/Original (11).jpeg", "Original (11)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 12", "wwwroot/images/birddataset/Original/Original (12).jpeg", "Original (12)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 13", "wwwroot/images/birddataset/Original/Original (13).jpeg", "Original (13)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 14", "wwwroot/images/birddataset/Original/Original (14).jpeg", "Original (14)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 15", "wwwroot/images/birddataset/Original/Original (15).jpeg", "Original (15)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 16", "wwwroot/images/birddataset/Original/Original (16).jpeg", "Original (16)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 17", "wwwroot/images/birddataset/Original/Original (17).jpeg", "Original (17)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 18", "wwwroot/images/birddataset/Original/Original (18).jpeg", "Original (18)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 19", "wwwroot/images/birddataset/Original/Original (19).jpeg", "Original (19)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 20", "wwwroot/images/birddataset/Original/Original (20).jpeg", "Original (20)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 21", "wwwroot/images/birddataset/Original/Original (21).jpeg", "Original (21)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 22", "wwwroot/images/birddataset/Original/Original (22).jpeg", "Original (22)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 23", "wwwroot/images/birddataset/Original/Original (23).jpeg", "Original (23)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 24", "wwwroot/images/birddataset/Original/Original (24).jpeg", "Original (24)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 25", "wwwroot/images/birddataset/Original/Original (25).jpeg", "Original (25)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 26", "wwwroot/images/birddataset/Original/Original (26).jpeg", "Original (26)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 27", "wwwroot/images/birddataset/Original/Original (27).jpeg", "Original (27)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 28", "wwwroot/images/birddataset/Original/Original (28).jpeg", "Original (28)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 29", "wwwroot/images/birddataset/Original/Original (29).jpeg", "Original (29)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 30", "wwwroot/images/birddataset/Original/Original (30).jpeg", "Original (30)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 31", "wwwroot/images/birddataset/Original/Original (31).jpeg", "Original (31)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 32", "wwwroot/images/birddataset/Original/Original (32).jpeg", "Original (32)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 33", "wwwroot/images/birddataset/Original/Original (33).jpeg", "Original (33)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 34", "wwwroot/images/birddataset/Original/Original (34).jpeg", "Original (34)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 35", "wwwroot/images/birddataset/Original/Original (35).jpeg", "Original (35)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 36", "wwwroot/images/birddataset/Original/Original (36).jpeg", "Original (36)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 37", "wwwroot/images/birddataset/Original/Original (37).jpeg", "Original (37)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 38", "wwwroot/images/birddataset/Original/Original (38).jpeg", "Original (38)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 39", "wwwroot/images/birddataset/Original/Original (39).jpeg", "Original (39)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 40", "wwwroot/images/birddataset/Original/Original (40).jpeg", "Original (40)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 41", "wwwroot/images/birddataset/Original/Original (41).jpeg", "Original (41)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 42", "wwwroot/images/birddataset/Original/Original (42).jpeg", "Original (42)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 43", "wwwroot/images/birddataset/Original/Original (43).jpeg", "Original (43)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 44", "wwwroot/images/birddataset/Original/Original (44).jpeg", "Original (44)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 45", "wwwroot/images/birddataset/Original/Original (45).jpeg", "Original (45)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 46", "wwwroot/images/birddataset/Original/Original (46).jpeg", "Original (46)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 47", "wwwroot/images/birddataset/Original/Original (47).jpeg", "Original (47)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 48", "wwwroot/images/birddataset/Original/Original (48).jpeg", "Original (48)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 49", "wwwroot/images/birddataset/Original/Original (49).jpeg", "Original (49)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 50", "wwwroot/images/birddataset/Original/Original (50).jpeg", "Original (50)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 51", "wwwroot/images/birddataset/Original/Original (51).jpeg", "Original (51)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 52", "wwwroot/images/birddataset/Original/Original (52).jpeg", "Original (52)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 53", "wwwroot/images/birddataset/Original/Original (53).jpeg", "Original (53)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 54", "wwwroot/images/birddataset/Original/Original (54).jpeg", "Original (54)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 55", "wwwroot/images/birddataset/Original/Original (55).jpeg", "Original (55)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 56", "wwwroot/images/birddataset/Original/Original (56).jpeg", "Original (56)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 57", "wwwroot/images/birddataset/Original/Original (57).jpeg", "Original (57)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 58", "wwwroot/images/birddataset/Original/Original (58).jpeg", "Original (58)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 59", "wwwroot/images/birddataset/Original/Original (59).jpeg", "Original (59)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 60", "wwwroot/images/birddataset/Original/Original (60).jpeg", "Original (60)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 61", "wwwroot/images/birddataset/Original/Original (61).jpeg", "Original (61)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 62", "wwwroot/images/birddataset/Original/Original (62).jpeg", "Original (62)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 63", "wwwroot/images/birddataset/Original/Original (63).jpeg", "Original (63)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 64", "wwwroot/images/birddataset/Original/Original (64).jpeg", "Original (64)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 65", "wwwroot/images/birddataset/Original/Original (65).jpeg", "Original (65)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 66", "wwwroot/images/birddataset/Original/Original (66).jpeg", "Original (66)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 67", "wwwroot/images/birddataset/Original/Original (67).jpeg", "Original (67)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 68", "wwwroot/images/birddataset/Original/Original (68).jpeg", "Original (68)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 69", "wwwroot/images/birddataset/Original/Original (69).jpeg", "Original (69)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 70", "wwwroot/images/birddataset/Original/Original (70).jpeg", "Original (70)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 71", "wwwroot/images/birddataset/Original/Original (71).jpeg", "Original (71)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 72", "wwwroot/images/birddataset/Original/Original (72).jpeg", "Original (72)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 73", "wwwroot/images/birddataset/Original/Original (73).jpeg", "Original (73)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 74", "wwwroot/images/birddataset/Original/Original (74).jpeg", "Original (74)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 75", "wwwroot/images/birddataset/Original/Original (75).jpeg", "Original (75)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 76", "wwwroot/images/birddataset/Original/Original (76).jpeg", "Original (76)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 77", "wwwroot/images/birddataset/Original/Original (77).jpeg", "Original (77)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 78", "wwwroot/images/birddataset/Original/Original (78).jpeg", "Original (78)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 79", "wwwroot/images/birddataset/Original/Original (79).jpeg", "Original (79)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 80", "wwwroot/images/birddataset/Original/Original (80).jpeg", "Original (80)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 81", "wwwroot/images/birddataset/Original/Original (81).jpeg", "Original (81)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 82", "wwwroot/images/birddataset/Original/Original (82).jpeg", "Original (82)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 83", "wwwroot/images/birddataset/Original/Original (83).jpeg", "Original (83)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 84", "wwwroot/images/birddataset/Original/Original (84).jpeg", "Original (84)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 85", "wwwroot/images/birddataset/Original/Original (85).jpeg", "Original (85)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 86", "wwwroot/images/birddataset/Original/Original (86).jpeg", "Original (86)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 87", "wwwroot/images/birddataset/Original/Original (87).jpeg", "Original (87)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 88", "wwwroot/images/birddataset/Original/Original (88).jpeg", "Original (88)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 89", "wwwroot/images/birddataset/Original/Original (89).jpeg", "Original (89)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 90", "wwwroot/images/birddataset/Original/Original (90).jpeg", "Original (90)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 91", "wwwroot/images/birddataset/Original/Original (91).jpeg", "Original (91)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 92", "wwwroot/images/birddataset/Original/Original (92).jpeg", "Original (92)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 93", "wwwroot/images/birddataset/Original/Original (93).jpeg", "Original (93)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 94", "wwwroot/images/birddataset/Original/Original (94).jpeg", "Original (94)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 95", "wwwroot/images/birddataset/Original/Original (95).jpeg", "Original (95)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 96", "wwwroot/images/birddataset/Original/Original (96).jpeg", "Original (96)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 97", "wwwroot/images/birddataset/Original/Original (97).jpeg", "Original (97)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 98", "wwwroot/images/birddataset/Original/Original (98).jpeg", "Original (98)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 99", "wwwroot/images/birddataset/Original/Original (99).jpeg", "Original (99)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 100", "wwwroot/images/birddataset/Original/Original (100).jpeg", "Original (100)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 101", "wwwroot/images/birddataset/Original/Original (101).jpeg", "Original (101)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 102", "wwwroot/images/birddataset/Original/Original (102).jpeg", "Original (102)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 103", "wwwroot/images/birddataset/Original/Original (103).jpeg", "Original (103)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 104", "wwwroot/images/birddataset/Original/Original (104).jpeg", "Original (104)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 105", "wwwroot/images/birddataset/Original/Original (105).jpeg", "Original (105)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 106", "wwwroot/images/birddataset/Original/Original (106).jpeg", "Original (106)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 107", "wwwroot/images/birddataset/Original/Original (107).jpeg", "Original (107)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 108", "wwwroot/images/birddataset/Original/Original (108).jpeg", "Original (108)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 109", "wwwroot/images/birddataset/Original/Original (109).jpeg", "Original (109)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 110", "wwwroot/images/birddataset/Original/Original (110).jpeg", "Original (110)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 111", "wwwroot/images/birddataset/Original/Original (111).jpeg", "Original (111)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 112", "wwwroot/images/birddataset/Original/Original (112).jpeg", "Original (112)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 113", "wwwroot/images/birddataset/Original/Original (113).jpeg", "Original (113)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 114", "wwwroot/images/birddataset/Original/Original (114).jpeg", "Original (114)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 115", "wwwroot/images/birddataset/Original/Original (115).jpeg", "Original (115)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 116", "wwwroot/images/birddataset/Original/Original (116).jpeg", "Original (116)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 117", "wwwroot/images/birddataset/Original/Original (117).jpeg", "Original (117)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 118", "wwwroot/images/birddataset/Original/Original (118).jpeg", "Original (118)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 119", "wwwroot/images/birddataset/Original/Original (119).jpeg", "Original (119)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 120", "wwwroot/images/birddataset/Original/Original (120).jpeg", "Original (120)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 121", "wwwroot/images/birddataset/Original/Original (121).jpeg", "Original (121)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 122", "wwwroot/images/birddataset/Original/Original (122).jpeg", "Original (122)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 123", "wwwroot/images/birddataset/Original/Original (123).jpeg", "Original (123)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 124", "wwwroot/images/birddataset/Original/Original (124).jpeg", "Original (124)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 125", "wwwroot/images/birddataset/Original/Original (125).jpeg", "Original (125)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 126", "wwwroot/images/birddataset/Original/Original (126).jpeg", "Original (126)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 127", "wwwroot/images/birddataset/Original/Original (127).jpeg", "Original (127)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 128", "wwwroot/images/birddataset/Original/Original (128).jpeg", "Original (128)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 129", "wwwroot/images/birddataset/Original/Original (129).jpeg", "Original (129)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 130", "wwwroot/images/birddataset/Original/Original (130).jpeg", "Original (130)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 131", "wwwroot/images/birddataset/Original/Original (131).jpeg", "Original (131)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 132", "wwwroot/images/birddataset/Original/Original (132).jpeg", "Original (132)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 133", "wwwroot/images/birddataset/Original/Original (133).jpeg", "Original (133)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 134", "wwwroot/images/birddataset/Original/Original (134).jpeg", "Original (134)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 135", "wwwroot/images/birddataset/Original/Original (135).jpeg", "Original (135)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 136", "wwwroot/images/birddataset/Original/Original (136).jpeg", "Original (136)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 137", "wwwroot/images/birddataset/Original/Original (137).jpeg", "Original (137)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 138", "wwwroot/images/birddataset/Original/Original (138).jpeg", "Original (138)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 139", "wwwroot/images/birddataset/Original/Original (139).jpeg", "Original (139)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 140", "wwwroot/images/birddataset/Original/Original (140).jpeg", "Original (140)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 141", "wwwroot/images/birddataset/Original/Original (141).jpeg", "Original (141)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 142", "wwwroot/images/birddataset/Original/Original (142).jpeg", "Original (142)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 143", "wwwroot/images/birddataset/Original/Original (143).jpeg", "Original (143)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 144", "wwwroot/images/birddataset/Original/Original (144).jpeg", "Original (144)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 145", "wwwroot/images/birddataset/Original/Original (145).jpeg", "Original (145)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 146", "wwwroot/images/birddataset/Original/Original (146).jpeg", "Original (146)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 147", "wwwroot/images/birddataset/Original/Original (147).jpeg", "Original (147)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 148", "wwwroot/images/birddataset/Original/Original (148).jpeg", "Original (148)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 149", "wwwroot/images/birddataset/Original/Original (149).jpeg", "Original (149)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 150", "wwwroot/images/birddataset/Original/Original (150).jpeg", "Original (150)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 151", "wwwroot/images/birddataset/Original/Original (151).jpeg", "Original (151)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 152", "wwwroot/images/birddataset/Original/Original (152).jpeg", "Original (152)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 153", "wwwroot/images/birddataset/Original/Original (153).jpeg", "Original (153)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 154", "wwwroot/images/birddataset/Original/Original (154).jpeg", "Original (154)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 155", "wwwroot/images/birddataset/Original/Original (155).jpeg", "Original (155)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 156", "wwwroot/images/birddataset/Original/Original (156).jpeg", "Original (156)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 157", "wwwroot/images/birddataset/Original/Original (157).jpeg", "Original (157)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 158", "wwwroot/images/birddataset/Original/Original (158).jpeg", "Original (158)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 159", "wwwroot/images/birddataset/Original/Original (159).jpeg", "Original (159)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 160", "wwwroot/images/birddataset/Original/Original (160).jpeg", "Original (160)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 161", "wwwroot/images/birddataset/Original/Original (161).jpeg", "Original (161)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 162", "wwwroot/images/birddataset/Original/Original (162).jpeg", "Original (162)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 163", "wwwroot/images/birddataset/Original/Original (163).jpeg", "Original (163)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 164", "wwwroot/images/birddataset/Original/Original (164).jpeg", "Original (164)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 165", "wwwroot/images/birddataset/Original/Original (165).jpeg", "Original (165)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 166", "wwwroot/images/birddataset/Original/Original (166).jpeg", "Original (166)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 167", "wwwroot/images/birddataset/Original/Original (167).jpeg", "Original (167)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 168", "wwwroot/images/birddataset/Original/Original (168).jpeg", "Original (168)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 169", "wwwroot/images/birddataset/Original/Original (169).jpeg", "Original (169)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 170", "wwwroot/images/birddataset/Original/Original (170).jpeg", "Original (170)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 171", "wwwroot/images/birddataset/Original/Original (171).jpeg", "Original (171)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 172", "wwwroot/images/birddataset/Original/Original (172).jpeg", "Original (172)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 173", "wwwroot/images/birddataset/Original/Original (173).jpeg", "Original (173)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 174", "wwwroot/images/birddataset/Original/Original (174).jpeg", "Original (174)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 175", "wwwroot/images/birddataset/Original/Original (175).jpeg", "Original (175)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 176", "wwwroot/images/birddataset/Original/Original (176).jpeg", "Original (176)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 177", "wwwroot/images/birddataset/Original/Original (177).jpeg", "Original (177)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 178", "wwwroot/images/birddataset/Original/Original (178).jpeg", "Original (178)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 179", "wwwroot/images/birddataset/Original/Original (179).jpeg", "Original (179)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 180", "wwwroot/images/birddataset/Original/Original (180).jpeg", "Original (180)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 181", "wwwroot/images/birddataset/Original/Original (181).jpeg", "Original (181)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 182", "wwwroot/images/birddataset/Original/Original (182).jpeg", "Original (182)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 183", "wwwroot/images/birddataset/Original/Original (183).jpeg", "Original (183)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 184", "wwwroot/images/birddataset/Original/Original (184).jpeg", "Original (184)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 185", "wwwroot/images/birddataset/Original/Original (185).jpeg", "Original (185)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 186", "wwwroot/images/birddataset/Original/Original (186).jpeg", "Original (186)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 187", "wwwroot/images/birddataset/Original/Original (187).jpeg", "Original (187)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 188", "wwwroot/images/birddataset/Original/Original (188).jpeg", "Original (188)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 189", "wwwroot/images/birddataset/Original/Original (189).jpeg", "Original (189)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 190", "wwwroot/images/birddataset/Original/Original (190).jpeg", "Original (190)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 191", "wwwroot/images/birddataset/Original/Original (191).jpeg", "Original (191)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 192", "wwwroot/images/birddataset/Original/Original (192).jpeg", "Original (192)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 193", "wwwroot/images/birddataset/Original/Original (193).jpeg", "Original (193)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 194", "wwwroot/images/birddataset/Original/Original (194).jpeg", "Original (194)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 195", "wwwroot/images/birddataset/Original/Original (195).jpeg", "Original (195)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 196", "wwwroot/images/birddataset/Original/Original (196).jpeg", "Original (196)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 197", "wwwroot/images/birddataset/Original/Original (197).jpeg", "Original (197)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 198", "wwwroot/images/birddataset/Original/Original (198).jpeg", "Original (198)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 199", "wwwroot/images/birddataset/Original/Original (199).jpeg", "Original (199)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 200", "wwwroot/images/birddataset/Original/Original (200).jpeg", "Original (200)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 201", "wwwroot/images/birddataset/Original/Original (201).jpeg", "Original (201)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 202", "wwwroot/images/birddataset/Original/Original (202).jpeg", "Original (202)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 203", "wwwroot/images/birddataset/Original/Original (203).jpeg", "Original (203)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 204", "wwwroot/images/birddataset/Original/Original (204).jpeg", "Original (204)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 205", "wwwroot/images/birddataset/Original/Original (205).jpeg", "Original (205)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 206", "wwwroot/images/birddataset/Original/Original (206).jpeg", "Original (206)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 207", "wwwroot/images/birddataset/Original/Original (207).jpeg", "Original (207)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 208", "wwwroot/images/birddataset/Original/Original (208).jpeg", "Original (208)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 209", "wwwroot/images/birddataset/Original/Original (209).jpeg", "Original (209)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 210", "wwwroot/images/birddataset/Original/Original (210).jpeg", "Original (210)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 211", "wwwroot/images/birddataset/Original/Original (211).jpeg", "Original (211)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 212", "wwwroot/images/birddataset/Original/Original (212).jpeg", "Original (212)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 213", "wwwroot/images/birddataset/Original/Original (213).jpeg", "Original (213)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 214", "wwwroot/images/birddataset/Original/Original (214).jpeg", "Original (214)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 215", "wwwroot/images/birddataset/Original/Original (215).jpeg", "Original (215)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 216", "wwwroot/images/birddataset/Original/Original (216).jpeg", "Original (216)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 217", "wwwroot/images/birddataset/Original/Original (217).jpeg", "Original (217)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 218", "wwwroot/images/birddataset/Original/Original (218).jpeg", "Original (218)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 219", "wwwroot/images/birddataset/Original/Original (219).jpeg", "Original (219)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 220", "wwwroot/images/birddataset/Original/Original (220).jpeg", "Original (220)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 221", "wwwroot/images/birddataset/Original/Original (221).jpeg", "Original (221)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 222", "wwwroot/images/birddataset/Original/Original (222).jpeg", "Original (222)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 223", "wwwroot/images/birddataset/Original/Original (223).jpeg", "Original (223)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 224", "wwwroot/images/birddataset/Original/Original (224).jpeg", "Original (224)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 225", "wwwroot/images/birddataset/Original/Original (225).jpeg", "Original (225)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 226", "wwwroot/images/birddataset/Original/Original (226).jpeg", "Original (226)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 227", "wwwroot/images/birddataset/Original/Original (227).jpeg", "Original (227)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 228", "wwwroot/images/birddataset/Original/Original (228).jpeg", "Original (228)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 229", "wwwroot/images/birddataset/Original/Original (229).jpeg", "Original (229)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 230", "wwwroot/images/birddataset/Original/Original (230).jpeg", "Original (230)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 231", "wwwroot/images/birddataset/Original/Original (231).jpeg", "Original (231)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 232", "wwwroot/images/birddataset/Original/Original (232).jpeg", "Original (232)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 233", "wwwroot/images/birddataset/Original/Original (233).jpeg", "Original (233)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 234", "wwwroot/images/birddataset/Original/Original (234).jpeg", "Original (234)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 235", "wwwroot/images/birddataset/Original/Original (235).jpeg", "Original (235)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 236", "wwwroot/images/birddataset/Original/Original (236).jpeg", "Original (236)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 237", "wwwroot/images/birddataset/Original/Original (237).jpeg", "Original (237)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 238", "wwwroot/images/birddataset/Original/Original (238).jpeg", "Original (238)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 239", "wwwroot/images/birddataset/Original/Original (239).jpeg", "Original (239)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 240", "wwwroot/images/birddataset/Original/Original (240).jpeg", "Original (240)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 241", "wwwroot/images/birddataset/Original/Original (241).jpeg", "Original (241)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 242", "wwwroot/images/birddataset/Original/Original (242).jpeg", "Original (242)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 243", "wwwroot/images/birddataset/Original/Original (243).jpeg", "Original (243)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 244", "wwwroot/images/birddataset/Original/Original (244).jpeg", "Original (244)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 245", "wwwroot/images/birddataset/Original/Original (245).jpeg", "Original (245)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 246", "wwwroot/images/birddataset/Original/Original (246).jpeg", "Original (246)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 247", "wwwroot/images/birddataset/Original/Original (247).jpeg", "Original (247)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 248", "wwwroot/images/birddataset/Original/Original (248).jpeg", "Original (248)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 249", "wwwroot/images/birddataset/Original/Original (249).jpeg", "Original (249)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 250", "wwwroot/images/birddataset/Original/Original (250).jpeg", "Original (250)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 251", "wwwroot/images/birddataset/Original/Original (251).jpeg", "Original (251)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 252", "wwwroot/images/birddataset/Original/Original (252).jpeg", "Original (252)", "Original" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Description", "Image", "Name", "Stage" },
                values: new object[] { "Description for Bird Original 253", "wwwroot/images/birddataset/Original/Original (253).jpeg", "Original (253)", "Original" });

            migrationBuilder.InsertData(
                table: "Kolis",
                columns: new[] { "Id", "Description", "Image", "Name", "Stage" },
                values: new object[,]
                {
                    { 254, "Description for Bird Original 254", "wwwroot/images/birddataset/Original/Original (254).jpeg", "Original (254)", "Original" },
                    { 255, "Description for Bird Original 255", "wwwroot/images/birddataset/Original/Original (255).jpeg", "Original (255)", "Original" },
                    { 256, "Description for Bird Original 256", "wwwroot/images/birddataset/Original/Original (256).jpeg", "Original (256)", "Original" },
                    { 257, "Description for Bird Original 257", "wwwroot/images/birddataset/Original/Original (257).jpeg", "Original (257)", "Original" },
                    { 258, "Description for Bird Original 258", "wwwroot/images/birddataset/Original/Original (258).jpeg", "Original (258)", "Original" },
                    { 259, "Description for Bird Blurred 1", "wwwroot/images/birddataset/Blurred/Blurred (1).jpeg", "Blurred (1)", "Blurred" },
                    { 260, "Description for Bird Blurred 2", "wwwroot/images/birddataset/Blurred/Blurred (2).jpeg", "Blurred (2)", "Blurred" },
                    { 261, "Description for Bird Blurred 3", "wwwroot/images/birddataset/Blurred/Blurred (3).jpeg", "Blurred (3)", "Blurred" },
                    { 262, "Description for Bird Blurred 4", "wwwroot/images/birddataset/Blurred/Blurred (4).jpeg", "Blurred (4)", "Blurred" },
                    { 263, "Description for Bird Blurred 5", "wwwroot/images/birddataset/Blurred/Blurred (5).jpeg", "Blurred (5)", "Blurred" },
                    { 264, "Description for Bird Blurred 6", "wwwroot/images/birddataset/Blurred/Blurred (6).jpeg", "Blurred (6)", "Blurred" },
                    { 265, "Description for Bird Blurred 7", "wwwroot/images/birddataset/Blurred/Blurred (7).jpeg", "Blurred (7)", "Blurred" },
                    { 266, "Description for Bird Blurred 8", "wwwroot/images/birddataset/Blurred/Blurred (8).jpeg", "Blurred (8)", "Blurred" },
                    { 267, "Description for Bird Blurred 9", "wwwroot/images/birddataset/Blurred/Blurred (9).jpeg", "Blurred (9)", "Blurred" },
                    { 268, "Description for Bird Blurred 10", "wwwroot/images/birddataset/Blurred/Blurred (10).jpeg", "Blurred (10)", "Blurred" },
                    { 269, "Description for Bird Blurred 11", "wwwroot/images/birddataset/Blurred/Blurred (11).jpeg", "Blurred (11)", "Blurred" },
                    { 270, "Description for Bird Blurred 12", "wwwroot/images/birddataset/Blurred/Blurred (12).jpeg", "Blurred (12)", "Blurred" },
                    { 271, "Description for Bird Blurred 13", "wwwroot/images/birddataset/Blurred/Blurred (13).jpeg", "Blurred (13)", "Blurred" },
                    { 272, "Description for Bird Blurred 14", "wwwroot/images/birddataset/Blurred/Blurred (14).jpeg", "Blurred (14)", "Blurred" },
                    { 273, "Description for Bird Blurred 15", "wwwroot/images/birddataset/Blurred/Blurred (15).jpeg", "Blurred (15)", "Blurred" },
                    { 274, "Description for Bird Blurred 16", "wwwroot/images/birddataset/Blurred/Blurred (16).jpeg", "Blurred (16)", "Blurred" },
                    { 275, "Description for Bird Blurred 17", "wwwroot/images/birddataset/Blurred/Blurred (17).jpeg", "Blurred (17)", "Blurred" },
                    { 276, "Description for Bird Blurred 18", "wwwroot/images/birddataset/Blurred/Blurred (18).jpeg", "Blurred (18)", "Blurred" },
                    { 277, "Description for Bird Blurred 19", "wwwroot/images/birddataset/Blurred/Blurred (19).jpeg", "Blurred (19)", "Blurred" },
                    { 278, "Description for Bird Blurred 20", "wwwroot/images/birddataset/Blurred/Blurred (20).jpeg", "Blurred (20)", "Blurred" },
                    { 279, "Description for Bird Blurred 21", "wwwroot/images/birddataset/Blurred/Blurred (21).jpeg", "Blurred (21)", "Blurred" },
                    { 280, "Description for Bird Blurred 22", "wwwroot/images/birddataset/Blurred/Blurred (22).jpeg", "Blurred (22)", "Blurred" },
                    { 281, "Description for Bird Blurred 23", "wwwroot/images/birddataset/Blurred/Blurred (23).jpeg", "Blurred (23)", "Blurred" },
                    { 282, "Description for Bird Blurred 24", "wwwroot/images/birddataset/Blurred/Blurred (24).jpeg", "Blurred (24)", "Blurred" },
                    { 283, "Description for Bird Blurred 25", "wwwroot/images/birddataset/Blurred/Blurred (25).jpeg", "Blurred (25)", "Blurred" },
                    { 284, "Description for Bird Blurred 26", "wwwroot/images/birddataset/Blurred/Blurred (26).jpeg", "Blurred (26)", "Blurred" },
                    { 285, "Description for Bird Blurred 27", "wwwroot/images/birddataset/Blurred/Blurred (27).jpeg", "Blurred (27)", "Blurred" },
                    { 286, "Description for Bird Blurred 28", "wwwroot/images/birddataset/Blurred/Blurred (28).jpeg", "Blurred (28)", "Blurred" },
                    { 287, "Description for Bird Blurred 29", "wwwroot/images/birddataset/Blurred/Blurred (29).jpeg", "Blurred (29)", "Blurred" },
                    { 288, "Description for Bird Blurred 30", "wwwroot/images/birddataset/Blurred/Blurred (30).jpeg", "Blurred (30)", "Blurred" },
                    { 289, "Description for Bird Blurred 31", "wwwroot/images/birddataset/Blurred/Blurred (31).jpeg", "Blurred (31)", "Blurred" },
                    { 290, "Description for Bird Blurred 32", "wwwroot/images/birddataset/Blurred/Blurred (32).jpeg", "Blurred (32)", "Blurred" },
                    { 291, "Description for Bird Blurred 33", "wwwroot/images/birddataset/Blurred/Blurred (33).jpeg", "Blurred (33)", "Blurred" },
                    { 292, "Description for Bird Blurred 34", "wwwroot/images/birddataset/Blurred/Blurred (34).jpeg", "Blurred (34)", "Blurred" },
                    { 293, "Description for Bird Blurred 35", "wwwroot/images/birddataset/Blurred/Blurred (35).jpeg", "Blurred (35)", "Blurred" },
                    { 294, "Description for Bird Blurred 36", "wwwroot/images/birddataset/Blurred/Blurred (36).jpeg", "Blurred (36)", "Blurred" },
                    { 295, "Description for Bird Blurred 37", "wwwroot/images/birddataset/Blurred/Blurred (37).jpeg", "Blurred (37)", "Blurred" },
                    { 296, "Description for Bird Blurred 38", "wwwroot/images/birddataset/Blurred/Blurred (38).jpeg", "Blurred (38)", "Blurred" },
                    { 297, "Description for Bird Blurred 39", "wwwroot/images/birddataset/Blurred/Blurred (39).jpeg", "Blurred (39)", "Blurred" },
                    { 298, "Description for Bird Blurred 40", "wwwroot/images/birddataset/Blurred/Blurred (40).jpeg", "Blurred (40)", "Blurred" },
                    { 299, "Description for Bird Blurred 41", "wwwroot/images/birddataset/Blurred/Blurred (41).jpeg", "Blurred (41)", "Blurred" },
                    { 300, "Description for Bird Blurred 42", "wwwroot/images/birddataset/Blurred/Blurred (42).jpeg", "Blurred (42)", "Blurred" },
                    { 301, "Description for Bird Blurred 43", "wwwroot/images/birddataset/Blurred/Blurred (43).jpeg", "Blurred (43)", "Blurred" },
                    { 302, "Description for Bird Blurred 44", "wwwroot/images/birddataset/Blurred/Blurred (44).jpeg", "Blurred (44)", "Blurred" },
                    { 303, "Description for Bird Blurred 45", "wwwroot/images/birddataset/Blurred/Blurred (45).jpeg", "Blurred (45)", "Blurred" },
                    { 304, "Description for Bird Blurred 46", "wwwroot/images/birddataset/Blurred/Blurred (46).jpeg", "Blurred (46)", "Blurred" },
                    { 305, "Description for Bird Blurred 47", "wwwroot/images/birddataset/Blurred/Blurred (47).jpeg", "Blurred (47)", "Blurred" },
                    { 306, "Description for Bird Blurred 48", "wwwroot/images/birddataset/Blurred/Blurred (48).jpeg", "Blurred (48)", "Blurred" },
                    { 307, "Description for Bird Blurred 49", "wwwroot/images/birddataset/Blurred/Blurred (49).jpeg", "Blurred (49)", "Blurred" },
                    { 308, "Description for Bird Blurred 50", "wwwroot/images/birddataset/Blurred/Blurred (50).jpeg", "Blurred (50)", "Blurred" },
                    { 309, "Description for Bird Blurred 51", "wwwroot/images/birddataset/Blurred/Blurred (51).jpeg", "Blurred (51)", "Blurred" },
                    { 310, "Description for Bird Blurred 52", "wwwroot/images/birddataset/Blurred/Blurred (52).jpeg", "Blurred (52)", "Blurred" },
                    { 311, "Description for Bird Blurred 53", "wwwroot/images/birddataset/Blurred/Blurred (53).jpeg", "Blurred (53)", "Blurred" },
                    { 312, "Description for Bird Blurred 54", "wwwroot/images/birddataset/Blurred/Blurred (54).jpeg", "Blurred (54)", "Blurred" },
                    { 313, "Description for Bird Blurred 55", "wwwroot/images/birddataset/Blurred/Blurred (55).jpeg", "Blurred (55)", "Blurred" },
                    { 314, "Description for Bird Blurred 56", "wwwroot/images/birddataset/Blurred/Blurred (56).jpeg", "Blurred (56)", "Blurred" },
                    { 315, "Description for Bird Blurred 57", "wwwroot/images/birddataset/Blurred/Blurred (57).jpeg", "Blurred (57)", "Blurred" },
                    { 316, "Description for Bird Blurred 58", "wwwroot/images/birddataset/Blurred/Blurred (58).jpeg", "Blurred (58)", "Blurred" },
                    { 317, "Description for Bird Blurred 59", "wwwroot/images/birddataset/Blurred/Blurred (59).jpeg", "Blurred (59)", "Blurred" },
                    { 318, "Description for Bird Blurred 60", "wwwroot/images/birddataset/Blurred/Blurred (60).jpeg", "Blurred (60)", "Blurred" },
                    { 319, "Description for Bird Blurred 61", "wwwroot/images/birddataset/Blurred/Blurred (61).jpeg", "Blurred (61)", "Blurred" },
                    { 320, "Description for Bird Blurred 62", "wwwroot/images/birddataset/Blurred/Blurred (62).jpeg", "Blurred (62)", "Blurred" },
                    { 321, "Description for Bird Blurred 63", "wwwroot/images/birddataset/Blurred/Blurred (63).jpeg", "Blurred (63)", "Blurred" },
                    { 322, "Description for Bird Blurred 64", "wwwroot/images/birddataset/Blurred/Blurred (64).jpeg", "Blurred (64)", "Blurred" },
                    { 323, "Description for Bird Blurred 65", "wwwroot/images/birddataset/Blurred/Blurred (65).jpeg", "Blurred (65)", "Blurred" },
                    { 324, "Description for Bird Blurred 66", "wwwroot/images/birddataset/Blurred/Blurred (66).jpeg", "Blurred (66)", "Blurred" },
                    { 325, "Description for Bird Blurred 67", "wwwroot/images/birddataset/Blurred/Blurred (67).jpeg", "Blurred (67)", "Blurred" },
                    { 326, "Description for Bird Blurred 68", "wwwroot/images/birddataset/Blurred/Blurred (68).jpeg", "Blurred (68)", "Blurred" },
                    { 327, "Description for Bird Blurred 69", "wwwroot/images/birddataset/Blurred/Blurred (69).jpeg", "Blurred (69)", "Blurred" },
                    { 328, "Description for Bird Blurred 70", "wwwroot/images/birddataset/Blurred/Blurred (70).jpeg", "Blurred (70)", "Blurred" },
                    { 329, "Description for Bird Blurred 71", "wwwroot/images/birddataset/Blurred/Blurred (71).jpeg", "Blurred (71)", "Blurred" },
                    { 330, "Description for Bird Blurred 72", "wwwroot/images/birddataset/Blurred/Blurred (72).jpeg", "Blurred (72)", "Blurred" },
                    { 331, "Description for Bird Blurred 73", "wwwroot/images/birddataset/Blurred/Blurred (73).jpeg", "Blurred (73)", "Blurred" },
                    { 332, "Description for Bird Blurred 74", "wwwroot/images/birddataset/Blurred/Blurred (74).jpeg", "Blurred (74)", "Blurred" },
                    { 333, "Description for Bird Blurred 75", "wwwroot/images/birddataset/Blurred/Blurred (75).jpeg", "Blurred (75)", "Blurred" },
                    { 334, "Description for Bird Blurred 76", "wwwroot/images/birddataset/Blurred/Blurred (76).jpeg", "Blurred (76)", "Blurred" },
                    { 335, "Description for Bird Blurred 77", "wwwroot/images/birddataset/Blurred/Blurred (77).jpeg", "Blurred (77)", "Blurred" },
                    { 336, "Description for Bird Blurred 78", "wwwroot/images/birddataset/Blurred/Blurred (78).jpeg", "Blurred (78)", "Blurred" },
                    { 337, "Description for Bird Blurred 79", "wwwroot/images/birddataset/Blurred/Blurred (79).jpeg", "Blurred (79)", "Blurred" },
                    { 338, "Description for Bird Blurred 80", "wwwroot/images/birddataset/Blurred/Blurred (80).jpeg", "Blurred (80)", "Blurred" },
                    { 339, "Description for Bird Blurred 81", "wwwroot/images/birddataset/Blurred/Blurred (81).jpeg", "Blurred (81)", "Blurred" },
                    { 340, "Description for Bird Blurred 82", "wwwroot/images/birddataset/Blurred/Blurred (82).jpeg", "Blurred (82)", "Blurred" },
                    { 341, "Description for Bird Blurred 83", "wwwroot/images/birddataset/Blurred/Blurred (83).jpeg", "Blurred (83)", "Blurred" },
                    { 342, "Description for Bird Blurred 84", "wwwroot/images/birddataset/Blurred/Blurred (84).jpeg", "Blurred (84)", "Blurred" },
                    { 343, "Description for Bird Blurred 85", "wwwroot/images/birddataset/Blurred/Blurred (85).jpeg", "Blurred (85)", "Blurred" },
                    { 344, "Description for Bird Blurred 86", "wwwroot/images/birddataset/Blurred/Blurred (86).jpeg", "Blurred (86)", "Blurred" },
                    { 345, "Description for Bird Blurred 87", "wwwroot/images/birddataset/Blurred/Blurred (87).jpeg", "Blurred (87)", "Blurred" },
                    { 346, "Description for Bird Blurred 88", "wwwroot/images/birddataset/Blurred/Blurred (88).jpeg", "Blurred (88)", "Blurred" },
                    { 347, "Description for Bird Blurred 89", "wwwroot/images/birddataset/Blurred/Blurred (89).jpeg", "Blurred (89)", "Blurred" },
                    { 348, "Description for Bird Blurred 90", "wwwroot/images/birddataset/Blurred/Blurred (90).jpeg", "Blurred (90)", "Blurred" },
                    { 349, "Description for Bird Blurred 91", "wwwroot/images/birddataset/Blurred/Blurred (91).jpeg", "Blurred (91)", "Blurred" },
                    { 350, "Description for Bird Blurred 92", "wwwroot/images/birddataset/Blurred/Blurred (92).jpeg", "Blurred (92)", "Blurred" },
                    { 351, "Description for Bird Blurred 93", "wwwroot/images/birddataset/Blurred/Blurred (93).jpeg", "Blurred (93)", "Blurred" },
                    { 352, "Description for Bird Blurred 94", "wwwroot/images/birddataset/Blurred/Blurred (94).jpeg", "Blurred (94)", "Blurred" },
                    { 353, "Description for Bird Blurred 95", "wwwroot/images/birddataset/Blurred/Blurred (95).jpeg", "Blurred (95)", "Blurred" },
                    { 354, "Description for Bird Blurred 96", "wwwroot/images/birddataset/Blurred/Blurred (96).jpeg", "Blurred (96)", "Blurred" },
                    { 355, "Description for Bird Blurred 97", "wwwroot/images/birddataset/Blurred/Blurred (97).jpeg", "Blurred (97)", "Blurred" },
                    { 356, "Description for Bird Blurred 98", "wwwroot/images/birddataset/Blurred/Blurred (98).jpeg", "Blurred (98)", "Blurred" },
                    { 357, "Description for Bird Blurred 99", "wwwroot/images/birddataset/Blurred/Blurred (99).jpeg", "Blurred (99)", "Blurred" },
                    { 358, "Description for Bird Blurred 100", "wwwroot/images/birddataset/Blurred/Blurred (100).jpeg", "Blurred (100)", "Blurred" },
                    { 359, "Description for Bird Blurred 101", "wwwroot/images/birddataset/Blurred/Blurred (101).jpeg", "Blurred (101)", "Blurred" },
                    { 360, "Description for Bird Blurred 102", "wwwroot/images/birddataset/Blurred/Blurred (102).jpeg", "Blurred (102)", "Blurred" },
                    { 361, "Description for Bird Blurred 103", "wwwroot/images/birddataset/Blurred/Blurred (103).jpeg", "Blurred (103)", "Blurred" },
                    { 362, "Description for Bird Blurred 104", "wwwroot/images/birddataset/Blurred/Blurred (104).jpeg", "Blurred (104)", "Blurred" },
                    { 363, "Description for Bird Blurred 105", "wwwroot/images/birddataset/Blurred/Blurred (105).jpeg", "Blurred (105)", "Blurred" },
                    { 364, "Description for Bird Blurred 106", "wwwroot/images/birddataset/Blurred/Blurred (106).jpeg", "Blurred (106)", "Blurred" },
                    { 365, "Description for Bird Blurred 107", "wwwroot/images/birddataset/Blurred/Blurred (107).jpeg", "Blurred (107)", "Blurred" },
                    { 366, "Description for Bird Blurred 108", "wwwroot/images/birddataset/Blurred/Blurred (108).jpeg", "Blurred (108)", "Blurred" },
                    { 367, "Description for Bird Blurred 109", "wwwroot/images/birddataset/Blurred/Blurred (109).jpeg", "Blurred (109)", "Blurred" },
                    { 368, "Description for Bird Blurred 110", "wwwroot/images/birddataset/Blurred/Blurred (110).jpeg", "Blurred (110)", "Blurred" },
                    { 369, "Description for Bird Blurred 111", "wwwroot/images/birddataset/Blurred/Blurred (111).jpeg", "Blurred (111)", "Blurred" },
                    { 370, "Description for Bird Blurred 112", "wwwroot/images/birddataset/Blurred/Blurred (112).jpeg", "Blurred (112)", "Blurred" },
                    { 371, "Description for Bird Blurred 113", "wwwroot/images/birddataset/Blurred/Blurred (113).jpeg", "Blurred (113)", "Blurred" },
                    { 372, "Description for Bird Blurred 114", "wwwroot/images/birddataset/Blurred/Blurred (114).jpeg", "Blurred (114)", "Blurred" },
                    { 373, "Description for Bird Blurred 115", "wwwroot/images/birddataset/Blurred/Blurred (115).jpeg", "Blurred (115)", "Blurred" },
                    { 374, "Description for Bird Blurred 116", "wwwroot/images/birddataset/Blurred/Blurred (116).jpeg", "Blurred (116)", "Blurred" },
                    { 375, "Description for Bird Blurred 117", "wwwroot/images/birddataset/Blurred/Blurred (117).jpeg", "Blurred (117)", "Blurred" },
                    { 376, "Description for Bird Blurred 118", "wwwroot/images/birddataset/Blurred/Blurred (118).jpeg", "Blurred (118)", "Blurred" },
                    { 377, "Description for Bird Blurred 119", "wwwroot/images/birddataset/Blurred/Blurred (119).jpeg", "Blurred (119)", "Blurred" },
                    { 378, "Description for Bird Blurred 120", "wwwroot/images/birddataset/Blurred/Blurred (120).jpeg", "Blurred (120)", "Blurred" },
                    { 379, "Description for Bird Blurred 121", "wwwroot/images/birddataset/Blurred/Blurred (121).jpeg", "Blurred (121)", "Blurred" },
                    { 380, "Description for Bird Blurred 122", "wwwroot/images/birddataset/Blurred/Blurred (122).jpeg", "Blurred (122)", "Blurred" },
                    { 381, "Description for Bird Blurred 123", "wwwroot/images/birddataset/Blurred/Blurred (123).jpeg", "Blurred (123)", "Blurred" },
                    { 382, "Description for Bird Blurred 124", "wwwroot/images/birddataset/Blurred/Blurred (124).jpeg", "Blurred (124)", "Blurred" },
                    { 383, "Description for Bird Blurred 125", "wwwroot/images/birddataset/Blurred/Blurred (125).jpeg", "Blurred (125)", "Blurred" },
                    { 384, "Description for Bird Blurred 126", "wwwroot/images/birddataset/Blurred/Blurred (126).jpeg", "Blurred (126)", "Blurred" },
                    { 385, "Description for Bird Blurred 127", "wwwroot/images/birddataset/Blurred/Blurred (127).jpeg", "Blurred (127)", "Blurred" },
                    { 386, "Description for Bird Blurred 128", "wwwroot/images/birddataset/Blurred/Blurred (128).jpeg", "Blurred (128)", "Blurred" },
                    { 387, "Description for Bird Blurred 129", "wwwroot/images/birddataset/Blurred/Blurred (129).jpeg", "Blurred (129)", "Blurred" },
                    { 388, "Description for Bird Blurred 130", "wwwroot/images/birddataset/Blurred/Blurred (130).jpeg", "Blurred (130)", "Blurred" },
                    { 389, "Description for Bird Blurred 131", "wwwroot/images/birddataset/Blurred/Blurred (131).jpeg", "Blurred (131)", "Blurred" },
                    { 390, "Description for Bird Blurred 132", "wwwroot/images/birddataset/Blurred/Blurred (132).jpeg", "Blurred (132)", "Blurred" },
                    { 391, "Description for Bird Blurred 133", "wwwroot/images/birddataset/Blurred/Blurred (133).jpeg", "Blurred (133)", "Blurred" },
                    { 392, "Description for Bird Blurred 134", "wwwroot/images/birddataset/Blurred/Blurred (134).jpeg", "Blurred (134)", "Blurred" },
                    { 393, "Description for Bird Blurred 135", "wwwroot/images/birddataset/Blurred/Blurred (135).jpeg", "Blurred (135)", "Blurred" },
                    { 394, "Description for Bird Blurred 136", "wwwroot/images/birddataset/Blurred/Blurred (136).jpeg", "Blurred (136)", "Blurred" },
                    { 395, "Description for Bird Blurred 137", "wwwroot/images/birddataset/Blurred/Blurred (137).jpeg", "Blurred (137)", "Blurred" },
                    { 396, "Description for Bird Blurred 138", "wwwroot/images/birddataset/Blurred/Blurred (138).jpeg", "Blurred (138)", "Blurred" },
                    { 397, "Description for Bird Blurred 139", "wwwroot/images/birddataset/Blurred/Blurred (139).jpeg", "Blurred (139)", "Blurred" },
                    { 398, "Description for Bird Blurred 140", "wwwroot/images/birddataset/Blurred/Blurred (140).jpeg", "Blurred (140)", "Blurred" },
                    { 399, "Description for Bird Blurred 141", "wwwroot/images/birddataset/Blurred/Blurred (141).jpeg", "Blurred (141)", "Blurred" },
                    { 400, "Description for Bird Blurred 142", "wwwroot/images/birddataset/Blurred/Blurred (142).jpeg", "Blurred (142)", "Blurred" },
                    { 401, "Description for Bird Blurred 143", "wwwroot/images/birddataset/Blurred/Blurred (143).jpeg", "Blurred (143)", "Blurred" },
                    { 402, "Description for Bird Blurred 144", "wwwroot/images/birddataset/Blurred/Blurred (144).jpeg", "Blurred (144)", "Blurred" },
                    { 403, "Description for Bird Blurred 145", "wwwroot/images/birddataset/Blurred/Blurred (145).jpeg", "Blurred (145)", "Blurred" },
                    { 404, "Description for Bird Blurred 146", "wwwroot/images/birddataset/Blurred/Blurred (146).jpeg", "Blurred (146)", "Blurred" },
                    { 405, "Description for Bird Blurred 147", "wwwroot/images/birddataset/Blurred/Blurred (147).jpeg", "Blurred (147)", "Blurred" },
                    { 406, "Description for Bird Blurred 148", "wwwroot/images/birddataset/Blurred/Blurred (148).jpeg", "Blurred (148)", "Blurred" },
                    { 407, "Description for Bird Blurred 149", "wwwroot/images/birddataset/Blurred/Blurred (149).jpeg", "Blurred (149)", "Blurred" },
                    { 408, "Description for Bird Blurred 150", "wwwroot/images/birddataset/Blurred/Blurred (150).jpeg", "Blurred (150)", "Blurred" },
                    { 409, "Description for Bird Blurred 151", "wwwroot/images/birddataset/Blurred/Blurred (151).jpeg", "Blurred (151)", "Blurred" },
                    { 410, "Description for Bird Blurred 152", "wwwroot/images/birddataset/Blurred/Blurred (152).jpeg", "Blurred (152)", "Blurred" },
                    { 411, "Description for Bird Blurred 153", "wwwroot/images/birddataset/Blurred/Blurred (153).jpeg", "Blurred (153)", "Blurred" },
                    { 412, "Description for Bird Blurred 154", "wwwroot/images/birddataset/Blurred/Blurred (154).jpeg", "Blurred (154)", "Blurred" },
                    { 413, "Description for Bird Blurred 155", "wwwroot/images/birddataset/Blurred/Blurred (155).jpeg", "Blurred (155)", "Blurred" },
                    { 414, "Description for Bird Blurred 156", "wwwroot/images/birddataset/Blurred/Blurred (156).jpeg", "Blurred (156)", "Blurred" },
                    { 415, "Description for Bird Blurred 157", "wwwroot/images/birddataset/Blurred/Blurred (157).jpeg", "Blurred (157)", "Blurred" },
                    { 416, "Description for Bird Blurred 158", "wwwroot/images/birddataset/Blurred/Blurred (158).jpeg", "Blurred (158)", "Blurred" },
                    { 417, "Description for Bird Blurred 159", "wwwroot/images/birddataset/Blurred/Blurred (159).jpeg", "Blurred (159)", "Blurred" },
                    { 418, "Description for Bird Blurred 160", "wwwroot/images/birddataset/Blurred/Blurred (160).jpeg", "Blurred (160)", "Blurred" },
                    { 419, "Description for Bird Blurred 161", "wwwroot/images/birddataset/Blurred/Blurred (161).jpeg", "Blurred (161)", "Blurred" },
                    { 420, "Description for Bird Blurred 162", "wwwroot/images/birddataset/Blurred/Blurred (162).jpeg", "Blurred (162)", "Blurred" },
                    { 421, "Description for Bird Blurred 163", "wwwroot/images/birddataset/Blurred/Blurred (163).jpeg", "Blurred (163)", "Blurred" },
                    { 422, "Description for Bird Blurred 164", "wwwroot/images/birddataset/Blurred/Blurred (164).jpeg", "Blurred (164)", "Blurred" },
                    { 423, "Description for Bird Blurred 165", "wwwroot/images/birddataset/Blurred/Blurred (165).jpeg", "Blurred (165)", "Blurred" },
                    { 424, "Description for Bird Blurred 166", "wwwroot/images/birddataset/Blurred/Blurred (166).jpeg", "Blurred (166)", "Blurred" },
                    { 425, "Description for Bird Blurred 167", "wwwroot/images/birddataset/Blurred/Blurred (167).jpeg", "Blurred (167)", "Blurred" },
                    { 426, "Description for Bird Blurred 168", "wwwroot/images/birddataset/Blurred/Blurred (168).jpeg", "Blurred (168)", "Blurred" },
                    { 427, "Description for Bird Blurred 169", "wwwroot/images/birddataset/Blurred/Blurred (169).jpeg", "Blurred (169)", "Blurred" },
                    { 428, "Description for Bird Blurred 170", "wwwroot/images/birddataset/Blurred/Blurred (170).jpeg", "Blurred (170)", "Blurred" },
                    { 429, "Description for Bird Blurred 171", "wwwroot/images/birddataset/Blurred/Blurred (171).jpeg", "Blurred (171)", "Blurred" },
                    { 430, "Description for Bird Blurred 172", "wwwroot/images/birddataset/Blurred/Blurred (172).jpeg", "Blurred (172)", "Blurred" },
                    { 431, "Description for Bird Blurred 173", "wwwroot/images/birddataset/Blurred/Blurred (173).jpeg", "Blurred (173)", "Blurred" },
                    { 432, "Description for Bird Blurred 174", "wwwroot/images/birddataset/Blurred/Blurred (174).jpeg", "Blurred (174)", "Blurred" },
                    { 433, "Description for Bird Blurred 175", "wwwroot/images/birddataset/Blurred/Blurred (175).jpeg", "Blurred (175)", "Blurred" },
                    { 434, "Description for Bird Blurred 176", "wwwroot/images/birddataset/Blurred/Blurred (176).jpeg", "Blurred (176)", "Blurred" },
                    { 435, "Description for Bird Blurred 177", "wwwroot/images/birddataset/Blurred/Blurred (177).jpeg", "Blurred (177)", "Blurred" },
                    { 436, "Description for Bird Blurred 178", "wwwroot/images/birddataset/Blurred/Blurred (178).jpeg", "Blurred (178)", "Blurred" },
                    { 437, "Description for Bird Blurred 179", "wwwroot/images/birddataset/Blurred/Blurred (179).jpeg", "Blurred (179)", "Blurred" },
                    { 438, "Description for Bird Blurred 180", "wwwroot/images/birddataset/Blurred/Blurred (180).jpeg", "Blurred (180)", "Blurred" },
                    { 439, "Description for Bird Blurred 181", "wwwroot/images/birddataset/Blurred/Blurred (181).jpeg", "Blurred (181)", "Blurred" },
                    { 440, "Description for Bird Blurred 182", "wwwroot/images/birddataset/Blurred/Blurred (182).jpeg", "Blurred (182)", "Blurred" },
                    { 441, "Description for Bird Blurred 183", "wwwroot/images/birddataset/Blurred/Blurred (183).jpeg", "Blurred (183)", "Blurred" },
                    { 442, "Description for Bird Blurred 184", "wwwroot/images/birddataset/Blurred/Blurred (184).jpeg", "Blurred (184)", "Blurred" },
                    { 443, "Description for Bird Blurred 185", "wwwroot/images/birddataset/Blurred/Blurred (185).jpeg", "Blurred (185)", "Blurred" },
                    { 444, "Description for Bird Blurred 186", "wwwroot/images/birddataset/Blurred/Blurred (186).jpeg", "Blurred (186)", "Blurred" },
                    { 445, "Description for Bird Blurred 187", "wwwroot/images/birddataset/Blurred/Blurred (187).jpeg", "Blurred (187)", "Blurred" },
                    { 446, "Description for Bird Blurred 188", "wwwroot/images/birddataset/Blurred/Blurred (188).jpeg", "Blurred (188)", "Blurred" },
                    { 447, "Description for Bird Blurred 189", "wwwroot/images/birddataset/Blurred/Blurred (189).jpeg", "Blurred (189)", "Blurred" },
                    { 448, "Description for Bird Blurred 190", "wwwroot/images/birddataset/Blurred/Blurred (190).jpeg", "Blurred (190)", "Blurred" },
                    { 449, "Description for Bird Blurred 191", "wwwroot/images/birddataset/Blurred/Blurred (191).jpeg", "Blurred (191)", "Blurred" },
                    { 450, "Description for Bird Blurred 192", "wwwroot/images/birddataset/Blurred/Blurred (192).jpeg", "Blurred (192)", "Blurred" },
                    { 451, "Description for Bird Blurred 193", "wwwroot/images/birddataset/Blurred/Blurred (193).jpeg", "Blurred (193)", "Blurred" },
                    { 452, "Description for Bird Blurred 194", "wwwroot/images/birddataset/Blurred/Blurred (194).jpeg", "Blurred (194)", "Blurred" },
                    { 453, "Description for Bird Blurred 195", "wwwroot/images/birddataset/Blurred/Blurred (195).jpeg", "Blurred (195)", "Blurred" },
                    { 454, "Description for Bird Blurred 196", "wwwroot/images/birddataset/Blurred/Blurred (196).jpeg", "Blurred (196)", "Blurred" },
                    { 455, "Description for Bird Blurred 197", "wwwroot/images/birddataset/Blurred/Blurred (197).jpeg", "Blurred (197)", "Blurred" },
                    { 456, "Description for Bird Blurred 198", "wwwroot/images/birddataset/Blurred/Blurred (198).jpeg", "Blurred (198)", "Blurred" },
                    { 457, "Description for Bird Blurred 199", "wwwroot/images/birddataset/Blurred/Blurred (199).jpeg", "Blurred (199)", "Blurred" },
                    { 458, "Description for Bird Blurred 200", "wwwroot/images/birddataset/Blurred/Blurred (200).jpeg", "Blurred (200)", "Blurred" },
                    { 459, "Description for Bird Blurred 201", "wwwroot/images/birddataset/Blurred/Blurred (201).jpeg", "Blurred (201)", "Blurred" },
                    { 460, "Description for Bird Blurred 202", "wwwroot/images/birddataset/Blurred/Blurred (202).jpeg", "Blurred (202)", "Blurred" },
                    { 461, "Description for Bird Blurred 203", "wwwroot/images/birddataset/Blurred/Blurred (203).jpeg", "Blurred (203)", "Blurred" },
                    { 462, "Description for Bird Blurred 204", "wwwroot/images/birddataset/Blurred/Blurred (204).jpeg", "Blurred (204)", "Blurred" },
                    { 463, "Description for Bird Blurred 205", "wwwroot/images/birddataset/Blurred/Blurred (205).jpeg", "Blurred (205)", "Blurred" },
                    { 464, "Description for Bird Blurred 206", "wwwroot/images/birddataset/Blurred/Blurred (206).jpeg", "Blurred (206)", "Blurred" },
                    { 465, "Description for Bird Blurred 207", "wwwroot/images/birddataset/Blurred/Blurred (207).jpeg", "Blurred (207)", "Blurred" },
                    { 466, "Description for Bird Blurred 208", "wwwroot/images/birddataset/Blurred/Blurred (208).jpeg", "Blurred (208)", "Blurred" },
                    { 467, "Description for Bird Blurred 209", "wwwroot/images/birddataset/Blurred/Blurred (209).jpeg", "Blurred (209)", "Blurred" },
                    { 468, "Description for Bird Blurred 210", "wwwroot/images/birddataset/Blurred/Blurred (210).jpeg", "Blurred (210)", "Blurred" },
                    { 469, "Description for Bird Blurred 211", "wwwroot/images/birddataset/Blurred/Blurred (211).jpeg", "Blurred (211)", "Blurred" },
                    { 470, "Description for Bird Blurred 212", "wwwroot/images/birddataset/Blurred/Blurred (212).jpeg", "Blurred (212)", "Blurred" },
                    { 471, "Description for Bird Blurred 213", "wwwroot/images/birddataset/Blurred/Blurred (213).jpeg", "Blurred (213)", "Blurred" },
                    { 472, "Description for Bird Blurred 214", "wwwroot/images/birddataset/Blurred/Blurred (214).jpeg", "Blurred (214)", "Blurred" },
                    { 473, "Description for Bird Blurred 215", "wwwroot/images/birddataset/Blurred/Blurred (215).jpeg", "Blurred (215)", "Blurred" },
                    { 474, "Description for Bird Blurred 216", "wwwroot/images/birddataset/Blurred/Blurred (216).jpeg", "Blurred (216)", "Blurred" },
                    { 475, "Description for Bird Blurred 217", "wwwroot/images/birddataset/Blurred/Blurred (217).jpeg", "Blurred (217)", "Blurred" },
                    { 476, "Description for Bird Blurred 218", "wwwroot/images/birddataset/Blurred/Blurred (218).jpeg", "Blurred (218)", "Blurred" },
                    { 477, "Description for Bird Blurred 219", "wwwroot/images/birddataset/Blurred/Blurred (219).jpeg", "Blurred (219)", "Blurred" },
                    { 478, "Description for Bird Blurred 220", "wwwroot/images/birddataset/Blurred/Blurred (220).jpeg", "Blurred (220)", "Blurred" },
                    { 479, "Description for Bird Blurred 221", "wwwroot/images/birddataset/Blurred/Blurred (221).jpeg", "Blurred (221)", "Blurred" },
                    { 480, "Description for Bird Blurred 222", "wwwroot/images/birddataset/Blurred/Blurred (222).jpeg", "Blurred (222)", "Blurred" },
                    { 481, "Description for Bird Blurred 223", "wwwroot/images/birddataset/Blurred/Blurred (223).jpeg", "Blurred (223)", "Blurred" },
                    { 482, "Description for Bird Blurred 224", "wwwroot/images/birddataset/Blurred/Blurred (224).jpeg", "Blurred (224)", "Blurred" },
                    { 483, "Description for Bird Blurred 225", "wwwroot/images/birddataset/Blurred/Blurred (225).jpeg", "Blurred (225)", "Blurred" },
                    { 484, "Description for Bird Blurred 226", "wwwroot/images/birddataset/Blurred/Blurred (226).jpeg", "Blurred (226)", "Blurred" },
                    { 485, "Description for Bird Blurred 227", "wwwroot/images/birddataset/Blurred/Blurred (227).jpeg", "Blurred (227)", "Blurred" },
                    { 486, "Description for Bird Blurred 228", "wwwroot/images/birddataset/Blurred/Blurred (228).jpeg", "Blurred (228)", "Blurred" },
                    { 487, "Description for Bird Blurred 229", "wwwroot/images/birddataset/Blurred/Blurred (229).jpeg", "Blurred (229)", "Blurred" },
                    { 488, "Description for Bird Blurred 230", "wwwroot/images/birddataset/Blurred/Blurred (230).jpeg", "Blurred (230)", "Blurred" },
                    { 489, "Description for Bird Blurred 231", "wwwroot/images/birddataset/Blurred/Blurred (231).jpeg", "Blurred (231)", "Blurred" },
                    { 490, "Description for Bird Blurred 232", "wwwroot/images/birddataset/Blurred/Blurred (232).jpeg", "Blurred (232)", "Blurred" },
                    { 491, "Description for Bird Blurred 233", "wwwroot/images/birddataset/Blurred/Blurred (233).jpeg", "Blurred (233)", "Blurred" },
                    { 492, "Description for Bird Blurred 234", "wwwroot/images/birddataset/Blurred/Blurred (234).jpeg", "Blurred (234)", "Blurred" },
                    { 493, "Description for Bird Blurred 235", "wwwroot/images/birddataset/Blurred/Blurred (235).jpeg", "Blurred (235)", "Blurred" },
                    { 494, "Description for Bird Blurred 236", "wwwroot/images/birddataset/Blurred/Blurred (236).jpeg", "Blurred (236)", "Blurred" },
                    { 495, "Description for Bird Blurred 237", "wwwroot/images/birddataset/Blurred/Blurred (237).jpeg", "Blurred (237)", "Blurred" },
                    { 496, "Description for Bird Blurred 238", "wwwroot/images/birddataset/Blurred/Blurred (238).jpeg", "Blurred (238)", "Blurred" },
                    { 497, "Description for Bird Blurred 239", "wwwroot/images/birddataset/Blurred/Blurred (239).jpeg", "Blurred (239)", "Blurred" },
                    { 498, "Description for Bird Blurred 240", "wwwroot/images/birddataset/Blurred/Blurred (240).jpeg", "Blurred (240)", "Blurred" },
                    { 499, "Description for Bird Blurred 241", "wwwroot/images/birddataset/Blurred/Blurred (241).jpeg", "Blurred (241)", "Blurred" },
                    { 500, "Description for Bird Blurred 242", "wwwroot/images/birddataset/Blurred/Blurred (242).jpeg", "Blurred (242)", "Blurred" },
                    { 501, "Description for Bird Blurred 243", "wwwroot/images/birddataset/Blurred/Blurred (243).jpeg", "Blurred (243)", "Blurred" },
                    { 502, "Description for Bird Blurred 244", "wwwroot/images/birddataset/Blurred/Blurred (244).jpeg", "Blurred (244)", "Blurred" },
                    { 503, "Description for Bird Blurred 245", "wwwroot/images/birddataset/Blurred/Blurred (245).jpeg", "Blurred (245)", "Blurred" },
                    { 504, "Description for Bird Blurred 246", "wwwroot/images/birddataset/Blurred/Blurred (246).jpeg", "Blurred (246)", "Blurred" },
                    { 505, "Description for Bird Blurred 247", "wwwroot/images/birddataset/Blurred/Blurred (247).jpeg", "Blurred (247)", "Blurred" },
                    { 506, "Description for Bird Blurred 248", "wwwroot/images/birddataset/Blurred/Blurred (248).jpeg", "Blurred (248)", "Blurred" },
                    { 507, "Description for Bird Blurred 249", "wwwroot/images/birddataset/Blurred/Blurred (249).jpeg", "Blurred (249)", "Blurred" },
                    { 508, "Description for Bird Blurred 250", "wwwroot/images/birddataset/Blurred/Blurred (250).jpeg", "Blurred (250)", "Blurred" },
                    { 509, "Description for Bird Blurred 251", "wwwroot/images/birddataset/Blurred/Blurred (251).jpeg", "Blurred (251)", "Blurred" },
                    { 510, "Description for Bird Blurred 252", "wwwroot/images/birddataset/Blurred/Blurred (252).jpeg", "Blurred (252)", "Blurred" },
                    { 511, "Description for Bird Blurred 253", "wwwroot/images/birddataset/Blurred/Blurred (253).jpeg", "Blurred (253)", "Blurred" },
                    { 512, "Description for Bird Blurred 254", "wwwroot/images/birddataset/Blurred/Blurred (254).jpeg", "Blurred (254)", "Blurred" },
                    { 513, "Description for Bird Blurred 255", "wwwroot/images/birddataset/Blurred/Blurred (255).jpeg", "Blurred (255)", "Blurred" },
                    { 514, "Description for Bird Blurred 256", "wwwroot/images/birddataset/Blurred/Blurred (256).jpeg", "Blurred (256)", "Blurred" },
                    { 515, "Description for Bird Blurred 257", "wwwroot/images/birddataset/Blurred/Blurred (257).jpeg", "Blurred (257)", "Blurred" },
                    { 516, "Description for Bird Blurred 258", "wwwroot/images/birddataset/Blurred/Blurred (258).jpeg", "Blurred (258)", "Blurred" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DropColumn(
                name: "Stage",
                table: "Kolis");

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 1", "wwwroot/images/kolidataset/Koli (1).jpeg", "Koli (1)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 2", "wwwroot/images/kolidataset/Koli (2).jpeg", "Koli (2)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 3", "wwwroot/images/kolidataset/Koli (3).jpeg", "Koli (3)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 4", "wwwroot/images/kolidataset/Koli (4).jpeg", "Koli (4)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 5", "wwwroot/images/kolidataset/Koli (5).jpeg", "Koli (5)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 6", "wwwroot/images/kolidataset/Koli (6).jpeg", "Koli (6)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 7", "wwwroot/images/kolidataset/Koli (7).jpeg", "Koli (7)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 8", "wwwroot/images/kolidataset/Koli (8).jpeg", "Koli (8)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 9", "wwwroot/images/kolidataset/Koli (9).jpeg", "Koli (9)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 10", "wwwroot/images/kolidataset/Koli (10).jpeg", "Koli (10)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 11", "wwwroot/images/kolidataset/Koli (11).jpeg", "Koli (11)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 12", "wwwroot/images/kolidataset/Koli (12).jpeg", "Koli (12)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 13", "wwwroot/images/kolidataset/Koli (13).jpeg", "Koli (13)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 14", "wwwroot/images/kolidataset/Koli (14).jpeg", "Koli (14)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 15", "wwwroot/images/kolidataset/Koli (15).jpeg", "Koli (15)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 16", "wwwroot/images/kolidataset/Koli (16).jpeg", "Koli (16)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 17", "wwwroot/images/kolidataset/Koli (17).jpeg", "Koli (17)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 18", "wwwroot/images/kolidataset/Koli (18).jpeg", "Koli (18)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 19", "wwwroot/images/kolidataset/Koli (19).jpeg", "Koli (19)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 20", "wwwroot/images/kolidataset/Koli (20).jpeg", "Koli (20)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 21", "wwwroot/images/kolidataset/Koli (21).jpeg", "Koli (21)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 22", "wwwroot/images/kolidataset/Koli (22).jpeg", "Koli (22)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 23", "wwwroot/images/kolidataset/Koli (23).jpeg", "Koli (23)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 24", "wwwroot/images/kolidataset/Koli (24).jpeg", "Koli (24)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 25", "wwwroot/images/kolidataset/Koli (25).jpeg", "Koli (25)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 26", "wwwroot/images/kolidataset/Koli (26).jpeg", "Koli (26)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 27", "wwwroot/images/kolidataset/Koli (27).jpeg", "Koli (27)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 28", "wwwroot/images/kolidataset/Koli (28).jpeg", "Koli (28)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 29", "wwwroot/images/kolidataset/Koli (29).jpeg", "Koli (29)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 30", "wwwroot/images/kolidataset/Koli (30).jpeg", "Koli (30)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 31", "wwwroot/images/kolidataset/Koli (31).jpeg", "Koli (31)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 32", "wwwroot/images/kolidataset/Koli (32).jpeg", "Koli (32)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 33", "wwwroot/images/kolidataset/Koli (33).jpeg", "Koli (33)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 34", "wwwroot/images/kolidataset/Koli (34).jpeg", "Koli (34)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 35", "wwwroot/images/kolidataset/Koli (35).jpeg", "Koli (35)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 36", "wwwroot/images/kolidataset/Koli (36).jpeg", "Koli (36)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 37", "wwwroot/images/kolidataset/Koli (37).jpeg", "Koli (37)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 38", "wwwroot/images/kolidataset/Koli (38).jpeg", "Koli (38)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 39", "wwwroot/images/kolidataset/Koli (39).jpeg", "Koli (39)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 40", "wwwroot/images/kolidataset/Koli (40).jpeg", "Koli (40)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 41", "wwwroot/images/kolidataset/Koli (41).jpeg", "Koli (41)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 42", "wwwroot/images/kolidataset/Koli (42).jpeg", "Koli (42)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 43", "wwwroot/images/kolidataset/Koli (43).jpeg", "Koli (43)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 44", "wwwroot/images/kolidataset/Koli (44).jpeg", "Koli (44)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 45", "wwwroot/images/kolidataset/Koli (45).jpeg", "Koli (45)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 46", "wwwroot/images/kolidataset/Koli (46).jpeg", "Koli (46)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 47", "wwwroot/images/kolidataset/Koli (47).jpeg", "Koli (47)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 48", "wwwroot/images/kolidataset/Koli (48).jpeg", "Koli (48)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 49", "wwwroot/images/kolidataset/Koli (49).jpeg", "Koli (49)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 50", "wwwroot/images/kolidataset/Koli (50).jpeg", "Koli (50)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 51", "wwwroot/images/kolidataset/Koli (51).jpeg", "Koli (51)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 52", "wwwroot/images/kolidataset/Koli (52).jpeg", "Koli (52)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 53", "wwwroot/images/kolidataset/Koli (53).jpeg", "Koli (53)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 54", "wwwroot/images/kolidataset/Koli (54).jpeg", "Koli (54)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 55", "wwwroot/images/kolidataset/Koli (55).jpeg", "Koli (55)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 56", "wwwroot/images/kolidataset/Koli (56).jpeg", "Koli (56)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 57", "wwwroot/images/kolidataset/Koli (57).jpeg", "Koli (57)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 58", "wwwroot/images/kolidataset/Koli (58).jpeg", "Koli (58)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 59", "wwwroot/images/kolidataset/Koli (59).jpeg", "Koli (59)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 60", "wwwroot/images/kolidataset/Koli (60).jpeg", "Koli (60)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 61", "wwwroot/images/kolidataset/Koli (61).jpeg", "Koli (61)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 62", "wwwroot/images/kolidataset/Koli (62).jpeg", "Koli (62)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 63", "wwwroot/images/kolidataset/Koli (63).jpeg", "Koli (63)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 64", "wwwroot/images/kolidataset/Koli (64).jpeg", "Koli (64)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 65", "wwwroot/images/kolidataset/Koli (65).jpeg", "Koli (65)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 66", "wwwroot/images/kolidataset/Koli (66).jpeg", "Koli (66)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 67", "wwwroot/images/kolidataset/Koli (67).jpeg", "Koli (67)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 68", "wwwroot/images/kolidataset/Koli (68).jpeg", "Koli (68)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 69", "wwwroot/images/kolidataset/Koli (69).jpeg", "Koli (69)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 70", "wwwroot/images/kolidataset/Koli (70).jpeg", "Koli (70)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 71", "wwwroot/images/kolidataset/Koli (71).jpeg", "Koli (71)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 72", "wwwroot/images/kolidataset/Koli (72).jpeg", "Koli (72)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 73", "wwwroot/images/kolidataset/Koli (73).jpeg", "Koli (73)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 74", "wwwroot/images/kolidataset/Koli (74).jpeg", "Koli (74)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 75", "wwwroot/images/kolidataset/Koli (75).jpeg", "Koli (75)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 76", "wwwroot/images/kolidataset/Koli (76).jpeg", "Koli (76)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 77", "wwwroot/images/kolidataset/Koli (77).jpeg", "Koli (77)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 78", "wwwroot/images/kolidataset/Koli (78).jpeg", "Koli (78)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 79", "wwwroot/images/kolidataset/Koli (79).jpeg", "Koli (79)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 80", "wwwroot/images/kolidataset/Koli (80).jpeg", "Koli (80)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 81", "wwwroot/images/kolidataset/Koli (81).jpeg", "Koli (81)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 82", "wwwroot/images/kolidataset/Koli (82).jpeg", "Koli (82)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 83", "wwwroot/images/kolidataset/Koli (83).jpeg", "Koli (83)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 84", "wwwroot/images/kolidataset/Koli (84).jpeg", "Koli (84)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 85", "wwwroot/images/kolidataset/Koli (85).jpeg", "Koli (85)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 86", "wwwroot/images/kolidataset/Koli (86).jpeg", "Koli (86)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 87", "wwwroot/images/kolidataset/Koli (87).jpeg", "Koli (87)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 88", "wwwroot/images/kolidataset/Koli (88).jpeg", "Koli (88)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 89", "wwwroot/images/kolidataset/Koli (89).jpeg", "Koli (89)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 90", "wwwroot/images/kolidataset/Koli (90).jpeg", "Koli (90)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 91", "wwwroot/images/kolidataset/Koli (91).jpeg", "Koli (91)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 92", "wwwroot/images/kolidataset/Koli (92).jpeg", "Koli (92)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 93", "wwwroot/images/kolidataset/Koli (93).jpeg", "Koli (93)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 94", "wwwroot/images/kolidataset/Koli (94).jpeg", "Koli (94)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 95", "wwwroot/images/kolidataset/Koli (95).jpeg", "Koli (95)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 96", "wwwroot/images/kolidataset/Koli (96).jpeg", "Koli (96)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 97", "wwwroot/images/kolidataset/Koli (97).jpeg", "Koli (97)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 98", "wwwroot/images/kolidataset/Koli (98).jpeg", "Koli (98)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 99", "wwwroot/images/kolidataset/Koli (99).jpeg", "Koli (99)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 100", "wwwroot/images/kolidataset/Koli (100).jpeg", "Koli (100)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 101", "wwwroot/images/kolidataset/Koli (101).jpeg", "Koli (101)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 102", "wwwroot/images/kolidataset/Koli (102).jpeg", "Koli (102)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 103", "wwwroot/images/kolidataset/Koli (103).jpeg", "Koli (103)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 104", "wwwroot/images/kolidataset/Koli (104).jpeg", "Koli (104)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 105", "wwwroot/images/kolidataset/Koli (105).jpeg", "Koli (105)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 106", "wwwroot/images/kolidataset/Koli (106).jpeg", "Koli (106)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 107", "wwwroot/images/kolidataset/Koli (107).jpeg", "Koli (107)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 108", "wwwroot/images/kolidataset/Koli (108).jpeg", "Koli (108)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 109", "wwwroot/images/kolidataset/Koli (109).jpeg", "Koli (109)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 110", "wwwroot/images/kolidataset/Koli (110).jpeg", "Koli (110)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 111", "wwwroot/images/kolidataset/Koli (111).jpeg", "Koli (111)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 112", "wwwroot/images/kolidataset/Koli (112).jpeg", "Koli (112)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 113", "wwwroot/images/kolidataset/Koli (113).jpeg", "Koli (113)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 114", "wwwroot/images/kolidataset/Koli (114).jpeg", "Koli (114)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 115", "wwwroot/images/kolidataset/Koli (115).jpeg", "Koli (115)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 116", "wwwroot/images/kolidataset/Koli (116).jpeg", "Koli (116)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 117", "wwwroot/images/kolidataset/Koli (117).jpeg", "Koli (117)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 118", "wwwroot/images/kolidataset/Koli (118).jpeg", "Koli (118)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 119", "wwwroot/images/kolidataset/Koli (119).jpeg", "Koli (119)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 120", "wwwroot/images/kolidataset/Koli (120).jpeg", "Koli (120)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 121", "wwwroot/images/kolidataset/Koli (121).jpeg", "Koli (121)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 122", "wwwroot/images/kolidataset/Koli (122).jpeg", "Koli (122)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 123", "wwwroot/images/kolidataset/Koli (123).jpeg", "Koli (123)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 124", "wwwroot/images/kolidataset/Koli (124).jpeg", "Koli (124)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 125", "wwwroot/images/kolidataset/Koli (125).jpeg", "Koli (125)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 126", "wwwroot/images/kolidataset/Koli (126).jpeg", "Koli (126)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 127", "wwwroot/images/kolidataset/Koli (127).jpeg", "Koli (127)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 128", "wwwroot/images/kolidataset/Koli (128).jpeg", "Koli (128)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 129", "wwwroot/images/kolidataset/Koli (129).jpeg", "Koli (129)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 130", "wwwroot/images/kolidataset/Koli (130).jpeg", "Koli (130)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 131", "wwwroot/images/kolidataset/Koli (131).jpeg", "Koli (131)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 132", "wwwroot/images/kolidataset/Koli (132).jpeg", "Koli (132)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 133", "wwwroot/images/kolidataset/Koli (133).jpeg", "Koli (133)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 134", "wwwroot/images/kolidataset/Koli (134).jpeg", "Koli (134)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 135", "wwwroot/images/kolidataset/Koli (135).jpeg", "Koli (135)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 136", "wwwroot/images/kolidataset/Koli (136).jpeg", "Koli (136)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 137", "wwwroot/images/kolidataset/Koli (137).jpeg", "Koli (137)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 138", "wwwroot/images/kolidataset/Koli (138).jpeg", "Koli (138)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 139", "wwwroot/images/kolidataset/Koli (139).jpeg", "Koli (139)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 140", "wwwroot/images/kolidataset/Koli (140).jpeg", "Koli (140)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 141", "wwwroot/images/kolidataset/Koli (141).jpeg", "Koli (141)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 142", "wwwroot/images/kolidataset/Koli (142).jpeg", "Koli (142)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 143", "wwwroot/images/kolidataset/Koli (143).jpeg", "Koli (143)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 144", "wwwroot/images/kolidataset/Koli (144).jpeg", "Koli (144)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 145", "wwwroot/images/kolidataset/Koli (145).jpeg", "Koli (145)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 146", "wwwroot/images/kolidataset/Koli (146).jpeg", "Koli (146)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 147", "wwwroot/images/kolidataset/Koli (147).jpeg", "Koli (147)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 148", "wwwroot/images/kolidataset/Koli (148).jpeg", "Koli (148)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 149", "wwwroot/images/kolidataset/Koli (149).jpeg", "Koli (149)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 150", "wwwroot/images/kolidataset/Koli (150).jpeg", "Koli (150)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 151", "wwwroot/images/kolidataset/Koli (151).jpeg", "Koli (151)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 152", "wwwroot/images/kolidataset/Koli (152).jpeg", "Koli (152)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 153", "wwwroot/images/kolidataset/Koli (153).jpeg", "Koli (153)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 154", "wwwroot/images/kolidataset/Koli (154).jpeg", "Koli (154)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 155", "wwwroot/images/kolidataset/Koli (155).jpeg", "Koli (155)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 156", "wwwroot/images/kolidataset/Koli (156).jpeg", "Koli (156)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 157", "wwwroot/images/kolidataset/Koli (157).jpeg", "Koli (157)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 158", "wwwroot/images/kolidataset/Koli (158).jpeg", "Koli (158)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 159", "wwwroot/images/kolidataset/Koli (159).jpeg", "Koli (159)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 160", "wwwroot/images/kolidataset/Koli (160).jpeg", "Koli (160)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 161", "wwwroot/images/kolidataset/Koli (161).jpeg", "Koli (161)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 162", "wwwroot/images/kolidataset/Koli (162).jpeg", "Koli (162)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 163", "wwwroot/images/kolidataset/Koli (163).jpeg", "Koli (163)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 164", "wwwroot/images/kolidataset/Koli (164).jpeg", "Koli (164)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 165", "wwwroot/images/kolidataset/Koli (165).jpeg", "Koli (165)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 166", "wwwroot/images/kolidataset/Koli (166).jpeg", "Koli (166)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 167", "wwwroot/images/kolidataset/Koli (167).jpeg", "Koli (167)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 168", "wwwroot/images/kolidataset/Koli (168).jpeg", "Koli (168)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 169", "wwwroot/images/kolidataset/Koli (169).jpeg", "Koli (169)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 170", "wwwroot/images/kolidataset/Koli (170).jpeg", "Koli (170)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 171", "wwwroot/images/kolidataset/Koli (171).jpeg", "Koli (171)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 172", "wwwroot/images/kolidataset/Koli (172).jpeg", "Koli (172)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 173", "wwwroot/images/kolidataset/Koli (173).jpeg", "Koli (173)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 174", "wwwroot/images/kolidataset/Koli (174).jpeg", "Koli (174)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 175", "wwwroot/images/kolidataset/Koli (175).jpeg", "Koli (175)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 176", "wwwroot/images/kolidataset/Koli (176).jpeg", "Koli (176)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 177", "wwwroot/images/kolidataset/Koli (177).jpeg", "Koli (177)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 178", "wwwroot/images/kolidataset/Koli (178).jpeg", "Koli (178)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 179", "wwwroot/images/kolidataset/Koli (179).jpeg", "Koli (179)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 180", "wwwroot/images/kolidataset/Koli (180).jpeg", "Koli (180)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 181", "wwwroot/images/kolidataset/Koli (181).jpeg", "Koli (181)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 182", "wwwroot/images/kolidataset/Koli (182).jpeg", "Koli (182)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 183", "wwwroot/images/kolidataset/Koli (183).jpeg", "Koli (183)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 184", "wwwroot/images/kolidataset/Koli (184).jpeg", "Koli (184)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 185", "wwwroot/images/kolidataset/Koli (185).jpeg", "Koli (185)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 186", "wwwroot/images/kolidataset/Koli (186).jpeg", "Koli (186)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 187", "wwwroot/images/kolidataset/Koli (187).jpeg", "Koli (187)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 188", "wwwroot/images/kolidataset/Koli (188).jpeg", "Koli (188)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 189", "wwwroot/images/kolidataset/Koli (189).jpeg", "Koli (189)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 190", "wwwroot/images/kolidataset/Koli (190).jpeg", "Koli (190)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 191", "wwwroot/images/kolidataset/Koli (191).jpeg", "Koli (191)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 192", "wwwroot/images/kolidataset/Koli (192).jpeg", "Koli (192)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 193", "wwwroot/images/kolidataset/Koli (193).jpeg", "Koli (193)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 194", "wwwroot/images/kolidataset/Koli (194).jpeg", "Koli (194)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 195", "wwwroot/images/kolidataset/Koli (195).jpeg", "Koli (195)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 196", "wwwroot/images/kolidataset/Koli (196).jpeg", "Koli (196)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 197", "wwwroot/images/kolidataset/Koli (197).jpeg", "Koli (197)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 198", "wwwroot/images/kolidataset/Koli (198).jpeg", "Koli (198)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 199", "wwwroot/images/kolidataset/Koli (199).jpeg", "Koli (199)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 200", "wwwroot/images/kolidataset/Koli (200).jpeg", "Koli (200)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 201", "wwwroot/images/kolidataset/Koli (201).jpeg", "Koli (201)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 202", "wwwroot/images/kolidataset/Koli (202).jpeg", "Koli (202)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 203", "wwwroot/images/kolidataset/Koli (203).jpeg", "Koli (203)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 204", "wwwroot/images/kolidataset/Koli (204).jpeg", "Koli (204)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 205", "wwwroot/images/kolidataset/Koli (205).jpeg", "Koli (205)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 206", "wwwroot/images/kolidataset/Koli (206).jpeg", "Koli (206)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 207", "wwwroot/images/kolidataset/Koli (207).jpeg", "Koli (207)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 208", "wwwroot/images/kolidataset/Koli (208).jpeg", "Koli (208)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 209", "wwwroot/images/kolidataset/Koli (209).jpeg", "Koli (209)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 210", "wwwroot/images/kolidataset/Koli (210).jpeg", "Koli (210)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 211", "wwwroot/images/kolidataset/Koli (211).jpeg", "Koli (211)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 212", "wwwroot/images/kolidataset/Koli (212).jpeg", "Koli (212)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 213", "wwwroot/images/kolidataset/Koli (213).jpeg", "Koli (213)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 214", "wwwroot/images/kolidataset/Koli (214).jpeg", "Koli (214)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 215", "wwwroot/images/kolidataset/Koli (215).jpeg", "Koli (215)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 216", "wwwroot/images/kolidataset/Koli (216).jpeg", "Koli (216)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 217", "wwwroot/images/kolidataset/Koli (217).jpeg", "Koli (217)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 218", "wwwroot/images/kolidataset/Koli (218).jpeg", "Koli (218)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 219", "wwwroot/images/kolidataset/Koli (219).jpeg", "Koli (219)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 220", "wwwroot/images/kolidataset/Koli (220).jpeg", "Koli (220)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 221", "wwwroot/images/kolidataset/Koli (221).jpeg", "Koli (221)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 222", "wwwroot/images/kolidataset/Koli (222).jpeg", "Koli (222)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 223", "wwwroot/images/kolidataset/Koli (223).jpeg", "Koli (223)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 224", "wwwroot/images/kolidataset/Koli (224).jpeg", "Koli (224)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 225", "wwwroot/images/kolidataset/Koli (225).jpeg", "Koli (225)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 226", "wwwroot/images/kolidataset/Koli (226).jpeg", "Koli (226)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 227", "wwwroot/images/kolidataset/Koli (227).jpeg", "Koli (227)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 228", "wwwroot/images/kolidataset/Koli (228).jpeg", "Koli (228)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 229", "wwwroot/images/kolidataset/Koli (229).jpeg", "Koli (229)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 230", "wwwroot/images/kolidataset/Koli (230).jpeg", "Koli (230)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 231", "wwwroot/images/kolidataset/Koli (231).jpeg", "Koli (231)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 232", "wwwroot/images/kolidataset/Koli (232).jpeg", "Koli (232)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 233", "wwwroot/images/kolidataset/Koli (233).jpeg", "Koli (233)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 234", "wwwroot/images/kolidataset/Koli (234).jpeg", "Koli (234)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 235", "wwwroot/images/kolidataset/Koli (235).jpeg", "Koli (235)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 236", "wwwroot/images/kolidataset/Koli (236).jpeg", "Koli (236)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 237", "wwwroot/images/kolidataset/Koli (237).jpeg", "Koli (237)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 238", "wwwroot/images/kolidataset/Koli (238).jpeg", "Koli (238)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 239", "wwwroot/images/kolidataset/Koli (239).jpeg", "Koli (239)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 240", "wwwroot/images/kolidataset/Koli (240).jpeg", "Koli (240)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 241", "wwwroot/images/kolidataset/Koli (241).jpeg", "Koli (241)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 242", "wwwroot/images/kolidataset/Koli (242).jpeg", "Koli (242)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 243", "wwwroot/images/kolidataset/Koli (243).jpeg", "Koli (243)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 244", "wwwroot/images/kolidataset/Koli (244).jpeg", "Koli (244)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 245", "wwwroot/images/kolidataset/Koli (245).jpeg", "Koli (245)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 246", "wwwroot/images/kolidataset/Koli (246).jpeg", "Koli (246)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 247", "wwwroot/images/kolidataset/Koli (247).jpeg", "Koli (247)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 248", "wwwroot/images/kolidataset/Koli (248).jpeg", "Koli (248)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 249", "wwwroot/images/kolidataset/Koli (249).jpeg", "Koli (249)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 250", "wwwroot/images/kolidataset/Koli (250).jpeg", "Koli (250)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 251", "wwwroot/images/kolidataset/Koli (251).jpeg", "Koli (251)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 252", "wwwroot/images/kolidataset/Koli (252).jpeg", "Koli (252)" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Description for Koli 253", "wwwroot/images/kolidataset/Koli (253).jpeg", "Koli (253)" });
        }
    }
}
