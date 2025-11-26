using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Player_MoveState : EntityState
{
    public Player_MoveState(Player player, StateMachine stateMachine, string stateName) : base(player, stateMachine, stateName)
    {
        
    }

    public override void Update()
    {
        base.Update();

    }
}
