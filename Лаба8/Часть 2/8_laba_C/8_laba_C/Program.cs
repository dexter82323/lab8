using System;

namespace _8_laba_C
{

    class Train
    {
        public string id_train;
        public string message;
        public int num;
        public enum typeTrain
        {
            skTrain,
            pasTrain,
            tTrain
        }
        public typeTrain type;
        public Train(string id, string message, int num, int i)
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

    class FirmTrain : Train
    {
        string nameFirm;
        double kPrice;
        public FirmTrain(string id, string message, int num, int i, string nameFirm, double kPrice) : base(id, message, num, i)
        {
            this.id_train = id;
            this.message = message;
            this.num = num;
            this.type = (typeTrain)i;
            this.nameFirm = nameFirm;
            this.kPrice = kPrice;
        }
        public override string ToString()
        {
            return $"Id поезда - {id_train} Сообщение - {message} Кол-во вагонов - {num} Тип поезда - {type} Название фирмы - {nameFirm} Коэффициент удорожания - {kPrice} ";
        }
    }

    class BigClass : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }   

    class Program
    {
        static void Main(string[] args) 
        {   
            //Задание 1-2
            FirmTrain train = new FirmTrain("1", "Сообщение 2 ", 15, 1, "Фирма 1 ", 2.2);
            Console.WriteLine(train);
            //Задание 4 
            Int16 a = 10;
            Int32 b = 20;
            double c = 30;
            c = a;
            c = b;
            a = (Int16)c;
            //a = (Int32)b;
            b = a;
            //b = (Int16)c;

        }
    }
}
