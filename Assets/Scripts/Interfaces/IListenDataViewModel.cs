using System;

namespace ChooseAndShowTemplate.Interfaces
{
    public interface IListenDataViewModel<out T>
    {
        event Action<T> OnViewModelChanged;
    }
}