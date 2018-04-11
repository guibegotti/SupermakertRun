using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{

    Rigidbody m_Rigidbody;
    Quaternion rot;
    float m_Speed;
    float m_Rotation_Speed;
    float uprightTorque;
    float maxSpeed;
    //Audio
    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    void Start()
    {
        // Fetch the Rigidbody component from GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        // Set the speed of the GameObject
        m_Speed = 2.0f;
        m_Rotation_Speed = 60.0f;
        maxSpeed = 3.0f;
        //Set up the torque to not topple
        uprightTorque = 100.0f;
        source.volume = 0.0f;
        //Timer to unmute the audio
        StartCoroutine(Unmute());
        Time.timeScale = 1;
    }


    void Update()
    {

        if (Time.timeScale == 1)
        {

            // Prevent the player toppling
            rot = Quaternion.FromToRotation(transform.up, Vector3.up);
            m_Rigidbody.AddTorque(new Vector3(rot.x, rot.y, rot.z) * uprightTorque);

            // Getting the player movement
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                // Rotation to the Right
                transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * m_Rotation_Speed, Space.World);
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                //Rotation to the Left
                transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * m_Rotation_Speed, Space.World);
            }

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                // Going forward, using Vector3.right because of wrong positioning
                m_Rigidbody.AddForce(transform.right * -m_Speed, ForceMode.Impulse);
                //Limitting Speed
                m_Rigidbody.velocity = Vector3.ClampMagnitude(m_Rigidbody.velocity, maxSpeed);

            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                // Going backward, using Vector3.right because of wrong positioning
                m_Rigidbody.AddForce(transform.right * m_Speed, ForceMode.Impulse);
                //Limitting Speed
                m_Rigidbody.velocity = Vector3.ClampMagnitude(m_Rigidbody.velocity, maxSpeed);

            }

            //Audio by movement
            if (m_Rigidbody.velocity.magnitude > 0)
            {
                source.volume = 0.3f;
            }
            else
            {
                source.volume = 0.0f;
            }

        }

    }

    IEnumerator Unmute()
    {
        yield return new WaitForSeconds(0.5f);
        source.mute = !source.mute;
    }

}
