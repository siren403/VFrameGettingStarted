using Cysharp.Threading.Tasks;
using UnityEngine;
using VFrame.UI.View;

public class SecondView : ComponentView<SecondView>
{
    public override UniTask Ready()
    {
        PositionZero();
        return UniTask.CompletedTask;
    }

    public override void OnEnter()
    {
        Debug.Log(nameof(SecondView));
    }

    public override void OnExit()
    {
    }
}