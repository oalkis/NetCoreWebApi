using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DinamikCRM.Repository.Service
{
    [Serializable]
    public class ServiceResponse<T>
    {
        private IList<T> _list;
        private int _listCount;
        public bool HasExceptionError { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ExceptionMessage { get; set; }

        public IList<T> List
        {
            get
            {
                return _list;
            }
            set
            { _list = value; }

        }

        [JsonProperty]
        public T Entity { get; set; }

        public int Count => List.Count;
        
        

        public bool IsValid => !HasExceptionError && string.IsNullOrEmpty(ExceptionMessage);

        public bool IsSuccessful { get; set; }

        public ServiceResponse()
        {
            List = new List<T>();
        }
    }
}
