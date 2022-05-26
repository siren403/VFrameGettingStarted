using UnityEngine;
using VFrame.UI.View;

public class FirstView : ComponentView<FirstView>
{
    public override void OnEnter()
    {
        Debug.Log("Hello World");
    }

    public override void OnExit()
    {
    }
}

