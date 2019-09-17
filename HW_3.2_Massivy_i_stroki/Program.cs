using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ввести с клавиатуры номер трамвайного билета(6-значное число) 
//и про-верить является ли данный билет счастливым(если на билете напечатано шестизначное число, 
//и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).



namespace HW_3._2_Massivy_i_stroki
{
    class Program
    {
        static void Main(string[] args)
        {
            var Sum1 = 0; var Sum2 = 0;
            int[] ticket = new int[6];
            bool[] isInt = new bool[6];
            int length = 0;
            Console.WriteLine("Введите номер трамвайного билета: ");
            do
            {
                isInt[0] = int.TryParse(Console.ReadKey().KeyChar.ToString(), out ticket[0]);
                isInt[1] = int.TryParse(Console.ReadKey().KeyChar.ToString(), out ticket[1]);
                isInt[2] = int.TryParse(Console.ReadKey().KeyChar.ToString(), out ticket[2]);
                isInt[3] = int.TryParse(Console.ReadKey().KeyChar.ToString(), out ticket[3]);
                isInt[4] = int.TryParse(Console.ReadKey().KeyChar.ToString(), out ticket[4]);
                isInt[5] = int.TryParse(Console.ReadKey().KeyChar.ToString(), out ticket[5]);
                foreach (bool check in isInt)
                {
                    if (check) { length++; }
                }
                if (length == 6)
                {
                    Sum1 = ticket[0] + ticket[1] + ticket[2];
                    Sum2 = ticket[3] + ticket[4] + ticket[5];
                    if (Sum1 == Sum2) Console.WriteLine("\nПоздравляем! Вы обладатель счастливого билета!");
                    else Console.WriteLine("\nУ вас обычный билет. Попробуйте в следующий раз.");
                }
                else
                {
                    Console.WriteLine("\nВы ввели символы, вместо цифр. Прошу введите номер билета снова: ");
                    length = 0;
                }
            }
            while (length != 6);
            Console.ReadKey();
        }
    }
}
