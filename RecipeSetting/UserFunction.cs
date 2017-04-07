using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace RecipeSetting
{
    public class UserFunction
    {
        public string VEEName { get { return _veeName; } }
        public string UserFunctionName { get { return _userFunctionName; } }

        private string[] _inputNames;
        private string[] _outputNames;
        private Hashtable _htVariables;
        string _veeName;
        string _userFunctionName;

        public UserFunction(string veeFileName, string userFuncName)
        {
            //Get All Input names
            _inputNames = null;

            // Get All Output names
            _outputNames = null;

            // Store All Variables into Hashtable
            _htVariables = new Hashtable();
            foreach (string name in _inputNames) { _htVariables.Add(name, ""); }
            foreach (string name in _outputNames) { _htVariables.Add(name, ""); }
        }

        public void SetValue(string InputName, string Value)
        {
            if (!_htVariables.Contains(InputName)) throw new Exception(string.Format("InputName: {0} Not Found!", InputName));
            _htVariables[InputName] = Value;
        }

        public string[] CallUserFunction()
        {
            // Calls User Function
            return null;
        }
    }
}
