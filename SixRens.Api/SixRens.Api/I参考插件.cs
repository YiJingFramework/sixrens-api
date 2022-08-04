﻿using SixRens.Api.实体;
using SixRens.Api.实体.壬式;

namespace SixRens.Api
{
    public interface I参考插件 : I插件
    {
        IEnumerable<I占断参考题目> 支持的占断参考 { get; }
        I占断参考内容 生成占断参考(
            I起课信息 起课信息,
            I天地盘 天盘,
            I四课 四课,
            I三传 三传,
            I天将盘 天将盘,
            IReadOnlyList<I神煞> 神煞列表,
            IReadOnlyList<I课体> 课体列表,
            string 占断参考题目);
    }
}
