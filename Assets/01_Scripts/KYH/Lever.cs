using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lever : MonoBehaviour , IInterection
{
    private Animator animator;
    public UnityEvent leverOnEvent;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void Interection()
    {
        leverOnEvent?.Invoke();
    }
}
