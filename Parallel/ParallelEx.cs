using System;
using System.Collections.Generic;
using Vaetech.Data.ContentResult;
using Tasks = System.Threading.Tasks;

namespace Vaetech.Threading.Task
{
    public enum TypeProcess
    {
        Default = 0,
        /// <summary>
        /// Run everything at the same time.
        /// </summary>
        RunAll = 0,
        /// <summary>
        /// Run in order of entry.
        /// </summary>
        RunInOrder
    }
    public class ParallelEx
    {
        public static void Invoke(params Action[] actions) => Invoke(TypeProcess.Default, actions);
        public static void Invoke(TypeProcess typeProcess, params Action[] actions)
        {
            switch (typeProcess)
            {
                case TypeProcess.RunInOrder:
                    {                        
                        foreach (Action action in actions)
                            Tasks.Task.Run(() => Invoke(action)).Wait();
                    }
                    break;
                case TypeProcess.RunAll:
                default:
                    {
                        List<Tasks.Task> tasks = new List<Tasks.Task>();

                        foreach (Action action in actions)
                            tasks.Add(Tasks.Task.Factory.StartNew(action));

                        Tasks.Task.WaitAll(tasks.ToArray());
                    }
                    break;
            }
        }
        public static ActionResult Invoke(Action action) => Invoke<Exception>(action,out Exception exception);
        public static ActionResult Invoke<TException>(Action action, out TException exception) where TException : Exception
        {
            try
            {
                action();
                return new ActionResult(false,(exception = null)?.Message);
            }
            catch (TException ex)
            {
                return new ActionResult(true, (exception = ex).Message);
            }
        }

        public static void Invoke<T>(params Func<T>[] actions) => Invoke<T>(TypeProcess.Default,actions);
        public static void Invoke<T>(TypeProcess typeProcess, params Func<T>[] actions)
        {
            switch (typeProcess)
            {
                case TypeProcess.RunInOrder:
                    {                        
                        foreach(Func<T> action in actions)
                            Tasks.Task.Run(() => Invoke<T>(action)).Wait();
                    }
                    break;
                case TypeProcess.RunAll:
                default:
                    {
                        List<Tasks.Task> tasks = new List<Tasks.Task>();

                        foreach (Func<T> action in actions)                        
                            tasks.Add(Tasks.Task.Factory.StartNew(action));                                                                            
                                                
                        Tasks.Task.WaitAll(tasks.ToArray());
                    }
                    break;
            }
        }
        public static ActionResult<T> Invoke<T>(Func<T> action) => Invoke<T, Exception>(action);
        public static ActionResult<T> Invoke<T, TException>(Func<T> action) where TException : Exception
        {
            try
            {
                T value = action();
                return new ActionResult<T>(value);
            }
            catch (TException ex)
            {
                return new ActionResult<T>(default(T), true, ex.Message);
            }
        }

        public static async Tasks.Task InvokeAsync(params Func<Tasks.Task>[] actions) => await InvokeAsync(TypeProcess.Default, actions);
        public static async Tasks.Task InvokeAsync(TypeProcess typeProcess, params Func<Tasks.Task>[] actions)
        {
            switch (typeProcess)
            {
                case TypeProcess.RunInOrder:
                    {
                        foreach (Func<Tasks.Task> action in actions)
                            await InvokeAsync<Exception>(action);
                    }
                    break;
                case TypeProcess.RunAll:
                default:
                    {
                        List<Tasks.Task> tasks = new List<Tasks.Task>();

                        foreach (Func<Tasks.Task> action in actions)
                            tasks.Add(InvokeAsync<Exception>(action));

                        await Tasks.Task.WhenAll(tasks);
                    }
                    break;
            }
        }
        public static async Tasks.Task<ActionResult> InvokeAsync(Func<Tasks.Task> action) => await InvokeAsync<Exception>(action);
        public static async Tasks.Task<ActionResult> InvokeAsync<TException>(Func<Tasks.Task> action) where TException : Exception
        {
            try
            {
                await action();
                return new ActionResult();
            }
            catch (TException ex)
            {
                return new ActionResult(true, ex.Message);
            }
        }

        public static async Tasks.Task InvokeAsync<T>(params Func<Tasks.Task<T>>[] actions) => await InvokeAsync(TypeProcess.Default, actions);
        public static async Tasks.Task InvokeAsync<T>(TypeProcess typeProcess, params Func<Tasks.Task<T>>[] actions)
        {
            switch (typeProcess)
            {
                case TypeProcess.RunInOrder:
                    {
                        foreach (Func<Tasks.Task<T>> action in actions)
                            await InvokeAsync<T, Exception>(action);
                    }
                    break;
                case TypeProcess.RunAll:
                default:
                    {
                        List<Tasks.Task> tasks = new List<Tasks.Task>();

                        foreach (Func<Tasks.Task<T>> action in actions)
                            tasks.Add(InvokeAsync<T, Exception>(action));

                        await Tasks.Task.WhenAll(tasks);
                    }
                    break;
            }
        }
        public static async Tasks.Task<ActionResult<T>> InvokeAsync<T>(Func<Tasks.Task<T>> action)
            => await InvokeAsync<T, Exception>(action);
        public static async Tasks.Task<ActionResult<T>> InvokeAsync<T, TException>(Func<Tasks.Task<T>> action) where TException : Exception
        {
            try
            {
                T value = await action();
                return new ActionResult<T>(value);
            }
            catch (TException ex)
            {
                return new ActionResult<T>(default(T), true, ex.Message);
            }
        }
    }
}
