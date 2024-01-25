using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Phone : MonoBehaviour
{
    [SerializeField] TMP_InputField _charHolder;
    public void N1()
    {
        _charHolder.text += "1";
    }
    public void N2()
    {
        _charHolder.text += "2";
    }
    public void N3()
    {
        _charHolder.text += "3";
    }
    public void N4()
    {
        _charHolder.text += "4";
    }
    public void N5()
    {
        _charHolder.text += "5";
    }
    public void N6()
    {
        _charHolder.text += "6";
    }
    public void N7()
    {
        _charHolder.text += "7";
    }
    public void N8()
    {
        _charHolder.text += "8";
    }
    public void N9()
    {
        _charHolder.text += "9";
    }
    public void N0()
    {
        _charHolder.text += "0";
    }
    public void Cancel()
    {
        _charHolder.text = "";
    }
    public void Call()
    {//switch case?
        if (_charHolder.text == "666")
        {
            Debug.Log("Vous êtes bien sur le répondeur de satan ne laissez pas de message après le cri des âmes damnées");
        }
        else if(_charHolder.text== "01123581321")
        {
            Debug.Log("BELPHEGOR");
        }
        else if (_charHolder.text == "0761964399")
        {
            Application.OpenURL("tel://0761964399");
        }
        else if (_charHolder.text == "0612047223")
        {
            Application.OpenURL("tel://0612047223");
        }
        else
        {
            Debug.Log("Le numéro composé n'a pas enocre été attribué");
        }
    }
}
