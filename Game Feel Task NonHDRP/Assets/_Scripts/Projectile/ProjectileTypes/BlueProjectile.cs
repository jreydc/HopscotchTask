using UnityEngine;

public class BlueProjectile : Projectile
{
    //[SerializeField]private Transform _spawnPosition;
    public override void Awake()
    {
        base.Awake();
    }

    public override void OnDisable() {
        base.OnDisable();
        DestroyedProjectile();
    }

    private void OnCollisionEnter(Collision other) {
        ObjectPooler._Instance.ReturnToPool(gameObject);
        VFXManager._Instance.Projectile2VFXExplosionPlay(transform.position);
    }

    public void DestroyedProjectile(){
        if (IsDestroyed == null ) print(gameObject.name + " is destroyed!");
    }
}
