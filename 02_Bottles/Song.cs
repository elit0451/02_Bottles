using System;

namespace _02_Bottles
{
    internal class Song
    {
        internal string CountBottles(int v)
        {
            string CompleteSong = " ";
            string Bottle = "bottles";
            bool V1 = true;
            for (int i = v; i >= 0; i--)
            {
                if (i == 0)
                {
                    CompleteSong = CompleteSong + "No more bottles of beer on the wall.";
                }
                else
                {
                    if (i == 1)
                    {
                        Bottle = "bottle";
                    }
                    if (V1 == true)
                    {
                        CompleteSong =
                        i + " "+Bottle+" of beer on the wall. "
                    + i + " " + Bottle + " of beer."
                    + " Take one down and pass it around. ";
                        V1 = false;
                    }
                    else
                    {
                        CompleteSong = CompleteSong + i + " " + Bottle + " of beer on the wall. "
                    + i + " " + Bottle + " of beer on the wall. "
                    + i + " " + Bottle + " of beer."
                    + " Take one down and pass it around. ";
                    }
                }
            }
            return CompleteSong;
        }
    }
}