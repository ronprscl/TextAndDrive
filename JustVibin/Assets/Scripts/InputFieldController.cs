using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldController : MonoBehaviour
{
    InputField IF;
    //public Text text1, text2, text3;
    // Start is called before the first frame update
    void Start()
    {
        IF = GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        IF.Select();
        IF.caretPosition = IF.text.Length;
    }
}
