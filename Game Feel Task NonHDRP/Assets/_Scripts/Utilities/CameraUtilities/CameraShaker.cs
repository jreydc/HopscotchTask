using UnityEngine;

public class CameraShaker : MonoBehaviour
{
    #region CameraShaker SingleInstance
    private static CameraShaker _instance;
    public static CameraShaker _Instance{ 
        get { return _instance; }
        private set{}
    }
    private void Awake() => _instance = this;
    #endregion

    [SerializeField]private Vector2 cameraShake;
    private Transform cameraTransform;
    private Vector3 initialPosition;
    void Start()
    {
        cameraTransform = Camera.main.transform;
        initialPosition = cameraTransform.position;
    }

    public void CameraShakeFunc(){
        HorizontalCameraShake();
    }

    private void HorizontalCameraShake(){
        LeanTween.moveX(cameraTransform.gameObject, cameraShake.x, 0.01f).setOnComplete(VerticalCameraShake);
    }

    private void VerticalCameraShake(){
        LeanTween.moveY(cameraTransform.gameObject, cameraShake.y, 0.05f).setOnComplete(DefaultCameraPosition);
    }

    private void DefaultCameraPosition(){
        LeanTween.move(cameraTransform.gameObject, initialPosition, 0.01f);
    }
}
