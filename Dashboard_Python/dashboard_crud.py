import pyodbc
import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sns

conexão = pyodbc.connect(
    'Driver={SQL Server};'
    'Server=localhost\\SQLEXPRESS;'
    'Database=Dados_Alunos;'
    'Trusted_connection=yes'
)

df_alunos = pd.read_sql("SELECT * FROM ALUNOS", conexão)
df_notas = pd.read_sql("SELECT * FROM NOTAS",conexão)

df_notas['Média'] = (df_notas['Nota1'] + df_notas['Nota2']) / 2

def status(media):

    if media > 7:
        return 'Aprovado'
    
    elif media >= 5 and media < 7:
        return 'Recuperação'
    else:
        return 'Reprovado'
    
df_notas['Status_Aluno'] = df_notas['Média'].apply(status)

df_completo = pd.merge(df_alunos, df_notas, on='Matrícula')

plt.figure(figsize=(10,6))
sns.barplot(x='Nome',y='Média',data=df_completo, palette='viridis')
plt.title('Media das Notas por Aluno')
plt.xlabel('Aluno')
plt.ylabel('Média')
plt.xticks(rotation=45)
plt.tight_layout()
plt.show()

status_counts = df_completo['Status_Aluno'].value_counts()

plt.figure(figsize=(6,6))
plt.pie(status_counts, labels=status_counts.index, autopct='%1.1f%%', colors=['green','orange','red'], startangle=140)
plt.title('Distribuição de Alunos por Status')
plt.axis('equal')
plt.tight_layout()
plt.show()