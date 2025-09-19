using UnityEngine;

public class AnotherState : State
{
    public override void Enter()
    {
        Debug.Log("Another Entered");
    }

    public override void Update()
    {
        Debug.Log("Another Update");
    }

    public override void Exit()
    {
        Debug.Log("Another Exit");
    }
}
