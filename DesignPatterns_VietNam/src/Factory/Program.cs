using System;

/// <summary>
/// Sử dụng khi cách tạo object khá phức tạp
/// Constructor khó diễn tả được: giớ hạn về Name,không thể overload, có thể chạy được nếu dùng paramerter hell
/// Object creation có thể được outsourced to: một factory method, class factory
/// </summary>

namespace Factory
{
    /// <summary>
    /// factory method
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
