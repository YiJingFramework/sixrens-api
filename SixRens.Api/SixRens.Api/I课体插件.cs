﻿using SixRens.Api.实体;
using SixRens.Api.实体.壬式;

namespace SixRens.Api
{
    public interface I课体插件 : I插件
    {
        IEnumerable<I课体> 识别课体(
            I年月日时 年月日时,
            地支盘 基础盘,
            地支盘 地盘,
            地支盘 天盘,
            I四课 四课,
            I三传 三传,
            I天将盘 天将盘,
            I年命? 课主年命,
            IReadOnlyList<I年命> 对象年命,
            IReadOnlyList<I神煞> 神煞列表);
    }
}
