using System;
using UnityEngine;
using Zork;
using TMPro;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    public void Clear() => throw new NotImplementedException();

    public void Write(string value) => mainOutputText.text = value;

    public void Write(object value) => Write(mainOutputText.text = value.ToString());

    public void WriteLine(string value)
    {

        mainOutputText = Instantiate(mainOutputText, contentFrame.transform);
        mainOutputText.text = value;
    }
    public void WriteLine(object value) => WriteLine(mainOutputText.text = value.ToString());
    
    [SerializeField]
    private TextMeshProUGUI mainOutputText;
    [SerializeField]
    private GameObject contentFrame;
}
