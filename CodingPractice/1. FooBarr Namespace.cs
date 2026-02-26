using System;
using System.Collections.Generic;
using System.Text;


namespace Foo
{
    public class Car
    {
        public void Go()
        {
            Console.WriteLine("Foo 네임스페이스의 Car 클래스");
        }
    }
}
namespace Bar
{
    public class Car
    {
        public void Go()
        {
            Console.WriteLine("Bar 네임스페이스의 Car 클래스");
        }
    }
}