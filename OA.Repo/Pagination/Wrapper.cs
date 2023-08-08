using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repo
{
    public class Wrapper <T>
    {
        public Object Data { get; set; }
        public bool Succeeded { get; set; }
        public string[] Errors { get; set; }
        public string Message { get; set; }

        public Wrapper()
        {
        }

        public Wrapper(Object data)
        {
            Succeeded = true;
            Message = string.Empty;
            Errors = null;
            Data = data;
        }        
    }
}
