string[,] Pairs = new string[,] { { "A", "P" }, { "B", "Q" }, { "C","R"}, { "D","S"}, { "E","T"}, { "F","U"}, { "G","V"} };
int count = 0;

Console.WriteLine("Results");

for (int x = 0; x < Pairs.GetLength(0); x++)
{
    string[] Pair1 = new string[] { Pairs[x,0], Pairs[x, 1] };

    for (int y = 0; y < Pairs.GetLength(0); y++)
    {
        string[] Pair2 = new string[] { Pairs[y, 0], Pairs[y, 1] };
        count = count + 2;
        if (Pair2[0] != Pair1[0] && Pair2[1] != Pair1[1])
        {

            for (int z = 0; z < Pairs.GetLength(0); z++)
            {
                count = count + 2;
                string[] Pair3 = new string[] { Pairs[z, 0], Pairs[z, 1] };
                if (Pair3[0] != Pair1[0] && Pair3[1] != Pair1[1])
                {
                    count = count + 2;
                    if (Pair3[0] != Pair2[0] && Pair3[1] != Pair2[1])
                    {
                        bool found = false;
                        count = count + 6;
                        if (matchingpair(Pair1[0], Pair2[1]) && matchingpair(Pair2[0], Pair3[1]) && matchingpair(Pair3[0], Pair1[1]))
                        {
                            found = true;
                        }
                        else if(matchingpair(Pair1[0],Pair3[1]) && matchingpair(Pair2[0],Pair1[1]) && matchingpair(Pair3[0],Pair2[1]))
                        { 
                            found=true;
                        }

                        if (found)
                        {
                            count = count + 1;
                            Console.WriteLine("{0},{1} / {2},{3} / {4},{5}", Pair1[0], Pair1[1], Pair2[0], Pair2[1], Pair3[0], Pair3[1]);
                        }
                    }
                }
            }
        }
    }
}

static bool matchingpair(string ReciverpairB,string DonorpairA)
{
    string comparing = ReciverpairB+DonorpairA;
    bool match = false;
    string[] Matches = new string[] { "AR", "AT", "CQ", "CT", "DV", "ER", "EV", "GP", "GS" };
    foreach (string s in Matches)
    { 
        if(s == comparing)
            match = true;
    }

    return match;
}


Console.WriteLine("count of instructions preformed: " +count);