
using UnityEngine;

public class CameraFolllow : MonoBehaviour {

    // What is the target
    [SerializeField]
    Player player;
    [SerializeField]
    float smoothFactor;
    [SerializeField]
    Vector3 offset;
    [SerializeField]
    private float minY;



    private void LateUpdate() {
        if (player != null && player.Dead == false) {
            Vector3 targetPos = new Vector3(
            offset.x + player.transform.position.x,
            Mathf.Max(offset.y + player.transform.position.y, minY),
            offset.z + transform.position.z);

            transform.position = Vector3.Lerp(
                transform.position, targetPos, smoothFactor * Time.deltaTime);
        }

    }
}
