using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public int dmg;
    public string tag;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(tag))
        {
            var hp = collision.gameObject.GetComponent<HP>();
            hp.Damage(dmg);
        }
    }
}
