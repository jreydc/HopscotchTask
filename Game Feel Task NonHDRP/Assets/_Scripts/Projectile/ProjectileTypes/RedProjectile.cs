using UnityEngine;

public class RedProjectile : Projectile
{
    //[SerializeField]private Transform _spawnPosition;
    public override void Awake()
    {
        base.Awake();
    }

    public override void OnEnable() {
        _spawnPosition = GameObject.Find("SpawningPoint3").transform;
    }
    
    public override void OnDisable() {
        base.OnDisable();
        DestroyedProjectile();
    }

    private void OnTriggerEnter(Collider other) {
        VFXManager._Instance.CameraShakeFX();
        //CameraShaker.Instance.ShakeOnce(4f, 4f, 0f, 0.5f);
        VFXManager._Instance.Projectile3VFXExplosionPlay(transform.position);
        ObjectPooler._Instance.ReturnToPool(gameObject);
        ObjectPooler._Instance.GetObjectFromPool("RedProjectile", _spawnPosition.position, transform.localScale);
    }

    public void DestroyedProjectile(){
        if (IsDestroyed == null ) print(gameObject.name + " is destroyed!");
    }
}
