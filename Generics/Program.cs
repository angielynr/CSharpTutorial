using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyDataStore<string> storeString = new MyDataStore<string>();
            //storeString.Data[0] = "Hello world";
            //storeString.Data[1] = "Hello again";

            //MyDataStore<int> storeInt = new MyDataStore<int>();
            //storeInt.Data = 5;

            //MyKeyValuePair<int, string> kvp1 = new MyKeyValuePair<int, string>();
            //kvp1.Key = 100;
            //kvp1.Value = "One hundred";

            //MyKeyValuePair<string, string> kvp2 = new MyKeyValuePair<string, string>();
            //kvp2.Key = "IT";
            //kvp2.Value = "Information Technology";

            //MyDataStore<string> cities = new MyDataStore<string>();
            //cities.AddOrUpdate(0, "Manila");
            //cities.AddOrUpdate(1, "Pasay");
            //cities.AddOrUpdate(2, "Makati");
            //Console.WriteLine($"My City is {cities.GetData(2)}");


            //MyDataStore<int> employeeId = new MyDataStore<int>();
            //employeeId.AddOrUpdate(0, 100);
            //employeeId.AddOrUpdate(1, 200);
            //employeeId.AddOrUpdate(3, 300);

            //Console.WriteLine($"My ID is {employeeId.GetData(2)}");

            //MyDataStore<Box> MyBoxes = new MyDataStore<Box>();
            //MyBoxes.AddOrUpdate(0, new Box() { NumberOfSides = 4 });
            //MyBoxes.AddOrUpdate(2, new Box() { NumberOfSides = 3 });

            //MyDataStore<int> store = new MyDataStore<int>();
            //MyDataStore<char> store2 = new MyDataStore<char>();
            //MyDataStore<string> store3 = new MyDataStore<string>(); //CANNOT BE COZ REFERENCE TYPE

            Console.ReadLine();

        }
    }

    class MyDataStore<T> where T : class, new()
    {
        private T[] _data = new T[10];
        public T Data { get; set; }

        public void AddOrUpdate(int index, T item)
        {
            if(index >= 0 && index < 10)
            {
                _data[index] = item;
            }
        }

        public void AddOrUpdate(T data1, T data2) { } //Impementation for Overloading
        public void AddOrUpdate<U>(T data1, T data2) { } //Impementation for Overloading
        public void AddOrUpdate(T data) { } //Impementation for Overloading

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
            {
                return _data[index];
            }
            else
            {
                return default(T);
            }
        }
    }

    class MyKeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }

    class Box
    {
        public Box()
        {

        }
        public Box(int numberOfSides)
        {

        }
        public int NumberOfSides { get; set; }
    }

    struct MyStruct
    {
        public int StructProperty { get; set; }
    }
}
