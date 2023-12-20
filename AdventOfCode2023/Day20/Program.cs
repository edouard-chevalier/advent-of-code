// See https://aka.ms/new-console-template for more information


using Template;

Console.WriteLine("Hello, World!");

const string inputReal = @"%jx -> rt, rs
&cc -> cd, fc, qr, nl, gk, zr
%qs -> cl, rs
%zr -> cq
%mx -> nr, pm
%mj -> qr, cc
%cj -> cc, nt
%jv -> sp
%dj -> bd, zc
%kt -> lt
broadcaster -> gz, xg, cd, sg
&dn -> rx
%br -> nf, bd
%cd -> cc, nl
%zc -> jq, bd
%xg -> cf, pm
%nz -> gm, bd
&dd -> dn
%nb -> sl
&pm -> kt, xg, xp, jv, sp
&fh -> dn
%rt -> qq
%qq -> rs, hd
%hd -> qs, rs
&xp -> dn
%pj -> cc, mj
%gz -> bd, kb
%zd -> jv, pm
%cq -> cj, cc
%qr -> gk
%ng -> jk, bd
%kb -> bd, sv
%cl -> zx, rs
%gj -> zd, pm
%sl -> kx
%sv -> br
%nf -> bd, nz
%zx -> rs
%nt -> mn, cc
%rh -> nb, rs
%gk -> ln
&bd -> gm, gz, fh, sv
%jq -> ng, bd
%sp -> pc
%sg -> rs, rh
%kx -> jx
&fc -> dn
%cf -> gj, pm
%pc -> kt, pm
%jk -> bd
%vf -> pm
&rs -> sg, dd, sl, kx, nb, rt
%nr -> vf, pm
%ln -> zr, cc
%lt -> pm, mx
%gm -> dj
%nl -> pj
%mn -> cc";
const string inputTest = @"broadcaster -> a
%a -> inv, con
&inv -> b
%b -> con
&con -> output";

void Part1(string input)
{
    var lines = input.Split(Environment.NewLine);
    var modules = Module.Parse(lines).ToDictionary(m => m.Name);
    var queue = new Queue<Pulse>();
    long nbHigh = 0;
    long nbLow = 0;
    for (int i = 0; i < 1000; i++)
    {

        queue.Enqueue(new Pulse { To = "broadcaster", From = "button", M = false });

        while (queue.Count > 0)
        {

            var pulse = queue.Dequeue();
            //Console.WriteLine(pulse);
            if (pulse.M)
            {
                nbHigh++;
            }
            else
            {
                nbLow++;
            }

            if (!modules.ContainsKey(pulse.To))
            {
                continue;
            }
            var module = modules[pulse.To];
            var outputs = module.Process(pulse);
            foreach (var output in outputs)
            {
                queue.Enqueue(output);
            }
        }
        Console.WriteLine();
    }

    Console.WriteLine(nbHigh * nbLow);
}


void Part2(string input)
{
    var lines = input.Split(Environment.NewLine);
    var allModules = Module.Parse(lines).ToDictionary(m => m.Name);
    var queue = new Queue<Pulse>();
//    string[] lastState = null; 
    /*Console.WriteLine(string.Join("\n", modules.Values));
    foreach (var o in modules["broadcaster"].OutPuts)
    {
        var dictionary = Module.Sub(modules,o);

        Console.WriteLine($"**** {o} {dictionary.Count} *****");
        Console.WriteLine(string.Join("\n", dictionary.Values));
    }*/
    var res = new List<long>();
    foreach (var o in allModules["broadcaster"].OutPuts)
    {
        foreach (var m in allModules.Values)
        {
            m.Reset();
        }
        var modules = Module.Sub(allModules, o);

        Console.WriteLine($"**** {o} {modules.Count} *****");
        Console.WriteLine(string.Join("\n", modules.Values));
        for (int i = 0; i < 10000; i++)
        {
            bool success = false;
            queue.Clear();
            queue.Enqueue(new Pulse { To = o, From = "button", M = false });

            while (queue.Count > 0)
            {
                var pulse = queue.Dequeue();

                if (pulse.To == "rx" && !pulse.M)
                {
                    success = true;
                    break;
                }

                if (!modules.ContainsKey(pulse.To))
                {
                    continue;
                }

                var module = modules[pulse.To];
                var outputs = module.Process(pulse);
                foreach (var output in outputs)
                {
                    queue.Enqueue(output);
                }
            }

            /*if (i % 10000 == 0)
            {
                Console.WriteLine("progress " + i);
            }*/

            if (success)
            {
                Console.WriteLine(i + 1);
                res.Add(i+1);
                break;
            }

            /*Console.WriteLine(string.Join("", ((Conjunction)modules["cc"]).states.Select(b => b ? "1" : "0")));
            if (((Conjunction)modules["cc"]).states.All(s => s))
            {
                Console.WriteLine("cc");
                Console.WriteLine(i + 1);
                break;
            }*/
        }
    }

    Console.WriteLine(Arithmetic.lcm(res.ToArray()));
}


//Part1(inputReal);
Part2(inputReal);

public abstract class Module
{

    public static IReadOnlyList<Module> Parse(IReadOnlyList<string> lines)
    {
        var res = lines.Select(Parse).ToArray();
        foreach (var module in res)
        {
            var list = new List<string>();
            foreach (var other in res)
            {
                if (other.OutPuts.Contains(module.Name))
                {
                    list.Add(other.Name);
                }
            }

            if (module.Name == "cc")
            {
                list = new() { "cd", "pj", "mj", "ln", "cq", "cj", "nt", "mn" };
            }
           

            foreach (var l in list)
            {
                module.AddInput(l);
            }
        }
        return res;
    }
    public static Module Parse(string line)
    {
        var parts = line .Split(" -> ");
        Module module = parts[0][0] switch
        {
            'b' => new Broadcast { Name = "broadcaster" },
            '&' => new Conjunction { Name = parts[0].Substring(1) },
            '%' => new FlipFlop() { Name = parts[0].Substring(1) },
            _ => throw new ArgumentException()
        };
        foreach (var input in parts[1].Split(","))
        {
            
            module.AddOutput(input.Trim());
        }

        return module;
    }

    public static Dictionary<string, Module> Sub(Dictionary<string, Module> modules, string from)
    {
        
        var visited = new HashSet<string>();
        var stack = new Stack<string>();
        stack.Push(from);
        while (stack.TryPop(out var c))
        {
            if (!modules.ContainsKey(c) || !visited.Add(c) )
            {
                continue;
            }
            foreach (var output in modules[c].OutPuts)
            {
                stack.Push(output);
            }
        }
        var res = new Dictionary<string, Module>();
        foreach (var v in visited)
        {
            if (v == "dn")
            {
                var input = from switch
                {
                    "cd" => "fc",
                    "sg" => "dd",
                    "xg" => "xp",
                    "gz" => "fh",
                    _ => throw new ArgumentException()
                };
                var conjunction = new Conjunction { Name = "dn", OutPuts = modules[v].OutPuts};
                conjunction.AddInput(input);
                res[v] = conjunction;
            }

            else {
                res[v] = modules[v];
            }
        }

        return res;
    }
    public string Name { get; set; }
    public List<string> OutPuts { get; set; } = new ();

    public void AddOutput(string o)
    {
        OutPuts.Add(o);
    }
    public abstract IReadOnlyList<Pulse> Process(Pulse input);

    public IReadOnlyList<Pulse> ToEachOutput(bool m)
    {
        return OutPuts.Select(o => new Pulse { From = Name, To = o, M = m }).ToArray();
    }

    public abstract string State();
    public Dictionary<string, int> stateNames = new();
    public List<bool> states = new();
    public abstract void Reset();
    public void AddInput(string name)
    {
        stateNames[name] = states.Count;
        states.Add(false);
    }
}
public class FlipFlop : Module
{
    private bool state = false;

    public override IReadOnlyList<Pulse> Process(Pulse input)
    {
        if( !input.M)
        {
            state = !state;
            return ToEachOutput(state);
        }

        return Array.Empty<Pulse>();
    }
    public override string State()
    {
        return Name + " " + (state? "1":"0");
    }
    
    public override string ToString()
    {
        return Name + " flip " + string.Join(",", stateNames.Keys) + " -> " + string.Join(",", OutPuts);
    }

    public override void Reset()
    {
        state = false;
    }

}
public class Broadcast : Module
{

    public override IReadOnlyList<Pulse> Process(Pulse input)
    {
        return ToEachOutput(input.M);
    }

    public override string State()
    {
        return Name;
    }

    public override void Reset()
    {
        
    }


    public override string ToString()
    {
        return Name;
    }
}

public class Conjunction : Module {
   
    public override IReadOnlyList<Pulse> Process(Pulse input)
    {
        states[stateNames[input.From]] = input.M;
        if (states.All(s => s)) {
            return ToEachOutput(false);
        }
        return ToEachOutput(true);
    }
    
    public override string State()
    {
        return Name + " " + string.Join(",", states.Select(b=>b?"1":"0"));
    }

    public override void Reset()
    {
        for (int i = 0; i < states.Count; i++)
        {
            states[i] = false;
        }
    }

    public override string ToString()
    {
        return Name + " conjoins " + string.Join(",", stateNames.Keys) + " -> " + string.Join(",", OutPuts);
    }
}

public class Pulse
{
    public string From { get; set; }
    public string To { get; set; }
    public bool M { get; set; }

    public override string ToString()
    {
        var dir = M ? "high" : "low";
        return $"{From} -{dir}-> {To}";
    }
}