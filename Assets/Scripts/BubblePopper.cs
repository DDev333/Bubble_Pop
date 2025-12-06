using UnityEngine;

public class BubblePopper : MonoBehaviour
{
    private AudioSource popSound;
    private Animator animator;
    // private bool isPopping = false;

    private void Start() {
        popSound = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown() 
    {
        // if (isPopping)
        // {
        //     return;
        // }
        FindObjectOfType<GameManager>().AddScore(10);
        popSound.Play();
        // animator.SetTrigger("Pop");
        Destroy(gameObject);
    }
}
