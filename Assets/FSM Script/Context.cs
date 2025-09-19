using UnityEngine;

public class Context 
{
    private State currentState;
    
    public Context(State initialState)
    {
        currentState = initialState;
        currentState.Enter();
    }

    public void ChangeState(State newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }

    public void Update()
    {
        currentState.Update();
    }
    
    
}
