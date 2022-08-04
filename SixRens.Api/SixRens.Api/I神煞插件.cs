using SixRens.Api.实体.壬式;
using SixRens.Api.实体.起课信息;
using YiJingFramework.StemsAndBranches;

namespace SixRens.Api
{
    public interface I神煞插件 : I插件
    {
        public interface I神煞内容提供器
        {
            IEnumerable<EarthlyBranch> 取所在神(string 神煞名);
        }

        IEnumerable<string> 支持神煞的名称 { get; }
        I神煞内容提供器 获取神煞内容提供器(
            I起课信息 起课信息,
            I天地盘 天地盘,
            I四课 四课,
            I三传 三传,
            I天将盘 天将盘);
    }
}
