using System;
using System.Collections.Generic;
using System.Text;

namespace kpyp
{
    class laba11
    {
<<<<<<< HEAD
        public static void print()
        {
            IMovable car = new Car();
            Console.WriteLine(car.Name);
            car.MoveEvent += () => Console.WriteLine("Car is moving");
            car.Move();
            Train train = new Train();
            Console.WriteLine(train.Name);
            ((ITransport)train).DoorsEvent += () => Console.WriteLine("Двери открыты);
            train.Doors();
        }
    }
    interface ITransport
    {
        void Doors();
        delegate void DoorsHandler();
        protected internal event DoorsHandler DoorsEvent;
    }
    interface IEngine
    {
        void Power();
        void Fuel();
    }
    interface IMovable
    {
        public const double minSpeed = 0;
        private static double maxSpeed = 60;
        static double MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value > 0.0) maxSpeed = value;
            }
        }
        void Move()
        {
            Console.WriteLine("Ехать");
        }
        static double GetTime(double distance, double speed) => distance / speed;

        string Name { get; set; }
        delegate void MoveHandler();
        protected internal event MoveHandler MoveEvent;
    }
    class Car : IMovable, IEngine
    {
        public string Name
        {
            get { return "Легковая машина"; }
            set
            {
                if (value.Length > 0) Name = value;
            }
        }
        IMovable.MoveHandler _moveEvent;
        event IMovable.MoveHandler IMovable.MoveEvent
        {
            add => _moveEvent += value;
            remove => _moveEvent -= value;
        }
        public void Move()
        {
            Console.WriteLine("Машина едет");
            _moveEvent();
        }
        void IEngine.Power()
        {
            Console.WriteLine("Моя мощность 300 л.с.");
        }

        void IEngine.Fuel()
        {
            Console.WriteLine("Я потребляю керосин");
        }
        public void Power()
        {
            Console.WriteLine("Моя мощность измеряется в л.с.");
        }

        public void Fuel()
        {
            Console.WriteLine("Я потребляю какой-то бензин");
        }
    }
    class Train : IMovable, IEngine, ITransport
    {

        public string Name
        {
            get { return "Поезд"; }
            set
            {
                if (value.Length > 0) Name = value;
            }
        }
        IMovable.MoveHandler _moveEvent;
        event IMovable.MoveHandler IMovable.MoveEvent
        {
            add => _moveEvent += value;
            remove => _moveEvent -= value;
        }
        public void Move()
        {
            Console.WriteLine("Поезд едет по рельсам");
            _moveEvent();
        }
        void IEngine.Power()
        {
            Console.WriteLine("Моя мощность 300 л.с.");
        }

        void IEngine.Fuel()
        {
            Console.WriteLine("Я потребляю ток");
        }
        public void Power()
        {
            Console.WriteLine("Моя мощность измеряется в л.с.");
        }

        public void Fuel()
        {
            Console.WriteLine("Я потребляю элекстричество");
        }
        ITransport.DoorsHandler _doorsEvent;
        event ITransport.DoorsHandler ITransport.DoorsEvent
        {
            add => _doorsEvent += value;
            remove => _doorsEvent -= value;
        }
        public void Doors()
        {
            Console.WriteLine("Двери в действии...");
            _doorsEvent();
        }
    }
    class ExpressTrain : IMovable, IEngine, ITransport
    {

        public string Name
        {
            get { return "Эеспресс"; }
            set
            {
                if (value.Length > 0) Name = value;
            }
        }
        IMovable.MoveHandler _moveEvent;
        event IMovable.MoveHandler IMovable.MoveEvent
        {
            add => _moveEvent += value;
            remove => _moveEvent -= value;
        }
        public void Move()
        {
            Console.WriteLine("Экспресс едет быстро по рельсам");
            _moveEvent();
        }
        void IEngine.Power()
        {
            Console.WriteLine("Моя мощность 400 л.с.");
        }

        void IEngine.Fuel()
        {
            Console.WriteLine("Я потребляю много ток");
        }
        public void Power()
        {
            Console.WriteLine("Моя мощность выше мощности обычного поезда");
        }

        public void Fuel()
        {
            Console.WriteLine("Я потребляю много элекстричества");
        }
        ITransport.DoorsHandler _doorsEvent;
        event ITransport.DoorsHandler ITransport.DoorsEvent
        {
            add => _doorsEvent += value;
            remove => _doorsEvent -= value;
        }
        public void Doors()
        {
            Console.WriteLine("Двери в действии...");
            _doorsEvent();
        }
    }
}
