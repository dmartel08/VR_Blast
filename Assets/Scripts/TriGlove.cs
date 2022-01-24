using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriGlove : MonoBehaviour
{

    private Animator Animator;

    [SerializeField]
    private Bullet fingerBullet;
    [SerializeField]
    private Transform fingerTipPos;

    // Start is called before the first frame update
    void Start()
    {
        Animator = this.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void FireFingerBullet()
    {
        Instantiate(fingerBullet, fingerTipPos.position, fingerTipPos.rotation);
        Debug.Log("Finger bullet fired!");
    }
    public void UpdatePointer(bool val)
    {
        Animator.SetBool("isPointing", val);
        Debug.Log("I'm getting called and the bool is: " + val);
    }
}
