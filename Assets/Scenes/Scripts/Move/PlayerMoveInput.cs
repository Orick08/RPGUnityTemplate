using UnityEngine;

[RequireComponent(typeof(Movement))]
public class PlayerMoveInput : MonoBehaviour
{
  public Movement movement { get; private set; }

  private void Awake()
  {
    movement = GetComponent<Movement>();
  }

  void Update()
  {
    if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
    {
      movement.direction = Vector2.up;
    }
    else if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W))
    {
      movement.direction = Vector2.down;
    }
    else if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
    {
      movement.direction = Vector2.left;
    }
    else if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
    {
      movement.direction = Vector2.right;
    }
    else
    {
      movement.direction = Vector2.zero;
    }
  }
}
