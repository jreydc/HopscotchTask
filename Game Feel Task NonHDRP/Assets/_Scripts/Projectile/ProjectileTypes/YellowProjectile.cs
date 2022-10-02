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

    private void OnTriggerEnter(Collider other) {
        ObjectPooler._Instance.ReturnToPool(gameObject);
        VFXManager._Instance.Projectile1VFXExplosionPlay(transform.position);
    }

    public void DestroyedProjectile(){
        if (IsDestroyed == null ) print(gameObject.name + " is destroyed!");
    }
}
