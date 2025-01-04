// See https://aka.ms/new-console-template for more information


using System.Text.RegularExpressions;

const string inputReal = @"x00: 1
x01: 0
x02: 0
x03: 1
x04: 1
x05: 1
x06: 0
x07: 0
x08: 0
x09: 1
x10: 0
x11: 0
x12: 0
x13: 1
x14: 0
x15: 1
x16: 0
x17: 0
x18: 1
x19: 1
x20: 0
x21: 0
x22: 1
x23: 1
x24: 0
x25: 1
x26: 1
x27: 1
x28: 1
x29: 1
x30: 0
x31: 1
x32: 0
x33: 1
x34: 1
x35: 1
x36: 0
x37: 1
x38: 1
x39: 0
x40: 1
x41: 0
x42: 1
x43: 1
x44: 1
y00: 1
y01: 1
y02: 1
y03: 1
y04: 0
y05: 1
y06: 0
y07: 1
y08: 0
y09: 1
y10: 1
y11: 1
y12: 1
y13: 0
y14: 0
y15: 0
y16: 1
y17: 0
y18: 1
y19: 0
y20: 0
y21: 0
y22: 0
y23: 0
y24: 1
y25: 0
y26: 1
y27: 0
y28: 0
y29: 0
y30: 1
y31: 0
y32: 1
y33: 0
y34: 1
y35: 0
y36: 0
y37: 0
y38: 0
y39: 0
y40: 0
y41: 0
y42: 1
y43: 1
y44: 1

jdr XOR wvk -> z32
x06 AND y06 -> vsv
x32 AND y32 -> dwn
x40 XOR y40 -> ftm
wcb OR mcn -> vwj
x14 XOR y14 -> vjc
knj OR rtq -> hvj
scr AND fvs -> cnw
vtk OR rcm -> fbc
y24 XOR x24 -> ftc
vtc XOR cwm -> z28
vmc OR ffj -> fqs
dqd XOR dnn -> ffj
spp XOR qtk -> z23
rmm XOR hvj -> z10
gvh OR fbh -> hdb
nrv AND ftm -> mcn
y29 AND x29 -> gnc
gtq AND npm -> gpf
y22 XOR x22 -> hgq
fpw OR vsw -> sff
pnm OR tpn -> mkg
y16 AND x16 -> chg
x43 XOR y43 -> qjh
jqn OR jjv -> hkc
gbr OR nrs -> smt
x07 AND y07 -> jmm
nnm AND dcs -> tgh
kvw AND hsn -> bdq
mpb OR kdc -> rwv
mvh XOR mkg -> z18
rwq OR kbg -> pvs
x23 AND y23 -> mkf
y38 XOR x38 -> psb
fwp AND phm -> gbb
ftm XOR nrv -> z40
y16 XOR x16 -> fwp
y17 XOR x17 -> wdm
phm XOR fwp -> z16
sff XOR wkd -> z19
y35 XOR x35 -> hsn
sqw OR fnj -> rkt
pgt AND hgq -> jbd
wps OR fhw -> vtc
x42 AND y42 -> gvh
qjw XOR smt -> z42
nsj OR qdq -> nnm
x02 AND y02 -> vht
fjr AND ndm -> hdc
vsq OR mkf -> hrv
npm XOR gtq -> z06
grh OR bbk -> nrv
qjr OR vvj -> vsb
qtk AND spp -> vsq
fjh XOR kfr -> z39
x40 AND y40 -> wcb
rbj AND jfc -> hbj
jbd OR gjh -> spp
vsb AND ktw -> fcv
jhk OR nvd -> cnt
dwp AND tpr -> knt
x36 AND y36 -> pmp
y39 XOR x39 -> kfr
y42 XOR x42 -> qjw
ktw XOR vsb -> z04
bcb AND qps -> tqb
ggt XOR vwj -> z41
y05 AND x05 -> grd
str OR pkg -> scr
mkg AND mvh -> fpw
x31 AND y31 -> ctt
rkt XOR vjc -> z14
vwj AND ggt -> nrs
fpp XOR jfn -> z05
grd OR bqn -> gtq
dhr XOR wdm -> z17
x25 XOR y25 -> hds
x34 AND y34 -> jjd
gpt XOR hkc -> z27
scm OR pcj -> pgt
scw OR dnc -> wqq
x41 AND y41 -> gbr
fvs XOR scr -> z29
pvs XOR ccd -> z21
x30 AND y30 -> dqc
tsb OR kcj -> trn
x25 AND y25 -> mtt
rns AND hnn -> vhw
hrv XOR ftc -> z24
fbc XOR vbf -> z02
hbj OR rrn -> qps
fpp AND jfn -> bqn
tnd XOR hhk -> z30
fjr XOR ndm -> z36
x19 XOR y19 -> wkd
x23 XOR y23 -> qtk
y01 XOR x01 -> kgc
y19 AND x19 -> scw
dvd AND wqm -> ckq
cwm AND vtc -> pkg
jrb XOR jjp -> z12
x08 XOR y08 -> dqd
wkm OR pwq -> tpr
prd OR vht -> sfh
fcv OR pkw -> jfn
y07 XOR x07 -> dvd
jss OR bdq -> ndm
y09 AND x09 -> rtq
y00 XOR x00 -> z00
y43 AND x43 -> tsb
qjw AND smt -> fbh
x33 XOR y33 -> jfc
x04 XOR y04 -> ktw
x44 AND y44 -> rbs
x10 AND y10 -> nsj
jfm XOR ssc -> z26
y24 AND x24 -> rdj
bcj AND hds -> gtn
y35 AND x35 -> jss
rbs OR rvg -> z45
y13 AND x13 -> sqw
jjd OR tqb -> kvw
rvh XOR kgc -> z01
y08 AND x08 -> vmc
x15 AND y15 -> dwp
y17 AND x17 -> tpn
x11 XOR y11 -> dcs
x06 XOR y06 -> npm
sqc XOR chd -> z37
wqm XOR dvd -> z07
x29 XOR y29 -> fvs
hdb AND qjh -> kcj
x37 XOR y37 -> chd
vsv OR gpf -> wqm
y15 XOR x15 -> kfm
kbp XOR sfh -> z03
y14 AND x14 -> wkm
rvh AND kgc -> vtk
y44 XOR x44 -> vsk
y38 AND x38 -> tbh
x26 XOR y26 -> jfm
x12 AND y12 -> nvd
cnt AND vnw -> fnj
hkc AND gpt -> wps
x39 AND y39 -> grh
trn XOR vsk -> z44
x20 AND y20 -> rwq
sbs AND fqs -> knj
x03 XOR y03 -> kbp
trn AND vsk -> rvg
tpr XOR dwp -> z15
psb AND rwv -> jth
x37 AND y37 -> mpb
jrb AND jjp -> jhk
x03 AND y03 -> vvj
ctt OR vhw -> z31
jfc XOR rbj -> z33
gbb OR chg -> dhr
x11 AND y11 -> ngf
pvs AND ccd -> pcj
y02 XOR x02 -> vbf
ftc AND hrv -> wwp
jth OR tbh -> fjh
x10 XOR y10 -> rmm
x18 AND y18 -> vsw
wvk AND jdr -> bhw
y36 XOR x36 -> fjr
y04 AND x04 -> pkw
x09 XOR y09 -> sbs
x27 AND y27 -> fhw
x26 AND y26 -> jjv
rkt AND vjc -> pwq
x28 AND y28 -> str
y28 XOR x28 -> cwm
x20 XOR y20 -> vbh
x32 XOR y32 -> wvk
y34 XOR x34 -> bcb
ssc AND jfm -> jqn
y27 XOR x27 -> gpt
gnc OR cnw -> hhk
tgh OR ngf -> jjp
kbp AND sfh -> qjr
mtt OR gtn -> ssc
hvj AND rmm -> qdq
dnn AND dqd -> z08
x01 AND y01 -> rcm
y22 AND x22 -> z22
fbc AND vbf -> prd
y13 XOR x13 -> vnw
x21 XOR y21 -> ccd
rwv XOR psb -> z38
pmp OR hdc -> sqc
hdb XOR qjh -> z43
rns XOR hnn -> jdr
chd AND sqc -> kdc
x21 AND y21 -> scm
sff AND wkd -> dnc
dhr AND wdm -> pnm
y31 XOR x31 -> rns
y05 XOR x05 -> fpp
hsn XOR kvw -> z35
y30 XOR x30 -> tnd
x00 AND y00 -> rvh
y41 XOR x41 -> ggt
bcb XOR qps -> z34
kfm OR knt -> phm
x18 XOR y18 -> mvh
vnw XOR cnt -> z13
vbh XOR wqq -> z20
dcs XOR nnm -> z11
hds XOR bcj -> z25
wqq AND vbh -> kbg
bhw OR dwn -> rbj
sbs XOR fqs -> z09
wwp OR rdj -> bcj
x33 AND y33 -> rrn
y12 XOR x12 -> jrb
tnd AND hhk -> cns
jmm OR ckq -> dnn
cns OR dqc -> hnn
fjh AND kfr -> bbk
pgt XOR hgq -> gjh";
const string inputTest = @"x00: 1
x01: 0
x02: 1
x03: 1
x04: 0
y00: 1
y01: 1
y02: 1
y03: 1
y04: 1

ntg XOR fgs -> mjb
y02 OR x01 -> tnw
kwq OR kpj -> z05
x00 OR x03 -> fst
tgd XOR rvg -> z01
vdt OR tnw -> bfw
bfw AND frj -> z10
ffh OR nrd -> bqk
y00 AND y03 -> djm
y03 OR y00 -> psh
bqk OR frj -> z08
tnw OR fst -> frj
gnj AND tgd -> z11
bfw XOR mjb -> z00
x03 OR x00 -> vdt
gnj AND wpb -> z02
x04 AND y00 -> kjc
djm OR pbm -> qhw
nrd AND vdt -> hwm
kjc AND fst -> rvg
y04 OR y02 -> fgs
y01 AND x02 -> pbm
ntg OR kjc -> kwq
psh XOR fgs -> tgd
qhw XOR tgd -> z09
pbm OR djm -> kpj
x03 XOR y03 -> ffh
x00 XOR y04 -> ntg
bfw OR bqk -> z06
nrd XOR fgs -> wpb
frj XOR qhw -> z04
bqk OR frj -> z07
y03 OR x01 -> nrd
hwm AND bqk -> z03
tgd XOR rvg -> z12
tnw OR pbm -> gnj";
Regex initValues = new Regex(@"^(?<name>[a-z0-9]+): (?<value>\d+)$");
Regex operationRegex = new Regex(@"^(?<input1>[a-z0-9]+) (?<operation>AND|OR|XOR) (?<input2>[a-z0-9]+) -> (?<output>[a-z0-9]+)$");

void Part1(string input) {
    var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
    var values = new Dictionary<string, bool>();
    var operations = new Dictionary<string,(string input1, Operation operation, string input2)>();
    foreach (var line in lines) {
        var match = initValues.Match(line);
        if (match.Success) {
            values[match.Groups["name"].Value] = match.Groups["value"].Value == "1";
            continue;
        }
        match = operationRegex.Match(line);
        if (match.Success) {
            var input1 = match.Groups["input1"].Value;
            var input2 = match.Groups["input2"].Value;
            var output = match.Groups["output"].Value;
            var operation = match.Groups["operation"].Value switch {
                "AND" => Operation.AND,
                "OR" => Operation.OR,
                "XOR" => Operation.XOR,
                _ => throw new Exception("Invalid operation")
            };
            if(operations.ContainsKey(output)) {
                throw new Exception($"Output {output} already has an operation");
            }
            operations.Add(output,(input1, operation, input2));
        }
    }
    bool GetValue( string name) {
        if (values.ContainsKey(name)) {
            return values[name];
        }
        if (operations.ContainsKey(name)) {
            var (input1, operation, input2) = operations[name];
            bool value1 = GetValue(input1);
            bool value2 = GetValue(input2);
            return operation switch {
                Operation.AND => value1 && value2,
                Operation.OR => value1 || value2,
                Operation.XOR => value1 ^ value2,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
        throw new Exception($"Value {name} not found");
    }
    var zs = operations.Keys.Where(k => k.StartsWith("z")).ToArray();
    Array.Sort(zs);
    long val = 0;
    for (int i = 0; i < zs.Length; i++) {
        var z = zs[i];
        var value = GetValue(z);
        if (value) {
            val |= 1L << i;
        }
        Console.WriteLine($"{z}: {GetValue(z)}");
    }
    Console.WriteLine(val);
    
}


void Part2(string input) {
    var lines = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
    var swaps = new Dictionary<string, string>();
    swaps.Add( "ffj", "z08");
    swaps.Add("z08", "ffj");
    swaps.Add("dwp", "kfm");
    swaps.Add("kfm", "dwp");
    swaps.Add("gjh", "z22");
    swaps.Add("z22", "gjh");
    swaps.Add("z31","jdr");
    swaps.Add("jdr","z31");

    string GetWireName(string name) {
        return swaps.GetValueOrDefault(name, name);
    }

    var values = new Dictionary<string, bool>();
    var operations = new Dictionary<string,(string input1, Operation operation, string input2)>();
    foreach (var line in lines) {
        var match = initValues.Match(line);
        if (match.Success) {
            values[match.Groups["name"].Value] = match.Groups["value"].Value == "1";
            continue;
        }
        match = operationRegex.Match(line);
        if (match.Success) {
            var input1 = match.Groups["input1"].Value;
            var input2 = match.Groups["input2"].Value;
            var output = match.Groups["output"].Value;
            var operation = match.Groups["operation"].Value switch {
                "AND" => Operation.AND,
                "OR" => Operation.OR,
                "XOR" => Operation.XOR,
                _ => throw new Exception("Invalid operation")
            };
            output = GetWireName(output);
            if(operations.ContainsKey(output)) {
                throw new Exception($"Output {output} already has an operation");
            }
            operations.Add(output,(input1, operation, input2));
        }
    }
    
    bool GetValue( string name) {
        if (values.ContainsKey(name)) {
            return values[name];
        }
        if (operations.ContainsKey(name)) {
            var (input1, operation, input2) = operations[name];
            bool value1 = GetValue(input1);
            bool value2 = GetValue(input2);
            return operation switch {
                Operation.AND => value1 && value2,
                Operation.OR => value1 || value2,
                Operation.XOR => value1 ^ value2,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
        throw new Exception($"Value {name} not found");
    }
    
    var varToOps = new Dictionary<string, List<string>>();
    foreach (var (key, value) in operations) {
        if (!varToOps.ContainsKey(value.input1)) {
            varToOps[value.input1] = new List<string>();
        }
        varToOps[value.input1].Add(key);
        if (!varToOps.ContainsKey(value.input2)) {
            varToOps[value.input2] = new List<string>();
        }
        varToOps[value.input2].Add(key);
    }
    
    var xs = values.Keys.Where(k => k.StartsWith("x")).ToArray();
    Array.Sort(xs);
    var ys = values.Keys.Where(k => k.StartsWith("y")).ToArray();
    Array.Sort(ys);
    var zs = operations.Keys.Where(k => k.StartsWith("z")).ToArray();
    Array.Sort(zs);

    for(int i = 0;i<xs.Length;i++) {
        var tmp = varToOps[xs[i]];
        tmp.Sort();
        var tmp2 = varToOps[ys[i]];
        tmp2.Sort();
        if(tmp.Count != tmp2.Count) {
            throw new Exception("Not the same number of operations");
        }
        for(int j = 0;j<tmp.Count;j++) {
            if(tmp[j] != tmp2[j]) {
                throw new Exception("Not the same operations");
            }
        }
    }
    // rvh: complement out for 00 complement in for 01 : Cin
    // kgc: A xor B
    // z01: a xor b xor cin
    // vtk: (A xor B) and Cin
    // rcm: A and B
    // fbc : A and B or ((A xor B) and Cin)


    HashSet<string> GetOutputOf(string op) {
        var res = new HashSet<string>();
        var stack = new Stack<string>();
        stack.Push(op);
        while( stack.Count>0) {
            var current = stack.Pop();
            if( !varToOps.TryGetValue(current, out var varToOp)) {
                continue;
            }

            foreach (var op2 in varToOp) {
                res.Add(op2);
                stack.Push(op2);
            }
        }
        return res;
    }
    HashSet<string> GetInputOf(string op) {
        var res = new HashSet<string>();
        //res.Add(op);
        var stack = new Stack<string>();
        stack.Push(op);
        while (stack.Count > 0) {
            var current = stack.Pop();
            if (!operations.TryGetValue(current, out var operation)) {
                continue;
            }

            var (input1, _, input2) = operation;
            res.Add(input1);
            stack.Push(input1);
            res.Add(input2);
            stack.Push(input2);
        }

        return res;
    }
    
    bool TryGetOp(List<string> ops, string input1, string input2, Operation operation, out string op) {
        foreach (var op2 in ops) {
            var (input1_2, operation2, input2_2) = operations[op2];
            if( operation != operation2) {
                continue;
            }
            if ((input1 == input1_2 && input2 == input2_2) || (input1 == input2_2 && input2 == input1_2)) {
                op = op2;
                return true;
            }
        }
        op = null;
        return false;
    }

    string? ValidAdder(List<string> ops, int adder, string complementIn, out string complementOut) {
        complementOut = null;
        if( !TryGetOp( ops, xs[adder], ys[adder], Operation.XOR, out var axorb)) {
            return "no axorb";
        }
        if( !TryGetOp( ops, xs[adder], ys[adder], Operation.AND, out var aandb)) {
            return "no aandb";
        }
        if( !TryGetOp( ops, axorb, complementIn, Operation.XOR, out var s) || s != zs[adder]) {
            return "no s";
        }
        if( !TryGetOp( ops, axorb, complementIn, Operation.AND, out var cinAndAxorB)) {
            return "no cinAndAxorB";
        }
        if( !TryGetOp( ops, aandb, cinAndAxorB, Operation.OR, out complementOut)) {
            return "no complementOut";
        }

        return null;
    }
    
    string OpToString(string op) {
        var (input1, operation, input2) = operations[op];
        return $"{input1} {operation} {input2} -> {op}";
    }

    string complementIn = "rvh";//ffj and z08
    for (int i = 1; i < xs.Length; i++) {
        Console.WriteLine($"For {xs[i]} and {ys[i]}");
        var outputs = GetOutputOf(xs[i]);
        var inputs = GetInputOf(zs[i+1]);
        foreach (var commonop in outputs.Intersect(inputs)) {
            Console.WriteLine(OpToString(commonop));
        }
        Console.WriteLine(OpToString(zs[i]));
        var reason = ValidAdder(outputs.ToList(), i, complementIn, out var complementOut);
        if(reason == null) {
            Console.WriteLine($"Valid adder for {i}");
            complementIn = complementOut;
        }
        else {
            Console.WriteLine($"Invalid adder for {i}: {reason}");
            //throw new Exception();
        }
    }
    Console.WriteLine(string.Join(",",swaps.Keys.Order()));
    
}


Part2(inputReal);

enum Operation {
    AND,
    OR,
    XOR
}