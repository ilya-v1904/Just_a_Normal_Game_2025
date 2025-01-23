using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour

{
    public AudioSource audioMoney;
    public AudioSource audioKey;
    public AudioSource audioChest;
    public AudioSource audioDoor;
    int coin = 0;
    int key = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            coin += 1;
            Debug.Log(coin);
            audioMoney.Play();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Chest"))
        {
            coin += 10;
            Debug.Log(coin);
            audioChest.Play();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Key"))
        {
            key += 1;
            audioKey.Play();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Door"))
        {
            if (key > 0)
            {

                key -= 1;
                audioDoor.Play();
                Destroy(collision.gameObject);
            }
        }
    }
}
