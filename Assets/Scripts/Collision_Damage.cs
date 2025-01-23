using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Damage : MonoBehaviour
{
    public int dmg;
    public string tag;
    // Start is called before the first frame update
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(tag))
        {
            var hp = collision.gameObject.GetComponent<HP>();
            hp.Damage(dmg);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
