using SixRens.Api.实体;
using SixRens.Api.实体.壬式;

namespace SixRens.Api
{
    public interface I四课插件 : I插件
    {
        I四课 获取四课(
            Guid 壬式识别码,
            I年月日时 年月日时,
            I地盘 地盘,
            I天盘 天盘);
    }
}
