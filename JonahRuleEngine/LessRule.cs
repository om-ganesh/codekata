using System;
using System.Collections.Generic;
using System.Text;

namespace JonahRuleEngine
{
    class LessRule : IRule
    {
        private int ruleNumber;
        private string ruleMessage;

        public LessRule(int ruleNo, string message)
        {
            ruleNumber = ruleNo;
            ruleMessage = message;
        }
        public string Operate(int value)
        {
            if (value < ruleNumber)
            {
                return ruleMessage;
            } else
            {
                return value.ToString();
            }

        }

        public string GetRuleName()
        {
            return "LESS";
        }
    }
}
