using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine 
{
    public PlayerState playerState { get; private set; }


    public void Initialize(PlayerState startPlayerState)
    {
        playerState = startPlayerState;
        playerState.Enter();
    }

    public void ChangeState(PlayerState newPlayerState)
    {
        playerState.Exit();
        playerState = newPlayerState;
        playerState.Enter();
    }
  
}
