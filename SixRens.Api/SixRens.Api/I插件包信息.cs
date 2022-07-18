using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixRens.Api
{
    public interface I插件包信息
    {
        string 名称 { get; }
        string 版本号 { get; }
        string? 网址 { get; }
        string 主程序集 { get; }
        IEnumerable<Type> 插件类 { get; }
    }
}
