namespace Ninject.Web.WebApi.BindingActivationLogger
{
    using Ninject.Activation.Strategies;
    using Ninject.Modules;

    /// <summary>
    /// Module for loading the binding activation logger
    /// </summary>
    public class MissingBindingLoggerModule : NinjectModule
    {
        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            Kernel.Components.Add<IActivationStrategy, ActivationLogger>();
        }
    }
}