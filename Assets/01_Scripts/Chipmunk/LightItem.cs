using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LightItem : MonoBehaviour
{
    LightChanger _lightChanger;
    [SerializeField] protected int lightLevel = 1;
    protected virtual void Awake()
    {
        _lightChanger = FindObjectOfType<LightChanger>();
        _lightChanger.BrightnessChanged += OnBrightnessChanged;
        OnBrightnessChanged(_lightChanger.CurrentBrightness);
    }

    private void OnBrightnessChanged(int currentlight)
    {
        if (currentlight == lightLevel)
        {
            InteractionToggle(true);
        }
        else
        {
            InteractionToggle(false);
        }
    }
    /// <summary>
    /// 본인의 LightLevel과 현재 밝기가 같을 때 호출되는 함수
    /// 상속받는 자식들이 실행할 내용 구현
    /// </summary>
    /// <param name="toggle"></param>
    public abstract void InteractionToggle(bool toggle);
}
