using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public StateMachine stateMachine { get; private set; }
    public Player_IdelState idleState { get; private set; }
    public Player_MoveState moveState { get; private set; }
    private void Awake()
    {
        stateMachine = new StateMachine();
        idleState = new Player_IdelState(this, stateMachine, "idle");
        moveState = new Player_MoveState(this, stateMachine, "move");
    }

    void Start()
    {
        stateMachine.Initialize(idleState);
    }
    // Update is called once per frame
    void Update()
    {
        stateMachine.CurrentState.Update();
    }
}
