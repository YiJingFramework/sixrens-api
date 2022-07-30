using SixRens.Api.实体;
using SixRens.Api.实体.壬式;

namespace SixRens.Api
{
    public interface I地盘插件 : I插件
    {
        I地盘 获取地盘(
            Guid 壬式识别码,
            I年月日时 年月日时);
    }
}