using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PageSwitcher : MonoBehaviour
{
    public TMP_Text answer;
    [SerializeField] List<Toggle> Toggles;


    public void Resulting()
    {
        if (Toggles[0].isOn && Toggles[1].isOn && !Toggles[2].isOn && !Toggles[3].isOn)
        {
            answer.text = "Cat";
        }
        else if (Toggles[2].isOn && Toggles[1].isOn && !Toggles[0].isOn && !Toggles[3].isOn)
        {
            answer.text = "Human";
        }
        else if((Toggles[0].isOn && Toggles[2].isOn && Toggles[3].isOn && !Toggles[1].isOn) ||
            Toggles[0].isOn && Toggles[2].isOn && !Toggles[3].isOn && !Toggles[1].isOn
            )
        {
            answer.text = "MoNkE";
        }
        else if (Toggles[0].isOn && Toggles[1].isOn && Toggles[3].isOn && !Toggles[2].isOn)
        {
            answer.text = "Tiger!!";
        }
        else answer.text = "???";
    }
}
