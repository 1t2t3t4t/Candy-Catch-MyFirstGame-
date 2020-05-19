using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed;

    [SerializeField] 
    private float MaxPos;
    
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

        var position = transform.position;
        position += Vector3.right * (xMovement * MoveSpeed * Time.deltaTime);
        
        var clampedPosX = Mathf.Clamp(position.x, -MaxPos, MaxPos);
        position.x = clampedPosX;
        
        transform.position = position;
    }
}
