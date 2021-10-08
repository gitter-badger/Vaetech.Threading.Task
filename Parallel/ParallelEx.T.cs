using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vaetech.Data.ContentResult.Events;

namespace Vaetech.Threading.Task
{
    public class ParallelEx<T>
    {
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandler;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerOne;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerTwo;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerThree;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerFour;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerFive;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerSix;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerSeven;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerEight;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerNine;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerTen;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerEleven;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerTwelve;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerThirteen;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerFourteen;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerFifteen;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerSixteen;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerSeventeen;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerEighteen;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerNineteen;
        public event DynamicEventHandler<IEnumerable<T>> _dynamicEventHandlerTwenty;
        public void InitParallel(Processors processors, List<T> list)
        {
            if (list == null)
                return;

            if (processors == Processors.None)
                processors = Processors.One;

            var proceso = (int)processors == 0 ? 0 : Convert.ToInt32(list.Count / (int)processors);

            switch (processors)
            {
                case Processors.One:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list)
                        );
                    }
                    break;
                case Processors.Two:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), list.Count - (proceso * 1)))
                        );
                    }
                    break;
                case Processors.Three:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), list.Count - (proceso * 2)))
                        );
                    }
                    break;
                case Processors.Four:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), proceso)),
                            () => OnSendParameters(4, list.GetRange((proceso * 3), list.Count - (proceso * 3)))
                        );
                    }
                    break;
                case Processors.Five:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), proceso)),
                            () => OnSendParameters(4, list.GetRange((proceso * 3), proceso)),
                            () => OnSendParameters(5, list.GetRange((proceso * 4), list.Count - (proceso * 4)))
                        );
                    }
                    break;
                case Processors.Six:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), proceso)),
                            () => OnSendParameters(4, list.GetRange((proceso * 3), proceso)),
                            () => OnSendParameters(5, list.GetRange((proceso * 4), proceso)),
                            () => OnSendParameters(6, list.GetRange((proceso * 5), list.Count - (proceso * 5)))
                        );
                    }
                    break;
                case Processors.Seven:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), proceso)),
                            () => OnSendParameters(4, list.GetRange((proceso * 3), proceso)),
                            () => OnSendParameters(5, list.GetRange((proceso * 4), proceso)),
                            () => OnSendParameters(6, list.GetRange((proceso * 5), proceso)),
                            () => OnSendParameters(7, list.GetRange((proceso * 6), list.Count - (proceso * 6)))
                        );
                    }
                    break;
                case Processors.Eight:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), proceso)),
                            () => OnSendParameters(4, list.GetRange((proceso * 3), proceso)),
                            () => OnSendParameters(5, list.GetRange((proceso * 4), proceso)),
                            () => OnSendParameters(6, list.GetRange((proceso * 5), proceso)),
                            () => OnSendParameters(7, list.GetRange((proceso * 6), proceso)),
                            () => OnSendParameters(8, list.GetRange((proceso * 7), list.Count - (proceso * 7)))
                        );
                    }
                    break;
                case Processors.Nine:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), proceso)),
                            () => OnSendParameters(4, list.GetRange((proceso * 3), proceso)),
                            () => OnSendParameters(5, list.GetRange((proceso * 4), proceso)),
                            () => OnSendParameters(6, list.GetRange((proceso * 5), proceso)),
                            () => OnSendParameters(7, list.GetRange((proceso * 6), proceso)),
                            () => OnSendParameters(8, list.GetRange((proceso * 7), proceso)),
                            () => OnSendParameters(9, list.GetRange((proceso * 8), list.Count - (proceso * 8)))
                        );
                    }
                    break;
                case Processors.Ten:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), proceso)),
                            () => OnSendParameters(4, list.GetRange((proceso * 3), proceso)),
                            () => OnSendParameters(5, list.GetRange((proceso * 4), proceso)),
                            () => OnSendParameters(6, list.GetRange((proceso * 5), proceso)),
                            () => OnSendParameters(7, list.GetRange((proceso * 6), proceso)),
                            () => OnSendParameters(8, list.GetRange((proceso * 7), proceso)),
                            () => OnSendParameters(9, list.GetRange((proceso * 8), proceso)),
                            () => OnSendParameters(10, list.GetRange((proceso * 9), list.Count - (proceso * 9)))
                        );
                    }
                    break;
                case Processors.Eleven:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), proceso)),
                            () => OnSendParameters(4, list.GetRange((proceso * 3), proceso)),
                            () => OnSendParameters(5, list.GetRange((proceso * 4), proceso)),
                            () => OnSendParameters(6, list.GetRange((proceso * 5), proceso)),
                            () => OnSendParameters(7, list.GetRange((proceso * 6), proceso)),
                            () => OnSendParameters(8, list.GetRange((proceso * 7), proceso)),
                            () => OnSendParameters(9, list.GetRange((proceso * 8), proceso)),
                            () => OnSendParameters(10, list.GetRange((proceso * 9), proceso)),
                            () => OnSendParameters(11, list.GetRange((proceso * 10), list.Count - (proceso * 10)))
                        );
                    }
                    break;
                case Processors.Twelve:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), proceso)),
                            () => OnSendParameters(4, list.GetRange((proceso * 3), proceso)),
                            () => OnSendParameters(5, list.GetRange((proceso * 4), proceso)),
                            () => OnSendParameters(6, list.GetRange((proceso * 5), proceso)),
                            () => OnSendParameters(7, list.GetRange((proceso * 6), proceso)),
                            () => OnSendParameters(8, list.GetRange((proceso * 7), proceso)),
                            () => OnSendParameters(9, list.GetRange((proceso * 8), proceso)),
                            () => OnSendParameters(10, list.GetRange((proceso * 9), proceso)),
                            () => OnSendParameters(11, list.GetRange((proceso * 10), proceso)),
                            () => OnSendParameters(12, list.GetRange((proceso * 11), list.Count - (proceso * 11)))
                        );
                    }
                    break;
                case Processors.Thirteen:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), proceso)),
                            () => OnSendParameters(4, list.GetRange((proceso * 3), proceso)),
                            () => OnSendParameters(5, list.GetRange((proceso * 4), proceso)),
                            () => OnSendParameters(6, list.GetRange((proceso * 5), proceso)),
                            () => OnSendParameters(7, list.GetRange((proceso * 6), proceso)),
                            () => OnSendParameters(8, list.GetRange((proceso * 7), proceso)),
                            () => OnSendParameters(9, list.GetRange((proceso * 8), proceso)),
                            () => OnSendParameters(10, list.GetRange((proceso * 9), proceso)),
                            () => OnSendParameters(11, list.GetRange((proceso * 10), proceso)),
                            () => OnSendParameters(12, list.GetRange((proceso * 11), proceso)),
                            () => OnSendParameters(13, list.GetRange((proceso * 12), list.Count - (proceso * 12)))
                        );
                    }
                    break;
                case Processors.Fourteen:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), proceso)),
                            () => OnSendParameters(4, list.GetRange((proceso * 3), proceso)),
                            () => OnSendParameters(5, list.GetRange((proceso * 4), proceso)),
                            () => OnSendParameters(6, list.GetRange((proceso * 5), proceso)),
                            () => OnSendParameters(7, list.GetRange((proceso * 6), proceso)),
                            () => OnSendParameters(8, list.GetRange((proceso * 7), proceso)),
                            () => OnSendParameters(9, list.GetRange((proceso * 8), proceso)),
                            () => OnSendParameters(10, list.GetRange((proceso * 9), proceso)),
                            () => OnSendParameters(11, list.GetRange((proceso * 10), proceso)),
                            () => OnSendParameters(12, list.GetRange((proceso * 11), proceso)),
                            () => OnSendParameters(13, list.GetRange((proceso * 12), proceso)),
                            () => OnSendParameters(14, list.GetRange((proceso * 13), list.Count - (proceso * 13)))
                        );
                    }
                    break;
                case Processors.Fifteen:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), proceso)),
                            () => OnSendParameters(4, list.GetRange((proceso * 3), proceso)),
                            () => OnSendParameters(5, list.GetRange((proceso * 4), proceso)),
                            () => OnSendParameters(6, list.GetRange((proceso * 5), proceso)),
                            () => OnSendParameters(7, list.GetRange((proceso * 6), proceso)),
                            () => OnSendParameters(8, list.GetRange((proceso * 7), proceso)),
                            () => OnSendParameters(9, list.GetRange((proceso * 8), proceso)),
                            () => OnSendParameters(10, list.GetRange((proceso * 9), proceso)),
                            () => OnSendParameters(11, list.GetRange((proceso * 10), proceso)),
                            () => OnSendParameters(12, list.GetRange((proceso * 11), proceso)),
                            () => OnSendParameters(13, list.GetRange((proceso * 12), proceso)),
                            () => OnSendParameters(14, list.GetRange((proceso * 13), proceso)),
                            () => OnSendParameters(15, list.GetRange((proceso * 14), list.Count - (proceso * 14)))
                        );
                    }
                    break;
                case Processors.Sixteen:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), proceso)),
                            () => OnSendParameters(4, list.GetRange((proceso * 3), proceso)),
                            () => OnSendParameters(5, list.GetRange((proceso * 4), proceso)),
                            () => OnSendParameters(6, list.GetRange((proceso * 5), proceso)),
                            () => OnSendParameters(7, list.GetRange((proceso * 6), proceso)),
                            () => OnSendParameters(8, list.GetRange((proceso * 7), proceso)),
                            () => OnSendParameters(9, list.GetRange((proceso * 8), proceso)),
                            () => OnSendParameters(10, list.GetRange((proceso * 9), proceso)),
                            () => OnSendParameters(11, list.GetRange((proceso * 10), proceso)),
                            () => OnSendParameters(12, list.GetRange((proceso * 11), proceso)),
                            () => OnSendParameters(13, list.GetRange((proceso * 12), proceso)),
                            () => OnSendParameters(14, list.GetRange((proceso * 13), proceso)),
                            () => OnSendParameters(15, list.GetRange((proceso * 14), proceso)),
                            () => OnSendParameters(16, list.GetRange((proceso * 15), list.Count - (proceso * 15)))
                        );
                    }
                    break;
                case Processors.Seventeen:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), proceso)),
                            () => OnSendParameters(4, list.GetRange((proceso * 3), proceso)),
                            () => OnSendParameters(5, list.GetRange((proceso * 4), proceso)),
                            () => OnSendParameters(6, list.GetRange((proceso * 5), proceso)),
                            () => OnSendParameters(7, list.GetRange((proceso * 6), proceso)),
                            () => OnSendParameters(8, list.GetRange((proceso * 7), proceso)),
                            () => OnSendParameters(9, list.GetRange((proceso * 8), proceso)),
                            () => OnSendParameters(10, list.GetRange((proceso * 9), proceso)),
                            () => OnSendParameters(11, list.GetRange((proceso * 10), proceso)),
                            () => OnSendParameters(12, list.GetRange((proceso * 11), proceso)),
                            () => OnSendParameters(13, list.GetRange((proceso * 12), proceso)),
                            () => OnSendParameters(14, list.GetRange((proceso * 13), proceso)),
                            () => OnSendParameters(15, list.GetRange((proceso * 14), proceso)),
                            () => OnSendParameters(16, list.GetRange((proceso * 15), proceso)),
                            () => OnSendParameters(17, list.GetRange((proceso * 16), list.Count - (proceso * 16)))
                        );
                    }
                    break;
                case Processors.Eighteen:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), proceso)),
                            () => OnSendParameters(4, list.GetRange((proceso * 3), proceso)),
                            () => OnSendParameters(5, list.GetRange((proceso * 4), proceso)),
                            () => OnSendParameters(6, list.GetRange((proceso * 5), proceso)),
                            () => OnSendParameters(7, list.GetRange((proceso * 6), proceso)),
                            () => OnSendParameters(8, list.GetRange((proceso * 7), proceso)),
                            () => OnSendParameters(9, list.GetRange((proceso * 8), proceso)),
                            () => OnSendParameters(10, list.GetRange((proceso * 9), proceso)),
                            () => OnSendParameters(11, list.GetRange((proceso * 10), proceso)),
                            () => OnSendParameters(12, list.GetRange((proceso * 11), proceso)),
                            () => OnSendParameters(13, list.GetRange((proceso * 12), proceso)),
                            () => OnSendParameters(14, list.GetRange((proceso * 13), proceso)),
                            () => OnSendParameters(15, list.GetRange((proceso * 14), proceso)),
                            () => OnSendParameters(16, list.GetRange((proceso * 15), proceso)),
                            () => OnSendParameters(17, list.GetRange((proceso * 16), proceso)),
                            () => OnSendParameters(18, list.GetRange((proceso * 17), list.Count - (proceso * 17)))
                        );
                    }
                    break;
                case Processors.Nineteen:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), proceso)),
                            () => OnSendParameters(4, list.GetRange((proceso * 3), proceso)),
                            () => OnSendParameters(5, list.GetRange((proceso * 4), proceso)),
                            () => OnSendParameters(6, list.GetRange((proceso * 5), proceso)),
                            () => OnSendParameters(7, list.GetRange((proceso * 6), proceso)),
                            () => OnSendParameters(8, list.GetRange((proceso * 7), proceso)),
                            () => OnSendParameters(9, list.GetRange((proceso * 8), proceso)),
                            () => OnSendParameters(10, list.GetRange((proceso * 9), proceso)),
                            () => OnSendParameters(11, list.GetRange((proceso * 10), proceso)),
                            () => OnSendParameters(12, list.GetRange((proceso * 11), proceso)),
                            () => OnSendParameters(13, list.GetRange((proceso * 12), proceso)),
                            () => OnSendParameters(14, list.GetRange((proceso * 13), proceso)),
                            () => OnSendParameters(15, list.GetRange((proceso * 14), proceso)),
                            () => OnSendParameters(16, list.GetRange((proceso * 15), proceso)),
                            () => OnSendParameters(17, list.GetRange((proceso * 16), proceso)),
                            () => OnSendParameters(18, list.GetRange((proceso * 17), proceso)),
                            () => OnSendParameters(19, list.GetRange((proceso * 18), list.Count - (proceso * 18)))
                        );
                    }
                    break;
                case Processors.Twenty:
                    {
                        Parallel.Invoke(
                            () => OnSendParameters(1, list.GetRange((proceso * 0), proceso)),
                            () => OnSendParameters(2, list.GetRange((proceso * 1), proceso)),
                            () => OnSendParameters(3, list.GetRange((proceso * 2), proceso)),
                            () => OnSendParameters(4, list.GetRange((proceso * 3), proceso)),
                            () => OnSendParameters(5, list.GetRange((proceso * 4), proceso)),
                            () => OnSendParameters(6, list.GetRange((proceso * 5), proceso)),
                            () => OnSendParameters(7, list.GetRange((proceso * 6), proceso)),
                            () => OnSendParameters(8, list.GetRange((proceso * 7), proceso)),
                            () => OnSendParameters(9, list.GetRange((proceso * 8), proceso)),
                            () => OnSendParameters(10, list.GetRange((proceso * 9), proceso)),
                            () => OnSendParameters(11, list.GetRange((proceso * 10), proceso)),
                            () => OnSendParameters(12, list.GetRange((proceso * 11), proceso)),
                            () => OnSendParameters(13, list.GetRange((proceso * 12), proceso)),
                            () => OnSendParameters(14, list.GetRange((proceso * 13), proceso)),
                            () => OnSendParameters(15, list.GetRange((proceso * 14), proceso)),
                            () => OnSendParameters(16, list.GetRange((proceso * 15), proceso)),
                            () => OnSendParameters(17, list.GetRange((proceso * 16), proceso)),
                            () => OnSendParameters(18, list.GetRange((proceso * 17), proceso)),
                            () => OnSendParameters(19, list.GetRange((proceso * 18), proceso)),
                            () => OnSendParameters(20, list.GetRange((proceso * 19), list.Count - (proceso * 19)))
                        );
                    }
                    break;
            }
        }
        private void OnSendParameters(int process, IEnumerable<T> list)
        {
            if (_dynamicEventHandler != null)
                _dynamicEventHandler(this, new DynamicEventArgs<IEnumerable<T>>(list));

            switch ((Processors)process)
            {
                case Processors.One:
                    if (_dynamicEventHandlerOne != null)
                        _dynamicEventHandlerOne(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Two:
                    if (_dynamicEventHandlerTwo != null)
                        _dynamicEventHandlerTwo(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Three:
                    if (_dynamicEventHandlerThree != null)
                        _dynamicEventHandlerThree(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Four:
                    if (_dynamicEventHandlerFour != null)
                        _dynamicEventHandlerFour(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Five:
                    if (_dynamicEventHandlerFive != null)
                        _dynamicEventHandlerFive(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Six:
                    if (_dynamicEventHandlerSix != null)
                        _dynamicEventHandlerSix(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Seven:
                    if (_dynamicEventHandlerSeven != null)
                        _dynamicEventHandlerSeven(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Eight:
                    if (_dynamicEventHandlerEight != null)
                        _dynamicEventHandlerEight(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Nine:
                    if (_dynamicEventHandlerNine != null)
                        _dynamicEventHandlerNine(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Ten:
                    if (_dynamicEventHandlerTen != null)
                        _dynamicEventHandlerTen(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Eleven:
                    if (_dynamicEventHandlerEleven != null)
                        _dynamicEventHandlerEleven(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Twelve:
                    if (_dynamicEventHandlerTwelve != null)
                        _dynamicEventHandlerTwelve(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Thirteen:
                    if (_dynamicEventHandlerThirteen != null)
                        _dynamicEventHandlerThirteen(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Fourteen:
                    if (_dynamicEventHandlerFourteen != null)
                        _dynamicEventHandlerFourteen(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Fifteen:
                    if (_dynamicEventHandlerFifteen != null)
                        _dynamicEventHandlerFifteen(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Sixteen:
                    if (_dynamicEventHandlerSixteen != null)
                        _dynamicEventHandlerSixteen(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Seventeen:
                    if (_dynamicEventHandlerSeventeen != null)
                        _dynamicEventHandlerSeventeen(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Eighteen:
                    if (_dynamicEventHandlerEighteen != null)
                        _dynamicEventHandlerEighteen(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Nineteen:
                    if (_dynamicEventHandlerNineteen != null)
                        _dynamicEventHandlerNineteen(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
                case Processors.Twenty:
                    if (_dynamicEventHandlerTwenty != null)
                        _dynamicEventHandlerTwenty(this, new DynamicEventArgs<IEnumerable<T>>(list));
                    break;
            }
        }
    }
}
