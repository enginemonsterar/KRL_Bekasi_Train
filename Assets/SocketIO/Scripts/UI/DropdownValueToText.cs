using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownValueToText : MonoBehaviour
{
    private Dropdown dropdown;
    [SerializeField] private Text toText;

    void Awake(){
        dropdown = GetComponent<Dropdown>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
        if(dropdown.options.Count > 0)
            toText.text = dropdown.options[0].text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetValueToText(){
        toText.text = dropdown.transform.GetChild(0).GetComponent<Text>().text;
    }
}
