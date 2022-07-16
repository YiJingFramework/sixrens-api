using SixRens.Api.实体;
using SixRens.Api.实体.壬式;
using YiJingFramework.Core;
using YiJingFramework.StemsAndBranches;

namespace SixRens.Api
{
    public interface I年命插件 : I插件
    {
        I年命 获取年命(
            I年月日时 年月日时,
            地支盘 基础盘,
            地支盘 地盘,
            地支盘 天盘,
            I四课 四课,
            I三传 三传,
            I天将盘 天将盘,
            YinYang 性别,
            EarthlyBranch 本命);
    }
}
