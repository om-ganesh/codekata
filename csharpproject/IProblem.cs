using System;
using System.Collections.Generic;
using System.Text;

namespace csharpproject
{
    interface IProblem
    {
        void ReadInput(); 
        
        void Execute();
        

        void ShowResult();
    }
}
