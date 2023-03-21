using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiffucultyButton : MonoBehaviour
{
    private Button button;


    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDiffuculty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDiffuculty()
    {
        Debug.Log(gameObject.name + " was clicked");
    }
}
