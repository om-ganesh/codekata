using System;
using System.Collections.Generic;
using System.Text;

namespace JonahRuleEngine
{
    public static class RuleFactory
    {
        public static IRule CreateRule(string ruleType, int ruleNo, string message)
        {
            switch(ruleType.ToUpper())
            {
                case "LESS":
                    return new LessRule(ruleNo, message);
                case "MORE":
                    return new MoreRule(ruleNo, message);
            }
            return null;
        }
    }
}
