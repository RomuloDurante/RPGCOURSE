using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerStateMachine playerStateMachine { get; private set; }
    public PlayerIdleState idleState { get; private set; }
    public PlayerMoveState moveState { get; private set; }


    private void Awake()
    {
        playerStateMachine = new PlayerStateMachine();
        idleState = new PlayerIdleState(this, playerStateMachine, "Idle");
        moveState = new PlayerMoveState(this, playerStateMachine, "Move");
    }


    private void Start()
    {
        playerStateMachine.Initialize(idleState);
        
    }

    private void Update()
    {
      playerStateMachine.playerState.Update();
      
    }

}
