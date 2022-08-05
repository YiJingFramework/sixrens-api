using System.Diagnostics.CodeAnalysis;

namespace SixRens.Api.实体
{
    public readonly struct 性别 : IComparable<性别>, IEquatable<性别>
    {
        public bool 为男性 { get; }
        public 性别(bool 为男性)
        {
            this.为男性 = 为男性;
        }
        public static 性别 男 => new(true);
        public static 性别 女 => new(false);
        public int CompareTo(性别 other)
        {
            return this.为男性.CompareTo(other.为男性);
        }
        public bool Equals(性别 other)
        {
            return this.为男性.Equals(other.为男性);
        }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if (obj is 性别 性别)
                return this.为男性.Equals(性别.为男性);
            return false;
        }

        public override string ToString()
        {
            return this.为男性 ? "男" : "女";
        }

        public static explicit operator bool(性别 性别)
        {
            return 性别.为男性;
        }

        public static explicit operator 性别(bool 为男性)
        {
            return new(为男性);
        }

        public override int GetHashCode()
        {
            return this.为男性.GetHashCode();
        }

        public static bool operator ==(性别 左, 性别 右)
        {
            return 左.为男性 == 右.为男性;
        }
        public static bool operator !=(性别 左, 性别 右)
        {
            return 左.为男性 != 右.为男性;
        }
    }
}
