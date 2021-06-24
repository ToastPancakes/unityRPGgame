using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest_Script : MonoBehaviour
{
    public GameObject commonItem;
    public GameObject uncommonItem;
    public GameObject rareItem;
    public GameObject veryRareItem;
    public SpriteRenderer spriteRenderer;
    public Sprite openedState;
    public int randomChance;
    public Transform Epos; //epos is the item container's current position

    private void Start()
    {
        randomChance = Random.Range(1, 101);
        Epos = GetComponent<Transform>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        spriteRenderer.sprite = openedState;
        if (randomChance >= 90)
        {
            Instantiate(veryRareItem, new Vector3(Epos.position.x, Epos.position.y, Epos.position.z), Quaternion.identity);
        }
        else if (randomChance > 75 && randomChance <90)
        {
            Instantiate(rareItem, new Vector3(Epos.position.x, Epos.position.y, Epos.position.z), Quaternion.identity);
        }
        else if (randomChance > 50 && randomChance < 75)
        {
            Instantiate(uncommonItem, new Vector3(Epos.position.x, Epos.position.y, Epos.position.z), Quaternion.identity);
        }
        else if (randomChance > 1 && randomChance < 50)
        {
            Instantiate(commonItem, new Vector3(Epos.position.x, Epos.position.y, Epos.position.z), Quaternion.identity);
        }
        Destroy(this.gameObject);
    }
}

