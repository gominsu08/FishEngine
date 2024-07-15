using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Star : MonoBehaviour
{
    public Rigidbody2D rigidbodyCompo { get; private set; }
    public bool IsShooting { get; private set; } = false;
    public bool IsGetting { get; private set; } = false;
    public void Shoot(Vector2 shootDir, float shootPower)
    {
        rigidbodyCompo.velocity = shootDir * shootPower;
        IsShooting = true;
        StartCoroutine(ShootingCoroutine());
    }
    public void Get(StarGetter starGetter, StarStorage starStorage)
    {
        IsGetting = true;
        this.transform.DOMove(transform.position, starGetter._getTime).OnComplete(() =>
        {
            starStorage.StoreStar(this);
            IsGetting = false;
        });
    }

    private IEnumerator ShootingCoroutine()
    {
        yield return new WaitForSeconds(1f);
        IsShooting = false;
        // while(IsShooting)
        // {
        //     if(rigidbodyCompo.velocity.magnitude < 0.1f)
        //     {
        //         IsShooting = false;
        //         rigidbodyCompo.velocity = Vector2.zero;
        //     }
        //     yield return null;
        // }
    }

    private void Awake()
    {
        rigidbodyCompo = GetComponent<Rigidbody2D>();
    }
}
