
using UnityEngine;

public class ChasePlayer : MonoBehaviour {

    [SerializeField]
    float speed;
    Transform target;
    // Start is called before the first frame update
    void Start() {

        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update() {

        if (target != null && Vector2.Distance(transform.position, target.position) > 1) {
            transform.position = Vector2.MoveTowards(
            transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
