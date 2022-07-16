using SixRens.Api.实体;
using SixRens.Api.实体.壬式;

namespace SixRens.Api
{
    public interface I地盘插件 : I插件
    {
        地支盘 获取地盘(地支盘 基础盘,
            I年月日时 年月日时);
    }
}