namespace Lands.Infrastructure
{
    using ViewModels;

     class InstanceLocator
    {
        #region Propierties
            public MainViewModel Main
            {
                get;
                set;
            }
        #endregion

        #region Constructors
            public InstanceLocator()
            {
            this.Main = new MainViewModel();
            }
        #endregion
    }
}
