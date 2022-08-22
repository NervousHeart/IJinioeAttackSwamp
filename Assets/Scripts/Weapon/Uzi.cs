using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : Weapon
{
    [SerializeField] private int _countBullet;
    public override void Shoot(Transform shootPoint)
    {
        for (int i = 0; i < _countBullet; i++)
        {
            Instantiate(Bullet, shootPoint.position + new Vector3(i, 0), Quaternion.identity);
        }
    }
}
