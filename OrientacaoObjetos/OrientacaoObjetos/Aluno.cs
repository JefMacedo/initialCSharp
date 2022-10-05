﻿namespace OrientacaoObjetos
{
    public class Aluno : Usuario
    {
        public int Matricula;
        public decimal Media { get; private set; }
        private List<Materia> Materias;

        public Aluno():base()
        {
            Materias = new List<Materia>();
        }

        public Aluno(int matricula, string nome, decimal media) : this()
        {
            Matricula = matricula;
            Nome = nome;
            Media = media;
        }

        public void CalcularMedia(decimal nota1, decimal nota2, decimal nota3)
        {
            decimal total = nota1 + nota2 + nota3;
            Media = total/3;
        }

        public string AdicionarMateria(Materia materia)
        {
            foreach(Materia mate in Materias)
            {
                if (mate.Nome == materia.Nome)
                    return "Esta matéria já existe!";
            }
            Materias.Add(materia);
            return "Matéria adicionada com sucesso!";
        }

        public void Adicionar() { }
    }
}
