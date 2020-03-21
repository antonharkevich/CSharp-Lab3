using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    
    public class Transport
    {
        public static void ModificationOutput()
        {
            Console.WriteLine("Для изменения имени нажмите 2");
            Console.WriteLine("Для изменения цвета нажмите 3");
            Console.WriteLine("Для изменения веса нажмите 4");
            Console.WriteLine("Для изменения количества мест нажмите 5");
            Console.WriteLine("Для изменения марки нажмите 6");
            Console.WriteLine("Для максимальной скорости нажмите 7");
            Console.WriteLine("Для изменения габаритов нажмите 8 и следуйте инструкции");
            Console.WriteLine("Для изменения состава нажмите 9 и следуйте инструкции");
        }

        public static void ModificationOutput2()
        {
            Console.WriteLine("Для изменения ширины нажмите 1");
            Console.WriteLine("Для изменения высоты нажмите 2");
            Console.WriteLine("Для изменения длины нажмите 3");

        }

        static Random rand = new Random();

            public Transport()
            {
                id = rand.Next(100, 1000);
                Console.WriteLine("Создан экзмепляр класса transport");
                Console.WriteLine("Поля имени, цвета, марки можно изменить вне функции модификации");
                Console.WriteLine("Состав транспорта, его максимальную скорость, вес, габариты и кол-во мест можно изменить только через функцию модификации");
                Console.WriteLine("id транспорта изменению не подлежит");
                Console.WriteLine("Можно вернуть в программу все параметры класса");
                totalAmount++;
                Console.WriteLine("Общее количество транспорта теперь равно:{0} ", totalAmount);
                Console.WriteLine("");
            }
            public Transport(string name)
            {
                this.Name = name;
                Console.WriteLine("Вы создали транспорт с именем {0}", this.Name);
                Console.WriteLine("Поля имени, цвета, марки можно изменить вне функции модификации");
                Console.WriteLine("Состав транспорта, его максимальную скорость, вес, габариты и кол-во мест можно изменить только через функцию модификации");
                Console.WriteLine("id транспорта изменению не подлежит");
                Console.WriteLine("Можно вернуть в программу все параметры класса");
                totalAmount++;
                Console.WriteLine("Общее количество транспорта теперь равно:{0} ", totalAmount);
                Console.WriteLine("");
            }
            public void Information()
            {
                Console.WriteLine("1)ID транспорта:{0} ", id);
                Console.WriteLine("2)Имя транспорта:{0} ", Name);
                Console.WriteLine("3)Цвет транспорта:{0} ", Color);
                Console.WriteLine("4)Вес транспорта:{0} ", Weight);
                Console.WriteLine("5)Количество мест в транспорте:{0} ", NumberOfSeats);
                Console.WriteLine("6)Марка транспорта:{0} ", Mark);
                Console.WriteLine("7)Максимальная скорость транспорта:{0} ", MaxSpeed);
                Console.WriteLine("8.1)Ширина транспорта:{0} ", transportDimensions.width);
                Console.WriteLine("8.2)Высота транспорта:{0} ", transportDimensions.height);
                Console.WriteLine("8.3)Длина транспорта:{0} ", transportDimensions.length);
                Console.WriteLine("Состав транспорта: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("9.{0}):{1} ", i + 1, this[i]);
                }
                Console.WriteLine("");
            }
            public void Information(int n)
            {
                switch (n)
                {
                    case 1: Console.WriteLine("1)ID транспорта:{0} ", id); break;
                    case 2:
                        Console.WriteLine("2)Имя транспорта:{0} ", Name); break;
                    case 3:
                        Console.WriteLine("3)Цвет транспорта:{0} ", Color); break;
                    case 4:
                        Console.WriteLine("4)Вес транспорта:{0} ", Weight); break;
                    case 5:
                        Console.WriteLine("5)Количество мест в транспорте:{0} ", NumberOfSeats); break;
                    case 6: Console.WriteLine("6)Марка транспорта:{0} ", Mark); break;
                    case 7:
                        Console.WriteLine("7)Максимальная скорость транспорта:{0} ", MaxSpeed); break;
                    case 8:
                        Console.WriteLine("8.1)Ширина транспорта:{0} ", transportDimensions.width);
                        Console.WriteLine("8.2)Высота транспорта:{0} ", transportDimensions.height);
                        Console.WriteLine("8.3)Длина транспорта:{0} ", transportDimensions.length); break;
                    case 9:
                        Console.WriteLine("Состав транспорта: ");
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("9.{0}):{1} ", i + 1, this[i]);
                        }
                        break;
                    default: break;


                }
                Console.WriteLine("");
            }
            public void Information(int n, int m)
            {
                switch (n)
                {
                    case 8:
                        switch (m)
                        {
                            case 1: Console.WriteLine("8.1)Ширина транспорта:{0} ", transportDimensions.width); break;
                            case 2: Console.WriteLine("8.2)Высота транспорта:{0} ", transportDimensions.height); break;
                            case 3: Console.WriteLine("8.3)Длина транспорта:{0} ", transportDimensions.length); break;
                            default: break;
                    }
                        break;
                    case 9: Console.WriteLine("9.{0}):{1} ", m, this[m - 1]); break;

                    default: break;

            }
                Console.WriteLine("");
            }


            public void Modification()
            {
                ModificationOutput();
                int n = Convert.ToInt32(Checks.CheckSingleInput());

                switch (n)
                {

                    case 2:
                        Console.WriteLine("Введите имя");
                        Name = Checks.CheckSingleStringInput(); break;
                    case 3:
                        Console.WriteLine("Введите цвет");
                        Color = Checks.CheckSingleStringInput(); break;
                    case 4:
                        Console.WriteLine("Введите вес");
                        Weight = Convert.ToDouble(Checks.CheckSingleDoubleInput()); break;
                    case 5:
                        Console.WriteLine("Введите количество мест");
                        NumberOfSeats = Convert.ToInt32(Checks.CheckSingleInput()); break;

                    case 6: Console.WriteLine("Введите марку"); Mark = Checks.CheckSingleStringInput(); break;
                    case 7:
                        Console.WriteLine("Введите максимальную скорость");
                        MaxSpeed = Convert.ToDouble(Checks.CheckSingleDoubleInput()); break;
                    case 8:
                        ModificationOutput2();
                        int m = Convert.ToInt32(Checks.CheckSingleInput());
                        switch (m)
                        {
                            case 1:
                                Console.WriteLine("Введите ширину");
                                double y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                if (y > 0)
                                {
                                    transportDimensions.width = y;
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка, вы ввели неправильное значение");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Введите высоту");
                                y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                if (y > 0)
                                {
                                    transportDimensions.height = y;
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка, вы ввели неправильное значение");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Введите длину"); 
                                y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                if (y > 0)
                                {
                                    transportDimensions.length = y;
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка, вы ввели неправильное значение");
                                }
                                break;
                        }
                        break;
                    case 9:
                        Console.WriteLine("Введите индекс поля состава, которое хотите изменить(>=0&&<=10)");
                        m = Convert.ToInt32(Checks.CheckSingleInput());
                        Console.WriteLine("Введите часть состава");
                        this[m - 1]= Checks.CheckSingleStringInput();
                        break;
                }
                Console.WriteLine("");
            }
            public void Modification(int n)
            {
                switch (n)
                {

                    case 2:
                        Console.WriteLine("Введите имя");
                        Name = Checks.CheckSingleStringInput(); ; break;
                    case 3:
                        Console.WriteLine("Введите цвет");
                        Color = Checks.CheckSingleStringInput(); ; break;
                    case 4:
                        Console.WriteLine("Введите вес");
                        Weight = Convert.ToDouble(Checks.CheckSingleDoubleInput()); break;
                    case 5:
                        Console.WriteLine("Введите количество мест");
                        NumberOfSeats = Convert.ToInt32(Checks.CheckSingleInput()); break;

                    case 6: Console.WriteLine("Введите марку"); Mark = Checks.CheckSingleStringInput(); ; break;
                    case 7:
                        Console.WriteLine("Введите максимальную скорость");
                        MaxSpeed = Convert.ToDouble(Checks.CheckSingleDoubleInput()); break;
                    case 8:
                        ModificationOutput2();
                        int m = Convert.ToInt32(Checks.CheckSingleInput());
                        switch (m)
                        {
                            case 1:
                                Console.WriteLine("Введите ширину");
                                double y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                if (y > 0)
                                {
                                    transportDimensions.width = y;
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка, вы ввели неправильное значение");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Введите высоту");
                                y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                if (y > 0)
                                {
                                    transportDimensions.height = y;
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка, вы ввели неправильное значение");
                                }
                                break;
                            case 3:
                                Console.WriteLine("Введите длину"); 
                                y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                                if (y > 0)
                                {
                                    transportDimensions.length = y;
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка, вы ввели неправильное значение");
                                }
                                break;
                        }
                        break;
                    case 9:
                        Console.WriteLine("Введите индекс поля состава, которое хотите изменить(>=0&&<=10)");
                        m = Convert.ToInt32(Checks.CheckSingleInput());
                        Console.WriteLine("Введите часть состава");
                        this[m - 1] = Checks.CheckSingleStringInput(); ;
                        break;
                     default: break;
            }
                Console.WriteLine("");
            }
            public void Modification(int n, int m)
            {
                if (n == 8)
                {

                    switch (m)
                    {
                        case 1:
                            Console.WriteLine("Введите ширину");
                            double y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                            if (y > 0)
                            {
                                transportDimensions.width = y;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка, вы ввели неправильное значение");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Введите высоту");
                            y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                            if (y > 0)
                            {
                                transportDimensions.height = y;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка, вы ввели неправильное значение");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Введите длину"); y = Convert.ToDouble(Checks.CheckSingleDoubleInput());
                            if (y > 0)
                            {
                                transportDimensions.length = y;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка, вы ввели неправильное значение");
                            }
                            break;
                        default: break;
                }
                }
                else if (n == 9)
                {
                    Console.WriteLine("Введите часть состава");
                    this[m - 1] = Checks.CheckSingleStringInput(); ;
                }
                Console.WriteLine("");
            }
            private string[] composition = { "empty", "empty", "empty", "empty", "empty", "empty", "empty", "empty", "empty", "empty" };
            public string this[int index]
            {
                get
                {
                    if (index >= 0 && index < 10)
                    {
                        return composition[index];
                    }
                    else
                    {
                        Console.WriteLine("Ошибка, вы ввели неправильный индекс, индексатор вернёт error");
                        return "error";
                    }
                }
                set
                {
                    if (index >= 0 && index < 10)
                    {
                        composition[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка, вы ввели неправильный индекс");
                    }
                }
            }
            public static void Version()
            {
                Console.WriteLine("Это первая версия класса транспорта, она была создана 23.02.2020");
                Console.WriteLine("");
            }
            public string Mark { get; set; } = "empty";
            private double maxSpeed = 0;
            public double MaxSpeed
            {

                get
                {
                    return maxSpeed;
                }

                private set
                {
                    if (value > 0)
                    {
                        maxSpeed = value;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка, вы ввели неправильное значение");
                    }
                }
            }
            public string Color { get; set; } = "empty";
            private double weight = 0;
            public double Weight
            {
                get
                {
                    return weight;
                }
                private set
                {
                    if (value > 0)
                    {
                        Weight = value;

                    }
                    else
                    {
                        Console.WriteLine("Ошибка, вы ввели неправильное значение");
                    }
                }
            }
            private Dimensions transportDimensions = new Dimensions(0);
            private int numberOfSeats = 0;
            public int NumberOfSeats
            {
                get
                {
                    return numberOfSeats;
                }
                private set
                {
                    if (value > 0)
                    {
                        NumberOfSeats = value;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка, вы ввели неправильное значение");
                    }
                }
            }

            private static int totalAmount = 0;
            public static int TotalAmount => totalAmount;
            private readonly int id;

            private string Name { get; set; } = "empty";
            public int GetId()
            {
                return id;
            }
            public double GetLength()
            {
                return transportDimensions.length;
            }
            public double GetWidth()
            {
                return transportDimensions.width;
            }
            public double GetHeight()
            {
                return transportDimensions.height;
            }


        };
    
}
