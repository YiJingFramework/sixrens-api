using SixRens.Api.实体.壬式;
using SixRens.Api.实体.起课信息;

namespace SixRens.Api
{
    public interface I天将插件 : I插件
    {
        I去冗天将盘 获取天将盘(
            I起课信息 起课信息,
            I天地盘 天地盘,
            I四课 四课,
            I三传 三传);
    }
}
