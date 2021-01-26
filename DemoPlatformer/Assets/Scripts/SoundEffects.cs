
using UnityEngine;

public class SoundEffects : MonoBehaviour {

    [SerializeField]
    AudioSource AudioSource;
    [SerializeField]
    AudioClip AudioClip;
    // Start is called before the first frame update
    void Start() {
        AudioSource = GetComponent<AudioSource>();
        if (AudioSource == null) {
            Debug.LogError("We could not find the Audio Source");
        } else {
            AudioSource.clip = AudioClip;
        }
    }
    // Update is called once per frame
    void Update() {

    }
}
