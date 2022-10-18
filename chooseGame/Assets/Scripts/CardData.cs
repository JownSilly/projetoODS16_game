using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="card", menuName ="ScriptableObject/Card")]
public class CardData : ScriptableObject
{
    public string main_text;
    //public string leftAnswer_text;
    //public string rightAnswer_text;
    public Sprite sprite_personagem;
    public int iconVerba;
    public int iconProfessor;
    public int iconAlunos;
    public int iconResponsaveis;
    
}
