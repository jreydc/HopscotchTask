using UnityEngine;
using UnityEngine.UI;
using TMPro;

public abstract class ButtonBase : MonoBehaviour
{
    public Button _button;

    public virtual void Awake() {
        _button = GetComponent<Button>();

        _button.onClick.AddListener( ()=>{
            ButtonClickedEventAction();
        });
    }

    public virtual void ButtonClickedEventAction(){
        Debug.Log(gameObject.name +" is clicked!");
    }
}
