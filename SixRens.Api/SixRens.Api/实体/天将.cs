using System.Diagnostics.CodeAnalysis;
using YiJingFramework.StemsAndBranches;

namespace SixRens.Api.实体
{
    public struct 天将 : IComparable<天将>, IEquatable<天将>
    {
        private readonly int 序号;
        private 天将(int 序号)
        {
            this.序号 = (序号 % 12 + 12) % 12;
        }
        public static 天将 贵人 => new(0);
        public static 天将 螣蛇 => new(1);
        public static 天将 朱雀 => new(2);
        public static 天将 六合 => new(3);
        public static 天将 勾陈 => new(4);
        public static 天将 青龙 => new(5);
        public static 天将 天空 => new(6);
        public static 天将 白虎 => new(7);
        public static 天将 太常 => new(8);
        public static 天将 玄武 => new(9);
        public static 天将 太阴 => new(10);
        public static 天将 天后 => new(11);

        public int CompareTo(天将 other)
        {
            return this.序号.CompareTo(other.序号);
        }

        public bool Equals(天将 other)
        {
            return this.序号.Equals(other.序号);
        }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if (obj is 天将 将)
                return 序号.Equals(将.序号);
            return false;
        }

        public override string ToString()
        {
            return 序号 switch
            {
                0 => "贵人",
                1 => "螣蛇",
                2 => "朱雀",
                3 => "六合",
                4 => "勾陈",
                5 => "青龙",
                6 => "天空",
                7 => "白虎",
                8 => "太常",
                9 => "玄武",
                10 => "太阴",
                _ => "天后",
            };
        }

        public static explicit operator int(天将 天将)
        {
            return 天将.序号;
        }

        public static explicit operator 天将(int 序号)
        {
            return new(序号);
        }

        public override int GetHashCode()
        {
            return 序号.GetHashCode();
        }

        public static bool operator ==(天将 左, 天将 右)
        {
            return 左.序号 == 右.序号;
        }
        public static bool operator !=(天将 左, 天将 右)
        {
            return 左.序号 != 右.序号;
        }
    }
}
