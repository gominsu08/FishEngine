using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarStorage : MonoBehaviour
{
    private Stack<Star> _stars = new();
    public int StarCount{get => _stars.Count;}
    public void StoreStar(Star star){
        _stars.Push(star);
        star.gameObject.SetActive(false);
    }
    public Star TakeOutStar(){
        return _stars.Pop();
    }
}
