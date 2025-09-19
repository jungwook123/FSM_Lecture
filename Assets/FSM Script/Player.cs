using UnityEngine;

public class Player : MonoBehaviour
{
    private Context _context;

    private void Start()
    {
        _context = new Context(new DebugState());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _context.ChangeState(new AnotherState());
        }
            
        _context.Update();
    }
    
}
