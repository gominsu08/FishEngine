using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class LightMoveBlock : LightItem
{
    [SerializeField] float moveTime = 0.3f;
    [SerializeField] Transform targetPosTrm;
    Vector3 starPos;
    protected override void Awake()
    {
        base.Awake();
        starPos = transform.position;
    }
    public override void InteractionToggle(bool toggle)
    {
        if(toggle){
            transform.DOMove(targetPosTrm.position, moveTime);
        }else{
            transform.DOMove(starPos, moveTime);
        }
    }
}
