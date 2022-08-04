using SixRens.Api.实体.壬式;
using SixRens.Api.实体.起课信息;

namespace SixRens.Api
{
    public interface I三传插件 : I插件
    {
        I三传 获取三传(
            I起课信息 起课信息,
            I天地盘 天地盘,
            I四课 四课);
    }
}