using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerGroundState
{
    public PlayerIdleState(Player player, PlayerStateMachine stateMachine, string animBoolName)
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
        if (_xInput != 0)
            player.playerStateMachine.ChangeState(player.moveState);
        
       
    }

    public override void Exit()
    {
        base.Exit();
    }

}
