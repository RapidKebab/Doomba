using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public float maxHP = 100;
    float currentHP;
    public Text HPText;
    public death death;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
        if (HPText != null)
            HPText.text = currentHP.ToString();
        death = GetComponent<death>();
        if (death ==null)
            death= gameObject.AddComponent<roombaDeath>();
    }

    public void takeDamage(float d) {
        Debug.Log("took" + d.ToString());
        currentHP -= d;
        if(HPText!=null)
            HPText.text = currentHP.ToString();
        if (currentHP <= 0) { death.Die(); }
    }
}
