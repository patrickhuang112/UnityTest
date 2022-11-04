using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TextController : MonoBehaviour
{
    public Button create;
    public Button join;

    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI createText = create.GetComponentInChildren<TextMeshProUGUI>();
        createText.text = "Create";
        TextMeshProUGUI joinText = join.GetComponentInChildren<TextMeshProUGUI>();
        joinText.text = "Join";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
