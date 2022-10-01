using UnityEngine;

public class BlueProjectile : Projectile
{
    [SerializeField]private Transform _spawnPosition;
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

    private void OnCollisionEnter(Collision other) {
        ObjectPooler._Instance.ReturnToPool(gameObject);
        ObjectPooler._Instance.GetObjectFromPool("BlueProjectile", _spawnPosition.position, transform.localScale);
    }

    public void DestroyedProjectile(){
        if (IsDestroyed == null ) print(gameObject.name + " is destroyed!");
    }
}
