using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]private GameObject _yellowPanel;
    [SerializeField]private GameObject _bluePanel;
    [SerializeField]private GameObject _redPanel;
    private bool isVisible => true;

    private void Awake() {
        DisablePrompts();
    }
    private void OnGUI (){
        GUI.Box (new Rect (Screen.width - 210, 10, 200, 120), "Projectile Settings");
        GUI.Label(new Rect (10, 40, 100, 20), GUI.tooltip);
        bool yellowProjectileSettingsClicked = GUI.Button (new Rect (Screen.width - 200, 40, 180, 20), "Yellow Projectile");
        bool blueProjectileSettingsClicked = GUI.Button (new Rect (Screen.width - 200, 70, 180, 20), "Blue Projectile");
        bool redProjectileSettingsClicked = GUI.Button (new Rect (Screen.width - 200, 100, 180, 20), "Red Projectile");

        if (yellowProjectileSettingsClicked) {
            DisablePrompts();
            SetPromptVisibility(_yellowPanel);
        }
        if (blueProjectileSettingsClicked){
            DisablePrompts();
            SetPromptVisibility(_bluePanel);
        } 
        if (redProjectileSettingsClicked) {
            DisablePrompts();
            SetPromptVisibility(_redPanel);
        }
	}

    private void SetPromptVisibility(GameObject prompt){
        prompt.SetActive(isVisible);
    }

    private void DisablePrompts(){
        _yellowPanel.SetActive(!isVisible);
        _bluePanel.SetActive(!isVisible);
        _redPanel.SetActive(!isVisible);
    }
}
