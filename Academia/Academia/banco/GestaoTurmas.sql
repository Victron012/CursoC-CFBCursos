select 
    tbt.N_IDTURMA as 'Id Turma',
    tbt.T_DSCTURMA as 'Desc. Turma',
    tbt.N_MAXALUNOS as 'Max Alunos',
    tbh.T_DSCHORARIO as 'Horário',
    tbp.T_NOMEPROFESSOR as 'Professor',
    CASE
        WHEN tbt.T_STATUS = 'A' THEN 'Ativa'
        WHEN tbt.T_STATUS = 'P' THEN 'Paralisada'
        WHEN tbt.T_STATUS = 'C' THEN 'Cancelada'
    END as 'Status'
 from 
     tb_turmas as tbt
 inner join 
     tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO, 
     tb_professores as tbp on tbp.N_IDPROFESSOR = tbt.N_IDPROFESSOR
