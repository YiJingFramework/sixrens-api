using YiJingFramework.StemsAndBranches;

namespace SixRens.Api.工具
{
    public static class 天干五合扩展
    {
        public static HeavenlyStem 取所合干(this HeavenlyStem 干)
        {
            return 干.Next(5);
        }
    }
}
