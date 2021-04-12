
using UnityEngine;

public class CharacterMechanics : MonoBehaviour
{
    public float CharacterMoveSpeed;

    private Rigidbody2D characterRigidbody2D;
    private Animator characterAnimator;
   
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
        characterRigidbody2D = GetComponent<Rigidbody2D>();
        characterAnimator = GetComponent<Animator>();
    }

    private void CharacterMove()
    {
        Vector2 _characterMoveVector;

        _characterMoveVector = Vector2.zero;
        _characterMoveVector.x = Input.GetAxis("Horizontal") * CharacterMoveSpeed;
        _characterMoveVector.y = Input.GetAxis("Vertical") * CharacterMoveSpeed;
        characterRigidbody2D.velocity = _characterMoveVector*Time.fixedDeltaTime;
    }
}
