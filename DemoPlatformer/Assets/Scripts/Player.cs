
using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField]
    float MovementSpeed = 5f;
    [SerializeField]
    float JumpForce = 10f;
    InputActions InputActions;
    [SerializeField]
    AudioSource AudioSource;
    [SerializeField]
    AudioClip AudioClip;
    SimpleEnemy enemy;
    bool canJump = true;
    private bool dead;
    public bool Dead { get { return dead; } }
    private float height;
    private float width;

    // This is what communicate my scrip to the sceneManager
    public delegate void CollectedCoinHandler();

    // This event will be called in the sceneManaget (needs to have the same name)
    public event CollectedCoinHandler OnCoinCollected;

    Rigidbody2D playerRigitBody;


    private void Awake() {
        InputActions = new InputActions();
        playerRigitBody = GetComponent<Rigidbody2D>();
        AudioSource = GetComponent<AudioSource>();
        height = GetComponent<BoxCollider2D>().size.y;
        width = GetComponent<BoxCollider2D>().size.x;
        AudioSource.clip = AudioClip;
    }
    // Start is called before the first frame update
    void Start() {

        GameObject obj = GameObject.FindGameObjectWithTag("Enemy");

        if (obj == null) {
            Debug.LogError("We could not find Enemy");
        } else {
            Debug.Log("We found the enemy");
        }

        enemy = obj.GetComponent<SimpleEnemy>();
        if (enemy == null) {
            Debug.LogError("We could not find the script of the enemy");
        } else {
            Debug.Log("We found the script");
        }
    }

    private void Jump() {
        if (canJump) {
            playerRigitBody.AddForce(new Vector2(0, JumpForce),
                ForceMode2D.Impulse);
            canJump = false;
        }
    }

    private void OnEnable() {
        InputActions.Enable();
    }
    private void OnDisable() {
        InputActions.Disable();
    }

    // Update is called once per frame
    void Update() {
        if (dead == false) {
            // We have to read the movement value from our InputActions class

            float movement = InputActions.Land.sideways.ReadValue<float>();

            // Grab the current position of the player

            Vector3 currentPos = transform.position;

            // Move the player in the X value

            currentPos.x += movement * MovementSpeed * Time.deltaTime;
            transform.position = currentPos;

            InputActions.Jump.jump.performed += _ => Jump();

        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        // We want to preform a jump if we hit the floor
        switch (collision.transform.tag) {
            case "Platform":
                canJump = true;
                break;
            case "Enemy":
                RaycastHit2D leftHit = Physics2D.Raycast(new Vector2(
                    transform.position.x - width / 2, transform.position.y - height / 2 - 0.01f),
                    Vector2.down, height / 2 + 0.02f);
                RaycastHit2D rightHit = Physics2D.Raycast(new Vector2(
                    transform.position.x + width / 2, transform.position.y - height / 2 - 0.01f),
                    Vector2.down, height / 2 + 0.02f);
                if (leftHit.collider != null && leftHit.collider.gameObject == collision.gameObject ||
                    rightHit.collider != null && rightHit.collider.gameObject == collision.gameObject) {
                    if (enemy.isDestroyable) {
                        Destroy(collision.gameObject);
                    } else {
                        Hurt();
                    }
                } else {
                    Hurt();
                }
                break;
            default:
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        switch (collision.transform.tag) {
            case "Coin":
                if (OnCoinCollected != null) {
                    OnCoinCollected();
                }
                Destroy(collision.gameObject);
                AudioSource.Play();
                break;
            default:
                break;
        }
    }

    private void Hurt() {
        GetComponent<Collider2D>().enabled = false;
        playerRigitBody.velocity = new Vector2(
             0,
             JumpForce
           );

        dead = true;
        Destroy(gameObject, 3f);
    }
}
