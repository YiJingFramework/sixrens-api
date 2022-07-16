using SixRens.Api.实体;
using SixRens.Api.实体.壬式;

namespace SixRens.Api
{
    public interface I四课插件 : I插件
    {
        I四课 获取四课(
            I年月日时 年月日时,
            地支盘 基础盘,
            地支盘 地盘,
            地支盘 天盘);
    }
}
