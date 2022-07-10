using SixRens.Api.实体;
using SixRens.Api.实体.壬式;

namespace SixRens.Api
{
    public interface I天盘插件
    {
        I地支盘 获取天盘(
            I年月日时 年月日时, I地支盘 地盘);
    }
}