// See https://aka.ms/new-console-template for more information


const string inputReal = @"dayXX";

static string Load() {
    return File.ReadAllText(Path.Combine("D:\\code\\advent-of-code\\AdventOfCode2025\\data", $"{inputReal}.txt"));
}

const string inputTest = @"";

void Part1(string input) {
    if (input.StartsWith("day")) {
        input = Load();
    }
    var lines = input.Split(Environment.NewLine);
}

Part1(inputTest);