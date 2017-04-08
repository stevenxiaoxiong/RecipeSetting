using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace RecipeSetting
{
    // User Function is the smallest element in the Project
    // When Loading a userfunction, all input output names are automatically resolved
    // User need to Set each input manually, then call user function
    // All inputs and outputs [name, value] are saved in a public hashtable: Variables.
    public class UserFunction
    {
        public string VEEName { get { return _veeName; } }
        public string UserFunctionName { get { return _userFunctionName; } }
        public Hashtable Variables { get { return _htVariables; } }
        public int Index { get { return _index; } }

        private string[] _inputNames;
        private string[] _outputNames;
        private Hashtable _htVariables;
        private string _veeName;
        private string _userFunctionName;
        private int _index;

        public UserFunction(string theVeeFileName, string theUserFuncName, int theIndex)
        {
            _veeName = theVeeFileName;
            _userFunctionName = theUserFuncName;
            _index = theIndex;

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

        public void CallUserFunction()
        {
            // Calls User Function, and output Values are Saved into Hashtable
            string[] outputs = null;
            for (int i = 0; i < _outputNames.Length; i++)
            {
                _htVariables[_outputNames[i]] = outputs[i];
            }
        }
    }
}
