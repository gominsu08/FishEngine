using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private PlayerInput playerInput;
    private Rigidbody2D rigid;
    [SerializeField] private float moveSpeed;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        rigid = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        rigid.velocity = playerInput.MoveDir * moveSpeed;
    }
}
