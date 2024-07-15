using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class Lever : MonoBehaviour , IInterection
{
    private Animator animator;
    public UnityEvent leverOnEvent;
    private SpriteRenderer inputBullun;//µµ¿ò ¸»Ç³¼±
    private void Awake()
    {
        animator = GetComponent<Animator>();
        inputBullun = GetComponentInChildren<SpriteRenderer>();
        Debug.Log(inputBullun.name);
    }
    public void Interection()
    {
        leverOnEvent?.Invoke();
        animator.SetBool("On", true);
    }

    public void InputHelp()
    {
        inputBullun.DOFade(1, 0.1f);
    }
    public void InputHelpOut()
    {
        inputBullun.DOFade(0, 0.1f);
    }
}
