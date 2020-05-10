using System;

namespace _8_laba_C
{
    struct Train
    {
        public string id_train;
        public string message;
        public int num; 
        public enum typeTrain
        {
            skTrain ,
            pasTrain ,
            tTrain 
        }
        public typeTrain type;
        public Train(string id, string message,int num,int i)
        {
            this.id_train = id;
            this.message = message;
            this.num = num;
            this.type = (typeTrain)i;
        }
        public override string ToString()
        {
            return $"Id поезда - {id_train} Сообщение - {message} Кол-во вагонов - {num} Тип поезда - {type}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1-2 
            //Train train = new Train("1", "Сообщение 1", 12, 1);
            //Console.WriteLine(train);

            //Задание 3
            //SByte a = 0;
            //Byte b = 1;
            //Int16 c = 2;
            //Int32 d = 3;
            //Int64 e = 4;
            //String f = "5";
            //Exception g = new Exception("6");
            //Object[] types = { a, b, c, d, e, f, g };
            //foreach (object o in types)
            //{
            //    Console.WriteLine(o.GetType());
            //    Console.WriteLine(o.GetType().IsValueType);
            //}

            //Задание 4 
            string str = "Слово_1 Слово_2 Слово_3";
            string[] sa = str.Split(" ");
            Array.Sort(sa);
            string str2 = string.Join(" ", sa);
            Console.WriteLine(str2);
        }
    }
}
