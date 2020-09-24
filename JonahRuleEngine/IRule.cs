using System;
using System.Collections.Generic;
using System.Text;

namespace JonahRuleEngine
{
    public interface IRule
    {
        //key LESS
        //value n
        string Operate(int value);

        string GetRuleName();
    }
}
