# 📊 Dashboards Python - Sistema de Cadastro de Alunos

Esta pasta contém o script Python responsável pela análise e visualização de dados do sistema de cadastro de alunos. O objetivo é gerar gráficos a partir das notas dos alunos cadastrados no banco de dados.

---

## 🧠 O que este script faz?

O arquivo `dashboards_crud.py` realiza as seguintes tarefas:

- Conecta-se ao banco de dados SQL Server (mesmo usado no CRUD em C#)
- Lê os dados das tabelas `ALUNOS` e `NOTAS`
- Calcula estatísticas como médias das notas
- Gera gráficos com `matplotlib` e `seaborn`:
  - Média de notas por aluno
  - Distribuição de notas
  - Outros gráficos exploratórios

---

## ▶️ Como executar

1. **Instale as bibliotecas necessárias** (com Python já instalado):

```bash
pip install -r requisitos.txt

ou tente

pip install pandas pyodbc matplotlib seaborn 