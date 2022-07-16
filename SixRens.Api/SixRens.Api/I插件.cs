using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixRens.Api
{
    public interface I插件
    {
        string? 插件名 { get; }
        Guid 插件识别码 { get; }
    }
}
