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
        private int Poder { get; set; }
        private int Influencia { get; set; }
        private int Planejamento { get; set; }
        private int Fortificacao { get; set; }
        private int Moral { get; set; }

        // ----- Atributos Secundários -----

        //Tropas vão de 1 a 6, equivalente as notas F>D>C>B>A>S
        private int TropaMaxima { get; set; } = 6;
        private int Cavaleiro { get; set; }
        private int Arqueiro { get; set; }
        private int Clerigo { get; set; }
        private int Catapulta { get; set; }
        //Proficiencia de castelo vai de 1 a 3, equivalente a Madeira > Pedra > Ferro
        string NivelDeCasteloProficiencia { get; set; }

        // ----- Atributos Terciários -----

        //Adicionar habilidades
        private int EnergiaMaxima { get; set; } = 100;
        private int Energia { get; set; } = 100;
        private int  SkillPoints { get; set; } = 0;

        // ----- Construtor -----
        public Hero(int poderBase, int influenciaBase, int planejamentoBase, int fortificacaoBase, int moralBase, int cavaleiroBase, int arqueiroBase, int clerigoBase, int catapultaBase, string nivelDeCasteloProficiencia)
        {
            Poder = poderBase;
            Influencia = influenciaBase;
            Planejamento = planejamentoBase;
            Fortificacao = fortificacaoBase;
            Moral = moralBase;
            Cavaleiro = cavaleiroBase;
            Arqueiro = arqueiroBase;
            Clerigo = clerigoBase;
            Catapulta = catapultaBase;
            NivelDeCasteloProficiencia = nivelDeCasteloProficiencia;
        }

        // ----- Chamados -----

        // Chamado para o gasto de energia
        public void PerderEnergia(int energiaGasta)
        {
            Energia -= energiaGasta;
            if (Energia <= 0) { Energia = 0; }
        }

        // Chamado para o ganho de energia
        public void GanharEnergia(int energiaGanha)
        {
            Energia += energiaGanha;
            if (Energia >= EnergiaMaxima) { Energia = EnergiaMaxima; }
        }

        // Chamado para o ganho ou perda de Poder
        public int AlterarPoder(int atributoGanho)
        {
            Poder += atributoGanho;
            if (Poder >= AtributoMaximo) { Poder = AtributoMaximo; } 
            else if (Poder < 0) { Poder = 0; }
            return Poder;
        }

        // Chamado para o ganho ou perda de Influência
        public int AlterarInfluencia(int atributoGanho)
        {
            Influencia += atributoGanho;
            if (Influencia >= AtributoMaximo) { Influencia = AtributoMaximo; } 
            else if (Influencia < 0) { Influencia = 0; }
            return Influencia;
        }

        // Chamado para o ganho ou perda de Planejamento
        public int AlterarPlanejamento(int atributoGanho)
        {
            Planejamento += atributoGanho;
            if (Planejamento >= AtributoMaximo) { Planejamento = AtributoMaximo; } 
            else if (Planejamento < 0) { Planejamento = 0; }
            return Planejamento;
        }

        // Chamado para o ganho ou perda de Fortificação
        public int AlterarFortificacao(int atributoGanho)
        {
            Fortificacao += atributoGanho;
            if (Fortificacao >= AtributoMaximo) { Fortificacao = AtributoMaximo; } 
            else if (Fortificacao < 0) { Fortificacao = 0; }
            return Fortificacao;
        }

        // Chamado para o ganho ou perda de Moral
        public int AlterarMoral(int atributoGanho)
        {
            Moral += atributoGanho;
            if (Moral >= AtributoMaximo) { Moral = AtributoMaximo; } 
            else if (Moral < 0) { Moral = 0; }
            return Moral;
        }

        // Chamados para o aprimoramento de tropas: Cavaleiro
        public int AprimorarCavaleiro(int atributoGanho)
        {
            Cavaleiro += atributoGanho;
            if (Cavaleiro >= TropaMaxima) { Cavaleiro = TropaMaxima; }
            return Cavaleiro;
        }

        // Chamados para o aprimoramento de tropas: Arqueiro
        public int AprimorarArqueiro(int atributoGanho)
        {
            Arqueiro += atributoGanho;
            if (Arqueiro >= TropaMaxima) { Arqueiro = TropaMaxima; }
            return Arqueiro;
        }

        // Chamados para o aprimoramento de tropas: Clerigo
        public int AprimorarClerigo(int atributoGanho)
        {
            Clerigo += atributoGanho;
            if (Clerigo >= TropaMaxima) { Clerigo = TropaMaxima; }
            return Clerigo;
        }

        // Chamados para o aprimoramento de tropas: Catapulta
        public int AprimorarCatapulta(int atributoGanho)
        {
            Catapulta += atributoGanho;
            if (Catapulta >= TropaMaxima) { Catapulta = TropaMaxima; }
            return Catapulta;
        }

        // Adicionar métodos para ganhar e gastar SkillPoints.

    }
}
