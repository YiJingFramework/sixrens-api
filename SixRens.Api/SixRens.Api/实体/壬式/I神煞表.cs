using YiJingFramework.StemsAndBranches;

namespace SixRens.Api.实体.壬式
{
    public interface I神煞表
    {
        public IEnumerable<I神煞信息> 支持的神煞 { get; }
        public EarthlyBranch? this[Guid 神煞] { get; }
    }
}
