using UnityEngine;
public class LaunchButton : ButtonBase
{
    [SerializeField]private Projectile _projectile1; //=> ObjectPooler._Instance.GetObjectFromPool("YellowProjectile", ObjectPooler._Instance.pools[0].prefab.transform.position, ObjectPooler._Instance.pools[0].prefab.transform.localScale);
    [SerializeField]private Projectile _projectile2;
    [SerializeField]private Projectile _projectile3;
    public override void Awake() {
        base.Awake();
    }
    
    /* public void Start(){
        _projectile1 = GameObject.Find("Rocket15_Yellow Variant").GetComponent<Projectile>();
        _projectile2 = GameObject.Find("Rocket13_Blue Variant").GetComponent<Projectile>();
        _projectile3 = GameObject.Find("Rocket29_Red Variant").GetComponent<Projectile>();
    }
    public override void ButtonClickedEventAction(){
        //Rocket13_Blue Variant Rocket15_Yellow Variant Rocket29_Red Variant
        _projectile1.ProjectileMovement();
        _projectile2.ProjectileMovement();
        _projectile3.ProjectileMovement();
    } */
}
