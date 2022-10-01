using UnityEngine;
public class LaunchButton : ButtonBase
{
    [SerializeField]private Projectile _projectile1;
    [SerializeField]private Projectile _projectile2;
    [SerializeField]private Projectile _projectile3;
    public override void Awake() {
        base.Awake();
    }
    
    public override void ButtonClickedEventAction(){
        _projectile1.ProjectileMovement();
        _projectile2.ProjectileMovement();
        _projectile3.ProjectileMovement();
    }
}
