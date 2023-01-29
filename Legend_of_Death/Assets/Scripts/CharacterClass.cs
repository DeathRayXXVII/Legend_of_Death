using UnityEngine;

public class CharacterClass : MonoBehaviour, IMove
{
    public float moveSpeed = 1.0f;
    private Vector3 diraction;
    private CharacterController characterControllerObj;

    private void Awake()
    {
        characterControllerObj = GetComponent<CharacterController>();
    }

    public void Move()
    {
        diraction.x = moveSpeed;
        characterControllerObj.Move(diraction);
    }
}
