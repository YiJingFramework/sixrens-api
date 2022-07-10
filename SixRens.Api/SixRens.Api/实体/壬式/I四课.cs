using YiJingFramework.StemsAndBranches;

namespace SixRens.Api.实体.壬式
{
    public interface I四课
    {
        HeavenlyStem 日 { get; }
        EarthlyBranch 日阳 { get; }
        EarthlyBranch 日阴 { get; }

        EarthlyBranch 辰 { get; }
        EarthlyBranch 辰阳 { get; }
        EarthlyBranch 辰阴 { get; }

        (HeavenlyStem 下, EarthlyBranch 上) 第一课 { get; }
        (EarthlyBranch 下, EarthlyBranch 上) 第二课 { get; }
        (EarthlyBranch 下, EarthlyBranch 上) 第三课 { get; }
        (EarthlyBranch 下, EarthlyBranch 上) 第四课 { get; }
    }
}
