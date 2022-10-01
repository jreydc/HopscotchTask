using UnityEngine;

public class RedProjectile : Projectile
{
    public override void Awake()
    {
        base.Awake();
    }
    
    public override void OnDestroy() {
        base.OnDestroy();
        DestroyedProjectile();
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

    public void DestroyedProjectile(){
        if (IsDestroyed == null ) print(gameObject.name + " is destroyed!");
    }
}
