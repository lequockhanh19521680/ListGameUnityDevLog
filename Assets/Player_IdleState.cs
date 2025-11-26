
using UnityEngine;

public class Player_IdelState : EntityState
{
    public Player_IdelState(Player player, StateMachine stateMachine, string stateName) : base(player, stateMachine, stateName)
    {
        
    }

    public override void Update()
    {
        base.Update();
        // Example condition to switch to move state
        if (Input.GetKeyDown(KeyCode.F))
        {
            stateMachine.ChangeState(player.moveState);
        }
    }
}
