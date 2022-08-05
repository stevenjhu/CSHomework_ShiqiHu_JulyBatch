using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_ShiqiHu_JulyBatch
{
    internal class hw4
    {
        //1. Describe the problem generics address.
        /*
         * Generics address the problem implementing type safety and allow flexibility in data type stored for the declared member
         */
        //2. How would you create a list of strings, using the generic List class?
        //List<string> list = new List<string>();
        //3. How many generic type parameters does the Dictionary class have?
        //Two
        //4. True/False. T
        //When a generic class has multiple type parameters, they must all match.
        //5. What method is used to add items to a List object?
        //List.Add(T)
        //6. Name two methods that cause items to be removed from a List.
        //List.Remove(T) and List.Clear()
        //7. How do you indicate that a class has a generic type parameter?
        //public class Demo<T>{}
        //8. True/False. F    You can have multiple type parameters with different names. E.g. (public class Demo<T,T1>{})
        //Generic classes can only have one generic type parameter.
        //9. True/False. T
        //Generic type constraints limit what can be used for the generic type.
        //10. True/False. F     Constrain to the type, overall or specific(class/struct, Employee/Manager)
        //Constraints let you use the methods of the thing you are constraining to.

        //Practice working with Generics
        //1. 
        public class MyStack<T> : Stack<T>
        {
            public int Count()
            {
                return base.Count;
            }
            public T Pop()
            {
                return base.Pop();
            }
            public void Push(T t)
            {
                base.Push(t);
            }
        }

        //2
        public struct MyList<T>
        {
            List<T> list;

            public MyList()
            {
                list = new List<T>();
            }

            public void Add(T t)
            {
                list.Add(t);
            }
            public T Remove(int index)
            {
                T t = list[index];
                list.RemoveAt(index);
                return t;
            }
            bool Contains(T element)
            {
                if (list.Contains(element))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            void Clear()
            {
                list.Clear();
            }
            void InsertAt(T element, int index)
            {
                list.Insert(index, element);
            }
            void DeleteAt(int index)
            {
                list.RemoveAt(index);
            }
            T Find(int index)
            {
                return list[index];
            }
        }

        //3
        public class GenericRepository<T> : IRepository<T> where T : Entity
        {
            private List<T> lst;
            public void Add(T item)
            {
                lst.Add(item);
            }

            public IEnumerable<T> GetAll()
            {
                return lst;
            }

            public T GetById(int id)
            {
                return lst.Find(x => x.GetId()==id);
            }

            public void Remove(T item)
            {
                lst.Remove(item);
            }

            public void Save()
            {
                throw new NotImplementedException();
            }
            
        }
        public interface IRepository<T>
        {
            void Add(T item);
            void Remove(T item);
            void Save();
            IEnumerable<T> GetAll();
            T GetById(int id);
        }
        public class Entity
        {
            private int Id;
            
            public int GetId()
            {
                return Id;
            }
            public void SetId(int id)
            {
                this.Id = id;
            }
            
        }
    }


}
