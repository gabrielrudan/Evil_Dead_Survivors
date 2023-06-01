using UnityEngine;

public class Gerador : MonoBehaviour
{
    public GameObject prefab;
    public int qnt;
    public float espaco;
    public bool serDestruido;
    public bool gerarParaCima;
    public bool gerarParaBaixo;
    public bool gerarParaDireita;
    public bool gerarParaEsquerda;

    private string direcao;

    private void Start()
    {

        direcao = getDirecao();
        if (qnt > 0)
        {
            InvokeRepeating("GerarGameObject", 0f, espaco);
        }
        else
        {
            InvokeRepeating("GerarGameObject", 0f, espaco);
        }

        if (direcao == "Cima")
            transform.Rotate(new Vector3(0.0f, 0.0f, 90.0f));

        else if(direcao == "Baixo")
            transform.Rotate(new Vector3(0.0f, 0.0f, -90.0f));

        else if (direcao == "Direita")
            transform.Rotate(new Vector3(0.0f, 0.0f, 0.0f));

        else if (direcao == "Esquerda")
            transform.Rotate(new Vector3(0.0f, 0.0f, 180.0f));
    }


    private void GerarGameObject()
    {
        Instantiate(prefab, transform.position, transform.rotation);
        qnt--;

        if (qnt == 0 && serDestruido)
        {
            Destroy(gameObject);
        }
    }

    private string getDirecao()
    {
        if (gerarParaCima)
            return "Cima";
        else if (gerarParaBaixo)
            return "Baixo";
        else if (gerarParaDireita)
            return "Direita";
        else if (gerarParaEsquerda)
            return "Esquerda";

        return null;
    }

}