using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperDangerousDoorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.itsOpen = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (ShutSecs > 0f) 
        {
            ShutSecs -= 1f * Time.deltaTime;
        }
        else if (ShutSecs < 0f & !this.itsOpen) 
        {
            this.OpenDoor();
        }
    }

    public void OpenDoor()
    {
        this.material.material = DoorOpen;
        this.material2.material = DoorOpen2;
        this.DoorIn.enabled = false;
        this.DoorOut.enabled = false;
        this.obstacle.SetActive(false);
        this.sound.PlayOneShot(Openclip, 1f);
        this.itsOpen = true;
    }

    public void ShutDoor()
    {
        if (this.itsOpen) 
        {
            this.material.material = DoorShut;
            this.material2.material = DoorShut2;
            this.DoorIn.enabled = true;
            this.DoorOut.enabled = true;
            this.obstacle.SetActive(true);
            this.sound.PlayOneShot(Shutclip, 1f);
            this.itsOpen = false;
            this.ShutSecs = 5f;
        }
    }

    public Material DoorShut;

    public Material DoorOpen;

    public Material DoorShut2;

    public Material DoorOpen2;

    public MeshRenderer material;

    public MeshRenderer material2;

    public MeshCollider DoorIn;

    public MeshCollider DoorOut;

    public GameObject obstacle;

    public AudioSource sound;

    public AudioClip Shutclip;

    public AudioClip Openclip;

    private float ShutSecs;

    private bool itsOpen;
}
