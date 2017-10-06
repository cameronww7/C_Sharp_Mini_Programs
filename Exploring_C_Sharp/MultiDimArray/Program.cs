using System;

namespace MultiDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multi Dim Array!");

            string[,] sections = new string[3, 3];

            sections[0, 0] = "top left";
            sections[0, 1] = "top center";
            sections[0, 2] = "top right";

            sections[1, 0] = "middle left";
            sections[1, 1] = "middle center";
            sections[1, 2] = "middle right";

            sections[2, 0] = "bottom left";
            sections[2, 1] = "bottom center";
            sections[2, 2] = "bottom right";

            for (int rows = 0; rows < 3; rows++)
            {
                for (int cols = 0; cols < 3; cols++)
                {
                    Console.Write(sections[rows,cols] + "\t");
                    if ((cols+1) % 3 == 0) {
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
