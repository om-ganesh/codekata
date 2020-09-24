using System;

namespace JonahRuleEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool exitFlag = false;
            while(!exitFlag)
            {
                ConsoleHelper.Print(">>> ");
                var input = Console.ReadLine().Split();
                int ruleNo = -1;

                switch (input[0].ToUpper())
                {
                    case "ADDRULE":
                        ruleNo = Convert.ToInt32(input[2]);
                        RuleEngine.CreateRule(ruleNo, RuleFactory.CreateRule(input[1], ruleNo, input[3]));
                        break;
                    case "REMOVERULE":
                        ruleNo = Convert.ToInt32(input[1]);
                        var result = RuleEngine.RemoveRule(ruleNo);
                        break;
                    case "PRINTRULES":
                        ConsoleHelper.PrintArray(RuleEngine.PrintRules());
                        break;
                    case "PRINT":
                        int number = Convert.ToInt32(input[1]);
                        ConsoleHelper.Println(RuleEngine.OperateRule(number));
                        break;
                    case "PRINTRANGE":
                        int start = Convert.ToInt32(input[1]);
                        int end = Convert.ToInt32(input[2]);
                        ConsoleHelper.PrintArray(RuleEngine.OperateRuleRange(start, end));
                        break;
                    case "EXIT":
                        ConsoleHelper.Println(Constants.EXIT);
                        exitFlag = true;
                        break;
                    default:
                        ConsoleHelper.Println(Constants.BAD_REQUEST);
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
