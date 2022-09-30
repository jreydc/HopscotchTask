using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueProjectile : Projectile
{
    public override void Awake()
    {
        base.Awake();
    }
    
    // Update is called once per frame
    void Update()
    {
        ProjectileMovement();    
    }

    private void OnTriggerEnter(Collider other) {
        CheckCollision(other);
        Destroy(gameObject);
    }
}
