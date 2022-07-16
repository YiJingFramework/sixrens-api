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

    /*
     * 插件类型和顺序：
     * 1 地盘
     * 2 天盘
     * 3 四课
     * 4 三传
     * 5 天将
     * 6 年命
     * 7 神煞
     * 8 课体
     */
}
