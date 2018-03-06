using System;

namespace _16._Instruction_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            string opCode = Console.ReadLine();
            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');
                long result = 0;
                long operandOne = 0;
                long operandTwo = 0;

                 result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            operandOne = int.Parse(codeArgs[1]);
                            result = ++operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            operandOne = int.Parse(codeArgs[1]);
                            result = --operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            operandOne = int.Parse(codeArgs[1]);
                            operandTwo = int.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            operandOne = int.Parse(codeArgs[1]);
                            operandTwo = int.Parse(codeArgs[2]);
                            result = (operandOne * operandTwo);
                            break;
                        }
                }
                Console.WriteLine(result);
                opCode = Console.ReadLine();
            }
        }
    }
}
