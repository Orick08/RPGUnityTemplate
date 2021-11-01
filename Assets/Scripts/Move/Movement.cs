using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
  public float speed = 8f;
  public float speedMultiplier = 1f;
  //Change this variable for move
  public Vector2 direction = Vector2.zero;
  public new Rigidbody2D rigidbody { get; private set; }
  private Animator animator;

  private void Awake()
  {
    rigidbody = GetComponent<Rigidbody2D>();
    animator = GetComponent<Animator>();
  }

  private void FixedUpdate()
  {
    if (direction == Vector2.zero)
    {
      animator.SetBool("isMoving", true);
    }
    else
    {
      animator.SetBool("isMoving", false);
      animator.SetFloat("x", direction.x);
      animator.SetFloat("y", direction.y);
    }
    Vector2 position = rigidbody.position;
    Vector2 translation = direction * speed * speedMultiplier * Time.fixedDeltaTime;
    rigidbody.MovePosition(position + translation);
  }
}
