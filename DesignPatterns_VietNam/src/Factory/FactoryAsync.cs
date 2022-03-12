using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// Lưu ý khi khởi tạo async có thể task bị exption dẫn tới object không được tạo ra
    /// </summary>
    public class Foo
    {
        public Foo()
        {
        }

        private async Task<Foo> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }

        public static Task<Foo> CreateAsync()
        {
            var result = new Foo();
            return result.InitAsync();
        }
    }
}
