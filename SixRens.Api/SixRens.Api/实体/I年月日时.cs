using YiJingFramework.StemsAndBranches;

namespace SixRens.Api.实体
{
    public interface I年月日时
    {
        public interface I旬
        {
            HeavenlyStem 旬首干 { get; }
            EarthlyBranch 旬首支 { get; }
            EarthlyBranch 空亡一 { get; }
            EarthlyBranch 空亡二 { get; }
            IEnumerable<(HeavenlyStem 干, EarthlyBranch 支)> 每日干支 { get; }
            HeavenlyStem? 获取对应天干(EarthlyBranch 地支);
            EarthlyBranch 获取对应地支(HeavenlyStem 天干);
        }

        HeavenlyStem 年干 { get; }
        HeavenlyStem 月干 { get; }
        HeavenlyStem 日干 { get; }
        HeavenlyStem 时干 { get; }
        EarthlyBranch 年支 { get; }
        EarthlyBranch 月支 { get; }
        EarthlyBranch 日支 { get; }
        EarthlyBranch 时支 { get; }
        EarthlyBranch 昼夜 { get; }
        I旬 旬所在 { get; }
        EarthlyBranch 月将 { get; }
    }
}
