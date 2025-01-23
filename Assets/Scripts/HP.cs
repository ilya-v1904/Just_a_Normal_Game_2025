using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HP : MonoBehaviour


{
    public AudioSource audioHealth;
    public int sceneId;
    public int hp = 100;
    public void Damage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            SceneManager.LoadScene(sceneId);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Apteka"))
        {
            hp += 20;
            audioHealth.Play();
            Destroy(collision.gameObject);
        }
    }
}
