using System.Collections.Generic;
using System.Linq;

namespace MissionG3_TwitterWeb_API.logic.Common
{
    public class OperationResult<T> where T : class
    {
        public OperationResult() { }

        public OperationResult(bool success)
        {
            this.Success = success;
        }

        public OperationResult(bool success, string errorMessage)
        {
            this.Success = success;
            this.ErrorMessage = errorMessage;
        }
        
        public OperationResult(bool success, string errorMessage, T model)
        {
            this.Model = model;
            this.Success = success;
            this.ErrorMessage = errorMessage;
        }

        public OperationResult(bool success, string errorMessage, IEnumerable<T> stateList)
        {
            this.StateList = stateList;
            this.Success = success;
            this.ErrorMessage = errorMessage;
        }

        public bool Success { get; private set; }
        public string ErrorMessage { get; private set; }
        public T Model { get; private set; }
        public IEnumerable<T> StateList { get; private set; }
    }
}