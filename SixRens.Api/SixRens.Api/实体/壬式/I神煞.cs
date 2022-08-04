using YiJingFramework.StemsAndBranches;

namespace SixRens.Api.实体.壬式
{
    public interface I神煞
    {
        string 神煞名 { get; }
        IReadOnlyList<EarthlyBranch> 所在神 { get; }
    }
}
