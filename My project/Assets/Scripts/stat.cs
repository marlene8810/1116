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
        //�p�G�o�{�ؼФw�g�Q�R���F
        if (target = null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
            return;
        }

        //��������
        Vector3 offset = new Vector3(0, 35, 0);
        Vector3 p = Camera.main.WorldToScreenPoint(target.transform.position);
        transform.position = p + offset;

        //���� hp bar
        float sx = target.hp / target.maxHp;
        if (sx < 0)
        {
            sx = 0;
        }
        hpBar.rectTransform.localScale = new Vector3(sx, 1, 1);
    }
}
