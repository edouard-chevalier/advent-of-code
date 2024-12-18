// See https://aka.ms/new-console-template for more information


using System.Text;

const string inputReal = @"Register A: 60589763
Register B: 0
Register C: 0

Program: 2,4,1,5,7,5,1,6,4,1,5,5,0,3,3,0";
const string inputTest = @"Register A: 729
Register B: 0
Register C: 0

Program: 0,1,5,4,3,0";
const string inputTest2 = @"Register A: 2024
Register B: 0
Register C: 0

Program: 0,3,5,4,3,0";

void Part1(string input) {
    var lines = input.Split(Environment.NewLine);
    long a = long.Parse(lines[0].Split("A:")[1]);
    long b = long.Parse(lines[1].Split("B:")[1]);
    long c = long.Parse(lines[2].Split("C:")[1]);
    var program = lines[4].Substring(8).Split(",").Select(byte.Parse).ToArray();
    
    List<long> output = new List<long>();
    int pointer = 0;
    while (pointer < program.Length) {
        var opcode = program[pointer];
        var operand = program[pointer + 1];
        long GetOperand( bool combo = false) {
            if (!combo) return operand;
            return operand switch
            {
                4 => a,
                5 => b,
                6 => c,
                _ => operand
            };
        }
        switch (opcode)
        {
            case 0:
                a >>= (int)GetOperand(true);
                break;
            case 1:
                b ^= GetOperand();
                break;
            case 2:
                b = GetOperand( true ) & 7;
                break;
            case 3:
                if (a != 0) {
                    pointer = (int) GetOperand();
                    continue;
                }
                break;
            case 4:
                b ^= c;
                break;
            case 5:
                output.Add(GetOperand(true) & 7);
                break;
            case 6:
                b  = a >> (int)GetOperand(true);
                break;
            case 7:
                c  = a >> (int)GetOperand(true);
                break;
                
        }
        pointer ++;
        pointer++;
    }
    Console.WriteLine(string.Join(",", output));
    
}

bool DidCopy(long a, byte[] program, List<byte> output ) {
    long b = 0;
    long c = 0;
    output.Clear();
    int pointer = 0;
    while (pointer < program.Length) {
        var opcode = program[pointer];
        var operand = program[pointer + 1];
        long GetOperand( bool combo = false) {
            if (!combo) return operand;
            return operand switch
            {
                4 => a,
                5 => b,
                6 => c,
                _ => operand
            };
        }
        switch (opcode)
        {
            case 0:
                a >>= (int)GetOperand(true);
                break;
            case 1:
                b ^= GetOperand();
                break;
            case 2:
                b = GetOperand( true ) & 7;
                break;
            case 3:
                if (a != 0) {
                    pointer = (int) GetOperand();
                    continue;
                }
                break;
            case 4:
                b ^= c;
                break;
            case 5:
                var outputSingle = (byte) ( GetOperand(true) & 7 );
                if( program[output.Count] != outputSingle) return false;
                output.Add(outputSingle);
                break;
            case 6:
                b  = a >> (int)GetOperand(true);
                break;
            case 7:
                c  = a >> (int)GetOperand(true);
                break;
                
        }
        pointer++;
        pointer++;
    }
    return AreSame(program, output);
}

static bool AreSame(IReadOnlyList<byte> a, IReadOnlyList<byte> b) {
    if (a.Count != b.Count) return false;
    for (int i = 0; i < a.Count; i++)
    {
        if (a[i] != b[i]) return false;
    }

    return true;
}

byte RunOnce(long a, IReadOnlyList<byte> program)
{
    byte res = 255;
    long b = 0;
    long c = 0;
    int pointer = 0;
    while (pointer < program.Count) {
        var opcode = program[pointer];
        var operand = program[pointer + 1];
        long GetOperand( bool combo = false) {
            if (!combo) return operand;
            return operand switch
            {
                4 => a,
                5 => b,
                6 => c,
                _ => operand
            };
        }
        switch (opcode)
        {
            case 0:
                a >>= (int)GetOperand(true);
                break;
            case 1:
                b ^= GetOperand();
                break;
            case 2:
                b = GetOperand( true ) & 7;
                break;
            case 3:
                /*if (a != 0) {
                    pointer = (int) GetOperand();
                    continue;
                }*/
                break;
            case 4:
                b ^= c;
                break;
            case 5:
                res = (byte) ( GetOperand(true) & 7 );
                break;
            case 6:
                b  = a >> (int)GetOperand(true);
                break;
            case 7:
                c  = a >> (int)GetOperand(true);
                break;
                
        }
        pointer++;
        pointer++;
    }

    return res;
}

string PrintProgram(IReadOnlyList<byte> program)
{
    var sb = new StringBuilder();
    
    int pointer = 0;
    while (pointer < program.Count) {
        var opcode = program[pointer];
        var operand = program[pointer + 1];
        string GetOperand( bool combo = false) {
            if (!combo) return operand.ToString();
            return operand switch
            {
                4 => "A",
                5 => "B",
                6 => "C",
                _ => operand.ToString()
            };
        }

        sb.Append($"@{pointer}: ");
        switch (opcode)
        {
            case 0:
                sb.AppendLine($"A = A >> {GetOperand(true)}");
                //a >>= (int)GetOperand(true);
                break;
            case 1:
                sb.AppendLine($"B = B ^ {GetOperand()}");
                //b ^= GetOperand();
                break;
            case 2:
                sb.AppendLine($"B = {GetOperand(true)} & 7");
                //b = GetOperand( true ) & 7;
                break;
            case 3:
                sb.AppendLine($"if A != 0 GOTO {GetOperand()}");
                /*if (a != 0) {
                    pointer = (int) GetOperand();
                    continue;
                }*/
                break;
            case 4:
                sb.AppendLine("B = B ^ C");
                //b ^= c;
                break;
            case 5:
                sb.AppendLine($"out {GetOperand(true)} & 7 ");
                /*var outputSingle = (byte) ( GetOperand(true) & 7 );
                if( program[output.Count] != outputSingle) return false;
                output.Add(outputSingle);*/
                break;
            case 6:
                sb.AppendLine($"B = A >> {GetOperand(true)}");
                //b  = a >> (int)GetOperand(true);
                break;
            case 7:
                sb.AppendLine($"C = A >> {GetOperand(true)}");
                //c  = a >> (int)GetOperand(true);
                break;
                
        }
        pointer++;
        pointer++;
    }

    return sb.ToString();
}

void Part2(string input) {
    var lines = input.Split(Environment.NewLine);
    /*long a = long.Parse(lines[0].Split("A:")[1]);
    long b = long.Parse(lines[1].Split("B:")[1]);
    long c = long.Parse(lines[2].Split("C:")[1]);*/
    var program = lines[4].Substring(8).Split(",").Select(byte.Parse).ToArray();
    Console.WriteLine(string.Join(",", program));
    Console.WriteLine(PrintProgram(program));
    var output = new Dictionary<byte,List<long>>();

    RunOnce(255, program);
    
    for( long tryA = 0; tryA < 4096; tryA++) {
        var runOnce = RunOnce(tryA,program);
        if (!output.ContainsKey(runOnce)) output[runOnce] = new List<long>();
        output[runOnce].Add(tryA);
        //output.TryAdd(runOnce, tryA);
        //Console.WriteLine(runOnce);
        /*if (tryA % 100000 == 0) {
            Console.WriteLine(tryA);
        }
        if (DidCopy(tryA, program, output)) {
            Console.WriteLine($"Victory: {tryA}");
            break;
        }*/
    }

    /*foreach (var a in output[2]) {
        Console.WriteLine(Convert.ToString(a, 2));
    }*/
    
    /*foreach (var item in output) {
        Console.WriteLine($"{item.Key}: {string.Join(",", item.Value)}");
    }*/
    
    List<List<long>> candidates = new List<List<long>>();
    foreach (var t in program) {
        candidates.Add(output[t].ToList());
    }
    for (int i = 0; i < program.Length; i++) {
        Console.WriteLine($"Candidates for {program[i]}: {string.Join(",", candidates[i])}");
    }
    Console.WriteLine("----");


    List<List<long>> FilterCandidates(List<List<long>> list) {
        List<List<long>> newCandidates = new List<List<long>>();
        for (int i = 0; i < program.Length; i++) {
            var newCandidate = new List<long>();
            newCandidates.Add(newCandidate);
            foreach (var possible in list[i])
            {
                bool keep = true;
                // the low 3 bits has to be compatible with the high 3 bits of the next
                if (i != program.Length - 1)
                {
                    long low = High3(possible);
                    if (list[i + 1].All(x => Low3(x) != low)) {
                        keep = false;
                    }
                }

                // the high 3 bits has to be compatible with the low 3 bits of the previous
                if (i != 0) {
                    long high = Low3(possible);
                    if (list[i - 1].All(x => High3(x) != high)) {
                        keep = false;
                    }
                }

                if (keep) {
                    newCandidate.Add(possible);
                }
            }
        }

        return newCandidates;
    }
    
  

    /*
    while (true) {
        var newCandidates1 = FilterCandidates(candidates);

        long toTEst = 1;

        for (int i = 0; i < program.Length; i++) {
            if (i != program.Length -1) toTEst *= newCandidates1[i].Count;
            Console.WriteLine($"Candidates for {program[i]}: {string.Join(",", newCandidates1[i])}");
        }
        Console.WriteLine(toTEst);
        if (candidates.Sum(c => c.Count) == newCandidates1.Sum(c => c.Count)) {
            candidates = newCandidates1;
            break;
        }
        candidates = newCandidates1;
        Console.WriteLine("--------");
    }*/

  
/*
Console.WriteLine("----");
    
    var newCandidates2 = FilterCandidates(candidates);
    candidates = newCandidates2;
    
    for (int i = 0; i < program.Length; i++)
    {
        Console.WriteLine($"Candidates for {program[i]}: {string.Join(",", candidates[i])}");
    }
  
    Console.WriteLine("----");
    var newCandidates3 = FilterCandidates(candidates);
    candidates = newCandidates3;
    for (int i = 0; i < program.Length; i++)
    {
        Console.WriteLine($"Candidates for {program[i]}: {string.Join(",", candidates[i])}");
    }*/

    var currentAttempts = new int[program.Length];
    
    long ComputeTryA() {
        long tryA = candidates[program.Length-1][currentAttempts[ program.Length -1]];
        for( int i = program.Length - 2; i>=0; i--)
        {
            long candidate = candidates[i][currentAttempts[i]];
            if( Low3(tryA) != High3(candidate)) {
                throw new Exception();
            }
            tryA <<= 3;
            tryA |=candidate;
        }

        return tryA;
    }
    
    bool Match( int idx ) {
        if (idx < 0)
        {
            long tryA = ComputeTryA();
            if( DidCopy(tryA, program, new List<byte>())) {
                Console.WriteLine($"Victory: {tryA}");
                return true;
            }
        }
        for( int i = 0; i < candidates[idx].Count; i++) {
            currentAttempts[idx] = i;
            if (idx != program.Length - 1) { // early bail out
                var theAttempt = candidates[idx][i];
                var attemptBefore = candidates[idx + 1][currentAttempts[idx + 1]];
                if (High3(theAttempt) != Low3(attemptBefore))
                {
                    continue;
                }
            }

            if (Match(idx - 1)) return true;
        }
        return false;
    }

    if (!Match(program.Length - 1))
    {
        Console.WriteLine("damn it !");

    }
    
    //Console.WriteLine(string.Join(",", output));
    //Console.WriteLine(string.Join(",", output));
}

long Low3(long n) => n & 511;// 511 = 111111111
long High3(long n) => (n >> 3) & 511;
long Low(long n) => n & 0x7;
long High(long n) => (n >> 3) & 0x7;
var reality =
@"
@0: B = A & 7
@2: B = B ^ 5
@4: C = A >> B
@6: B = B ^ 6
@8: B = B ^ C
@10: out B & 7 
@12: A = A >> 3
@14: if A != 0 GOTO 0";


Part2(inputReal);