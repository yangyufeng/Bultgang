using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Me : MonoBehaviour
{
	public float MoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalMove = Input.GetAxisRaw("Horizontal");
        
        transform.Translate(HorizontalMove * MoveSpeed * Time.deltaTime, 0, 0);
    }
}
