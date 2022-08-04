namespace SixRens.Api.实体.壬式
{
    public interface I占断参考 : I占断参考内容, I占断参考题目
    {
    }
    public interface I占断参考题目
    {
        string 题目 { get; }
    }
    public interface I占断参考内容
    {
        string? 内容 { get; }
    }
}
