using UnityEngine;
public class LaunchButton : ButtonBase
{
    [SerializeField]private Projectile _projectile1 => ProjectileManager._Instance.YellowProjectileSpawner(); 
    [SerializeField]private Projectile _projectile2 => ProjectileManager._Instance.BlueProjectileSpawner();
    [SerializeField]private Projectile _projectile3 => ProjectileManager._Instance.RedProjectileSpawner();
    public override void Awake() {
        base.Awake();
    }
    
    public override void ButtonClickedEventAction(){
        _projectile1.ProjectileMovement();
        _projectile2.ProjectileMovement();
        _projectile3.ProjectileMovement();
    }
}
