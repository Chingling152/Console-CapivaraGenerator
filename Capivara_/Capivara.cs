using System;
namespace CapivaraGenerator.Capivara_
{
    public class Capivara
    {
        public readonly string[] linha = new string[8]{
            "　　　　　/)─ヘ      ", //0
            "　　　＿／　　　＼    ",
            "　 ／　　　●　　　●丶 ",
            "　｜　　　　　　▼　 | ",//3
            "　｜　　　　　　亠 ノ ",//4
            "   ||￣||￣||￣||￣  ",
            "   ||  ||  ||  ||   ",
            "   ᑌ   ᑌ   ᑌ   ᑌ   " //7
        };

        public readonly string[] falas = 
        {          
            /**Default**/
            "Hm... Você é gay",
            "Lautrec não fez nada de errado",
            "Avatar é o melhor anime....",
            "HTML Não é linguagem de programação",
            "Design é lixo",
            "Você não é tão bom assim , é um fracassado.",
            "Não acredite nas frases ditas por uma capivra",
            "Imposto é roubo",
            "for >>> foreach",
            "O que o Naruto faria?",
            "Você vai ganhar na loteria e morrer no dia seguinte ;-;",
            /**Lucas**/
            "Trap não é gay ;-; ",
            "Não é estupro se ela estiver morta",
            "Só é crime se alguem souber",
            "O errado é limitado pela nossa moral",
            /**Murilo**/
            "Você poderia ser uma merda pior",
            "MORRE QUE PASSA",
            "Se pega no olho....",
            "Comunismo funciona só com animais!!",
            "SAAAASSSSUKEEEEEEE",
            /**Jefferson**/
            "Palmeiras n tem mundial",
            "Html é programação sim caraleo",
            "Sou totalmente contra a extinção das capivaras, ok?",
            /**Felipe**/
            "Front-End é top",
            "Back-End é top",
            "Usem NoSQL para big data",
            "usem SQL para regra de negócioss",
            "Usem a metodologia Scrum para projetos",
            "Fiz uma pipa sem saber graças ao Scrum",
            "100% Jesus",
            /** Gabriel **/
            "Em briga de saci, qualquer chute é voadora",
            /**Ricardo**/
            "Morte aos nazistas, brancos, negros, gays, heteros e todo mundo que restou"
        };
        public string gerarFala(){
            Random rdm = new Random();
            return falas[rdm.Next(0,falas.Length+1)];
        }
    }
}