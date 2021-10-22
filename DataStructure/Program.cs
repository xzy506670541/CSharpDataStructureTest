using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            #region[视频编号: 2-1 什么是动态数组]
            ////1.静态数组:不越界的
            //int[] arr = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    arr[i] = i;
            //    Console.Write(arr[i] + " ");
            //}
            //Console.Read();

            ////2.静态数组:越界的
            //int[] arr = new int[10];
            //for (int i = 0; i < 15; i++)
            //{
            //    arr[i] = i;
            //    Console.Write(arr[i] + " ");
            //}
            //Console.Read();

            ////3.动态数组:添加内容和初始化时候数量一致
            //ArrayList a = new ArrayList(10);
            //for (int i = 0; i <10; i++)
            //{
            //    a.Add(i);
            //    Console.Write(a[i] + " ");
            //}
            //Console.Read();

            ////4.动态数组：添加内容和初始化时候数量一致
            //ArrayList a = new ArrayList(10);
            //for (int i = 0; i < 15; i++)
            //{
            //    a.Add(i);
            //    Console.Write(a[i] + " ");
            //}
            //Console.Read();

            ////5.动态数组:List
            //List<int> l = new List<int>(10);
            //for (int i = 0; i <15; i++)
            //{
            //    l.Add(i);
            //    Console.Write(l[i] + " ");
            //}
            //Console.Read();
            #endregion

            #region[视频编号: 2-3 获取、修改、打印]
            //Array1 a = new Array1(20);
            //for (int i = 0; i <10; i++)
            //{
            //    a.AddLast(i);
            //}
            //Console.WriteLine(a);

            //a.AddFirst(66);
            //Console.WriteLine(a);

            //a.Add(2, 88);
            //Console.WriteLine(a);

            //Console.WriteLine(a.GetFirst());
            //Console.WriteLine(a.GetLast());
            //Console.WriteLine(a.Get(1));

            //a.Set(1, 6666);
            //Console.WriteLine(a );

            //Console.Read();
            #endregion

            #region[视频编号: 2-4 包含、搜索、删除]
            //Array1 a = new Array1(20);
            //for (int i = 0; i < 10; i++)
            //{
            //    a.AddLast(i);
            //}
            //Console.WriteLine(a);

            //a.AddFirst(66);
            //Console.WriteLine(a);

            //a.Add(2, 77);
            //Console.WriteLine(a);

            ////删除前数据内容：[66,  0,  77,  1,  2,  3,  4,  5,  6,  7,  8,  9]
            //a.RemoveAt(2);
            //a.RemoveFirst();
            //a.RemoveLast();
            //a.Remove(4);
            //Console.WriteLine(a);
            ////删除前数据内容:[0,  1,  2,  3,  5,  6,  7,  8]

            //Console.Read();
            #endregion

            #region[视频编号: 2-5 动态数组:增加内容]
            //Array1 a = new Array1(10);
            //for (int i = 0; i <10; i++)
            //{
            //    a.AddLast(i);
            //}
            //Console.WriteLine(a);

            //a.AddLast(55);
            //Console.WriteLine(a);

            //for (int i = 0; i <6; i++)
            //{
            //    a.RemoveLast();
            //    Console.WriteLine(a);
            //}
            //Console.Read();
            #endregion

            #region[视频编号:2-6 装箱和拆箱]
            //int n = 10000000;
            //Stopwatch t1 = new Stopwatch();
            //Stopwatch t2 = new Stopwatch();
            //Stopwatch t3 = new Stopwatch();
            //Stopwatch t4 = new Stopwatch();

            ////测试1：泛型List+int值类型
            //t1.Start();
            //List<int> l = new List<int>();
            //for (int i = 0; i < n; i++)
            //{
            //    l.Add(i);//int:值类型+List:不发生装箱
            //    int x = l[i];//int:值类型+List:不发生拆箱
            //}
            //t1.Stop();
            //Console.WriteLine("测试1：泛型List+int值类型 花费时间:" + t1.ElapsedMilliseconds + "ms");

            ////测试2:非泛型ArrayList+int值类型
            //t2.Start();
            //ArrayList a = new ArrayList();
            //for (int i = 0; i < n; i++)
            //{
            //    a.Add(i);//发生装箱：非泛型ArrayList+int值类型
            //    int x = (int)a[i];//发生拆箱：非泛型ArrayList+int值类型
            //}
            //t2.Stop();
            //Console.WriteLine("测试2:非泛型ArrayList+int值类型 花费时间:" + t2.ElapsedMilliseconds + "ms");

            ////测试3：泛型List+引用类型对象string
            //t3.Start();
            //List<string> l2 = new List<string>();
            //for (int i = 0; i < n; i++)
            //{
            //    l2.Add("X");//不发生装箱
            //    string x = l2[i];//不发生拆箱
            //}
            //t3.Stop();
            //Console.WriteLine("测试3：泛型List+引用类型对象string:花费时间:" + t3.ElapsedMilliseconds + "ms");

            ////测试4:非泛型ArrayList+ 引用类型string
            //t4.Start();
            //ArrayList a2 = new ArrayList();
            //for (int i = 0; i < n; i++)
            //{
            //    a2.Add("X");//不发生装箱
            //    string s = (string)a2[i];//不发生拆箱
            //}
            //t4.Stop();
            //Console.WriteLine("测试4:非泛型ArrayList+ 引用类型string 花费时间:" + t4.ElapsedMilliseconds + "ms");

            //Console.Read();
            #endregion

            #region[视频编号:2-7 使用泛型技术]
            //int[] n = { 1,2,3,4,5,6,7};
            //Array1<int> a = new Array1<int>();
            //for (int i = 0; i <n.Length; i++)
            //{
            //    a.AddLast(n[i]);//将数组n添加到a泛型中
            //}
            //Console.WriteLine(a);

            //string[] s = {"a","b","c","d"};
            //Array1<string> a2 =new Array1<string>();
            //for (int i = 0; i <s.Length; i++)
            //{
            //    a2.AddLast(s[i]);//将数组s添加到a2泛型中
            //}
            //Console.WriteLine(a2);

            //Console.ReadLine();     
            #endregion

            #region[3-3 获取、修改、包含、打印]
            //LinkedList1<int> l = new LinkedList1<int>();
            //for (int i = 0; i < 5; i++)
            //{
            //    //for循环添加元素
            //    l.AddFirst(i);
            //    Console.WriteLine(l);
            //}

            ////末尾添加元素
            //l.AddLast(666);
            //Console.WriteLine(l);

            ////指定位置添加元素
            //l.Add(2, 999);
            //Console.WriteLine(l);

            ////指定位置修改元素
            //l.Set(2, 1000);
            //Console.WriteLine(l);

            //Console.Read();
            #endregion

            #region[3-4 删除链表中的结点]
            //LinkedList1<int> l = new LinkedList1<int>();
            //for (int i = 0; i < 5; i++)
            //{
            //    //for循环添加元素
            //    l.AddFirst(i);
            //    Console.WriteLine(l);
            //}

            ////末尾添加元素
            //l.AddLast(666);
            //Console.WriteLine(l);

            ////指定位置添加元素
            //l.Add(2, 999);
            //Console.WriteLine(l);

            ////指定位置修改元素
            //l.Set(2, 1000);
            //Console.WriteLine(l);

            //l.RemoveAt(2);
            //Console.WriteLine(l);

            //l.RemoveFirst();
            //Console.WriteLine(l);

            //l.RemoveLast();
            //Console.WriteLine(l);

            //l.Remove(0);
            //Console.WriteLine(l);

            //Console.Read();
            #endregion

            #region [视频编号 4-2 数组栈 ]
            Array1Stack<int> stack = new Array1Stack<int>();

            //测试:数组栈末尾添加元素
            for (int i = 0; i <5; i++)
            { 
                stack.Push(i);
                Console.WriteLine(stack);
            }

            stack.Pop();
            Console.WriteLine(stack);

            Console.ReadLine();
            #endregion

        }
    }
}

