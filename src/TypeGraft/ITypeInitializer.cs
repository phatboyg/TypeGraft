namespace TypeGraft
{
    using System;
    using System.Threading.Tasks;

    public interface ITypeInitializer<TResult> :
        ITypeInitializer
    {
        Task<TResult> Initialize();
    }

    public interface ITypeInitializer
    {
        Type ResultType { get; }
    }
}
