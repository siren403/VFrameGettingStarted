using UnityEngine;
using VContainer;
using VContainer.Unity;
using VFrame.Scene;
using VFrame.UI;

public class GameScope : SceneScope<GameScene>
{
    protected override void Configure(IContainerBuilder builder)
    {
        base.Configure(builder);
    }
}

public class GameScene : SceneEntry, ITickable
{
    public GameScene(IObjectResolver resolver) : base(resolver)
    {
    }

    public override void Initialize()
    {
        UISystem.Entry<FirstView>();
    }

    public void Tick()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            UISystem.To<SecondView>();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UISystem.Back();
        }
    }

    protected override void OnDisposed()
    {
    }
}