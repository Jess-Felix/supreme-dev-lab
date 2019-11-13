using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlatformCollapse : MonoBehaviour
{
    public Animator fadeOutAnimator, theEndFadingAnimator;
    public float delta = 1.5f; // Amount to move left and right from the start point
    public float speed = 2.0f;
    private Vector3 startPos;
    bool isEnabled = false;
    public float timer = 0;
    public GameObject player;
    private Rigidbody rb, rbPlayer;
    public float thrust;
    public float timeToFadeOut = 10.0f;
    public AudioSource earthquakeAudio;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rbPlayer = player.GetComponent<Rigidbody>();
        startPos = transform.position;
        earthquakeAudio = GetComponent<AudioSource>();

    }

    void Update()
    {
        if (isEnabled && timer < 1.0f)
        {
            timer += Time.deltaTime;
            Vector3 v = startPos;
            v.z += delta * Mathf.Sin(Time.time * speed);
            transform.position = v;

            if (!earthquakeAudio.isPlaying)
            {
                earthquakeAudio.Play();
            }
        }
        else if (timer >= 1.0f)
        {
            timer += Time.deltaTime;
            if (isEnabled)
            {
                isEnabled = false;
                rbPlayer.constraints = RigidbodyConstraints.None;
                rbPlayer.isKinematic = false;
                rb.constraints = RigidbodyConstraints.None;
                rb.isKinematic = false;
            }
        }

        if (timer >= timeToFadeOut) {
            fadeOutAnimator.SetBool("FadeOut", true);
            theEndFadingAnimator.SetBool("TheEndFadeIn", true);

            if (timer > timeToFadeOut + 2.0f && Input.GetButton("Fire2") ) {
                SceneManager.LoadScene("FirstRoom");
            }
        }
        
    }

    void FixedUpdate()
    {
        rbPlayer.AddForce(transform.up * thrust);
        rb.AddForce(transform.up * thrust);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isEnabled = true;
        }
    }
}