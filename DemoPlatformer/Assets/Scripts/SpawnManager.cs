
using System.Collections;

using UnityEngine;

public class SpawnManager : MonoBehaviour {

    [SerializeField]
    GameObject coinPrefab;
    [SerializeField]
    GameObject coinsContainer;
    [SerializeField]
    int ammountOfCoins;

    // Start is called before the first frame update
    void Start() {
        StartCoroutine(instantiatecCoins());
    }
    IEnumerator instantiatecCoins() {

        WaitForSeconds wait = new WaitForSeconds(1f);

        for (int i = 0; i <= ammountOfCoins; i++) {
            Vector3 coinPos = new Vector3(
                            Random.Range(-4.0f, 4.0f),
                            Random.Range(-4.0f, 4f), 0);
            Instantiate(coinPrefab, coinPos, Quaternion.identity, coinsContainer.transform);
            yield return wait;
        }
    }
}
