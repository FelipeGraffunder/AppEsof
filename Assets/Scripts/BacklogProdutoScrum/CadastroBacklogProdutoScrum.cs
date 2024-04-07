using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class CadastroBacklogProdutoScrum : MonoBehaviour
{
    private string filePath;

    public TMP_InputField nome;
    public TMP_InputField historia;
    public TMP_InputField prioridade;

    private void Start()
    {
        filePath = Application.persistentDataPath + "/BacklogProdutoData.txt";
    }

    public void SalvarBut()
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(nome.text);
            writer.WriteLine(historia.text);
            writer.WriteLine(prioridade.text);
        }
    }
}
