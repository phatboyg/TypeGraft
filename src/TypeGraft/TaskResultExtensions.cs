namespace TypeGraft
{
    using System;
    using System.Threading.Tasks;

    public static class TaskResultExtensions
    {
        public static async Task<string> Select<T>(this Task<T> task, Func<T, string> selector)
            where T : class
        {
            var subject = await task.ConfigureAwait(false);

            return selector(subject);
        }

        public static async Task<string> Select<T>(this Task<T> task, Func<T, string> selector, string defaultValue)
            where T : class
        {
            var subject = await task.ConfigureAwait(false);

            return selector(subject) ?? defaultValue;
        }

        public static async Task<string> Select<T>(this Task<T> task, Func<T, string> selector, Func<string> getDefaultValue)
            where T : class
        {
            var subject = await task.ConfigureAwait(false);

            return selector(subject) ?? getDefaultValue();
        }

        public static async Task<string> Select<T>(this Task<T> task, Func<T, string> selector, Func<Task<string>> getDefaultValue)
            where T : class
        {
            var subject = await task.ConfigureAwait(false);

            return selector(subject) ?? await getDefaultValue().ConfigureAwait(false);
        }

        public static async Task<TResult> Select<T, TResult>(this Task<T> task, Func<T, TResult> selector)
            where T : class
            where TResult : struct
        {
            var subject = await task.ConfigureAwait(false);

            return selector(subject);
        }

        public static async Task<TResult?> Select<T, TResult>(this Task<T> task, Func<T, TResult?> selector)
            where T : class
            where TResult : struct
        {
            var subject = await task.ConfigureAwait(false);

            return selector(subject);
        }

        public static async Task<TResult> Select<T, TResult>(this Task<T> task, Func<T, TResult?> selector, TResult defaultValue)
            where T : class
            where TResult : struct
        {
            var subject = await task.ConfigureAwait(false);

            return selector(subject) ?? defaultValue;
        }

        public static async Task<TResult> Select<T, TResult>(this Task<T> task, Func<T, TResult?> selector, Func<TResult> getDefaultValue)
            where T : class
            where TResult : struct
        {
            var subject = await task.ConfigureAwait(false);

            return selector(subject) ?? getDefaultValue();
        }

        public static async Task<TResult> Select<T, TResult>(this Task<T> task, Func<T, TResult?> selector, Func<Task<TResult>> getDefaultValue)
            where T : class
            where TResult : struct
        {
            var subject = await task.ConfigureAwait(false);

            return selector(subject) ?? await getDefaultValue().ConfigureAwait(false);
        }
    }
}