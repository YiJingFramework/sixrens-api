using SixRens.Api.实体;
using SixRens.Api.实体.壬式;

namespace SixRens.Api
{
    public interface I三传插件
    {
        I三传 获取三传(地支盘 基础盘,
            I年月日时 年月日时,
            地支盘 地盘,
            地支盘 天盘,
            I四课 四课);
    }
}