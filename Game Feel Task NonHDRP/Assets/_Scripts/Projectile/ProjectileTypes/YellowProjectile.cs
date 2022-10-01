using UnityEngine;

public class YellowProjectile : Projectile
{
    public override void Awake()
    {
        base.Awake();
    }
    
    public override void OnDisable() {
        base.OnDisable();
        DestroyedProjectile();
    }

    void Update()
    {
        ProjectileMovement();    
    }

    private void OnTriggerEnter(Collider other) {
        CheckCollision(other);
        //Destroy(gameObject);
        ObjectPooler._Instance.ReturnToPool(gameObject);
    }

    public void DestroyedProjectile(){
        if (IsDestroyed == null ) print(gameObject.name + " is destroyed!");
    }
}
