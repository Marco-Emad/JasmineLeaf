using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JasmineLeaf.Migrations
{
    /// <inheritdoc />
    public partial class kolidata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Kolis",
                columns: new[] { "Id", "Description", "Image", "Name" },
                values: new object[,]
                {
                    { 3, "Description for Koli 3", "wwwroot/images/kolidataset/Koli (3).jpeg", "Koli (3)" },
                    { 4, "Description for Koli 4", "wwwroot/images/kolidataset/Koli (4).jpeg", "Koli (4)" },
                    { 5, "Description for Koli 5", "wwwroot/images/kolidataset/Koli (5).jpeg", "Koli (5)" },
                    { 6, "Description for Koli 6", "wwwroot/images/kolidataset/Koli (6).jpeg", "Koli (6)" },
                    { 7, "Description for Koli 7", "wwwroot/images/kolidataset/Koli (7).jpeg", "Koli (7)" },
                    { 8, "Description for Koli 8", "wwwroot/images/kolidataset/Koli (8).jpeg", "Koli (8)" },
                    { 9, "Description for Koli 9", "wwwroot/images/kolidataset/Koli (9).jpeg", "Koli (9)" },
                    { 10, "Description for Koli 10", "wwwroot/images/kolidataset/Koli (10).jpeg", "Koli (10)" },
                    { 11, "Description for Koli 11", "wwwroot/images/kolidataset/Koli (11).jpeg", "Koli (11)" },
                    { 12, "Description for Koli 12", "wwwroot/images/kolidataset/Koli (12).jpeg", "Koli (12)" },
                    { 13, "Description for Koli 13", "wwwroot/images/kolidataset/Koli (13).jpeg", "Koli (13)" },
                    { 14, "Description for Koli 14", "wwwroot/images/kolidataset/Koli (14).jpeg", "Koli (14)" },
                    { 15, "Description for Koli 15", "wwwroot/images/kolidataset/Koli (15).jpeg", "Koli (15)" },
                    { 16, "Description for Koli 16", "wwwroot/images/kolidataset/Koli (16).jpeg", "Koli (16)" },
                    { 17, "Description for Koli 17", "wwwroot/images/kolidataset/Koli (17).jpeg", "Koli (17)" },
                    { 18, "Description for Koli 18", "wwwroot/images/kolidataset/Koli (18).jpeg", "Koli (18)" },
                    { 19, "Description for Koli 19", "wwwroot/images/kolidataset/Koli (19).jpeg", "Koli (19)" },
                    { 20, "Description for Koli 20", "wwwroot/images/kolidataset/Koli (20).jpeg", "Koli (20)" },
                    { 21, "Description for Koli 21", "wwwroot/images/kolidataset/Koli (21).jpeg", "Koli (21)" },
                    { 22, "Description for Koli 22", "wwwroot/images/kolidataset/Koli (22).jpeg", "Koli (22)" },
                    { 23, "Description for Koli 23", "wwwroot/images/kolidataset/Koli (23).jpeg", "Koli (23)" },
                    { 24, "Description for Koli 24", "wwwroot/images/kolidataset/Koli (24).jpeg", "Koli (24)" },
                    { 25, "Description for Koli 25", "wwwroot/images/kolidataset/Koli (25).jpeg", "Koli (25)" },
                    { 26, "Description for Koli 26", "wwwroot/images/kolidataset/Koli (26).jpeg", "Koli (26)" },
                    { 27, "Description for Koli 27", "wwwroot/images/kolidataset/Koli (27).jpeg", "Koli (27)" },
                    { 28, "Description for Koli 28", "wwwroot/images/kolidataset/Koli (28).jpeg", "Koli (28)" },
                    { 29, "Description for Koli 29", "wwwroot/images/kolidataset/Koli (29).jpeg", "Koli (29)" },
                    { 30, "Description for Koli 30", "wwwroot/images/kolidataset/Koli (30).jpeg", "Koli (30)" },
                    { 31, "Description for Koli 31", "wwwroot/images/kolidataset/Koli (31).jpeg", "Koli (31)" },
                    { 32, "Description for Koli 32", "wwwroot/images/kolidataset/Koli (32).jpeg", "Koli (32)" },
                    { 33, "Description for Koli 33", "wwwroot/images/kolidataset/Koli (33).jpeg", "Koli (33)" },
                    { 34, "Description for Koli 34", "wwwroot/images/kolidataset/Koli (34).jpeg", "Koli (34)" },
                    { 35, "Description for Koli 35", "wwwroot/images/kolidataset/Koli (35).jpeg", "Koli (35)" },
                    { 36, "Description for Koli 36", "wwwroot/images/kolidataset/Koli (36).jpeg", "Koli (36)" },
                    { 37, "Description for Koli 37", "wwwroot/images/kolidataset/Koli (37).jpeg", "Koli (37)" },
                    { 38, "Description for Koli 38", "wwwroot/images/kolidataset/Koli (38).jpeg", "Koli (38)" },
                    { 39, "Description for Koli 39", "wwwroot/images/kolidataset/Koli (39).jpeg", "Koli (39)" },
                    { 40, "Description for Koli 40", "wwwroot/images/kolidataset/Koli (40).jpeg", "Koli (40)" },
                    { 41, "Description for Koli 41", "wwwroot/images/kolidataset/Koli (41).jpeg", "Koli (41)" },
                    { 42, "Description for Koli 42", "wwwroot/images/kolidataset/Koli (42).jpeg", "Koli (42)" },
                    { 43, "Description for Koli 43", "wwwroot/images/kolidataset/Koli (43).jpeg", "Koli (43)" },
                    { 44, "Description for Koli 44", "wwwroot/images/kolidataset/Koli (44).jpeg", "Koli (44)" },
                    { 45, "Description for Koli 45", "wwwroot/images/kolidataset/Koli (45).jpeg", "Koli (45)" },
                    { 46, "Description for Koli 46", "wwwroot/images/kolidataset/Koli (46).jpeg", "Koli (46)" },
                    { 47, "Description for Koli 47", "wwwroot/images/kolidataset/Koli (47).jpeg", "Koli (47)" },
                    { 48, "Description for Koli 48", "wwwroot/images/kolidataset/Koli (48).jpeg", "Koli (48)" },
                    { 49, "Description for Koli 49", "wwwroot/images/kolidataset/Koli (49).jpeg", "Koli (49)" },
                    { 50, "Description for Koli 50", "wwwroot/images/kolidataset/Koli (50).jpeg", "Koli (50)" },
                    { 51, "Description for Koli 51", "wwwroot/images/kolidataset/Koli (51).jpeg", "Koli (51)" },
                    { 52, "Description for Koli 52", "wwwroot/images/kolidataset/Koli (52).jpeg", "Koli (52)" },
                    { 53, "Description for Koli 53", "wwwroot/images/kolidataset/Koli (53).jpeg", "Koli (53)" },
                    { 54, "Description for Koli 54", "wwwroot/images/kolidataset/Koli (54).jpeg", "Koli (54)" },
                    { 55, "Description for Koli 55", "wwwroot/images/kolidataset/Koli (55).jpeg", "Koli (55)" },
                    { 56, "Description for Koli 56", "wwwroot/images/kolidataset/Koli (56).jpeg", "Koli (56)" },
                    { 57, "Description for Koli 57", "wwwroot/images/kolidataset/Koli (57).jpeg", "Koli (57)" },
                    { 58, "Description for Koli 58", "wwwroot/images/kolidataset/Koli (58).jpeg", "Koli (58)" },
                    { 59, "Description for Koli 59", "wwwroot/images/kolidataset/Koli (59).jpeg", "Koli (59)" },
                    { 60, "Description for Koli 60", "wwwroot/images/kolidataset/Koli (60).jpeg", "Koli (60)" },
                    { 61, "Description for Koli 61", "wwwroot/images/kolidataset/Koli (61).jpeg", "Koli (61)" },
                    { 62, "Description for Koli 62", "wwwroot/images/kolidataset/Koli (62).jpeg", "Koli (62)" },
                    { 63, "Description for Koli 63", "wwwroot/images/kolidataset/Koli (63).jpeg", "Koli (63)" },
                    { 64, "Description for Koli 64", "wwwroot/images/kolidataset/Koli (64).jpeg", "Koli (64)" },
                    { 65, "Description for Koli 65", "wwwroot/images/kolidataset/Koli (65).jpeg", "Koli (65)" },
                    { 66, "Description for Koli 66", "wwwroot/images/kolidataset/Koli (66).jpeg", "Koli (66)" },
                    { 67, "Description for Koli 67", "wwwroot/images/kolidataset/Koli (67).jpeg", "Koli (67)" },
                    { 68, "Description for Koli 68", "wwwroot/images/kolidataset/Koli (68).jpeg", "Koli (68)" },
                    { 69, "Description for Koli 69", "wwwroot/images/kolidataset/Koli (69).jpeg", "Koli (69)" },
                    { 70, "Description for Koli 70", "wwwroot/images/kolidataset/Koli (70).jpeg", "Koli (70)" },
                    { 71, "Description for Koli 71", "wwwroot/images/kolidataset/Koli (71).jpeg", "Koli (71)" },
                    { 72, "Description for Koli 72", "wwwroot/images/kolidataset/Koli (72).jpeg", "Koli (72)" },
                    { 73, "Description for Koli 73", "wwwroot/images/kolidataset/Koli (73).jpeg", "Koli (73)" },
                    { 74, "Description for Koli 74", "wwwroot/images/kolidataset/Koli (74).jpeg", "Koli (74)" },
                    { 75, "Description for Koli 75", "wwwroot/images/kolidataset/Koli (75).jpeg", "Koli (75)" },
                    { 76, "Description for Koli 76", "wwwroot/images/kolidataset/Koli (76).jpeg", "Koli (76)" },
                    { 77, "Description for Koli 77", "wwwroot/images/kolidataset/Koli (77).jpeg", "Koli (77)" },
                    { 78, "Description for Koli 78", "wwwroot/images/kolidataset/Koli (78).jpeg", "Koli (78)" },
                    { 79, "Description for Koli 79", "wwwroot/images/kolidataset/Koli (79).jpeg", "Koli (79)" },
                    { 80, "Description for Koli 80", "wwwroot/images/kolidataset/Koli (80).jpeg", "Koli (80)" },
                    { 81, "Description for Koli 81", "wwwroot/images/kolidataset/Koli (81).jpeg", "Koli (81)" },
                    { 82, "Description for Koli 82", "wwwroot/images/kolidataset/Koli (82).jpeg", "Koli (82)" },
                    { 83, "Description for Koli 83", "wwwroot/images/kolidataset/Koli (83).jpeg", "Koli (83)" },
                    { 84, "Description for Koli 84", "wwwroot/images/kolidataset/Koli (84).jpeg", "Koli (84)" },
                    { 85, "Description for Koli 85", "wwwroot/images/kolidataset/Koli (85).jpeg", "Koli (85)" },
                    { 86, "Description for Koli 86", "wwwroot/images/kolidataset/Koli (86).jpeg", "Koli (86)" },
                    { 87, "Description for Koli 87", "wwwroot/images/kolidataset/Koli (87).jpeg", "Koli (87)" },
                    { 88, "Description for Koli 88", "wwwroot/images/kolidataset/Koli (88).jpeg", "Koli (88)" },
                    { 89, "Description for Koli 89", "wwwroot/images/kolidataset/Koli (89).jpeg", "Koli (89)" },
                    { 90, "Description for Koli 90", "wwwroot/images/kolidataset/Koli (90).jpeg", "Koli (90)" },
                    { 91, "Description for Koli 91", "wwwroot/images/kolidataset/Koli (91).jpeg", "Koli (91)" },
                    { 92, "Description for Koli 92", "wwwroot/images/kolidataset/Koli (92).jpeg", "Koli (92)" },
                    { 93, "Description for Koli 93", "wwwroot/images/kolidataset/Koli (93).jpeg", "Koli (93)" },
                    { 94, "Description for Koli 94", "wwwroot/images/kolidataset/Koli (94).jpeg", "Koli (94)" },
                    { 95, "Description for Koli 95", "wwwroot/images/kolidataset/Koli (95).jpeg", "Koli (95)" },
                    { 96, "Description for Koli 96", "wwwroot/images/kolidataset/Koli (96).jpeg", "Koli (96)" },
                    { 97, "Description for Koli 97", "wwwroot/images/kolidataset/Koli (97).jpeg", "Koli (97)" },
                    { 98, "Description for Koli 98", "wwwroot/images/kolidataset/Koli (98).jpeg", "Koli (98)" },
                    { 99, "Description for Koli 99", "wwwroot/images/kolidataset/Koli (99).jpeg", "Koli (99)" },
                    { 100, "Description for Koli 100", "wwwroot/images/kolidataset/Koli (100).jpeg", "Koli (100)" },
                    { 101, "Description for Koli 101", "wwwroot/images/kolidataset/Koli (101).jpeg", "Koli (101)" },
                    { 102, "Description for Koli 102", "wwwroot/images/kolidataset/Koli (102).jpeg", "Koli (102)" },
                    { 103, "Description for Koli 103", "wwwroot/images/kolidataset/Koli (103).jpeg", "Koli (103)" },
                    { 104, "Description for Koli 104", "wwwroot/images/kolidataset/Koli (104).jpeg", "Koli (104)" },
                    { 105, "Description for Koli 105", "wwwroot/images/kolidataset/Koli (105).jpeg", "Koli (105)" },
                    { 106, "Description for Koli 106", "wwwroot/images/kolidataset/Koli (106).jpeg", "Koli (106)" },
                    { 107, "Description for Koli 107", "wwwroot/images/kolidataset/Koli (107).jpeg", "Koli (107)" },
                    { 108, "Description for Koli 108", "wwwroot/images/kolidataset/Koli (108).jpeg", "Koli (108)" },
                    { 109, "Description for Koli 109", "wwwroot/images/kolidataset/Koli (109).jpeg", "Koli (109)" },
                    { 110, "Description for Koli 110", "wwwroot/images/kolidataset/Koli (110).jpeg", "Koli (110)" },
                    { 111, "Description for Koli 111", "wwwroot/images/kolidataset/Koli (111).jpeg", "Koli (111)" },
                    { 112, "Description for Koli 112", "wwwroot/images/kolidataset/Koli (112).jpeg", "Koli (112)" },
                    { 113, "Description for Koli 113", "wwwroot/images/kolidataset/Koli (113).jpeg", "Koli (113)" },
                    { 114, "Description for Koli 114", "wwwroot/images/kolidataset/Koli (114).jpeg", "Koli (114)" },
                    { 115, "Description for Koli 115", "wwwroot/images/kolidataset/Koli (115).jpeg", "Koli (115)" },
                    { 116, "Description for Koli 116", "wwwroot/images/kolidataset/Koli (116).jpeg", "Koli (116)" },
                    { 117, "Description for Koli 117", "wwwroot/images/kolidataset/Koli (117).jpeg", "Koli (117)" },
                    { 118, "Description for Koli 118", "wwwroot/images/kolidataset/Koli (118).jpeg", "Koli (118)" },
                    { 119, "Description for Koli 119", "wwwroot/images/kolidataset/Koli (119).jpeg", "Koli (119)" },
                    { 120, "Description for Koli 120", "wwwroot/images/kolidataset/Koli (120).jpeg", "Koli (120)" },
                    { 121, "Description for Koli 121", "wwwroot/images/kolidataset/Koli (121).jpeg", "Koli (121)" },
                    { 122, "Description for Koli 122", "wwwroot/images/kolidataset/Koli (122).jpeg", "Koli (122)" },
                    { 123, "Description for Koli 123", "wwwroot/images/kolidataset/Koli (123).jpeg", "Koli (123)" },
                    { 124, "Description for Koli 124", "wwwroot/images/kolidataset/Koli (124).jpeg", "Koli (124)" },
                    { 125, "Description for Koli 125", "wwwroot/images/kolidataset/Koli (125).jpeg", "Koli (125)" },
                    { 126, "Description for Koli 126", "wwwroot/images/kolidataset/Koli (126).jpeg", "Koli (126)" },
                    { 127, "Description for Koli 127", "wwwroot/images/kolidataset/Koli (127).jpeg", "Koli (127)" },
                    { 128, "Description for Koli 128", "wwwroot/images/kolidataset/Koli (128).jpeg", "Koli (128)" },
                    { 129, "Description for Koli 129", "wwwroot/images/kolidataset/Koli (129).jpeg", "Koli (129)" },
                    { 130, "Description for Koli 130", "wwwroot/images/kolidataset/Koli (130).jpeg", "Koli (130)" },
                    { 131, "Description for Koli 131", "wwwroot/images/kolidataset/Koli (131).jpeg", "Koli (131)" },
                    { 132, "Description for Koli 132", "wwwroot/images/kolidataset/Koli (132).jpeg", "Koli (132)" },
                    { 133, "Description for Koli 133", "wwwroot/images/kolidataset/Koli (133).jpeg", "Koli (133)" },
                    { 134, "Description for Koli 134", "wwwroot/images/kolidataset/Koli (134).jpeg", "Koli (134)" },
                    { 135, "Description for Koli 135", "wwwroot/images/kolidataset/Koli (135).jpeg", "Koli (135)" },
                    { 136, "Description for Koli 136", "wwwroot/images/kolidataset/Koli (136).jpeg", "Koli (136)" },
                    { 137, "Description for Koli 137", "wwwroot/images/kolidataset/Koli (137).jpeg", "Koli (137)" },
                    { 138, "Description for Koli 138", "wwwroot/images/kolidataset/Koli (138).jpeg", "Koli (138)" },
                    { 139, "Description for Koli 139", "wwwroot/images/kolidataset/Koli (139).jpeg", "Koli (139)" },
                    { 140, "Description for Koli 140", "wwwroot/images/kolidataset/Koli (140).jpeg", "Koli (140)" },
                    { 141, "Description for Koli 141", "wwwroot/images/kolidataset/Koli (141).jpeg", "Koli (141)" },
                    { 142, "Description for Koli 142", "wwwroot/images/kolidataset/Koli (142).jpeg", "Koli (142)" },
                    { 143, "Description for Koli 143", "wwwroot/images/kolidataset/Koli (143).jpeg", "Koli (143)" },
                    { 144, "Description for Koli 144", "wwwroot/images/kolidataset/Koli (144).jpeg", "Koli (144)" },
                    { 145, "Description for Koli 145", "wwwroot/images/kolidataset/Koli (145).jpeg", "Koli (145)" },
                    { 146, "Description for Koli 146", "wwwroot/images/kolidataset/Koli (146).jpeg", "Koli (146)" },
                    { 147, "Description for Koli 147", "wwwroot/images/kolidataset/Koli (147).jpeg", "Koli (147)" },
                    { 148, "Description for Koli 148", "wwwroot/images/kolidataset/Koli (148).jpeg", "Koli (148)" },
                    { 149, "Description for Koli 149", "wwwroot/images/kolidataset/Koli (149).jpeg", "Koli (149)" },
                    { 150, "Description for Koli 150", "wwwroot/images/kolidataset/Koli (150).jpeg", "Koli (150)" },
                    { 151, "Description for Koli 151", "wwwroot/images/kolidataset/Koli (151).jpeg", "Koli (151)" },
                    { 152, "Description for Koli 152", "wwwroot/images/kolidataset/Koli (152).jpeg", "Koli (152)" },
                    { 153, "Description for Koli 153", "wwwroot/images/kolidataset/Koli (153).jpeg", "Koli (153)" },
                    { 154, "Description for Koli 154", "wwwroot/images/kolidataset/Koli (154).jpeg", "Koli (154)" },
                    { 155, "Description for Koli 155", "wwwroot/images/kolidataset/Koli (155).jpeg", "Koli (155)" },
                    { 156, "Description for Koli 156", "wwwroot/images/kolidataset/Koli (156).jpeg", "Koli (156)" },
                    { 157, "Description for Koli 157", "wwwroot/images/kolidataset/Koli (157).jpeg", "Koli (157)" },
                    { 158, "Description for Koli 158", "wwwroot/images/kolidataset/Koli (158).jpeg", "Koli (158)" },
                    { 159, "Description for Koli 159", "wwwroot/images/kolidataset/Koli (159).jpeg", "Koli (159)" },
                    { 160, "Description for Koli 160", "wwwroot/images/kolidataset/Koli (160).jpeg", "Koli (160)" },
                    { 161, "Description for Koli 161", "wwwroot/images/kolidataset/Koli (161).jpeg", "Koli (161)" },
                    { 162, "Description for Koli 162", "wwwroot/images/kolidataset/Koli (162).jpeg", "Koli (162)" },
                    { 163, "Description for Koli 163", "wwwroot/images/kolidataset/Koli (163).jpeg", "Koli (163)" },
                    { 164, "Description for Koli 164", "wwwroot/images/kolidataset/Koli (164).jpeg", "Koli (164)" },
                    { 165, "Description for Koli 165", "wwwroot/images/kolidataset/Koli (165).jpeg", "Koli (165)" },
                    { 166, "Description for Koli 166", "wwwroot/images/kolidataset/Koli (166).jpeg", "Koli (166)" },
                    { 167, "Description for Koli 167", "wwwroot/images/kolidataset/Koli (167).jpeg", "Koli (167)" },
                    { 168, "Description for Koli 168", "wwwroot/images/kolidataset/Koli (168).jpeg", "Koli (168)" },
                    { 169, "Description for Koli 169", "wwwroot/images/kolidataset/Koli (169).jpeg", "Koli (169)" },
                    { 170, "Description for Koli 170", "wwwroot/images/kolidataset/Koli (170).jpeg", "Koli (170)" },
                    { 171, "Description for Koli 171", "wwwroot/images/kolidataset/Koli (171).jpeg", "Koli (171)" },
                    { 172, "Description for Koli 172", "wwwroot/images/kolidataset/Koli (172).jpeg", "Koli (172)" },
                    { 173, "Description for Koli 173", "wwwroot/images/kolidataset/Koli (173).jpeg", "Koli (173)" },
                    { 174, "Description for Koli 174", "wwwroot/images/kolidataset/Koli (174).jpeg", "Koli (174)" },
                    { 175, "Description for Koli 175", "wwwroot/images/kolidataset/Koli (175).jpeg", "Koli (175)" },
                    { 176, "Description for Koli 176", "wwwroot/images/kolidataset/Koli (176).jpeg", "Koli (176)" },
                    { 177, "Description for Koli 177", "wwwroot/images/kolidataset/Koli (177).jpeg", "Koli (177)" },
                    { 178, "Description for Koli 178", "wwwroot/images/kolidataset/Koli (178).jpeg", "Koli (178)" },
                    { 179, "Description for Koli 179", "wwwroot/images/kolidataset/Koli (179).jpeg", "Koli (179)" },
                    { 180, "Description for Koli 180", "wwwroot/images/kolidataset/Koli (180).jpeg", "Koli (180)" },
                    { 181, "Description for Koli 181", "wwwroot/images/kolidataset/Koli (181).jpeg", "Koli (181)" },
                    { 182, "Description for Koli 182", "wwwroot/images/kolidataset/Koli (182).jpeg", "Koli (182)" },
                    { 183, "Description for Koli 183", "wwwroot/images/kolidataset/Koli (183).jpeg", "Koli (183)" },
                    { 184, "Description for Koli 184", "wwwroot/images/kolidataset/Koli (184).jpeg", "Koli (184)" },
                    { 185, "Description for Koli 185", "wwwroot/images/kolidataset/Koli (185).jpeg", "Koli (185)" },
                    { 186, "Description for Koli 186", "wwwroot/images/kolidataset/Koli (186).jpeg", "Koli (186)" },
                    { 187, "Description for Koli 187", "wwwroot/images/kolidataset/Koli (187).jpeg", "Koli (187)" },
                    { 188, "Description for Koli 188", "wwwroot/images/kolidataset/Koli (188).jpeg", "Koli (188)" },
                    { 189, "Description for Koli 189", "wwwroot/images/kolidataset/Koli (189).jpeg", "Koli (189)" },
                    { 190, "Description for Koli 190", "wwwroot/images/kolidataset/Koli (190).jpeg", "Koli (190)" },
                    { 191, "Description for Koli 191", "wwwroot/images/kolidataset/Koli (191).jpeg", "Koli (191)" },
                    { 192, "Description for Koli 192", "wwwroot/images/kolidataset/Koli (192).jpeg", "Koli (192)" },
                    { 193, "Description for Koli 193", "wwwroot/images/kolidataset/Koli (193).jpeg", "Koli (193)" },
                    { 194, "Description for Koli 194", "wwwroot/images/kolidataset/Koli (194).jpeg", "Koli (194)" },
                    { 195, "Description for Koli 195", "wwwroot/images/kolidataset/Koli (195).jpeg", "Koli (195)" },
                    { 196, "Description for Koli 196", "wwwroot/images/kolidataset/Koli (196).jpeg", "Koli (196)" },
                    { 197, "Description for Koli 197", "wwwroot/images/kolidataset/Koli (197).jpeg", "Koli (197)" },
                    { 198, "Description for Koli 198", "wwwroot/images/kolidataset/Koli (198).jpeg", "Koli (198)" },
                    { 199, "Description for Koli 199", "wwwroot/images/kolidataset/Koli (199).jpeg", "Koli (199)" },
                    { 200, "Description for Koli 200", "wwwroot/images/kolidataset/Koli (200).jpeg", "Koli (200)" },
                    { 201, "Description for Koli 201", "wwwroot/images/kolidataset/Koli (201).jpeg", "Koli (201)" },
                    { 202, "Description for Koli 202", "wwwroot/images/kolidataset/Koli (202).jpeg", "Koli (202)" },
                    { 203, "Description for Koli 203", "wwwroot/images/kolidataset/Koli (203).jpeg", "Koli (203)" },
                    { 204, "Description for Koli 204", "wwwroot/images/kolidataset/Koli (204).jpeg", "Koli (204)" },
                    { 205, "Description for Koli 205", "wwwroot/images/kolidataset/Koli (205).jpeg", "Koli (205)" },
                    { 206, "Description for Koli 206", "wwwroot/images/kolidataset/Koli (206).jpeg", "Koli (206)" },
                    { 207, "Description for Koli 207", "wwwroot/images/kolidataset/Koli (207).jpeg", "Koli (207)" },
                    { 208, "Description for Koli 208", "wwwroot/images/kolidataset/Koli (208).jpeg", "Koli (208)" },
                    { 209, "Description for Koli 209", "wwwroot/images/kolidataset/Koli (209).jpeg", "Koli (209)" },
                    { 210, "Description for Koli 210", "wwwroot/images/kolidataset/Koli (210).jpeg", "Koli (210)" },
                    { 211, "Description for Koli 211", "wwwroot/images/kolidataset/Koli (211).jpeg", "Koli (211)" },
                    { 212, "Description for Koli 212", "wwwroot/images/kolidataset/Koli (212).jpeg", "Koli (212)" },
                    { 213, "Description for Koli 213", "wwwroot/images/kolidataset/Koli (213).jpeg", "Koli (213)" },
                    { 214, "Description for Koli 214", "wwwroot/images/kolidataset/Koli (214).jpeg", "Koli (214)" },
                    { 215, "Description for Koli 215", "wwwroot/images/kolidataset/Koli (215).jpeg", "Koli (215)" },
                    { 216, "Description for Koli 216", "wwwroot/images/kolidataset/Koli (216).jpeg", "Koli (216)" },
                    { 217, "Description for Koli 217", "wwwroot/images/kolidataset/Koli (217).jpeg", "Koli (217)" },
                    { 218, "Description for Koli 218", "wwwroot/images/kolidataset/Koli (218).jpeg", "Koli (218)" },
                    { 219, "Description for Koli 219", "wwwroot/images/kolidataset/Koli (219).jpeg", "Koli (219)" },
                    { 220, "Description for Koli 220", "wwwroot/images/kolidataset/Koli (220).jpeg", "Koli (220)" },
                    { 221, "Description for Koli 221", "wwwroot/images/kolidataset/Koli (221).jpeg", "Koli (221)" },
                    { 222, "Description for Koli 222", "wwwroot/images/kolidataset/Koli (222).jpeg", "Koli (222)" },
                    { 223, "Description for Koli 223", "wwwroot/images/kolidataset/Koli (223).jpeg", "Koli (223)" },
                    { 224, "Description for Koli 224", "wwwroot/images/kolidataset/Koli (224).jpeg", "Koli (224)" },
                    { 225, "Description for Koli 225", "wwwroot/images/kolidataset/Koli (225).jpeg", "Koli (225)" },
                    { 226, "Description for Koli 226", "wwwroot/images/kolidataset/Koli (226).jpeg", "Koli (226)" },
                    { 227, "Description for Koli 227", "wwwroot/images/kolidataset/Koli (227).jpeg", "Koli (227)" },
                    { 228, "Description for Koli 228", "wwwroot/images/kolidataset/Koli (228).jpeg", "Koli (228)" },
                    { 229, "Description for Koli 229", "wwwroot/images/kolidataset/Koli (229).jpeg", "Koli (229)" },
                    { 230, "Description for Koli 230", "wwwroot/images/kolidataset/Koli (230).jpeg", "Koli (230)" },
                    { 231, "Description for Koli 231", "wwwroot/images/kolidataset/Koli (231).jpeg", "Koli (231)" },
                    { 232, "Description for Koli 232", "wwwroot/images/kolidataset/Koli (232).jpeg", "Koli (232)" },
                    { 233, "Description for Koli 233", "wwwroot/images/kolidataset/Koli (233).jpeg", "Koli (233)" },
                    { 234, "Description for Koli 234", "wwwroot/images/kolidataset/Koli (234).jpeg", "Koli (234)" },
                    { 235, "Description for Koli 235", "wwwroot/images/kolidataset/Koli (235).jpeg", "Koli (235)" },
                    { 236, "Description for Koli 236", "wwwroot/images/kolidataset/Koli (236).jpeg", "Koli (236)" },
                    { 237, "Description for Koli 237", "wwwroot/images/kolidataset/Koli (237).jpeg", "Koli (237)" },
                    { 238, "Description for Koli 238", "wwwroot/images/kolidataset/Koli (238).jpeg", "Koli (238)" },
                    { 239, "Description for Koli 239", "wwwroot/images/kolidataset/Koli (239).jpeg", "Koli (239)" },
                    { 240, "Description for Koli 240", "wwwroot/images/kolidataset/Koli (240).jpeg", "Koli (240)" },
                    { 241, "Description for Koli 241", "wwwroot/images/kolidataset/Koli (241).jpeg", "Koli (241)" },
                    { 242, "Description for Koli 242", "wwwroot/images/kolidataset/Koli (242).jpeg", "Koli (242)" },
                    { 243, "Description for Koli 243", "wwwroot/images/kolidataset/Koli (243).jpeg", "Koli (243)" },
                    { 244, "Description for Koli 244", "wwwroot/images/kolidataset/Koli (244).jpeg", "Koli (244)" },
                    { 245, "Description for Koli 245", "wwwroot/images/kolidataset/Koli (245).jpeg", "Koli (245)" },
                    { 246, "Description for Koli 246", "wwwroot/images/kolidataset/Koli (246).jpeg", "Koli (246)" },
                    { 247, "Description for Koli 247", "wwwroot/images/kolidataset/Koli (247).jpeg", "Koli (247)" },
                    { 248, "Description for Koli 248", "wwwroot/images/kolidataset/Koli (248).jpeg", "Koli (248)" },
                    { 249, "Description for Koli 249", "wwwroot/images/kolidataset/Koli (249).jpeg", "Koli (249)" },
                    { 250, "Description for Koli 250", "wwwroot/images/kolidataset/Koli (250).jpeg", "Koli (250)" },
                    { 251, "Description for Koli 251", "wwwroot/images/kolidataset/Koli (251).jpeg", "Koli (251)" },
                    { 252, "Description for Koli 252", "wwwroot/images/kolidataset/Koli (252).jpeg", "Koli (252)" },
                    { 253, "Description for Koli 253", "wwwroot/images/kolidataset/Koli (253).jpeg", "Koli (253)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Sample description", "sample-image-path.jpg", "Sample Name" });

            migrationBuilder.UpdateData(
                table: "Kolis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Name" },
                values: new object[] { "Another description", "another-image-path.jpg", "Another Name" });
        }
    }
}
