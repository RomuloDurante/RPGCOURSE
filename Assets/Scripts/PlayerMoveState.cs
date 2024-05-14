using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveState : PlayerGroundState

{
    public PlayerMoveState(Player player, PlayerStateMachine stateMachine, string animBoolName)
        : base(player, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Update() 
    {
        base.Update();

        if(_xInput == 0)
            player.playerStateMachine.ChangeState(player.idleState); 

        //=> pass x velocity and y will be zero
        //=> we have acess to the player object and all functions 
        var xVelocity = _xInput * player.moveSpeed;
        player.SetVelocity(xVelocity, rb.velocity.y);
        
    }

    public override void Exit()
    {
        base.Exit();
    }
}
