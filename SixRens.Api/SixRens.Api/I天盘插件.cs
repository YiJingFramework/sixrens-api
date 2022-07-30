using SixRens.Api.实体;
using SixRens.Api.实体.壬式;

namespace SixRens.Api
{
    public interface I天盘插件 : I插件
    {
        I天盘 获取天盘(
            Guid 壬式识别码,
            I年月日时 年月日时,
            I地盘 地盘);
    }
}