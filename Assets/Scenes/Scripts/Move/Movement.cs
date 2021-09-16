using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
  public float speed = 8f;
  public float speedMultiplier = 1f;
  //Change this variable for move
  public Vector2 direction = Vector2.zero;
  public new Rigidbody2D rigidbody { get; private set; }

  private void Awake()
  {
    rigidbody = GetComponent<Rigidbody2D>();
  }

  private void FixedUpdate()
  {
    Vector2 position = rigidbody.position;
    Vector2 translation = direction * speed * speedMultiplier * Time.fixedDeltaTime;
    rigidbody.MovePosition(position + translation);
  }
}
