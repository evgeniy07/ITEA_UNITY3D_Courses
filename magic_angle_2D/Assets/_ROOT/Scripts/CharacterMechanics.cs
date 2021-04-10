
using UnityEngine;

public class CharacterMechanics : MonoBehaviour
{
    public float MoveSpeed;

    private Rigidbody2D rigidbody2D;
    private Animator characterAnimator;
    private Vector2 moveVector;

    void Awake()
    {
        InitializationObjects();
    }

    private void FixedUpdate()
    {
        CharacterMove();
    }

    private void InitializationObjects()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        characterAnimator = GetComponent<Animator>();
    }

    private void CharacterMove()
    {
        moveVector = Vector2.zero;
        moveVector.x = Input.GetAxis("Horizontal") * MoveSpeed;
        moveVector.y = Input.GetAxis("Vertical") * MoveSpeed;
        rigidbody2D.velocity = moveVector*Time.fixedDeltaTime;
    }
}
