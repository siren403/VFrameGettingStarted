using Cysharp.Threading.Tasks;
using VContainer;
using VContainer.Unity;
using VFrame.UI.Animation;
using VFrame.UI.Extension;
using VFrame.UI.External;
using VFrame.UI.View;

public class RootScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.UseUISystem();
        
        builder.RegisterViewDefaultAnimation<FadeAnimation<IView>>();
    }
}

