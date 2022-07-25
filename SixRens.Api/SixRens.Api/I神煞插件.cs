using SixRens.Api.实体;
using SixRens.Api.实体.壬式;

namespace SixRens.Api
{
    public interface I神煞插件 : I插件
    {
        IEnumerable<I神煞题目> 支持的神煞 { get; }
        I神煞内容 获取神煞(
            I年月日时 年月日时,
            I地盘 地盘,
            I天盘 天盘,
            I四课 四课,
            I三传 三传,
            I天将盘 天将盘,
            I年命? 课主年命,
            IReadOnlyList<I年命> 对象年命,
            string 神煞题目);
    }
}
