using UnityEngine;
using UnityEngine.UI;
using System;
using Utage;

public class ParameterGet : MonoBehaviour {
    public AdvEngine engine;    //�C���X�y�N�^��AdvEngine���A�^�b�`����
    public String [] paramName; //Excel�ł�Param�����C���X�y�N�^�ɓ���
    public Text [] paramText;//Param�𔽉f������Text

   public void ParamGetSet() {
        for (int i = 0; i < paramName.Length; i++) {
            //Excel��Param��ϐ�parameter�Ɋi�[
            int parameter = engine.Param.GetParameterInt(paramName[i]);
            //�Q�l�@https://belhb.hateblo.jp/entry/2016/02/11/140637
            //�e�L�X�g�ɕϐ��̒l�𔽉f�Bint�^�Ȃ̂ŁAstring�^�Ƀt�H�[�}�b�g����B
            paramText[i].text = string.Format("{0}", parameter);
        }
    }
}