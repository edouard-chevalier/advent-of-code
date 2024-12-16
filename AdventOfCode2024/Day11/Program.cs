// See https://aka.ms/new-console-template for more information


const string inputReal = @"554735 45401 8434 0 188 7487525 77 7";
const string inputTest = @"125 17";

void Part1(string input) {
    var stones = input.Split(" ").Select(long.Parse).Take(1).ToList();

    var newStones = new List<long>();
    for (int i = 0; i < 25; i++) {
        newStones.Clear();
        for (int j = 0; j < stones.Count; j++) {
            if (stones[j] == 0) {
                newStones.Add(1);
                continue;
            }
            var asString = stones[j].ToString();
            if( asString.Length % 2 == 0){
                newStones.Add(long.Parse(asString.Substring(0, asString.Length / 2)));
                newStones.Add(long.Parse(asString.Substring(asString.Length / 2)));
                continue;
            }
            newStones.Add(stones[j] * 2024);
        }
        (stones, newStones) = (newStones, stones);
        Console.WriteLine($"step {i} : {stones.Count} stones with {stones.Distinct().Count()} distinct values");
    }
    Console.WriteLine(stones.Count);
    
}

void Part2(string input) {
    var stones = input.Split(" ").Select(long.Parse).ToDictionary( x => x, x => 1L);

    var newStones = new Dictionary<long, long>();
    for (int i = 0; i < 75; i++) {
        newStones.Clear();

        void Add(long value, long count) {
            if(!newStones.ContainsKey(value)){
                newStones[value] = count;
                return;
            }
            newStones[value] += count;
        }
        foreach (var (value,count) in stones) {
            
            if (value == 0) {
                Add(1, count);
                continue;
            }
            var asString = value.ToString();
            if( asString.Length % 2 == 0){
                Add(long.Parse(asString.Substring(0, asString.Length / 2)), count);
                Add(long.Parse(asString.Substring(asString.Length / 2)), count);
                continue;
            }
            Add(value * 2024, count);
        }
        (stones, newStones) = (newStones, stones);
        Console.WriteLine($"step {i} : {stones.Values.Sum()} stones with {stones.Count} distinct values");
    }
    Console.WriteLine(stones.Values.Sum());
    
}

Part2(inputReal);