using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    /// <summary>
    /// [Author:XZY Time:20211022 视频编号：4-2 数组栈]
    /// [功能：数组栈接口]
    /// </summary>
    interface IStack<E>
    {
        /// <summary>
        /// [Author:XZY Time:20211022 视频编号：4-2 数组栈]
        /// [功能：得到 数组栈接口 数量]
        /// </summary>
        /// <returns>数量</returns>
        int Count { get; }

        /// <summary>
        /// [Author:XZY Time:20211022 视频编号：4-2 数组栈]
        /// [功能：得到 数组栈接口 是否为空]
        /// </summary>
        /// <returns>是否为空</returns>
        bool IsEmpty { get; }

        /// <summary>
        /// [Author:XZY Time:20211022 视频编号：4-2 数组栈]
        /// [功能：添加元素到栈接口数组]
        /// </summary>
        /// <param name="e"></param>
        void Push(E e);

        /// <summary>
        /// [Author:XZY Time:20211022 视频编号：4-2 数组栈]
        /// [功能：删除 数组栈接口 的顶部，并且返回数组栈]
        /// </summary>
        /// <returns></returns>
        E Pop();

        /// <summary>
        /// [Author:XZY Time:20211022 视频编号：4-2 数组栈]
        /// [功能：检查元素是否在栈数组接口中]
        /// </summary>
        /// <returns></returns>
        E Peek();
    }
}
