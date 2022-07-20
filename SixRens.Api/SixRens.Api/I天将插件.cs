using SixRens.Api.实体;
using SixRens.Api.实体.壬式;

namespace SixRens.Api
{
    public interface I天将插件 : I插件
    {
        I天将盘 获取天将盘(
            I年月日时 年月日时,
            I地盘 地盘,
            I天盘 天盘,
            I四课 四课,
            I三传 三传);
    }
}
