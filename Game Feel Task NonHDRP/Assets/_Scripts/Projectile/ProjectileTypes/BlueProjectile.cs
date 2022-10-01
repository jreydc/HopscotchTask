using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueProjectile : Projectile
{
    public override void Awake()
    {
        base.Awake();
    }

    public override void OnDestroy() {
        base.OnDestroy();
        DestroyedProjectile();
    }

    void Update()
    {
        ProjectileMovement();    
    }

    private void OnCollisionEnter(Collision other) {
        //CheckCollision(other);
        Destroy(gameObject);
    }

    public void DestroyedProjectile(){
        if (IsDestroyed == null ) print(gameObject.name + " is destroyed!");
    }
}
