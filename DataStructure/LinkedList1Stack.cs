using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    /// <summary>[功能：泛型的链表栈，继承 泛型的IStack 接口]  [Author:XZY Time:20211022 视频编号：4-3 链表栈] </summary>
    class LinkedList1Stack<E>: IStack<E>
    {
        /// <summary>[功能：私有对象]  [Author:XZY Time:20211022 视频编号：4-3 链表栈] </summary>
        private LinkedList1<E> list;

        /// <summary>[功能：构造函数]  [Author:XZY Time:20211022 视频编号：4-3 链表栈] </summary>
        public LinkedList1Stack()
        {
            list = new LinkedList1<E>();
        }

        /// <summary>[功能：得到链表栈的节点个数]  [Author:XZY Time:20211022 视频编号：4-3 链表栈] </summary>
        public int Count { get { return list.Count; } }

        /// <summary>[功能：得到链表栈是否为空]  [Author:XZY Time:20211022 视频编号：4-3 链表栈] </summary>
        public bool IsEmpty { get { return list.IsEmpty; } }

        /// <summary>[功能：查看栈顶节点(头部节点)]  [Author:XZY Time:20211022 视频编号：4-3 链表栈] </summary>
        public E Peek()
        {
            return list.GetFirst();
        }

        /// <summary>[功能：删除栈顶节点(头部节点)]  [Author:XZY Time:20211022 视频编号：4-3 链表栈] </summary>
        public E Pop()
        {
            return list.RemoveFirst();
        }

        /// <summary>[功能：添加链接头部节点)]  [Author:XZY Time:20211022 视频编号：4-3 链表栈] </summary>
        public void Push(E e)
        {
             list.AddFirst(e);
        }

        public override string ToString()
        {
            return "Stack :top " + list.ToString();
        }

    }
}
