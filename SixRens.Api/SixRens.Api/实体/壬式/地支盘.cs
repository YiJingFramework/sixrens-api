using YiJingFramework.StemsAndBranches;

namespace SixRens.Api.实体.壬式
{
    public struct 地支盘
    {
        private readonly int 首地支序数;

        public 地支盘()
        {
            this.首地支序数 = 1;
        }

        public 地支盘(地支盘 基盘, EarthlyBranch 基盘地支, EarthlyBranch 所对新盘地支)
        {
            this.首地支序数 = 基盘.首地支序数 - 基盘地支.Index + 所对新盘地支.Index;
        }

        public EarthlyBranch 获取同位支(地支盘 其他盘, EarthlyBranch 其他盘中支)
        {
            return new EarthlyBranch(this.首地支序数 - 其他盘.首地支序数 + 其他盘中支.Index);
        }
    }
}
