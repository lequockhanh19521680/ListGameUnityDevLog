using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Animator anim;
    public PlayerInputSet input { get; set; }
    public StateMachine stateMachine { get; private set; }
    public Player_IdelState idleState { get; private set; }
    public Player_MoveState moveState { get; private set; }

    public Vector2 moveInput { get; private set; }
    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        stateMachine = new StateMachine();
        input = new PlayerInputSet();
        idleState = new Player_IdelState(this, stateMachine, "idle");
        moveState = new Player_MoveState(this, stateMachine, "move");
    }

    private void OnEnable()
    {
        input.Enable();       

        input.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        input.Player.Move.canceled += ctx => moveInput = Vector2.zero;

        
    }

    private void OnDisable()
    {
        input.Disable();
    }
    void Start()
    {
        stateMachine.Initialize(idleState);
    }
    // Update is called once per frame
    void Update()
    {
        stateMachine.UpdateActiveState();
    }


}
