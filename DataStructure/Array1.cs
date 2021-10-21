using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    #region[2-7 使用泛型技术]
    //class Array1
    class Array1<E>
    {
        /// <summary>int[]:数组</summary>
        //private int[] data;
        private E[] data;

        /// <summary>int:数组中存储元素个数</summary>
        private int N;

        //构造函数:
        public Array1(int capacity)
        {
            //data = new int[capacity];
            data = new E[capacity];
            N = 0;
        }

        //构造函数
        public Array1() : this(10) { }

        //方法:获取data.Length
        public int Capacity
        {
            get { return data.Length; }
        }

        //方法:获取N
        public int Count
        {
            get { return N; }
        }

        //是否是空
        public bool IsEmpty
        {
            get { return N == 0; }
        }

        /// <summary>
        /// 视频编号: 2-5 动态数组
        /// 功能：数组添加元素：在数组中间空间位置添加元素
        /// </summary>
        /// <param name="index"></param>
        /// <param name="e"></param>
        //public void Add(int index, int e)
        public void Add(int index, E e)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界！");

            if (N == data.Length)
                ResetCapacity(2 * data.Length);//( 视频编号: 2-5 动态数组:增加内容)因为需要动态数组，所以当增加元素超过数组长度后，需要扩容相当于之前2倍大小的新数组
                                               //throw new ArgumentException("数组已满!");

            //从后向前，每一个往后挪一个
            for (int i = N - 1; i >= index; i--)
                data[i + 1] = data[i]; //将当前空间数据给后面一个空间，实现将从index开始的元素每一个往后挪一个空间位置

            data[index] = e;
            N++;
        }

        //数组添加元素:在末尾空间位置添加元素
        //public void AddLast(int e)
        public void AddLast(E e)
        {
            Add(N, e);
        }

        //数组添加元素:在首位空间位置添加元素
        //public void AddFirst(int e)
        public void AddFirst(E e)
        {
            Add(0, e);
        }

        /// <summary>
        /// 视频编号: 2-3 获取、修改、打印
        /// 功能:得到某个索引的元素
        /// </summary>
        /// <param name="index">数组中索引编号</param>
        /// <returns></returns>
        //public int Get(int index)
        public E Get(int index)
        {
            if (index < 0 || index >= N)
            {
                throw new ArgumentException("数组索引越界！");
            }
            return data[index];
        }

        /// <summary>
        /// 视频编号: 2-3 获取、修改、打印
        /// 功能：得到第一个索引的元素
        /// </summary>
        /// <returns></returns>
        //public int GetFirst()
        public E GetFirst()
        {
            return Get(0);
        }

        /// <summary>
        /// 视频编号: 2-3 获取、修改、打印
        /// 功能：得到数组最后一个索引的元素
        /// </summary>
        /// <returns></returns>
        //public int GetLast()
        public E GetLast()
        {
            return Get(N - 1);
        }

        /// <summary>
        ///视频编号: 2-3 获取、修改、打印
        /// 功能:修改索引位置的元素
        /// </summary>
        /// <param name="index">准备在什么索引进行修改</param>
        /// <param name="newE">准备将制定位置的元素修改什么数值</param>
        //public void Set(int index, int newE)
        public void Set(int index, E newE)
        {
            if (index < 0 || index >= N)
            {
                throw new ArgumentException("索引越界!");
            }
            data[index] = newE;
        }

        /// <summary>
        /// 视频编号: 2-4 包含、搜索、删除
        /// 功能：检查数组是否包含输入的元素
        /// </summary>
        /// <param name="e">输入的元素</param>
        /// <returns>存在:true| 不存在:false</returns>
        public bool Contains(int e)
        {
            for (int i = 0; i < N; i++)
            {
                //if (data[i] == e)
                if (data[i].Equals(e))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 视频编号: 2-4 包含、搜索、删除
        /// 功能：获取元素在数组第一次从前往后第几个位置
        /// </summary>
        /// <param name="e">检查的元素</param>
        /// <returns>如果输入的元素存在返回元素在元素中的索引   如果输入的元素不存在数组就返回-1</returns>
        public int IndexOf(int e)
        {
            for (int i = 0; i < N; i++)
            {
                //if (data[i] == e)
                if (data[i].Equals(e))
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        ///  视频编号: 2-4 包含、搜索、删除
        ///  视频编号: 2-5 动态数组
        /// 功能：删除指定索引的元素
        /// </summary>
        /// <param name="index">删除元素的索引</param>
        /// <returns>删除索引的元素内容</returns>
        //public int RemoveAt(int index)
        public E RemoveAt(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("索引越界!");

            //int del = data[index];//删除位置的元素内容
            E del = data[index];//删除位置的元素内容

            for (int i = index + 1; i <= N - 1; i++)
                data[i - 1] = data[i];//这里时候联想：删除数组中的元素:动画演示

            N--;
            //data[N] = default(int);
            data[N] = default(E);


            // ( 视频编号: 2-5 动态数组:增加内容)想想：动画演示:数组缩容因为当删除数组某个元素后，
            // 如果数组长度没有之前的四分之一长，那么就可以将其缩容一半，减少内存开支，
            //并不是只有之前一半长久缩容，而是四分之一，减少内存空间不断的缩容和扩容
            if (N == data.Length / 4)
                ResetCapacity(data.Length / 2);

            return del;
        }

        /// <summary>
        ///  视频编号: 2-4 包含、搜索、删除
        /// 功能：删除第一个索引的元素
        /// </summary>
        /// <returns></returns>
        //public int RemoveFirst()
        public E RemoveFirst()
        {
            return RemoveAt(0);
        }

        /// <summary>
        ///  视频编号: 2-4 包含、搜索、删除
        /// 功能：删除数组最后一个索引的元素
        /// </summary>
        /// <returns></returns>
        //public int RemoveLast()
        public E RemoveLast()
        {
            return RemoveAt(N - 1);
        }

        /// <summary>
        ///  视频编号: 2-4 包含、搜索、删除
        /// 功能：删除指定索引位置的元素
        /// </summary>
        /// <param name="e">输入参数:移除数组从左向右第一个元素为e的元素</param>
        public void Remove(int e)
        {
            int index = IndexOf(e);
            if (index != -1)
                RemoveAt(index);
        }

        /// <summary>
        /// 视频编号: 2-5 动态数组
        /// 功能：重新开辟一个内容空间，想想 动画演示:数组扩容，就会理解这样写的思路
        /// </summary>
        /// <param name="newCapacity"></param>
        private void ResetCapacity(int newCapacity)
        {
            //int[] newData = new int[newCapacity];//新建一个数组，大小是形参
            E[] newData = new E[newCapacity];//新建一个数组，大小是形参
            for (int i = 0; i < N; i++)
            {
                newData[i] = data[i];//将之前的数组数据都赋值给新的数组
            }
            data = newData;//将新创建的数组赋值给全局变量data，这样就实现了数组data的扩容。
        }

        /// <summary>
        /// 功能：因为Console.writeLine()调用的是父类的ToString，直接是类的名字，所以需要重写toString：方便输出数组内部数据，
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(string.Format("Array1: count={0} capacity={1}\n", N, data.Length));
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(data[i]);
                if (i != N - 1)
                    res.Append(",  ");
            }
            res.Append("]");
            return res.ToString();
        }

    }
    #endregion
}
