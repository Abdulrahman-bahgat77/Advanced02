using System.Collections;

namespace Advanced02
{
    internal class Program
    {
        public static int SumArrayList(ArrayList arraylist)
        {
            int sum = 0;
            for(int i=0;i<arraylist.Count;i++)
            {
                if (arraylist is not null)
                {
                    sum +=(int)arraylist[i];
                }
            }
            return sum;
        }

        public static int SumList(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            #region Non Generic(Array list)
            // ArrayList arraylsit = new ArrayList();
            //Console.WriteLine($"Count of arraylist={arraylsit.Count}, Capicty of arraylist={arraylsit.Capacity}");
            //Console.WriteLine("--------------");

            //arraylsit.Add(1);
            //Console.WriteLine($"Count of arraylist={arraylsit.Count}, Capicty of arraylist={arraylsit.Capacity}");
            //Console.WriteLine("--------------");
            //arraylsit.AddRange(new int []{ 2,3});
            //Console.WriteLine($"Count of arraylist={arraylsit.Count}, Capicty of arraylist={arraylsit.Capacity}");

            //ArrayList arrayList = new ArrayList(5) { 1,2,3,4,5};
            //Console.WriteLine($"Count of arraylist={arrayList.Count}, Capicty of arraylist={arrayList.Capacity}");
            //Console.WriteLine("--------------------");
            //arrayList.Add(6);
            //Console.WriteLine($"Count of arraylist={arrayList.Count}, Capicty of arraylist={arrayList.Capacity}");
            //Console.WriteLine("--------------------");

            //arrayList.TrimToSize();
            //Console.WriteLine($"Count of arraylist={arrayList.Count}, Capicty of arraylist={arrayList.Capacity}");
            //int result=SumArrayList(arrayList);
            //Console.WriteLine(result);
            #endregion

            #region Generic(List)
            //List<int> numbers = new List<int>();
            //Console.WriteLine($"Count={numbers.Count},Capicty={numbers.Capacity}");
            //Console.WriteLine("---------------");
            //numbers.Add(1);
            //Console.WriteLine($"Count={numbers.Count},Capicty={numbers.Capacity}");
            //Console.WriteLine("---------------");

            //numbers.Add(2);

            //numbers.AddRange(new int[] {3,4});
            //numbers.Add(6);
            //Console.WriteLine($"Count={numbers.Count},Capicty={numbers.Capacity}");
            //Console.WriteLine("---------------");
            //numbers.TrimExcess();
            //Console.WriteLine($"Count={numbers.Count},Capicty={numbers.Capacity}");
            //Console.WriteLine("---------------");

            //List<int> list = new List<int>(5) { 1,2,3,4,5};
            #endregion

            #region List Method
            //List<int> list = new List<int>(4) { 1, 2, 3, 4 };
            //list.Add(5);


            //list.AddRange(new int[] { 6, 7 });
            //foreach (int i in list)
            //{
            //    Console.Write($"{i} ");
            //}
            //  Console.WriteLine("\n-------------------");
            //list.Insert(1, 5);
            //foreach (int i in list)
            //{
            //    Console.Write($"{i} ");
            //}
            //list.InsertRange(0,new int[] {6,7});
            //foreach (int i in list)
            //{
            //    Console.Write($"{i} ");
            //}

            // Console.WriteLine(list.BinarySearch(3));

            //list.Clear();
            //Console.WriteLine($"count={list.Count},capacity={list.Capacity}");

            //Console.WriteLine(list.Contains(100)) ;
            //Console.WriteLine(list.LastIndexOf(1)); 
            #endregion

            #region Linked List
            // LinkedList<int>linkedlist=new LinkedList<int>();
            //// Console.WriteLine(linkedlist.Count);
            // linkedlist.AddFirst(1);
            //// Console.WriteLine(linkedlist.Count);
            // linkedlist.AddLast(2);
            // //Console.WriteLine(linkedlist.Count);
            // LinkedListNode<int> afternode = linkedlist.Find(1);
            // linkedlist.AddAfter(afternode, 5);
            // LinkedListNode<int> addbefor=linkedlist.Find(2);
            // linkedlist.AddBefore(addbefor, 6);
            // foreach(int i in linkedlist)
            // {
            //     Console.WriteLine($"{i} ");
            // }
            #endregion

            #region Stack
           //Stack<int> stack=new Stack<int> ();
           // stack.Push (1);
           // stack.Push(2);
           // stack.Push(3);
           // Console.WriteLine(stack.Pop());
           // Console.WriteLine(stack.Pop());
           // //Console.WriteLine(stack.Pop());
            
           // bool result = stack.TryPop(out int element);
           // Console.WriteLine(result);
           // Console.WriteLine(element);
           // Console.WriteLine("-----------");
            //foreach(int i in stack)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Queue
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //Console.WriteLine(queue.Dequeue());
            
            #endregion
        }
    }
}
