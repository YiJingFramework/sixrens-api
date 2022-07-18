using SixRens.Api.实体;
using SixRens.Api.实体.壬式;

namespace SixRens.Api
{
    public interface I参考插件 : I插件
    {
        IEnumerable<I占断参考> 支持的占断参考 { get; }
        IEnumerable<I占断参考> 生成占断参考(
            I年月日时 年月日时,
            地支盘 基础盘,
            地支盘 地盘,
            地支盘 天盘,
            I四课 四课,
            I三传 三传,
            I天将盘 天将盘,
            I年命? 课主年命,
            IReadOnlyList<I年命> 对象年命,
            IReadOnlyList<I神煞> 神煞列表,
            IReadOnlyList<I课体> 课体列表);
    }
}
