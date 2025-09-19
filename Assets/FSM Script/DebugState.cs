using UnityEngine;

public class DebugState : State
{
    public override void Enter()
    {
        Debug.Log("On Enter");
    }

    public override void Update()
    {
        Debug.Log("On Update");
    }

    public override void Exit()
    {
        Debug.Log("On Exit");
    }
}
