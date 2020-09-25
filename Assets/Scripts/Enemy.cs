using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : GameEntity
{
    public int points = 100;

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Enemy>()) return;
        if (collision.GetComponent<Ship>()) return;
        base.OnTriggerEnter2D(collision);

        GameControler.instance.Score(points);
    }
}

