using UnityEngine;
using Zork;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";
    // Start is called before the first frame update
    void Awake()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);
        Game.Start(gameJsonAsset.text);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
