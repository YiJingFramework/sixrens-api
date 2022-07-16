using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixRens.Api
{
    [Serializable]
    public class 起课失败异常 : Exception
    {
        public 起课失败异常() { }
        public 起课失败异常(string message) : base(message) { }
        public 起课失败异常(string message, Exception inner) : base(message, inner) { }
        protected 起课失败异常(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
