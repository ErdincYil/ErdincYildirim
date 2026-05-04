using UnityEngine;

public class KarakterHareket : MonoBehaviour
{
    private Animator anim;
    
    public float yurumeHizi = 3.0f;
    public float kosmaHizi = 8.0f;
    public float donmeHizi = 150.0f;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float dikey = Input.GetAxis("Vertical"); 
        float yatay = Input.GetAxis("Horizontal");

        float anlikHiz = Input.GetKey(KeyCode.LeftShift) ? kosmaHizi : yurumeHizi;
        transform.Translate(0, 0, dikey * anlikHiz * Time.deltaTime);
        transform.Rotate(0, yatay * donmeHizi * Time.deltaTime, 0);

        float animasyonHizi = 0f;
        if (Mathf.Abs(dikey) > 0.1f) 
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                animasyonHizi = 1.0f;
            }
            else
            {
                animasyonHizi = 0.3f; 
            }
        }

        anim.SetFloat("Hiz", animasyonHizi);
    }
}