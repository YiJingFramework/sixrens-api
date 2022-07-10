using YiJingFramework.StemsAndBranches;

namespace SixRens.Api.实体.壬式
{
    public interface I神煞表
    {
        public IEnumerable<string> 支持的神煞 { get; }
        public EarthlyBranch? this[string 神煞] { get; }
    }
}
