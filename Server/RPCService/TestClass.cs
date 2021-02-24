using System;
using System.Collections.Generic;

namespace RPCServiceDemo
{
    [Serializable]
    public class Test01
    {
        public int Age { get; set; } = 1;
        public string Name { get; set; }
    }

    [Serializable]
    public class Test02
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public List<int> list { get; set; }
        public int[] nums { get; set; }
    }

    [Serializable]
    public class Test03 : Test02
    {
        public int Length { get; set; }
    }

    public enum MyEnum
    {
        T1 = 0,
        T2 = 100,
        T3 = 200
    }
}