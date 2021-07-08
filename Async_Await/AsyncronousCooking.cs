using Async_Await.BreakfastElements;
using System;
using System.Threading.Tasks;

namespace Async_Await
{
    class AsyncronousCooking
    {

        public async void SimpleCookAsync()
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            // Сохраним задачи для отдельных операций при их запуске, чтобы не ждать их
            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);
            
            Egg eggs = await eggsTask;
            Console.WriteLine("eggs are ready");
            
            Bacon bacon = await baconTask;
            Console.WriteLine("bacon is ready");

            var toast = await toastTask;
            Console.WriteLine("toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");

            Console.WriteLine("Breakfast is ready!");
        }

        public void CookAsync()
        {

        }

        // Асинхронная работа, которая включает синхронные операции, которым нужен результат из асинхрона
        private async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

        private void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");

        private void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");

        private Task<Toast> ToastBreadAsync(int slices)
            => (Task<Toast>)Task.Run(() => 
            {
                for (int slice = 0; slice < slices; slice++)
                {
                    Console.WriteLine("Putting a slice of bread in the toaster");
                }
                Console.WriteLine("Start toasting...");
                Task.Delay(3000).Wait();
                Console.WriteLine("Remove toast from toaster");
            });

        private Task<Bacon> FryBaconAsync(int slices)
            => (Task<Bacon>)Task.Run(() => 
            {
                Console.WriteLine($"putting {slices} slices of bacon in the pan");
                Console.WriteLine("cooking first side of bacon...");
                Task.Delay(3000).Wait();
                for (int slice = 0; slice < slices; slice++)
                {
                    Console.WriteLine("flipping a slice of bacon");
                }
                Console.WriteLine("cooking the second side of bacon...");
                Task.Delay(3000).Wait();
                Console.WriteLine("Put bacon on plate");
            });

        private Task<Egg> FryEggsAsync(int howMany)
            => (Task<Egg>)Task.Run( () => 
            {
                Console.WriteLine("Warming the egg pan...");
                Task.Delay(3000).Wait();
                Console.WriteLine($"cracking {howMany} eggs");
                Console.WriteLine("cooking the eggs ...");
                Task.Delay(3000).Wait();
                Console.WriteLine("Put eggs on plate");
            });

        private Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }


    }
}
