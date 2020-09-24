using System;
using System.Collections.Generic;
using System.Text;

namespace JonahRuleEngine
{
    public static class RuleEngine
    {
        public static Dictionary<string, int> ValidCommands => new Dictionary<string, int>
        {
            {"ADDRULE", 4 },
            {"REMOVERULE", 2 },
            {"EXIT", 1 },
            {"PRINT", 2 },
            {"PRINTRANGE", 3 }
        };

        public static SortedDictionary<int, IRule> Rules;

        static RuleEngine()
        {
            Rules = new SortedDictionary<int, IRule>();
        }

        public static DataResult CreateRule(int ruleNo, IRule rule)
        {
            if(Rules.ContainsKey(ruleNo))
            {
                Rules[ruleNo] = rule;
            } else
            {
                Rules.Add(ruleNo, rule);
            }
            return new DataResult(true, Constants.RULE_ADD_SUCCESS);
        }

        public static DataResult RemoveRule(int ruleNo)
        {
            if (Rules.Remove(ruleNo))
            {
                return new DataResult(true, Constants.SUCCESS);
            } else
            {
                return new DataResult(false, Constants.RULE_NOT_EXISTS);
            }
        }

        internal static string OperateRule(int number)
        {
            StringBuilder result = new StringBuilder();
            foreach(KeyValuePair<int, IRule> keyValuePair in Rules)
            {
                IRule rule = keyValuePair.Value;
                result.Append(rule.Operate(number));
            }
            return result.ToString();
        }

        internal static IEnumerable<string> OperateRuleRange(int start, int end)
        {
            while(start<=end)
            {
                yield return OperateRule(start++);
            }
        }

        public static IEnumerable<string> PrintRules()
        {
            foreach(KeyValuePair<int, IRule> keyValuePair in Rules)
            {
                IRule rule = keyValuePair.Value;
                yield return rule.GetRuleName();
            }
        }
    }
}
