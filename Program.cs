using System;

namespace ConsoleApp3
{//требования  : (несколько полей), свойств, !(методов), индексаторов; !(перегрузку методов), !(конструктора);!(реализовать статические элементы класса)
    class Program
    {
        static void StartOutput()
        {
            Console.WriteLine("Для добавления нового экземпляра класса введите 1");
            Console.WriteLine("Для добавления нового экземпляра класса с заданием его имени введите 2, затем введите имя");
            Console.WriteLine("Для просмотра текущей версии программы введите 3");
            Console.WriteLine("Для просмотра информации об транспорте введите 4, затем введите индекс нужного объекта");
            Console.WriteLine("Для модификации транспорта введите 5, затем введите индекс нужного объекта");
            Console.WriteLine("Для просмотра информации о поле транспорта c заданием номера поля введите 6, затем введите индекс нужного объекта и следуйте инструкции");
            Console.WriteLine("Для просмотра информации о поле габаритов или состава транспорта c заданием номера поля введите 7, затем введите индекс нужного объекта и следуйте инструкции");
            Console.WriteLine("Для модификации поля транспорта c заданием номера поля введите 8, затем введите индекс нужного объекта и следуйте инструкции");
            Console.WriteLine("Для модификации поля габаритов или состава транспорта c заданием номера поля введите 9, затем введите индекс нужного объекта и следуйте инструкции");
            Console.WriteLine("Для выхода из программы нажмите 10");
        }
        static void ViewOutput()
        {
            Console.WriteLine("Для просмотра id нажмите 1"); 
            Console.WriteLine("Для просмотра имени нажмите 2");
            Console.WriteLine("Для просмотра цвета нажмите 3");
            Console.WriteLine("Для просмотра веса нажмите 4");
            Console.WriteLine("Для просмотра количества мест нажмите 5");
            Console.WriteLine("Для просморта марки нажмите 6");
            Console.WriteLine("Для просмотра максимальной скорости нажмите 7");
            Console.WriteLine("Для просмотра габаритов нажмите 8");
            Console.WriteLine("Для промотра состава нажмите 9");
        }

       

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу работы с транспортом!");
            Console.WriteLine("Наш класс транспорта содержит:имя, цвет, уникальный id, количество мест, вес, максимальную скорость");
            Console.WriteLine("Так же у транспорта есть габариты(ширина,высота,длина),а внутренне устройство транспорта можно описать составом из 10 элементов");
            Console.WriteLine("Наша программа будет сообщать о количестве текущий экземпляров класса, так же класс транспорта содержит информацию о текущей версии программы");
            Transport[] transp = new Transport[1];
            while (true)
            {
                StartOutput();
                int a = Convert.ToInt32(Checks.CheckSingleInput());
                switch (a)
                {
                    case 1:
                        if (Transport.TotalAmount == 0)
                        {

                            transp[0] = new Transport();
                        }
                        else
                        {
                            Array.Resize(ref transp, transp.Length + 1);
                            transp[transp.Length - 1] = new Transport();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите имя");
                        string str = Checks.CheckSingleStringInput();
                        if (Transport.TotalAmount == 0)
                        {

                            transp[0] = new Transport(str);
                        }
                        else
                        {
                            Array.Resize(ref transp, transp.Length + 1);
                            transp[transp.Length - 1] = new Transport(str);
                        }
                        break;
                    case 3: Transport.Version(); break;
                    case 4: Console.WriteLine("Введите индекс объекта,о котором нужна информация (от 0 и до {0})", transp.Length-1);
                        int i = Convert.ToInt32(Checks.CheckSingleInput());
                        while (i < 0 || i > transp.Length - 1)
                        {
                            Console.WriteLine("Введите корректное значение индекса");
                            i = Convert.ToInt32(Checks.CheckSingleInput());
                        }
                        transp[i].Information(); break;
                    case 5: Console.WriteLine("Введите индекс объекта,который хотите изменить (от 0 и до {0})", transp.Length-1);
                        i = Convert.ToInt32(Checks.CheckSingleInput());
                        while (i < 0 || i > transp.Length - 1)
                        {
                            Console.WriteLine("Введите корректное значение индекса");
                            i = Convert.ToInt32(Checks.CheckSingleInput());
                        }
                        transp[i].Modification(); break;
                    case 6: Console.WriteLine("Введите индекс объекта, о котором нужна информация (от 0 и до {0})", transp.Length-1);
                        i = Convert.ToInt32(Checks.CheckSingleInput());
                        while (i < 0 || i > transp.Length - 1)
                        {
                            Console.WriteLine("Введите корректное значение индекса");
                            i = Convert.ToInt32(Checks.CheckSingleInput());
                        }
                        ViewOutput();  
                        int n = Convert.ToInt32(Checks.CheckSingleInput()); 
                        transp[i].Information(n); break;
                    case 7: Console.WriteLine("Введите индекс объекта,о котором нужна информация (от 0 и до {0})", transp.Length-1);
                        i = Convert.ToInt32(Checks.CheckSingleInput());
                        while (i < 0 || i > transp.Length - 1)
                        {
                            Console.WriteLine("Введите корректное значение индекса");
                            i = Convert.ToInt32(Checks.CheckSingleInput());
                        }
                        Console.WriteLine("Для изменения габаритов нажмите 8 и следуйте инструкции");
                        Console.WriteLine("Для изменения состава нажмите 9 и следуйте инструкции");
                        n = Convert.ToInt32(Checks.CheckSingleInput()); 
                        if (n == 8)
                        {
                            Console.WriteLine("Для просмотра ширины нажмите 1");
                            Console.WriteLine("Для просмотра высоты нажмите 2");
                            Console.WriteLine("Для просмотра длины нажмите 3");

                        }
                        if (n == 9)
                        {
                            Console.WriteLine("Введите индекс поля состава, которое хотите просмотреть(>=0&&<=10)");
                        }
                        int m = Convert.ToInt32(Checks.CheckSingleInput()); 
                        transp[i].Information(n,m); break;
                    case 8:
                        Console.WriteLine("Введите индекс объекта,который хотите изменить (от 0 и до {0})",transp.Length-1);
                        i = Convert.ToInt32(Checks.CheckSingleInput());
                        while (i < 0 || i > transp.Length - 1)
                        {
                            Console.WriteLine("Введите корректное значение индекса");
                            i = Convert.ToInt32(Checks.CheckSingleInput());
                        }
                        Transport.ModificationOutput(); 
                        n = Convert.ToInt32(Checks.CheckSingleInput()); 
                        transp[i].Modification(n); break;
                    case 9:
                        Console.WriteLine("Введите индекс объекта,который хотите изменить (от 0 и до {0})", transp.Length-1);
                        i = Convert.ToInt32(Checks.CheckSingleInput());
                        while (i < 0 || i > transp.Length - 1)
                        {
                            Console.WriteLine("Введите корректное значение индекса");
                            i = Convert.ToInt32(Checks.CheckSingleInput());
                        }
                        Console.WriteLine("Для изменения габаритов нажмите 8 и следуйте инструкции");
                        Console.WriteLine("Для изменения состава нажмите 9 и следуйте инструкции"); 
                        n = Convert.ToInt32(Checks.CheckSingleInput());
                        if (n == 8)
                        {
                            Transport.ModificationOutput2();
                        }
                        if (n == 9)
                        {
                            Console.WriteLine("Введите индекс поля состава, которое хотите изменить(>=0&&<=10)");
                        }
                        m = Convert.ToInt32(Console.ReadLine()); 
                        transp[i].Modification(n, m); break;
                    case 10: return;
                }
            }


        }
    }
}
