using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yutset : MonoBehaviour
{
    public Yut[] yut;
    public int ch_result = 0;
    private int frontcount=0;
    private int sbackcount = 0;
    private int backcount=0;
    public string combination=" ";
    void Update()
    {
        all_ground();
    }

    void check_combination()
    {
            foreach (Yut instantyut in yut)
            {
                if (instantyut.YutValue == "front")
                {
                    frontcount++;
                }
                if (instantyut.YutValue == "back")
                {
                    backcount++;
                }
                if (instantyut.YutValue == "sback")
                {
                    sbackcount++;
                }
            }
            if (sbackcount == 1 && frontcount == 3)
            {
                combination = ("����");
            }
            else if (backcount == 1&&frontcount==3)
            {
                combination = ("��");
            }
            else if (frontcount == 2)
            {
                combination = ("��");
            }
            else if (frontcount==1)
            {
                combination = ("��");
            }
            else if (frontcount == 4)
            {
                combination = ("��");
            }
            else if (backcount == 3 && sbackcount == 1)
            {
                combination = ("��");
            }
        Debug.Log("hi");
            frontcount = 0;
            backcount = 0;
            sbackcount = 0;
            ch_result = 1;
    }
    void all_ground()
    {
        if (!check_ground())
        {
            //���� ��� �������ʾ�����
        }
        else //���� ��� ��������  
        {
            if(ch_result==0)
                check_combination();
        }
     
    }
    public void roll_all_yut()
    {
        foreach (Yut instantyut in yut)
            {
                instantyut.rollyut();
            }
    }
    public bool check_ground()
    {
        foreach (Yut instantyut in yut)
        {
            if (!instantyut.sideground)
            {
                return false;
            }
        }
        return true;
    }
}
