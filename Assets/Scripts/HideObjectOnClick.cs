using UnityEngine;
using UnityEngine.UI;

public class HideObjectOnClick : MonoBehaviour
{
    
    public Button hideButton;
    
    public GameObject objectToHide;

    void Start()
    {
        
        if (hideButton != null)
        {
            
            hideButton.onClick.AddListener(HideObject);
        }
    }

    
    void HideObject()
    {
        if (objectToHide != null)
        {
            objectToHide.SetActive(false);  
        }
    }
}