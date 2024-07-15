using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour , IInterection
{
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void Interection()
    {
        //animator
    }
}
