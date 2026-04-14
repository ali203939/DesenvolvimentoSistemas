using AppExemploDIP.Model;

//var turma = new Turma("turma única DS - BCC", "Noturno");
//var aluno = new Aluno("João", "20230001", turma);

//aluno.ExibirInformarcoesAluno();

ITurma presencial = new TurmaPresencial("turma única DS - BCC", "Noturno", "101");
ITurma online = new TurmaOnline("turma única DS - BCC", "Noturno", "https://meet.google.com/abc-defg-hij");

var aluno1 = new Aluno("João", "20230001", presencial);
var aluno2 = new Aluno("Maria", "20230002", online);

aluno1.ExibirInformarcoesAluno();
aluno2.ExibirInformarcoesAluno();