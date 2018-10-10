using System.Collections.Generic;
using System.Reflection;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Logging;

namespace mvvmcrosstabs.Droid
{
    public class Setup : MvxAppCompatSetup<App>
    {
        protected override IEnumerable<Assembly> AndroidViewAssemblies =>
            new List<Assembly>(base.AndroidViewAssemblies)
            {
                typeof(MvxRecyclerView).Assembly
            };

        //public override MvxLogProviderType GetDefaultLogProviderType()
        //=> MvxLogProviderType.Serilog;

        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {

            base.FillTargetFactories(registry);
        }
    }
}
