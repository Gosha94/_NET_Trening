using System;
using System.Diagnostics;

namespace ValueVsReferenceCollections.Helpers
{

    /// <summary>
    /// Класс времени выполнения операции кода
    /// </summary>
    internal class OperationTimer : IDisposable
    {

        private Stopwatch _stopwatch;
        private string _text;
        private int _collectionCount;

        public OperationTimer(string text)
        {
            PrepareForOperation();

            this._text = text;
            this._collectionCount = GC.CollectionCount(0);

            // Команда должна быть последней в методе для точного старта отсчета
            this._stopwatch = Stopwatch.StartNew();
        }

        public void Dispose()
        {
            //Console.WriteLine($"{0} (GCs = {1,3}) {2}");
            Console.WriteLine("{0} (GCs = {1,3}) {2}", (this._stopwatch.Elapsed), GC.CollectionCount(0) - this._collectionCount, this._text );
        }

        private static void PrepareForOperation()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

    }
}