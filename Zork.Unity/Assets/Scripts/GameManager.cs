using UnityEngine;
using Zork;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";
    [SerializeField]
    private UnityOutputService Output;
    // Start is called before the first frame update
    void Awake()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);


        Game.Start(gameJsonAsset.text, Output);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
