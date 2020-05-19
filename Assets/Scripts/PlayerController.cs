using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed;
    
    private bool _canMove = true;

    private void Update()
    {
        if (_canMove)
        {
            _move();
        }
    }

    private void _move()
    {
        var xMovement = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * (xMovement * MoveSpeed * Time.deltaTime); 
    }
}
