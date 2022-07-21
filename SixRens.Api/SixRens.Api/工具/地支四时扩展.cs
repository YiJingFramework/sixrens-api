using YiJingFramework.StemsAndBranches;

namespace SixRens.Api.工具
{
    public static class 地支四时扩展
    {
        public static 四时 获取四时(this EarthlyBranch 支)
        {
            return (四时)(支.Index % 12 / 4);
        }
    }
}
