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

     public override void OnEnable() {
        //_spawnPosition = GameObject.Find("SpawningPoint1").transform;
    }

    private void Update() {
        ProjectileMovement();
    }

    private void OnTriggerEnter(Collider other) {
        ObjectPooler._Instance.ReturnToPool(gameObject);
        ProjectileManager._Instance.YellowProjectileSpawner();
    }

    public void DestroyedProjectile(){
        if (IsDestroyed == null ) print(gameObject.name + " is destroyed!");
    }
}
