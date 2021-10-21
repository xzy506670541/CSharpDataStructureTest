using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 链表
/// </summary>
namespace DataStructure
{
    /// <summary>链表 视频编号：3-1 什么是链表</summary>
    class LinkedList1<E>
    {
        /// <summary>得到数量 视频编号：3-1 什么是链表</summary>
        private class Node
        {
            /// <summary>数据类型 视频编号：3-1 什么是链表</summary>
            public E e;

            /// <summary>下一个节点 视频编号：3-1 什么是链表</summary>
            public Node next;

            /// <summary>构造函数 视频编号：3-1 什么是链表</summary>
            public Node(E e, Node next)
            {
                this.e = e;
                this.next = next;
            }

            /// <summary>构造函数  视频编号：3-1 什么是链表</summary>
            public Node(E e)
            {
                this.e = e;
                this.next = null;
            }

            /// <summary>重写 视频编号：3-1 什么是链表</summary>
            public override string ToString()
            {
                return e.ToString();
            }
        }

        /// <summary>头节点 视频编号：3-1 什么是链表</summary>
        private Node head;

        /// <summary>节点数量 视频编号：3-1 什么是链表</summary>
        private int N;

        /// <summary>构造函数 视频编号：3-1 什么是链表</summary>
        public LinkedList1()
        {
            head = null;
            N = 0;
        }

        /// <summary>得到数量 视频编号：3-1 什么是链表</summary>
        public int Count
        {
            get { return N; }
        }

        /// <summary>是否是空 视频编号：3-1 什么是链表</summary>
        public bool IsEmpty
        {
            get { return N == 0; }
        }

        /// <summary>
        ///视频编号： 3-2 往链表添加结点
        /// 功能：链表添加元素
        /// </summary>
        /// <param name="index">元素插入的索引</param>
        /// <param name="e">数据类型</param>
        public void Add(int index, E e)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("非法索引！");

            if (index == 0)
            {
                //写法一：
                //Node node = new Node(e);
                //node.next = head;
                //head = node;

                //写法二：
                head = new Node(e, head);
            }
            else
            {
                Node pre = head;
                for (int i = 0; i < index - 1; i++)
                    pre = pre.next;

                //写法一：
                //Node node = new Node(e);
                //node.next = pre.next;
                //pre.next = node;

                //写法二：
                pre.next = new Node(e, pre.next);
            }

            N++;
        }

        /// <summary>
        /// 视频编号： 3-2 往链表添加结点
        /// 功能：添加元素到链表头部
        /// </summary>
        /// <param name="e">添加的元素</param>
        public void AddFirst(E e)
        {
            Add(0, e);
        }

        /// <summary>
        /// 视频编号： 3-2 往链表添加结点
        ///  功能：添加元素到链表尾部
        /// </summary>
        /// <param name="e">添加的元素</param>
        public void AddLast(E e)
        {
            Add(N, e);
        }

        /// <summary>
        /// [Athor:XZY Time:20210817]
        /// [视频编号：3-3 获取、修改、包含、打印]
        ///  [功能：得到某个 索引的元素]
        /// </summary>
        /// <param name="_index">得到某个索引的元素</param>
        /// <returns></returns>
        public E Get(int _index)
        {
            if (_index < 0 || _index >= N)
                throw new ArgumentException("非法索引！");

            Node cur = head;//因为需要遍历，所以如此写，联想动画，每次都将下个指向给前一个(类似C++中的指针)，
            for (int i = 0; i < _index; i++)
                cur = cur.next;

            return cur.e;
        }

        /// <summary>
        /// [Author:XZY Time:20210817]
        /// [视频编号：3-3 获取、修改、包含、打印]
        ///  [功能：得到 首个 索引的元素]
        /// </summary>
        /// <returns></returns>
        public E GetFirst()
        {
            return Get(0);
        }

        /// <summary>
        /// [Author:XZY Time:20210817]
        /// [视频编号：3-3 获取、修改、包含、打印]
        ///  [功能：得到 最后一个 索引的元素]
        /// </summary>
        /// <returns></returns>
        public E GetLast()
        {
            return Get(N - 1);
        }

        /// <summary>
        /// [Author:XZY Time:20210817]
        /// [视频编号：3-3 获取、修改、包含、打印]
        /// [功能：将指定索引的元素修改为指定元素值]
        /// </summary>
        /// <param name="_index"></param>
        /// <param name="_newE"></param>
        public void Set(int _index, E _newE)
        {
            if (_index < 0 || _index >= N)
                throw new ArgumentException("非法索引！");

            Node cur = head;
            for (int i = 0; i < _index; i++)
                cur = cur.next;

            cur.e = _newE;
        }

        /// <summary>
        /// [Author:XZY Time:20210817]
        /// [视频编号：3-3 获取、修改、包含、打印]
        /// [功能：查看 链表是否存在某个 元素]
        /// </summary>
        /// <param name="_e"></param>
        /// <returns></returns>
        public bool Contains(E _e)
        {
            Node cur = head;
            while (cur != null)
            {
                if (cur.e.Equals(_e))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// [Author:XZY Time:20210817]
        /// [视频编号：3-3 获取、修改、包含、打印]
        /// [功能：重写 ToString 函数，进行输出我们的信息]
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            Node cur = head;
            while (cur != null)
            {
                res.Append(cur + "->");
                cur = cur.next;
            }
            res.Append("Null");

            return res.ToString();
        }

    }


}