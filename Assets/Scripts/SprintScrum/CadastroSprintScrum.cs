using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class CadastroSprintScrum : MonoBehaviour
{
    private string filePath;

    public TMP_InputField nome;
    public TMP_InputField goal;
    public TMP_InputField dataIni;
    public TMP_InputField dataFim;

    private void Start()
    {
        filePath = Application.persistentDataPath + "/SprintData.txt";
    }

    public void SalvarBut()
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(nome.text);
            writer.WriteLine(goal.text);
            writer.WriteLine(dataIni.text);
            writer.WriteLine(dataFim.text);
        }
    }
}
