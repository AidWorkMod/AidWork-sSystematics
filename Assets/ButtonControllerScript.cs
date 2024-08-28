using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ButtonControllerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            spriteUnpress();
        }
        if ((Input.GetMouseButtonDown(0) || Singleton<InputManager>.Instance.GetActionKey(InputAction.Interact)) && Time.timeScale != 0f & Vector3.Distance(this.player.position, base.transform.position) < this.distance) //If the door is left clicked and the game isn't paused
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3((float)(Screen.width / 2), (float)(Screen.height / 2), 0f));
            RaycastHit raycastHit;
            if (Physics.Raycast(ray, out raycastHit) && (raycastHit.collider == this.trigger))
            {
                this.spritePress();
                this.audioDevice.PlayOneShot(press, 1f);
                OnButtonPress();

            }
        }
    }

    void spritePress() 
    {
        this.isPressed = true;
        this.material.material = Pressed;
    }

    void spriteUnpress()
    {
        this.isPressed = false;
        this.material.material = Unpressed;
    }

    public void OnButtonPress() 
    {
        this.ButtonPress.Invoke();
    }

    public UnityEvent ButtonPress;

    public Transform player;

    public MeshCollider trigger;

    public Material Pressed;

    public Material Unpressed;

    public MeshRenderer material;

    public float distance;

    public bool isPressed;

    public AudioSource audioDevice;

    public AudioClip press;
}
