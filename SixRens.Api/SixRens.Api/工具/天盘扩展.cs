using SixRens.Api.实体.壬式;
using YiJingFramework.StemsAndBranches;

namespace SixRens.Api.工具
{
    public static class 天盘扩展
    {
        public sealed class 可逆天盘 : I天地盘
        {
            private readonly Dictionary<EarthlyBranch, EarthlyBranch> 从天神查地支表;
            private readonly I天地盘 天盘;

            internal 可逆天盘(I天地盘 天盘)
            {
                this.天盘 = 天盘;
                this.从天神查地支表 = new Dictionary<EarthlyBranch, EarthlyBranch>(12);
                for (int i = 1; i <= 12; i++)
                {
                    var 地支 = new EarthlyBranch(i);
                    var 天神 = this.天盘.取天神(地支);
                    this.从天神查地支表[天神] = 地支;
                }
            }
            public bool 一一对应 => 从天神查地支表.Count is 12;
            public EarthlyBranch 取上神(EarthlyBranch 地盘支)
            {
                return this.天盘.取天神(地盘支);
            }
            public EarthlyBranch? 取临地(EarthlyBranch 天盘神)
            {
                if (this.从天神查地支表.TryGetValue(天盘神, out var 地盘支))
                    return 地盘支;
                else
                    return null;
            }
            EarthlyBranch I天地盘.取天神(EarthlyBranch 地盘支)
            {
                return this.天盘.取天神(地盘支);
            }
        }

        public sealed class 完全可逆天盘 : I天地盘
        {
            private readonly 可逆天盘 天盘;

            internal 完全可逆天盘(可逆天盘 天盘, bool 强制生成)
            {
                if (!天盘.一一对应 && !强制生成)
                    throw new ArgumentException("所给天盘不能一一对应", nameof(天盘));
                this.天盘 = 天盘;
            }

            public EarthlyBranch 取上神(EarthlyBranch 地盘支)
            {
                return this.天盘.取上神(地盘支);
            }
            public EarthlyBranch 取临地(EarthlyBranch 天盘神)
            {
                var 临地 = this.天盘.取临地(天盘神);
                if (临地.HasValue)
                    return 临地.Value;
                else
                    return default;
            }
            EarthlyBranch I天地盘.取天神(EarthlyBranch 地盘支)
            {
                return this.天盘.取上神(地盘支);
            }
        }

        public static 可逆天盘 可逆化(this I天地盘 天盘)
        {
            return new 可逆天盘(天盘);
        }
        public static 完全可逆天盘 完全化(this 可逆天盘 天盘, bool 强制生成 = false)
        {
            return new 完全可逆天盘(天盘, 强制生成);
        }
        public static 完全可逆天盘 完全可逆化(this I天地盘 天盘, bool 强制生成 = false)
        {
            return 天盘.可逆化().完全化(强制生成);
        }
    }
}
