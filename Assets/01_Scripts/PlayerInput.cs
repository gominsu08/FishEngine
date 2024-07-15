using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Vector2 MoveDir { get; private set; }

    public static bool stop;

    public event Action OnFire;

    private void Update()
    {
        if (!stop)
            MoveInput();
    }

    private void MoveInput()
    {
        float x = Input.GetAxisRaw("Horizontal");

        MoveDir = new Vector2(x, 0);
        MoveDir = MoveDir.normalized;
    }
}
