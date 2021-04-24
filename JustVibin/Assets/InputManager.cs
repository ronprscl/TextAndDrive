using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public Text[] texts = new Text[3];
    public InputField IF;
    InputField IF2;
    int relationScore;
    Vector2[] textsPos = new Vector2[3];
    int randomPosInt;
    List<Dialogue> logs = new List<Dialogue>();
    public Dialogues DLOGS;
    int index, badness;
    // Start is called before the first frame update
    void Start()
    {
        DLOGS.StartDialogues();
        index = 0; badness = 0;
        OrganizeTexts();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckInputMatch()
    {
        IF2 = IF.GetComponent<InputField>();
       for (int i = 0; i<3; i++)
        {
            if(IF2.text == texts[i].text)
            {
                IF.GetComponent<InputField>().text = "";
                randomPosInt = Random.Range(0, 5);
                

                switch (i)
                {
                    case 0:
                        index++;
                        Debug.Log("index is" + index);
                        break;
                    case 1:
                        index++;
                        badness++;
                        break;
                    case 2:
                        badness++;
                        break;
                }
                OrganizeTexts();

                switch (randomPosInt)
                {
                    case 0: texts[0].transform.position = textsPos[0];
                        texts[1].transform.position = textsPos[1];
                        texts[2].transform.position = textsPos[2];

                        break;
                    case 1:
                        texts[0].transform.position = textsPos[1];
                        texts[1].transform.position = textsPos[0];
                        texts[2].transform.position = textsPos[2];
                        break;
                    case 2:
                        texts[0].transform.position = textsPos[1];
                        texts[1].transform.position = textsPos[2];
                        texts[2].transform.position = textsPos[0];
                        break;
                    case 3:
                        texts[0].transform.position = textsPos[2];
                        texts[1].transform.position = textsPos[1];
                        texts[2].transform.position = textsPos[0];
                        break;
                    case 4:
                        texts[0].transform.position = textsPos[2];
                        texts[1].transform.position = textsPos[0];
                        texts[2].transform.position = textsPos[1];
                        break;
                    
                }

            }

        }
       
    }

    //void CreateDialogue()
    //{
    //    logs.Add( new Dialogue("Hey, what's up?", "im on my way", "u know already", "none of ur business"));
    //}

    void OrganizeTexts()
    {
        textsPos[0] = texts[0].transform.position;
        textsPos[1] = texts[1].transform.position;
        textsPos[2] = texts[2].transform.position;
        texts[0].text = DLOGS.logs[badness, index].GetGood();
        texts[1].text = DLOGS.logs[badness, index].GetNeutral();
        texts[2].text = DLOGS.logs[badness, index].GetBad();
    }
}
