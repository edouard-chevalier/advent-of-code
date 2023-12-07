// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");

/*
const string inputReal = @"Time:        46     85     75     82
Distance:   208   1412   1257   1410";
const string inputTest = @"Time:      7  15   30
Distance:  9  40  200";

var input = inputReal;
var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
    .Where(l => l.Trim() != string.Empty).ToArray();
 var times = lines[0].Replace("Time:", "").Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
var distances = lines[1].Replace("Distance:", "").Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

long DistanceForPressing(long timeHold, long total) {
    return timeHold * (total - timeHold);
}

long res = 1;
for( int i = 0; i < times.Length; i++ ) {
    var time = times[i];
    var record = distances[i];
    var count = 0;
    for (int j = 0; j < time; j++) {
        var distanceForPressing = DistanceForPressing(j, time);
        if( distanceForPressing > record ) {
            count++;
        }
    }
    Console.WriteLine($"{i}: {count}");
    res*=count;

}
Console.WriteLine(res);*/


const string inputReal = @"Time:        46857582
Distance:   208141212571410";
const string inputTest = @"Time:      71530
Distance:  940200";

var input = inputReal;
var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
    .Where(l => l.Trim() != string.Empty).ToArray();
var times = lines[0].Replace("Time:", "").Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
var distances = lines[1].Replace("Distance:", "").Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

long DistanceForPressing(long timeHold, long total) {
    return timeHold * (total - timeHold);
}

long res = 1;
for( int i = 0; i < times.Length; i++ ) {
    var time = times[i];
    var record = distances[i];
    var count = 0;
    for (int j = 0; j < time; j++) {
        var distanceForPressing = DistanceForPressing(j, time);
        if( distanceForPressing > record ) {
            count++;
        }
    }
    Console.WriteLine($"{i}: {count}");
    res*=count;

}
Console.WriteLine(res);

