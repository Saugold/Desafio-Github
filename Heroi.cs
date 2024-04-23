using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Godot_Dio
{
    public class Heroi
    {
        private string nome{get;set;}
        private float xp;
    public Heroi(string nome, float xp)
    {
        this.nome = nome;
        this.xp = xp;
    }
    
    public string CalcularNivel(float xp){
        string resultado = "null";
        if(xp < 1000){
            resultado = "Ferro";
        }
        else if(xp >= 1001 && xp <= 2000)
            resultado = "Bronze";
        else if(xp >= 2001 && xp <= 5000)
            resultado = "prata";
        else if(xp >= 5001 && xp <= 7000)
            resultado = "Ouro";
        else if(xp >= 7001 && xp <= 8000)
            resultado = "Platina";
        else if(xp >= 8001 && xp <= 9000)
            resultado = "Ascendente";
        else if(xp >= 9001 && xp <= 10000)
            resultado = "Imortal";
        else
            resultado = "Radiante";
            
        return resultado;
    }
    public string GetNome(){
        return nome;
    }
    public float GetXp(){
        return xp;
    }
    }
    
    
}