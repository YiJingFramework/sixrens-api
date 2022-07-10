using SixRens.Api.实体;
using SixRens.Api.实体.壬式;

namespace SixRens.Api
{
    public interface I三传插件
    {
        I三传 获取三传(
            I年月日时 年月日时, I地支盘 地盘,
            I地支盘 天盘);
    }
}