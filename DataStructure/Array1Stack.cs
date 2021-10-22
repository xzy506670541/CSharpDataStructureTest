using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    /// <summary>[功能：泛型的数组栈，继承 泛型的IStack 接口]  [Author:XZY Time:20211022 视频编号：4-2 数组栈] </summary>
    class Array1Stack<E> : IStack<E>
    {
        /// <summary>[功能：创建泛型的数组]    [Author:XZY Time:20211022 视频编号：4-2 数组栈] </summary>
        private Array1<E> arr;

        /// <summary>[功能：得到 泛型数组 的元素数量]    [Author:XZY Time:20211022 视频编号：4-2 数组栈] </summary>
        public int Count { get { return arr.Count; } }

        /// <summary>[功能：得到 泛型数组 是否为空]    [Author:XZY Time:20211022 视频编号：4-2 数组栈] </summary>
        public bool IsEmpty { get { return arr.IsEmpty; } }

        /// <summary>[功能：构造函数 Array1Stack ]  [参数:capacity=创建容器的大小]  [Author:XZY Time:20211022 视频编号：4-2 数组栈] </summary>
        public Array1Stack(int capacity)
        {
            arr = new Array1<E>(capacity);//构造函数中如果知道链表多长就直接创建
        }

        /// <summary>[功能：构造函数 Array1Stack ]   [Author:XZY Time:20211022 视频编号：4-2 数组栈] </summary>
        public Array1Stack()
        {
            arr = new Array1<E>();//构造函数中如果不知道链表多长就自动创建容量大小为10的链表；
        }

        /// <summary>[功能：将元素添加到数组中 ]   [Author:XZY Time:20211022 视频编号：4-2 数组栈] </summary>
        public void Push(E e)
        {
            arr.AddLast(e);//因为将元素放在最后一位，时间复杂地为O（1）
        }

        /// <summary>[功能：将数组最后一个元素删除 ]   [Author:XZY Time:20211022 视频编号：4-2 数组栈] </summary>
        public E Pop()
        {
            return arr.RemoveLast();
        }

        /// <summary>[功能：得到数组最后一个元素 ]   [Author:XZY Time:20211022 视频编号：4-2 数组栈] </summary>
        public E Peek()
        {
            return arr.GetLast();
        }

        /// <summary>[功能：重写转换为字符串，目的为了输出好看 ]   [Author:XZY Time:20211022 视频编号：4-2 数组栈] </summary>
        public override string ToString()
        {
            return "Stack:" + arr.ToString() + "Top";
        }

    }
}
