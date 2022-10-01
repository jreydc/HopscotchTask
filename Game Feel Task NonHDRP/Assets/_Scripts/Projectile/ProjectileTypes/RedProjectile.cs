using UnityEngine;

public class RedProjectile : Projectile
{
    [SerializeField]private Transform _spawnPosition;
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
        ObjectPooler._Instance.ReturnToPool(gameObject);
        ObjectPooler._Instance.GetObjectFromPool("RedProjectile", _spawnPosition.position, transform.localScale);
    }

    public void DestroyedProjectile(){
        if (IsDestroyed == null ) print(gameObject.name + " is destroyed!");
    }
}
