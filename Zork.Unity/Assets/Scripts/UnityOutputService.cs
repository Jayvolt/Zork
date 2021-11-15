using System;
using UnityEngine;
using Zork;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    public void Clear() => throw new NotImplementedException();

    public void Write(string value) => throw new NotImplementedException();

    public void Write(object value) => throw new NotImplementedException();

    public void WriteLine(string value) => throw new NotImplementedException();

    public void WriteLine(object value) => throw new NotImplementedException();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
