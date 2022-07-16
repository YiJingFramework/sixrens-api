using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.Core;
using YiJingFramework.StemsAndBranches;

namespace SixRens.Api.实体
{
    public interface I年命
    {
        YinYang 性别 { get; }
        EarthlyBranch 本命 { get; }
        EarthlyBranch 行年 { get; }
    }
}
