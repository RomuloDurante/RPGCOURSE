using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Move Info")]
    public float moveSpeed = 8f;


    #region Components
    //==>
    public Animator anin { get; private set; }
    public Rigidbody2D rb {  get; private set; }
    //==>
    #endregion
   

    #region States
    //==>
    public PlayerStateMachine playerStateMachine { get; private set; }
    public PlayerIdleState idleState { get; private set; }
    public PlayerMoveState moveState { get; private set; }
    //==>
    #endregion

    private void Awake()
    {
        playerStateMachine = new PlayerStateMachine();
        idleState = new PlayerIdleState(this, playerStateMachine, "Idle");
        moveState = new PlayerMoveState(this, playerStateMachine, "Move");
    }


    private void Start()
    {
        anin = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();

        //==>

        playerStateMachine.Initialize(idleState);

        
    }

    private void Update()
    {
      playerStateMachine.playerState.Update();
      
    }


    public void SetVelocity(float xVelocity, float yVelocity)
    {
        rb.velocity = new Vector2(xVelocity,yVelocity);
    }

}
