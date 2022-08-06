using YiJingFramework.StemsAndBranches;

namespace SixRens.Api.实体.壬式
{
    public interface I去冗天将盘
    {
        bool 为顺行 { get; }
        EarthlyBranch 贵人天盘所乘 { get; }
    }
    public interface I天将盘 : I去冗天将盘
    {
        天将 取乘将(EarthlyBranch 天盘支);
        EarthlyBranch 取乘神(天将 天将);
        EarthlyBranch 取临地(天将 天将);
    }
}
