using Application.Data;
using System.Collections.Generic;

namespace Application.Service.Services
{
    [System.Serializable]
        public class ReturnValue
        {
            public int Id { get; set; }
            public int? Result { get; set; }
            public string RequestType { get; set; }
            public string RequestTime { get; set; }
            public virtual List<IP> iPs { get; set; }
            public virtual List<File> Files { get; set; }

        }
    
}