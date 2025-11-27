using System;
using Unity.VisualScripting;
using UnityEngine;

public abstract class EntityState
{
    protected Player player;
    protected StateMachine stateMachine;
    protected String aniBoolName;

    public EntityState(Player player, StateMachine stateMachine, string aniBoolName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.aniBoolName = aniBoolName;
    }

    public virtual void Enter()
    {
        player.anim.SetBool(aniBoolName, true);
    }


    public virtual void Update()
    {
        Debug.Log("Updating State: " + aniBoolName);
    }   
    public virtual void Exit()
    {
        player.anim.SetBool(aniBoolName, false);

    }
}
