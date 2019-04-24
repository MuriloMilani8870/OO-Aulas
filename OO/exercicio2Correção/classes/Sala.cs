namespace exercicio2Correção {
    public class Sala {
        public int numeroSala;
        public int capacidadeAtual;
        public int capacidadeTotal;
        public string[] alunos;

        public string AlocarAluno (string nomeAluno) {
            capacidadeAtual--;
            if (capacidadeAtual >= 0) {

                alunos[capacidadeAtual] = nomeAluno;
                return $"Aluno {nomeAluno} alocado com sucesso!";
            } else {
                capacidadeAtual = 0;
                return $"Capacidade da sala {numeroSala} excedida!";
            }
        }

        public string ExibirAlunos () {
            string nomesAlunos = "";
            foreach (var item in alunos) {
                if (item != null) {
                    nomesAlunos += item + " ";
                }
            }
            return nomesAlunos;
        }

        public string RemoverAluno(string nomeAluno){
            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i] != null && nomeAluno.Equals(alunos[i]))
                {
                    alunos[i] = "";
                    return $"Aluno {nomeAluno} removido com sucesso!";
                }
            }
            return $"{nomeAluno} não foi encontrado";
        }

    }
}