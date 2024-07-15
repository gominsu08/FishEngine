using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMoveBlock : LightItem
{
    [SerializeField] float moveTime;
    [SerializeField] Transform targetPosTrm;
    Vector3 starPos;
    public override void InteractionToggle(bool toggle)
    {
        if(toggle){

        }
    }
}
