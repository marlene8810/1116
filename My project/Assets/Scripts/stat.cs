using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stat : MonoBehaviour
{
    public Enemy target;
    public Image hpBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //如果發現目標已經被刪掉了
        if (target = null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
            return;
        }

        //讓血條跟著
        Vector3 offset = new Vector3(0, 35, 0);
        Vector3 p = Camera.main.WorldToScreenPoint(target.transform.position);
        transform.position = p + offset;

        //控制 hp bar
        float sx = target.hp / target.maxHp;
        if (sx < 0)
        {
            sx = 0;
        }
        hpBar.rectTransform.localScale = new Vector3(sx, 1, 1);
    }
}
