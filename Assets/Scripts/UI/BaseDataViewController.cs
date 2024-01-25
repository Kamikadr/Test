using ChooseAndShowTemplate.Interfaces;
using UnityEngine;

namespace ChooseAndShowTemplate.UI
{
    public abstract class BaseDataViewController<T>: MonoBehaviour
    {
        protected IListenDataViewModel<T>  ViewModel;
        public void Initialize(IListenDataViewModel<T> viewModel)
        {
            ViewModel = viewModel;
        }

        protected virtual void OnEnable()
        {
            if (ViewModel != null)
            {
                ViewModel.OnViewModelChanged += OnViewModelChanged;
            }
        }
        protected virtual void OnDisable()
        {
            if (ViewModel != null)
            {
                ViewModel.OnViewModelChanged -= OnViewModelChanged;
            }
        }
        
        protected abstract void OnViewModelChanged(T viewModel);
    }
}