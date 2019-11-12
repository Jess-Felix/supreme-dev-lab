using UnityEngine;
using System.Collections;

public class PlatformCollapse : MonoBehaviour
{

    public float delta = 1.5f; // Amount to move left and right from the start point
    public float speed = 2.0f;
    private Vector3 startPos;
    bool isEnabled = false;
    public float timer = 0;
    public GameObject reference;
    private Rigidbody rb, rbPlayer;
    public float thrust;

	public AudioSource earthquakeAudio;

	void Start()
    {
        rb = GetComponent<Rigidbody>();
        rbPlayer = reference.GetComponent<Rigidbody>();
        startPos = transform.position;

		earthquakeAudio = GetComponent<AudioSource>();

	}

    void Update()
    
    {
        
        if (isEnabled && timer < 1.0f)
        {
            Debug.Log(timer);

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
            isEnabled = false;
            rbPlayer.constraints = RigidbodyConstraints.None;
            rbPlayer.isKinematic = false;
            rb.constraints = RigidbodyConstraints.None;
            rb.isKinematic = false;
            
            

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