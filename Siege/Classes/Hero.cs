using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siege
{
    internal class Hero
    {
        // ----- Atributos Primários -----

        private int AtributoMaximo { get; set; } = 120;
        private int PoderBase { get; set; }
        private int PoderAtual { get; set; }
        private int InfluenciaBase { get; set; }
        private int InfluenciaAtual { get; set; }
        private int PlanejamentoBase { get; set; }
        private int PlanejamentoAtual { get; set; }
        private int FortificacaoBase { get; set; }
        private int FortificacaoAtual { get; set; }
        private int MoralBase { get; set; }
        private int MoralAtual { get; set; }

        // ----- Atributos Secundários -----

        //Tropas vão de 1 a 6, equivalente as notas F>D>C>B>A>S
        private int CavaleiroBase { get; set; }
        private int ArqueiroBase { get; set; }
        private int ClerigoBase { get; set; }
        private int CatapultaBase { get; set; }
        //Proficiencia de castelo vai de 1 a 3, equivalente a Madeira > Pedra > Ferro
        string NivelDeCasteloProficiencia { get; set; }

        // ----- Atributos Terciários -----

        //Ideal seria uma lista de funções que apenas chamas elas.
        private string[] Habilidades = new string[3];
        private int Energia { get; set; } = 100;
        private int  SkillPoints { get; set; } = 0;

        // ----- Construtor -----
        public Hero(int poderBase, int influenciaBase, int planejamentoBase, int fortificacaoBase, int moralBase, int cavaleiroBase, int arqueiroBase, int clerigoBase, int catapultaBase, string nivelDeCasteloProficiencia, string[] habilidades)
        {
            PoderBase = poderBase;
            InfluenciaBase = influenciaBase;
            PlanejamentoBase = planejamentoBase;
            FortificacaoBase = fortificacaoBase;
            MoralBase = moralBase;

            CavaleiroBase = cavaleiroBase;
            ArqueiroBase = arqueiroBase;
            ClerigoBase = clerigoBase;
            CatapultaBase = catapultaBase;

            NivelDeCasteloProficiencia = nivelDeCasteloProficiencia;

            // Garante que só 3 habilidades sejam atribuídas
            if (habilidades.Length == 3)
            {
                this.Habilidades = habilidades;
            }
            else
            {
                throw new ArgumentException("É necessário fornecer exatamente 3 habilidades.");
            }
        }

    }
}
