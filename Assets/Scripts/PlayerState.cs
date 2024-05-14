using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    #region Objects Instances
    //=>
    protected PlayerStateMachine stateMachine;
    protected Player player;
    protected Rigidbody2D rb;
    //=>
    #endregion

    #region Variables
    //=>
    private string _animBoolName;
    protected float _xInput;
    //=>
    #endregion

    public PlayerState(Player player, PlayerStateMachine stateMachine, string animBoolName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        _animBoolName = animBoolName;
    }


    public virtual void Enter()
    {
        player.anin.SetBool(_animBoolName, true);
        rb = player.rb;
    }

    public virtual void Update()
    {
        _xInput = Input.GetAxisRaw("Horizontal");
        player.anin.SetFloat("yVelocity", rb.velocity.y);
    }

    public virtual void Exit()
    {
        player.anin.SetBool(_animBoolName, false);
    }
}
