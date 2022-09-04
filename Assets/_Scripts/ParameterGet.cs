using UnityEngine;
using UnityEngine.UI;
using System;
using Utage;

public class ParameterGet : MonoBehaviour {
    public AdvEngine engine;    //インスペクタでAdvEngineをアタッチする
    public String [] paramName; //ExcelでのParam名をインスペクタに入力
    public Text [] paramText;//Paramを反映させるText

   public void ParamGetSet() {
        for (int i = 0; i < paramName.Length; i++) {
            //ExcelのParamを変数parameterに格納
            int parameter = engine.Param.GetParameterInt(paramName[i]);
            //参考　https://belhb.hateblo.jp/entry/2016/02/11/140637
            //テキストに変数の値を反映。int型なので、string型にフォーマットする。
            paramText[i].text = string.Format("{0}", parameter);
        }
    }
}