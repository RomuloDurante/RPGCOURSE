using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    protected PlayerStateMachine stateMachine;
    protected Player player;
    private string _animBoolName;

    public PlayerState(Player player, PlayerStateMachine stateMachine, string animBoolName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        _animBoolName = animBoolName;
    }


    public virtual void Enter()
    {
        player.anin.SetBool(_animBoolName, true);
    }

    public virtual void Update()
    {
        //Debug.Log("I in update " + _animBoolName);
    }

    public virtual void Exit()
    {
        player.anin.SetBool(_animBoolName, false);
    }
}
