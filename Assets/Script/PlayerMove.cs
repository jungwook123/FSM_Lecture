using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Debug.Log(x);
        Debug.Log(y);
        Debug.DrawRay(transform.position, new Vector3(x,y, transform.position.z).normalized*5);
        gameObject.transform.Translate(new Vector3(x, y, 0).normalized * (moveSpeed * Time.deltaTime));
    }
}
