using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class Lever : MonoBehaviour , IInterection
{
    private Animator animator;
    public UnityEvent leverOnEvent;
    public GameObject inputBullun;//���� ��ǳ��
    private void Awake()
    {
        animator = GetComponent<Animator>();
        inputBullun.SetActive(false);
        Debug.Log(inputBullun.name);
    }
    public void Interection()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
        leverOnEvent?.Invoke();
        animator.SetBool("On", true);
        inputBullun.SetActive(false);
    }

    public void InputHelp()
    {
        Debug.Log("����");
        inputBullun.SetActive(true);
    }

}
