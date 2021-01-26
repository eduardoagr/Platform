
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour {

    [SerializeField]
    Player player;
    [SerializeField]
    Text coinsText;

    private int coins = 0;
    private int Coins {
        get { return coins; }
        set {
            coins = value;
            coinsText.text = $"Coins: {coins}";
        }
    }
    // Start is called before the first frame update
    void Start() {

        player.OnCoinCollected += OnCoinCollected;
        Coins = 0;
    }

    void OnCoinCollected() {
        Coins++;
    }
}
