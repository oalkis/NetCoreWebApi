using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DinamikCRM.Repository
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

        public int Count
        {
            get
            {
                return _listCount;
            }
            set
            {
                if (_list != null)
                {
                    _listCount = _list.Count;
                }
                else
                {
                    _listCount = 0;
                }
                //_list != null ? _listCount = _list.Count : _listCount = value;
            }
        }

        public bool IsValid => !HasExceptionError && string.IsNullOrEmpty(ExceptionMessage);

        public bool IsSuccessful { get; set; }

        public ServiceResponse()
        {
            List = new List<T>();
        }
    }
}
