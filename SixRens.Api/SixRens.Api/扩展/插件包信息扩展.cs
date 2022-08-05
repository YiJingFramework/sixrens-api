using System.Text.Json;
using System.Text.Json.Serialization;

namespace SixRens.Api.扩展
{
    public static class 插件包信息扩展
    {
        [Serializable]
        private class 插件包信息不正确异常 : Exception
        {
            public 插件包信息不正确异常() { }
            public 插件包信息不正确异常(string message) : base(message) { }
            public 插件包信息不正确异常(string message, Exception inner) : base(message, inner) { }
            protected 插件包信息不正确异常(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }

        private sealed record 可序列化插件包信息
        {
            public string? 名称 { get; init; }
            public string? 版本号 { get; init; }
            public string? 网址 { get; init; }
            public string? 主程序集 { get; init; }
            public string?[]? 插件类 { get; init; }
        }

        private static readonly JsonSerializerOptions serializerOptions = new() {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            WriteIndented = true
        };
        public static string 生成插件包信息文件内容(this I插件包信息 插件包信息, bool 检查内容 = true)
        {
            ArgumentNullException.ThrowIfNull(插件包信息);

            var 可序列化 = new 可序列化插件包信息() {
                名称 = 插件包信息.名称,
                版本号 = 插件包信息.版本号,
                网址 = 插件包信息.网址,
                主程序集 = 插件包信息.主程序集,
                插件类 = 插件包信息.插件类?.Select(类 => 类.FullName)?.ToArray()
            };

            if (检查内容)
            {
                if (可序列化.名称 is null)
                    throw new 插件包信息不正确异常($"未填写{nameof(I插件包信息.名称)}");
                if (可序列化.版本号 is null)
                    throw new 插件包信息不正确异常($"未填写{nameof(I插件包信息.版本号)}");
                if (可序列化.主程序集 is null)
                    throw new 插件包信息不正确异常($"未填写{nameof(I插件包信息.主程序集)}");
                if (可序列化.插件类 is null)
                    throw new 插件包信息不正确异常($"未填写{nameof(I插件包信息.插件类)}");
                if (!可序列化.插件类.Any())
                    throw new 插件包信息不正确异常($"{nameof(I插件包信息.插件类)}中没有任何内容");
                if (可序列化.插件类.Contains(null))
                    throw new 插件包信息不正确异常($"{nameof(I插件包信息.插件类)}提供了不正确的类型");
            }

            return JsonSerializer.Serialize(可序列化, serializerOptions);
        }
    }
}
