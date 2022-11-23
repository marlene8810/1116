using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float hp = 100;
    public float maxHp = 100;
    public Image  hpBar ;
    public GameObject statusBar; //資訊bar
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = new Vector3(0, 50, 0);
        Vector3 p = Camera.main.WorldToScreenPoint(transform.position);
        statusBar.transform.position = p + offset;
            
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            hp -= 25;//扣血


            //控制hp bar
            float sx = hp / maxHp;
            hpBar.rectTransform.localScale = new Vector3(sx, 1, 1);
            //血沒了移除自己

            if (hp <= 0)
            {
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
}
