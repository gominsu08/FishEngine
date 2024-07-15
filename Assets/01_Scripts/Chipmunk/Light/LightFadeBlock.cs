using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LightFadeBlock : LightItem
{
    Sequence _sequence;
    Tween _tween;
    SpriteRenderer _spriteRendererCompo;
    [SerializeField] float fadeTime = 0.3f;
    protected override void Awake()
    {
        base.Awake();
        _spriteRendererCompo = GetComponent<SpriteRenderer>();
    }
    public override void InteractionToggle(bool toggle)
    {
        _tween.Kill();
        if (toggle)
        {
            Debug.Log("밍");
            gameObject.SetActive(true);
            _tween = _spriteRendererCompo.DOFade(1, fadeTime);
        }
        else
        {
            _tween = _spriteRendererCompo.DOFade(0, fadeTime).OnComplete(() => gameObject.SetActive(false));
        }
    }
}
