using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace MvvmCrossDialogFragment.Core.ViewModels
{
    public class ModalViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public ModalViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            CloseCommand = new MvxAsyncCommand(async () => await _navigationService.Close(this));
        }

        public override System.Threading.Tasks.Task Initialize()
        {
            return base.Initialize();
        }

        public void Init()
        {
        }

        public override void Start()
        {
            base.Start();
        }

        public IMvxAsyncCommand CloseCommand { get; private set; }


    }
}
