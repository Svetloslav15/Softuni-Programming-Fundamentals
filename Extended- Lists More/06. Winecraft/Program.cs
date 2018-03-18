namespace _06.Winecraft
{
    using System;
    using System.Linq;

    public class Winecraft
    {
        public static void Main()
        {
            var grapes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => Convert.ToInt16(x)).ToArray();

            var rounds = Convert.ToInt16(Console.ReadLine());

            var grapesCounter = grapes.Length;


            //---spin for each season until the grapes are less than rounds---
            while (grapesCounter >= rounds)
            {
                //---count the rounds---
                for (int counter = 0; counter < rounds; counter++)
                {
                    // -1 => lesser, 0 => normal, 1 => greater
                    var grapesKind = new int[grapes.Length];
                    grapesCounter = grapes.Length;
                    for (int index = 0; index < grapes.Length; index++)
                    {
                        if (grapes[index] <= rounds)
                        {
                            grapes[index] = 0;
                            grapesCounter--;
                        }
                    }
                    for (int index = 1; index < grapes.Length - 1; index++)
                    {
                        if (grapes[index] > grapes[index - 1] && grapes[index] > grapes[index + 1])
                        {
                            grapesKind[index] = 1;
                            grapesKind[index - 1] = -1;
                            grapesKind[index + 1] = -1;
                            index++;
                        }
                    }
                    //---calculate the grapes---
                    for (int index = 0; index < grapes.Length; index++)
                    {
                        if (grapesKind[index] == 0 && grapes[index] > 0)
                        {
                            grapes[index]++;
                        }
                        else if (grapesKind[index] == 1)
                        {
                            grapes[index]++;
                            if (grapes[index - 1] > 0)
                            {
                                grapes[index]++;
                                grapes[index - 1]--;
                            }
                            if (grapes[index + 1] > 0)
                            {
                                grapes[index]++;
                                grapes[index + 1]--;
                            }
                            index++;
                        }
                    }
               
                }
            }
            Console.WriteLine(string.Join(" ", grapes.Where(x => x > rounds)));
            //88/100
        }
    }
}