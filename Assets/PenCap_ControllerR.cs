using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class PenCap_ControllerR : MonoBehaviour {

    public GameObject cam, pencapDebris, blueArrow;
    public float throwForceX, throwForceY, explodeForce, explodeRadius, upwardsModifier, rotateAfterward, projectileKnockback, pencapPower;
    public bool collided;
    public AudioSource audio;
    public AudioClip smash;

    private Rigidbody rb;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();

       rb.AddForce(new Vector3(1f * throwForceX, 1f * throwForceY, 0f), ForceMode.Impulse);
        AddToTargets();

    }

    public void AddToTargets()
    {

        cam.GetComponent<Camera_Controller>().targets.Add(gameObject.transform);

    }

    public void RemoveFromTargets()
    {

        cam.GetComponent<Camera_Controller>().targets.Remove(gameObject.transform);

    }

    void Update()
    {

        if (transform.position.x > 21f)
        {

            transform.position = new Vector3(21f, transform.position.y, transform.position.z);

        }
        else if (transform.position.x < -21f)
        {

            transform.position = new Vector3(-21f, transform.position.y, transform.position.z);

        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (!collided)
        {

            if (collision.gameObject.tag == "Opponent")
            {

                GameObject opponent = collision.gameObject;
                rb.AddExplosionForce(explodeForce, opponent.transform.position, explodeRadius, upwardsModifier, ForceMode.Impulse);
                CameraShaker.Instance.ShakeOnce(4f, 5f, 0.1f, 2f);
                GameObject debris = Instantiate(pencapDebris, transform.position, Quaternion.identity);
                debris.SetActive(true);
                audio.PlayOneShot(smash);
                opponent.GetComponent<MainOpponent_Controller>().newHealth -= (pencapPower / 100f);

                collided = true;

                if (transform.position.x > opponent.transform.position.x)
                {

                    opponent.GetComponent<Rigidbody>().AddForce(Vector3.left * projectileKnockback, ForceMode.Impulse);

                }
                else
                {

                    opponent.GetComponent<Rigidbody>().AddForce(Vector3.right * projectileKnockback, ForceMode.Impulse);

                }

            }
            else
            {

                collided = true;

            }
        }
        else if (collision.gameObject.tag == "Player")
        {

            RemoveFromTargets();
            blueArrow.SetActive(false);
            gameObject.SetActive(false);

        }
        else
        {

            blueArrow.SetActive(true);

        }
    }
}
