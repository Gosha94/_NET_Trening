using ExceptionsLearn.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            // ДЗ создать свой класс исключения
            // Сгенерировать свое исключение
            // Добавить проверку в работе с классами try/catch/catch/catch/catch/finally
            // Отловить свое и другие исключения

            
            int y = 5;

            try
            {
                //int i = 5;
                //int j = i / 0;
                //Console.WriteLine(j);

                //int a = 300000;
                //int b = 300000;
                //// ключевое слово checked исп. для выдачи исключения 
                //// при переполнении MaxValue для типа данных, иначе данные обрежутся
                //int c = checked(a * b);
                //double d = checked(4567.432 * 567.322);

                throw new MyException();
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Деление на ноль!" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Какое-то исключение: " + ex.Message);
                throw; // передает исключение на уровень вызова этого кода, если это библиотека например
            }
            // Данный блок исп. для закрытия файлов, потоков и др. операций
            // После сработки блока catch
            finally
            {
                Console.WriteLine("Возникло исключение, а это блок finally. Работа завершается");
                Console.ReadLine();
            }
        }
    }
}
