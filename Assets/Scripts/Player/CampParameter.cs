using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CampParameter : MonoBehaviour 
{
    public string campName;
    /// <summary>
    /// ��������
    /// </summary>
    public int totalEconomy;
    /// <summary>
    /// ��������
    /// </summary>
    public int economicIncrement;
    /// <summary>
    /// ����ֵ
    /// </summary>
    public int politicalValue;
    /// <summary>
    /// �Ļ�ֵ
    /// </summary>
    public int culturalValue;
    /// <summary>
    /// �Ƽ�ֵ
    /// </summary>
    public int technologyValue;
    /// <summary>
    /// �������ζ�
    /// </summary>
    public int publicTrust;
    /// <summary>
    /// �����������ζȣ�����ר�ã���������Ĭ��Ϊ-100��
    /// </summary>
    public int publicTrustP = -100;
    /// <summary>
    /// �������ۿ�����
    /// </summary>
    public int internalControl;
    /// <summary>
    /// �������ۿ�����
    /// </summary>
    public int externalControl;
    /// <summary>
    /// ��NPC�Ĺ�ϵ
    /// </summary>
    public List<int> relationWithNPCs;
    /// <summary>
    /// ���³���
    /// </summary>
    public int militaryChips;
    /// <summary>
    /// ����ֵ
    /// </summary>
    public int militaryValue;
}
