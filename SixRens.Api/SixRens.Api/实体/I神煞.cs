using YiJingFramework.StemsAndBranches;

namespace SixRens.Api.实体
{
    public interface I神煞 : I神煞题目, I神煞内容
    {
        new IReadOnlyList<EarthlyBranch> 所在神 { get; }

        IEnumerable<EarthlyBranch> I神煞内容.所在神 => this.所在神;
    }
}
