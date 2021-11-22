using UnityEngine;
using Zork;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";
    [SerializeField]
    private UnityOutputService OutputService;
    [SerializeField]
    private UnityInputService InputService;

    [SerializeField]
    private TextMeshProUGUI locationText;
    [SerializeField]
    private TextMeshProUGUI movesText;
    [SerializeField]
    private TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Awake()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);
        Game.Start(gameJsonAsset.text, InputService, OutputService);
        OutputService.WriteLine($"{Game.Instance.Player.Location}\n{Game.Instance.Player.Location.Description}");
        locationText.text = $"Location: {Game.Instance.Player.Location}";

        Game.Instance.Player.LocationChanged += PlayerLocationChanged;
        Game.Instance.Player.AddedMove += MoveAdded;
        Game.Instance.Player.AddedScore += ScoreAdded;
    }

    private void MoveAdded(object sender, int movesCount)
    {
        movesText.text = $"Moves: {movesCount}";
    }
    private void ScoreAdded(object sender, int scoreCount)
    {
        scoreText.text = $"Score: {scoreCount}";
    }
    private void PlayerLocationChanged(object sender, Room room)
    {
        locationText.text = $"Location: {room.Name}";
        OutputService.WriteLine($"{Game.Instance.Player.Location}\n{Game.Instance.Player.Location.Description}");
    }
}
