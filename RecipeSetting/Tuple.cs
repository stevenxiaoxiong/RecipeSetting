using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace RecipeSetting
{
    class Tuple
    {
        private List<UserFunction> _userFunctionList;
        private Hashtable _htTablePicks;
        
        public Tuple(string VEEFileName, List<string> FuncNameList)
        {
            _userFunctionList = new List<UserFunction>();
            for (int i = 0; i < FuncNameList.Count; i++ )
                _userFunctionList.Add(new UserFunction(VEEFileName, FuncNameList[i], i));
        }

        public void SetFunctionInput(int index, string InputName, string Value)
        {
            _userFunctionList[index].SetValue(InputName, Value);
        }


    }
}
