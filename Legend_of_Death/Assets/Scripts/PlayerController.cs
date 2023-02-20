using UnityEngine;

public class PlayerController : MonoBehaviour, /*ITakeDamage,*/ IDie, IAttack
{
    [Header ("Stats")]
    public floatData curHP;
    [SerializeField] private float playerSpeed = 2.0f;
    [SerializeField] private float jumpHeight = 1.0f;
    [SerializeField] private float gravityValue = -9.81f;
    public HealthBar healthBar;
    public int damage;
    private float lastAttackTime;


    protected CharacterController controller;
    protected PlayerActionsExample playerInput;
    private Vector3 playerVelocity;
    private bool groundedPlayer;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        playerInput = new PlayerActionsExample();
    }

    private void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector2 movement = playerInput.Player.Move.ReadValue<Vector2>();
        Vector3 move = new Vector3(movement.x, 0, movement.y);
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // bool jumpPress = playerInput.Player.Jump.IsPressed();
        bool jumpPress = playerInput.Player.Jump.triggered;
        if (jumpPress && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    public void Attack()
    {
        lastAttackTime = Time.time;
    }
    
    public void Die()
    {
        {
            Debug.Log("!!Player has Died!!");
        }
    }
}
