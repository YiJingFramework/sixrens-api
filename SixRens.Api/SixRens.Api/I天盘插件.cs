using SixRens.Api.实体;
using SixRens.Api.实体.壬式;

namespace SixRens.Api
{
    public interface I天盘插件
    {
        地支盘 获取天盘(地支盘 基础盘,
            I年月日时 年月日时,
            地支盘 地盘);
    }
}