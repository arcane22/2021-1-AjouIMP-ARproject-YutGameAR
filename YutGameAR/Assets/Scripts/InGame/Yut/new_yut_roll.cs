using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_yut_roll : MonoBehaviour
{
    int [] yut = new int [4];
    int yut_combination;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

   public void roll()
    {
        //yut_combination�� ���������� ������ �����Ѵ�.[-1=����,1=��,2=��,3=��,4=��,5=��] 
        int yut_sum = 0;
        for(int i=0; i < 4; i++)
        {
            yut[i] = Random.Range(0, 2);
            yut_sum += yut[i];
            Debug.Log(yut[i]);
        }
        if (yut[0] == 1 && yut_sum == 0)
        {
            yut_combination = -1;
            Debug.Log("����");
        }
        else if (yut_sum == 1)
        {
            yut_combination = 1;
            Debug.Log("��");
        }
        else if (yut_sum == 2)
        {
            yut_combination = 2;
            Debug.Log("��");
        }
        else if (yut_sum == 3)
        {
            yut_combination = 3;
            Debug.Log("��");
        }
        else if (yut_sum == 4)
        {
            yut_combination = 4;
            Debug.Log("��");
        }
        else if (yut_sum == 0)
        {
            yut_combination = 5;
            Debug.Log("��");
        }
        
    }
}
