using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChanger : MonoBehaviour
{

    private List<LightLevelBlock> _lightLevelBlockList;
    [SerializeField] StarStorage starStorage;
    public Action<int> BrightnessChanged;
    [SerializeField] int maxBrightness;
    [SerializeField] int currentBrightness = 1;
    [SerializeField]
    public int CurrentBrightness
    {
        get => currentBrightness;
        set
        {
            currentBrightness = Mathf.Clamp(value, 1, maxBrightness);
            BrightnessChanged?.Invoke(CurrentBrightness);
        }
    }
    private void Awake()
    {
        GetComponentsInChildren(_lightLevelBlockList);
        starStorage.StarCountChanged += SetBright;
    }
    private void Start()
    {
        BrightnessChanged?.Invoke(CurrentBrightness);
    }

    private void SetBright(int Brightness)
    {
        CurrentBrightness = Brightness;
    }
    private void OnDestroy()
    {
        starStorage.StarCountChanged -= SetBright;
    }
}
