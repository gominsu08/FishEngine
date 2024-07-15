using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LightFadeBlock : LightItem
{
    SpriteRenderer _spriteRendererCompo;
    [SerializeField] float fadeTime = 0.3f;
    protected override void Awake()
    {
        base.Awake();
        _spriteRendererCompo = GetComponent<SpriteRenderer>();
    }
    public override void InteractionToggle(bool toggle)
    {
        if (toggle)
        {
            Debug.Log("밍");
            _spriteRendererCompo.DOFade(1, fadeTime).OnComplete(() => gameObject.SetActive(true));
        }
        else
        {
            _spriteRendererCompo.DOFade(0, fadeTime).OnComplete(() => gameObject.SetActive(false));
        }
    }
}
