using YiJingFramework.Core;
using YiJingFramework.StemsAndBranches;

namespace SixRens.Api.实体.起课信息
{
    public interface I起课信息
    {
        I年月日时 年月日时 { get; }
        I年命? 课主年命 { get; }
        IReadOnlyList<I年命> 对象年命 { get; }
    }
}
