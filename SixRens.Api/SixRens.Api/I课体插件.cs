using SixRens.Api.实体.壬式;
using SixRens.Api.实体.起课信息;

namespace SixRens.Api
{
    public interface I课体插件 : I插件
    {
        public interface I课体内容提供器
        {
            bool 属此课体(string 课体名);
        }

        IEnumerable<string> 支持的课体 { get; }
        I课体内容提供器 获取课体内容提供器(
            I起课信息 起课信息,
            I天地盘 天盘,
            I四课 四课,
            I三传 三传,
            I天将盘 天将盘,
            IReadOnlyList<I神煞> 神煞列表);
    }
}
